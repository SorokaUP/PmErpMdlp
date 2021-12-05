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
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;

namespace PMMarkingUI.Forms
{
    public partial class frmCreateDocumentOutcome : Form
    {
        private List<SelectedDataDoc> Selected = new List<SelectedDataDoc>();
        private int IndexSgtinId = 0;
        private int IndexSgtinSid = 0;
        private int IndexSgtinSgtin = 0;
        public frmCreateDocumentOutcome()
        {
            InitializeComponent();
            docFilterTWDbView1.SetDelegate(Refresh_Docs);
        }

        private void frmCreateDocumentOutcome_Shown(object sender, EventArgs e)
        {
            docFilterTWDbView1.dtpFrom.Value = DateTime.Now.AddDays(-1);
            docFilterTWDbView1.dtpTo.Value = DateTime.Now.AddDays(-1);

            IndexSgtinId = tlSGTIN.Columns["ID"].AbsoluteIndex;
            IndexSgtinSid = tlSGTIN.Columns["SID"].AbsoluteIndex;
            IndexSgtinSgtin = tlSGTIN.Columns["SGTIN"].AbsoluteIndex;
        }

        //----------------------------------------------------------------------------------------------

        /// <summary>
        /// Обновить список документов
        /// </summary>
        /// <param name="filter"></param>
        private void Refresh_Docs(DocFilterTWDb filter)
        {
            DataTable docs = DAO.GetTWDocumentByFilter(filter.FromDate, filter.ToDate, filter.Counteragent, filter.Manager, filter.Group, filter.Departament);
            cDocs.DataSource = docs;
            if (docs.Rows.Count > 0)
            {
                vDocs.SelectRows(0, 0);
                Refresh_Lins();
            }
        }

        /// <summary>
        /// Обновить список строк документа
        /// </summary>
        private void Refresh_Lins()
        {
            DataRow row = vDocs.GetDataSourceRow();
            if (row == null)
                return;

            DataTable lins = DAO.GetTWDocumentLines((int)row["DID"]);
            cLins.DataSource = lins;
        }

        /// <summary>
        /// Обновить список SGTIN связанных с товаром на выбранной строке документа
        /// </summary>
        private void Refresh_Sgtins()
        {
            DataRow doc = vDocs.GetDataSourceRow();
            if (doc == null)
                return;
            DataRow lin = vLins.GetDataSourceRow();
            if (lin == null)
                return;
            List<TreeListNode> SGTIN_Selected = new List<TreeListNode>();
            foreach (SelectedDataDoc selDoc in Selected)
            {
                if (selDoc.Doc == null)
                    continue;

                if (selDoc.Doc == doc)
                {
                    foreach (SelectedDataLin selLin in selDoc.Lins)
                    {
                        if (selLin.Lin == null)
                            continue;

                        if (selLin.Lin == lin)
                        {
                            SGTIN_Selected = selLin.SGTINs;
                            goto ToSgtinDataSource;
                        }
                    }
                }
            }

            ToSgtinDataSource:
            tlSGTIN.DataSource = DAO.GetSgtinsByLid((int)lin["GOOD_ID"]);
            foreach (TreeListNode nodeSource in tlSGTIN.Nodes)
            {
                foreach (TreeListNode nodeSelect in SGTIN_Selected)
                {
                    if (nodeSource.GetValue(IndexSgtinId) == nodeSelect.GetValue(IndexSgtinId))
                    {
                        nodeSource.Checked = true;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Пометка выбора SGTIN
        /// </summary>
        /// <param name="node"></param>
        private void SelectSgtin(TreeListNode node)
        {
            object nodeVal = node.GetValue(IndexSgtinId);
            DataRow doc = vDocs.GetDataSourceRow();
            if (doc == null)
                return;
            DataRow lin = vLins.GetDataSourceRow();
            if (lin == null)
                return;

            bool isDocExist = false;
            bool isLinExist = false;
            bool isSgtinExist = false;

            // В случае, когда выбранные данные есть
            foreach (SelectedDataDoc selDoc in Selected)
            {
                if (selDoc.Doc == null)
                    continue;

                // Ищем выбранный документ
                if (selDoc.Doc == doc)
                {
                    isDocExist = true;
                                        
                    foreach (SelectedDataLin selLin in selDoc.Lins)
                    {
                        if (selLin.Lin == null)
                            continue;

                        // Ищем выбранную строку
                        if (selLin.Lin == lin)
                        {
                            isLinExist = true;

                            // У выбранной (выделенной) строки ищем помеченные SGTIN
                            // Идем в обратном порядке, чтобы была возможность удалить найденный элемент
                            for (int i = selLin.SGTINs.Count - 1; i >= 0; i--)
                            {
                                if (selLin.SGTINs[i].GetValue(IndexSgtinId) == nodeVal)
                                {
                                    // Если такой SGTIN в списке есть - удаляем (так как по логике это значит, что с него свняли флаг)
                                    selLin.SGTINs.RemoveAt(i);
                                    isSgtinExist = true;
                                    break;
                                }
                            }

                            // В случае, когда SGTIN ранее небыло
                            if (!isSgtinExist)
                                selLin.SGTINs.Add(node);

                            break;
                        }
                    }

                    // В случае, когда строка не найдена
                    if (!isLinExist)
                    {
                        SelectedDataLin sel = new SelectedDataLin();
                        sel.Lin = lin;
                        sel.SGTINs.Add(node);
                        selDoc.Lins.Add(sel);
                    }
                }
            }

            // В случае, когда документ не найден
            if (!isDocExist)
            {
                SelectedDataLin selLin = new SelectedDataLin();
                selLin.Lin = lin;
                selLin.SGTINs.Add(node);

                SelectedDataDoc selDoc = new SelectedDataDoc();
                selDoc.Doc = doc;
                selDoc.Lins.Add(selLin);

                Selected.Add(selDoc);
            }
        }

        /// <summary>
        /// Создание документа
        /// </summary>
        private void CreateDocument()
        {
            if (ShowSelected() == DialogResult.Cancel)
                return;

            // Выбор типа документа
            //frmRef frm = new frmRef("Тип документа", DAO.Ref_GetDocTypes());
            //if (frm.ShowDialog() == DialogResult.OK)
            {
                //int DocType = frm.ValueInt;

                // Константы
                int DOC_ID = 0;
                int ZK_EID = 0;
                int ZK_DID = 0;
                int TYPE_CODE = 2;
                string PARENT_CODE = null;

                // Выбранные документы
                foreach (SelectedDataDoc selDoc in Selected)
                {
                    if (selDoc.Doc == null)
                        continue;

                    // Данные документа
                    int DID = (int)selDoc.Doc["DID"];
                    int DID1 = (int)selDoc.Doc["DID1"]; ;
                    string DOC_NUM = selDoc.Doc["DCODE"].ToString();
                    DateTime DOC_DATE = (DateTime)selDoc.Doc["DDATE1"];

                    // Выбранные строки
                    foreach (SelectedDataLin selLin in selDoc.Lins)
                    {
                        if (selLin.Lin == null)
                            continue;

                        try
                        {
                            // Данные строки
                            int EID = (int)selLin.Lin["EID"];
                            int PARENT_EID = (int)selLin.Lin["PARENT_EID"];
                            int LID800 = (int)selLin.Lin["GOOD_ID"];
                            string SERNAME = selLin.Lin["SER_NAME"].ToString();
                            DateTime SER_DATE1 = (DateTime)selLin.Lin["SERDATE1"];
                            DateTime SER_DATE2 = (DateTime)selLin.Lin["SERDATE2"];
                            decimal COST = (decimal)selLin.Lin["PRICE"];
                            decimal VAT_VALUE = (decimal)selLin.Lin["SUMM"]; // !!!! НЕ Сумма НДС

                            // Выбранные SGTIN
                            foreach (TreeListNode sgtin in selLin.SGTINs)
                            {
                                if (sgtin == null)
                                    continue;

                                string CODE = sgtin.GetValue(IndexSgtinSgtin).ToString();
                                try
                                {
                                    DAO.InsertSgtinToLin(EID, PARENT_EID, DID, ZK_EID, ZK_DID, DOC_ID, DID1, DOC_NUM, DOC_DATE, LID800, SERNAME, SER_DATE1, SER_DATE2, COST, VAT_VALUE, TYPE_CODE, CODE, PARENT_CODE);
                                }
                                catch { }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ошибка: " + ex.Message);
                        }
                    }
                }
            }
        }

        private DialogResult ShowSelected()
        {
            frmCreateDocumentOutcome_ShowSelected frm = new frmCreateDocumentOutcome_ShowSelected(Selected);
            return frm.ShowDialog();
        }

        //----------------------------------------------------------------------------------------------

        private void tsmiAction_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAction_CreateDoc_Click(object sender, EventArgs e)
        {
            CreateDocument();
        }

        private void tlSGTIN_NodeChanged(object sender, NodeChangedEventArgs e)
        {
            if (e.ChangeType == DevExpress.XtraTreeList.NodeChangeTypeEnum.CheckedState)
            {
                SelectSgtin(e.Node);
            }
        }

        private void vLins_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Refresh_Sgtins();
        }

        private void vDocs_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Refresh_Lins();
        }

        private void tsmiAction_ShowSelected_Click(object sender, EventArgs e)
        {
            ShowSelected();
        }
    }
}
