using System;
using System.Threading;
using System.IO;
using System.Xml;
using System.Drawing;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using PMMarkingUI.Delegats;
using PMMarkingUI.Classes;
using ProfitMed.Firebird;
using ProfitMed.DataContract;
using ProfitMedServiceClient;
using System.Text;

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using PMMarkingUI.Forms;

namespace PMMarkingUI.Views
{
    public partial class DocumentSSCCView : UserControl
    {
        public int doc_id { get; private set; }
        public Control ctrl { get; private set; }
        public event DelegateGetDialogResult dGetDialogResult;
        public event DelegateGetGridFilter dGetFilterBalanceId;
        private frmProccess process;
        public delegate void OnWorkIsDoneHandler(object sender, EventArgs e); // Делегат для события окна.
        public event OnWorkIsDoneHandler OnWorkIsDone; // Событие окна: завершение потока чтения.
        public delegate void RefreshSscc();

        public DocumentSSCCView()
        {
            InitializeComponent();
            tlSSCC.Nodes.Clear();
            OnWorkIsDone += OnWorkEnd;
            /*this.doc_id = doc_id;
            this.Text += this.doc_id.ToString();

            if (this.doc_id == 0)
            {
                MessageBox.Show("Не передан ID документа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                return;
            }*/
        }

        #region Виторичка
        private void OnWorkEnd(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнено!");
        }

        public void SetData(DelegateGetDialogResult d, int doc_id, Control ctrl)
        {
            this.dGetDialogResult = d;
            this.doc_id = doc_id;
            this.ctrl = ctrl;            
        }

        public void RefreshData()
        {
            GetSSCC();
            Sys.GridColumns.CreateFormatRules(tlSSCC, "IsError01", "SSCC", "IsNullOrEmpty([tlcSSCC])", false);
        }

        DataTable SSCC;
        int IndexColSSCC_ID;
        int IndexColSSCC_NAME;
        int IndexColSSCC_IsScan;
        int IndexColSSCC_Is912;
        int IndexColSSCC_INFO_ID;
        private void GetSSCC()
        {
            // Получаем все данные по SSCC, SGTIN, GTIN
            SSCC = DAO.GetSsccList(this.doc_id);

            IndexColSSCC_ID = tlSSCC.Columns["ID"].AbsoluteIndex;
            IndexColSSCC_NAME = tlSSCC.Columns["SSCC"].AbsoluteIndex;
            IndexColSSCC_IsScan = tlSSCC.Columns["IS_SCAN"].AbsoluteIndex;
            IndexColSSCC_Is912 = tlSSCC.Columns["IS_DISBAND"].AbsoluteIndex;
            IndexColSSCC_INFO_ID = tlSSCC.Columns["INFO_ID"].AbsoluteIndex;

            tlSSCC.Nodes.Clear();
            try
            {
                tlSSCC.DataSource = SSCC;
                foreach (TreeListNode node in tlSSCC.Nodes)
                {
                    CheckChildren(node);
                }
                tlSSCC.LayoutChanged();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка формирования списка коробок: " + ex.Message);
            }
        }

        private void CheckChildren(TreeListNode node)
        {
            try
            {
                DataRow row = node.GetDataSourceRow();
                if (node.Nodes.Count > 0)
                {
                    row["IS_CHILDREN"] = 1;
                    foreach (TreeListNode nnode in node.Nodes)
                    {
                        CheckChildren(nnode);
                    }
                }
                else
                {
                    row["IS_CHILDREN"] = 0;
                }
            }
            catch { }
        }

        private void tlSSCC_NodeChanged(object sender, DevExpress.XtraTreeList.NodeChangedEventArgs e)
        {
            int cnt = tlSSCC.GetAllCheckedNodes().Count;
            
            tlSSCC.Caption = SsccCaption(cnt);
        }

        private string SsccCaption(int cnt)
        {
            string s = "Список коробок (SSCC)";
            if (cnt == 0)
                return s;

            if (((cnt % 100) > 10) && ((cnt % 100) < 20))
                s = "коробок";
            else
            if (cnt % 10 == 1)
                s = "коробока";
            else
            if ((cnt % 10 == 2) || (cnt % 10 == 3) || (cnt % 10 == 4))
                s = "коробоки";
            else
                s = "коробок";

            return $"Выбрано: {cnt} {s}";
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlSSCC.CheckAll();
        }

        private void снятьВыделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlSSCC.UncheckAll();
        }

        private void ChangeCheckedNodes(bool isCheck)
        {
          /*  foreach (TreeListNode node in tlSSCC.Nodes)
            {
                node.Checked = isCheck;
            }*/
        }

        private void tsmiGetSsccInfo_Click(object sender, EventArgs e)
        {
            if (tlSSCC.GetAllCheckedNodes().Count > 1)
            {
                MessageBox.Show("Слишком много элементов!\n Операция займет много времени.\n Для получения информации о большом кол-ве объектов\n воспользуйтесь командой\n 'Запрос информации по sscc'");
                return;
            }  
                    
            ApiN_8_4_2();
            dGetDialogResult(DialogResult.OK);
        }

        /// <summary>
        /// 8.4.2 Получить информацию по выбранным коробкам
        /// </summary>
        private void ApiN_8_4_2()
        {
            List<IdName> data = new List<IdName>();
            foreach (TreeListNode sscc in tlSSCC.GetAllCheckedNodes())
            {
                IdName item = new IdName();
                item.Name = sscc.GetValue(IndexColSSCC_NAME).ToString();
                item.Id = (int)sscc.GetValue(IndexColSSCC_ID);

                data.Add(item);
            }
            bool res = WebMethods.GetSsccInfo(ctrl, doc_id, data);
            if (res)
                GetSSCC();
        }

        private void tsmiGetSscc_Click(object sender, EventArgs e)
        {
            ApiN_8_4_1();
            dGetDialogResult(DialogResult.OK);
        }

        /// <summary>
        /// 8.4.1 Получить иерархию вложенности третичных упаковок (коробок)
        /// </summary>
        /// <param name="sscc"></param>
        private void ApiN_8_4_1()
        {
            List<IdName> data = new List<IdName>();
            foreach (TreeListNode sscc in tlSSCC.GetAllCheckedNodes())
            {
                IdName item = new IdName();
                item.Name = sscc.GetValue(IndexColSSCC_NAME).ToString();
                item.Id = (int)sscc.GetValue(IndexColSSCC_ID);

                data.Add(item);
            }
            bool res = WebMethods.GetSsccHierarhy(ctrl, doc_id, data);
            if (res)
                GetSSCC();
        }

        private void tmsiSendQueryKiz_Click(object sender, EventArgs e)
        {
            #region Старый способ
            /*foreach (TreeListNode node in tlSSCC.GetAllCheckedNodes())
            {
                string session_ui = Guid.NewGuid().ToString().ToLower();
                StringBuilder xml_body = new StringBuilder();
                xml_body.Append($"<documents session_ui = \"{session_ui}\" version = \"{Sys.Global.VERSION}\">");
                xml_body.Append("<query_hierarchy_info action_id = \"220\">");
                xml_body.Append($"<subject_id>{Sys.Global.SYS_OBJ_ID.ToLower()}</subject_id>");
                xml_body.Append($"<sscc>{node.GetValue(IndexColSSCC_NAME).ToString()}</sscc>");
                xml_body.Append("</query_hierarchy_info>");
                xml_body.Append("</documents>");

                int new_id = DAO.CreateChildDocument(this.doc_id, 220);
                Sys.Global.DataProvider.SaveDocBodyById(xml_body.ToString(), new_id);
                WebMethods.DocumentSend(xml_body.ToString(), new_id);
            }
            MessageBox.Show("Выполнено!"); */
            #endregion
            if (MessageBox.Show("Сформировать документы о получении информации о коробке SSCC (220)", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool isExpress = MessageBox.Show("Хотите отправить документ в МДЛП сразу после его создания?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                System.Threading.Thread readThread = new System.Threading.Thread(() => { ThreadQueryKiz(isExpress); });
                readThread.Start();
            }
        }

        public void ThreadQueryKiz(bool isExpress)
        {
            process = new frmProccess();
            
            process.progressBarControl.Properties.Maximum = tlSSCC.GetAllCheckedNodes().Count();
            process.Show();
            Application.DoEvents();
            List<string> ssccList = new List<string>();
            foreach (TreeListNode node in tlSSCC.GetAllCheckedNodes())
            {
                string sscc = node.GetValue(IndexColSSCC_NAME).ToString();
                if (!ssccList.Contains(sscc))
                    ssccList.Add(sscc);
            }
            Additional.dGetInfoByKIZ += () => {
                process.progressBarControl.Position++;
                Application.DoEvents();
            };
            Additional.GetInfoByKIZ(this.doc_id, ssccList, isExpress);
            process.Close();
            OnWorkIsDone?.Invoke(this, EventArgs.Empty);
            tlSSCC.Invoke(new RefreshSscc(RefreshData));
        }

        private void tlSSCC_RowClick(object sender, DevExpress.XtraTreeList.RowClickEventArgs e)
        {
            List<string> data = new List<string>();
            if (e.Node.Nodes.Count == 0)
            {
                //data.Add(e.Node.GetValue(IndexColSSCC_ID).ToString());
                data.Add(e.Node.GetValue(IndexColSSCC_INFO_ID).ToString());
            }
            else
            {
                RecursiveChildFilter(data, e.Node);
            }

            if (e.Clicks == 2)
                dGetFilterBalanceId(data);
        }

        private void RecursiveChildFilter(List<string> data, TreeListNode n)
        {
            data.Add(n.GetValue(IndexColSSCC_ID).ToString());
            foreach (TreeListNode sn in n.Nodes)
            {
                RecursiveChildFilter(data, sn);
            }
        }

        private void tsmiUnPackingBox_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите разагрегировать коробки (912)? Операцию отменить будет нельзя! Продолжить?", "ВНИМАНИЕ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadUnPackingBox));
                //readThread.Start();
                ThreadUnPackingBox();
            }            
        }

        private void tsmiExtractBoxFromBox_Click(object sender, EventArgs e)
        {
            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadExtractBox));
            readThread.Start();
        }

        private void tsmiMovedSSCC_Click(object sender, EventArgs e)
        {
            //System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(MovedSSCC));
            //readThread.Start();
            MovedSSCC();
        }

        private TreeListNode GetMasterParentNode(TreeListNode node)
        {
            if (node == null)
                return node;

            if (node.ParentNode == null)
                return node;
            else
                return GetMasterParentNode(node.ParentNode);
        }
        
        private void DisbandmentSSCC()
        {
            if (tlSSCC.Nodes.Count == 0)
            {
                MessageBox.Show("Коробок не найдено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var data = tlSSCC.GetAllCheckedNodes();
            string question = /*(data.Count == 0)
                ? "Вы не отметили ни одной коробки. Операция РАСФОРМИРОВАНИЯ будет выполнена по всем коробкам. Продолжить?"
                :*/ "Операция РАСФОРМИРОВАНИЯ будет выполнена по отмеченным коробкам. Продолжить?";
            if (MessageBox.Show(question, "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }

            // Передавать строго паренты коробок (верхний уровень) (самый-самый верхний)
            using (frmProccess frmP = new frmProccess())
            {
                process.Show();

                List<object> listRes = new List<object>();
                string branch_id = Sys.Global.DataProvider.GetBranchIdByDoc(this.doc_id);

                //if (data.Count == 0)
                //{
                    //process.progressBarControl.Properties.Maximum = 1;
                    //int res = DAO.CreateOutcomeDocument(this.doc_id, 431, address, "", null, null, 1);
                    //listRes.Add(res);
                //}
                //else
                {
                    List<TreeListNode> dataFiltered = new List<TreeListNode>();
                    foreach (TreeListNode node in data)
                    {
                        TreeListNode parentNode = GetMasterParentNode(node);
                        if (!dataFiltered.Contains(parentNode))
                            dataFiltered.Add(parentNode);
                    }
                    if (dataFiltered.Count == 0)
                    {
                        MessageBox.Show("Ни одной коробки не обнаружено! Операция прервана!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    process.progressBarControl.Properties.Maximum = dataFiltered.Count;
                    foreach (TreeListNode node in dataFiltered)
                    {
                        string session_ui = Guid.NewGuid().ToString().ToLower();
                        StringBuilder xml_body = new StringBuilder();
                        xml_body.Append($"<documents session_ui = \"{session_ui}\" version = \"{Sys.Global.VERSION}\">");
                        xml_body.Append("<unit_unpack action_id = \"912\">");
                        //xml_body.Append($"<subject_id>{Sys.Global.SYS_OBJ_ID.ToLower()}</subject_id>");
                        xml_body.Append($"<subject_id>{branch_id}</subject_id>");
                        //00000000279052
                        xml_body.Append($"<operation_date>{DateTime.Now.ToString("yyyy-MM-ddTH:mm:ss+03:00")}</operation_date>");
                        xml_body.Append($"<sscc>{node.GetValue(IndexColSSCC_NAME).ToString()}</sscc>");
                        xml_body.Append("</unit_unpack>");
                        xml_body.Append("</documents>");

                        int new_id = Sys.Global.DataProvider.CreateChildDocument(this.doc_id, 912);
                        Sys.Global.DataProvider.SaveDocBodyById(xml_body.ToString(), new_id);
                        WebMethods.DocumentSend(xml_body.ToString(), new_id, false);

                        //(для расформирования 912)


                        //int res = DAO.CreateOutcomeDocument(this.doc_id, 431, address, node.GetValue(IndexColSSCC_ID).ToString(), null, null, 1);
                        //listRes.Add(res);
                        process.progressBarControl.Position++;
                    }
                }


                if (MessageBox.Show($"Выполнено. Было создано {listRes.Count} документов. Хотите посмотреть список?", "Выполнено", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmStringList frmRes = new frmStringList(listRes, "Список созданных документов перемещения");
                }
                process.Close();
            }
        }

        private void tsmiSerchSscc_Click(object sender, EventArgs e)
        {
            frmTextBox frm = new frmTextBox("Найти коробку", "Введите номер коробки (SSCC)");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                List<string> f = new List<string>();
                f.Add(frm.Data);
                tlSSCC.SetFilter("SSCC", f);
                tlSSCC.ExpandAll();
            }
        }

        private void tsmiAction_List_ExpandAll_Click(object sender, EventArgs e)
        {
            tlSSCC.ExpandAll();
        }

        private void tsmiAction_List_CollapseAll_Click(object sender, EventArgs e)
        {
            tlSSCC.CollapseAll();
        }

        private void tsmiAction_List_ClearFilter_Click(object sender, EventArgs e)
        {
            tlSSCC.ClearFilter();
        }
        #endregion




        /// <summary>
        /// ПЕРЕМЕЩЕНИЕ КОРОБОК
        /// </summary>
        private void MovedSSCC()
        {
            if (tlSSCC.Nodes.Count == 0)
            {
                MessageBox.Show("Коробок не найдено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Заполняем временную таблицу данными по выбранным коробкам
            DataTable data = new DataTable();
            data.Columns.Add("OBJECT", typeof(string));
            data.PrimaryKey = new DataColumn[] { data.Columns["OBJECT"] };

            foreach (TreeListNode node in tlSSCC.GetAllCheckedNodes())
            {
                DataRow row = data.NewRow();
                // Если ничего не отмечено, только верхний уровень
                //TreeListNode parentNode = GetMasterParentNode(node);                
                //row[0] = parentNode.GetValue(IndexColSSCC_NAME).ToString();

                // Если отмечено, то перемещаем конкретную
                row[0] = node.GetValue(IndexColSSCC_NAME).ToString();

                if (!data.Rows.Contains(row))
                    data.Rows.Add(row);
            }
            if (data.Rows.Count == 0)
            {
                if (MessageBox.Show("Вы не выбрали ни одной коробки. Будут перемещены все. Продолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    goto ToMove;
                else
                    return;
            }

            ToMove:
            Additional.MoveDocBody("SSCC", this.doc_id, data);
        }

        /// <summary>
        /// ИЗЪЯТЬ КОРОБКИ
        /// </summary>
        private void ThreadExtractBox()
        {
            process = new frmProccess();

            process.progressBarControl.Properties.Maximum = tlSSCC.GetAllCheckedNodes().Count();
            process.Show();
            Application.DoEvents();

            string branch_id = Sys.Global.DataProvider.GetBranchIdByDoc(this.doc_id);
            string session_ui = Guid.NewGuid().ToString().ToLower();
            StringBuilder xml_body = new StringBuilder();
            xml_body.Append($"<documents session_ui = \"{session_ui}\" version = \"{Sys.Global.VERSION}\">");
            xml_body.Append("<unit_extract action_id = \"913\">");
            xml_body.Append($"<subject_id>{branch_id}</subject_id>");
            xml_body.Append($"<operation_date>{DateTime.Now.ToString("yyyy-MM-ddTH:mm:ssZ")}</operation_date>");
            xml_body.Append("<content>");
            foreach (TreeListNode node in tlSSCC.GetAllCheckedNodes())
            {
                xml_body.Append($"<sscc>{node.GetValue(IndexColSSCC_NAME).ToString()}</sscc>");
                process.progressBarControl.Position++;
                Application.DoEvents();
            }
            xml_body.Append("</content>");
            xml_body.Append("</unit_extract>");
            xml_body.Append("</documents>");

            int new_id = Sys.Global.DataProvider.CreateChildDocument(this.doc_id, 913);
            Sys.Global.DataProvider.SaveDocBodyById(xml_body.ToString(), new_id);
            WebMethods.DocumentSend(xml_body.ToString(), new_id, false);


            process.Close();
            OnWorkIsDone?.Invoke(this, EventArgs.Empty);
            tlSSCC.Invoke(new RefreshSscc(RefreshData));
        }

        /// <summary>
        /// РАСФОРМИРОВАТЬ КОРОБКИ
        /// </summary>
        private void ThreadUnPackingBox()
        {
            process = new frmProccess();

            process.progressBarControl.Properties.Maximum = tlSSCC.GetAllCheckedNodes().Count > 0 ? tlSSCC.GetAllCheckedNodes().Count : tlSSCC.GetNodeList().Count;
            process.Show();
            Application.DoEvents();

            // В случае, если небыло выбрано ни одной коробки, передаем все
            foreach (TreeListNode node in tlSSCC.GetAllCheckedNodes().Count > 0 ? tlSSCC.GetAllCheckedNodes() : tlSSCC.GetNodeList())
            {
                int doc_id = DAO.CreateOutcomeDocument(this.doc_id, 912, null, node.GetValue(IndexColSSCC_NAME).ToString(), null, null, 1);
                WebMethods.DocumentSend(Sys.Global.DataProvider.GetDocBody(doc_id), doc_id, false);
                process.progressBarControl.Position++;
                Application.DoEvents();
            }
            process.Close();
            OnWorkIsDone?.Invoke(this, EventArgs.Empty);
            tlSSCC.Invoke(new RefreshSscc(RefreshData));
        }

        private void btnOutbox_Click(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("OUTBOX");
            dGetFilterBalanceId(data);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("ALL");
            dGetFilterBalanceId(data);
        }

        private void выделитьПоФильтрамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecursiveCheckingVisible(tlSSCC.Nodes);
        }

        private void RecursiveCheckingVisible(TreeListNodes nodes)
        {
            foreach (TreeListNode node in nodes)
            {
                if (node.Visible == true)
                {
                    if (node.Nodes.Count > 0)
                        RecursiveCheckingVisible(node.Nodes);
                    node.Checked = true;
                }
            }
        }

        private void tlSSCC_AfterCheckNode(object sender, NodeEventArgs e)
        {
            tsslCount.Text = "Выделено: " + tlSSCC.GetAllCheckedNodes().Count();
        }
    }
}
