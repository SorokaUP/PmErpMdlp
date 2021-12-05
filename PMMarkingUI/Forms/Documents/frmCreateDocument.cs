using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProfitMed.Firebird;
using PMMarkingUI.Classes;
using PMMarkingUI.Delegats;
using DevExpress.XtraTreeList.Nodes;

namespace PMMarkingUI.Forms
{
    public partial class frmCreateDocument : Form
    {
        List<int> docs_id = new List<int>();
        public frmCreateDocument(List<int> docs_id)
        {
            InitializeComponent();
            this.docs_id = docs_id;
        }

        private void frmCreateDocument_Shown(object sender, EventArgs e)
        {
            tlSSCC.Nodes.Clear();
            GetSSCC();
        }

        DataTable SSCC;
        int IndexColSSCC_ID;
        int IndexColSSCC_NAME;
        int IndexColSSCC_IsScan;
        private void GetSSCC()
        {
            SSCC = new DataTable();
            // Получаем все данные по SSCC, SGTIN, GTIN
            foreach (int doc_id in docs_id)
            {
                DataTable tSSCC = DAO.GetSsccListForCreateDocument(doc_id);
                if (SSCC.Rows.Count == 0)
                    SSCC = tSSCC;
                else
                    foreach (DataRow row in tSSCC.Rows)
                    {
                        SSCC.Rows.Add(row);
                    }
            }

            IndexColSSCC_ID = tlSSCC.Columns["ID"].AbsoluteIndex;
            IndexColSSCC_NAME = tlSSCC.Columns["SSCC"].AbsoluteIndex;
            IndexColSSCC_IsScan = tlSSCC.Columns["IS_SCAN"].AbsoluteIndex;

            tlSSCC.Nodes.Clear();
            try
            {
                tlSSCC.DataSource = SSCC;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка формирования списка коробок: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        DataTable DOCS = new DataTable();
        List<int> NewDocsId = new List<int>();
        private void tsmiUnPackingBox_Click(object sender, EventArgs e)
        {
            foreach (TreeListNode node in tlSSCC.GetAllCheckedNodes())
            {
                DataRow row = node.GetDataSourceRow();
                int doc_id = (int)row["DOC_ID"];
                string branch_id = Sys.Global.DataProvider.GetBranchIdByDoc(doc_id);
                string session_ui = Guid.NewGuid().ToString().ToLower();
                StringBuilder xml_body = new StringBuilder();
                xml_body.Append($"<documents session_ui = \"{session_ui}\" version = \"{Sys.Global.VERSION}\">");
                xml_body.Append("<unit_unpack action_id = \"912\">");
                //xml_body.Append($"<subject_id>{Sys.Global.SYS_OBJ_ID.ToLower()}</subject_id>");
                xml_body.Append($"<subject_id>{branch_id}</subject_id>");
                //00000000279052
                xml_body.Append($"<operation_date>{DateTime.Now.ToString("yyyy-MM-ddTH:mm:ss+03:00")}</operation_date>");
                xml_body.Append($"<sscc>{row["SSCC"].ToString()}</sscc>");
                xml_body.Append("</unit_unpack>");
                xml_body.Append("</documents>");

                int new_id = Sys.Global.DataProvider.CreateChildDocument(doc_id, 912);
                Sys.Global.DataProvider.SaveDocBodyById(xml_body.ToString(), new_id);
                //WebMethods.DocumentSend(xml_body.ToString(), new_id, false);
                if (!NewDocsId.Contains(new_id))
                    NewDocsId.Add(new_id);
            }

            DOCS = new DataTable();
            // Получаем все данные по SSCC, SGTIN, GTIN
            foreach (int doc_id in NewDocsId)
            {
                DataTable tDOCS = DAO.GetDocumentById(Sys.Global.USER_ID, doc_id);
                if (DOCS.Rows.Count == 0)
                    DOCS = tDOCS;
                else
                    foreach (DataRow row in tDOCS.Rows)
                    {
                        DOCS.Rows.Add(row);
                    }
            }
            cServiceDocs.DataSource = DOCS;
        }

        public delegate void OnWorkIsDoneHandler(object sender, EventArgs e); // Делегат для события окна.
        public event OnWorkIsDoneHandler OnWorkIsDone; // Событие окна: завершение потока чтения.
        private void tsmiUoloadDoc_Click(object sender, EventArgs e)
        {
            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            {
                using (frmProccess process = new frmProccess())
                {
                    process.progressBarControl.Properties.Maximum = (cServiceDocs.DataSource as DataTable).Select("handle_select = 1 and doc_result > 2000 and doc_result < 2003").Count();
                    process.Show();
                    Application.DoEvents();
                    foreach (DataRow row in (cServiceDocs.DataSource as DataTable).Select("handle_select = 1 and doc_result = 2001"))
                    {
                        try
                        {
                            WebMethods.DocumentSend(row["DOC_BODY"].ToString(), Int32.Parse(row["id"].ToString()), false);

                            //MessageBox.Show("Выполнено");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка! " + ex.Message);
                        }
                        process.progressBarControl.Position++;
                        Application.DoEvents();
                    }
                    process.Close();
                    OnWorkIsDone?.Invoke(this, EventArgs.Empty);
                    //cServiceDocs.Invoke(new RefreshServiceDoc(Refresh_ServiceDocuments));
                }
            }));
            readThread.Start();
        }

        private void метаданныеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmProccess process = new frmProccess())
            {
                process.progressBarControl.Properties.Maximum = (cServiceDocs.DataSource as DataTable).Select("handle_select = 1").Count();
                process.Show();
                Application.DoEvents();
                foreach (DataRow row in (cServiceDocs.DataSource as DataTable).Select("handle_select = 1"))
                {
                    try
                    {
                        // 5.9. Получение метаданных документа
                        WebMethods.DocumentGetMetadata(row["DOCUMENT_ID"].ToString(), (int)row["DIRECT"], false);
                        process.progressBarControl.Position++;
                        Application.DoEvents();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                process.Close();
                OnWorkIsDone?.Invoke(this, EventArgs.Empty);
                //cServiceDocs.Invoke(new RefreshServiceDoc(Refresh_ServiceDocuments));
            }
        }

        private void документToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmProccess process = new frmProccess())
            {
                process.progressBarControl.Properties.Maximum = (cServiceDocs.DataSource as DataTable).Select("handle_select = 1").Count();
                process.Show();
                Application.DoEvents();
                foreach (DataRow row in (cServiceDocs.DataSource as DataTable).Select("handle_select = 1"))
                {

                    try
                    {
                        // 5.10 Получение документа по идентификатору
                        WebMethods.DocumentGetDoc(row["DOCUMENT_ID"].ToString(), false);
                        process.progressBarControl.Position++;
                        Application.DoEvents();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                process.Close();
                OnWorkIsDone?.Invoke(this, EventArgs.Empty);
                //cServiceDocs.Invoke(new RefreshServiceDoc(Refresh_ServiceDocuments));
            }
        }

        private void квитанциюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmProccess process = new frmProccess())
            {
                process.progressBarControl.Properties.Maximum = (cServiceDocs.DataSource as DataTable).Select("handle_select = 1").Count();
                process.Show();
                Application.DoEvents();
                foreach (DataRow row in (cServiceDocs.DataSource as DataTable).Select("handle_select = 1"))
                {

                    try
                    {
                        //5.12 Получение квитанции по номеру исходящего документа
                        WebMethods.DocumentGetTiket(row["DOCUMENT_ID"].ToString().ToLower(), (int)row["id"], false);
                        process.progressBarControl.Position++;
                        Application.DoEvents();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                process.Close();
                OnWorkIsDone?.Invoke(this, EventArgs.Empty);
                //cServiceDocs.Invoke(new RefreshServiceDoc(Refresh_ServiceDocuments));
            }
        }
    }
}
