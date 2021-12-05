using System;
using System.IO;
using System.Xml;
using System.Drawing;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using PMMarkingUI.Forms;
using PMMarkingUI.Classes;
using PMMarkingUI.Delegats;
using ProfitMed.Firebird;
using ProfitMed.DataContract;
using System.Xml.Serialization;
using System.Text;

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;

namespace PMMarkingUI.Views
{
    public partial class DocumentView : UserControl
    {
        private frmProccess process;
        public delegate void OnWorkIsDoneHandler(object sender, EventArgs e); // Делегат для события окна.
        public event OnWorkIsDoneHandler OnWorkIsDone; // Событие окна: завершение потока чтения.
        public delegate void RefreshServiceDoc();

        private DelegateAddPage dAddPage;
        DataRow Doc;
        public int doc_id { get; private set; }
        public string REQUEST_ID { get; private set; }
        public string DOCUMENT_ID { get; private set; }
        public int DIRECT { get; private set; }
        public int DOC_TYPE { get; private set; }
        public int DOC_PARENT { get; private set; }
        private Panel Background;
        private Label LP_Background;
        public DocumentView(int doc_id, DelegateAddPage dap = null)
        {
            InitializeComponent();

            this.doc_id = doc_id;
            this.Tag = doc_id;
            this.dAddPage = dap;
            documentSSCCView.SetData(GetSSCC_DialogResult, this.doc_id, this);
            documentSSCCView.dGetFilterBalanceId += FilterBalanceId;
            OnWorkIsDone += this.OnWorkEnd;
            // SetReadOnlyVGridRows(vGridControl);
            vBalance.SetDefaultGridViewOptions();            
            vServiceDocs.SetDefaultGridViewOptions();
            vServiceDocs_Errors.SetDefaultGridViewOptions();
            vErrors.SetDefaultGridViewOptions();
            vUnion.SetDefaultGridViewOptions();
            vUnion.OptionsView.AllowCellMerge = true;
            tsmiUnion_MergeCell.Text = "Разъединить строки";

            Background = new Panel();
            Background.Parent = scUnionHead.Panel2;
            Background.Dock = DockStyle.Fill;
            Background.BringToFront();

            LP_Background = new Label();
            LP_Background.Parent = Background;
            LP_Background.Dock = DockStyle.Fill;
            LP_Background.Text = "Для отображения содержимого документа, в левой части окна выберите один из вариантов:\n\n* РОССЫПЬ (отображается только SGTIN без коробки)\n* Показать все\n* Показать содержимое коробки (по двойному щелчку)\n\nДля поиска SGTIN по ВСЕМУ документу, выберите слева \"Показать все\"";
            LP_Background.TextAlign = ContentAlignment.TopLeft;
            LP_Background.Font = new Font(LP_Background.Font.FontFamily, 12, FontStyle.Italic);
            LP_Background.Padding = new Padding(120, 50, 0, 0);

            IMG_Background.Parent = Background;
            IMG_Background.Location = new Point(0, 0);
            IMG_Background.Padding = new Padding(5, 5, 5, 5);
            IMG_Background.BringToFront();

            tsslShowGtinInfo_Click(null, null);
        }

        private void OnWorkEnd(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнено!");            
        }

        private void InizializeProcessForm()
        {
            process.Location = new Point(400, 250);
        }

        /// <summary>
        /// Загрузить представление документа
        /// </summary>
        public void ViewShow()
        {
            DataTable DocData = DAO.GetDocumentById(Sys.Global.USER_ID, doc_id);
            if (DocData.Rows.Count == 0)
                throw new Exception($"Документ № {doc_id} не найден");
            Doc = DocData.Rows[0];
            this.Text = String.Concat("Документ: ", this.doc_id) + (!string.IsNullOrEmpty(Doc["DOC_NUM"].ToString()) ? $" # {Doc["DOC_NUM"].ToString()}" : ""); //  Doc["ID"].ToString();
            this.REQUEST_ID = Doc["REQUEST_ID"].ToString();
            this.DOCUMENT_ID = Doc["DOCUMENT_ID"].ToString();
            this.DIRECT = (Doc["DIRECT"] == DBNull.Value) ? 0 : (int)Doc["DIRECT"];
            this.DOC_TYPE = (Doc["DOC_TYPE"] == DBNull.Value) ? 0 : (int)Doc["DOC_TYPE"];
            this.DOC_PARENT = (Doc["PARENT"] == DBNull.Value) ? 0 : (int)Doc["PARENT"];
            tsmiGetOutcome_Group.Enabled = (DIRECT == -1);

            vgcDoc.DataSource = DocData;
            vgcDoc.LayoutChanged();
            vgcDoc.CollapseAllRows();
            rootDocument.Expanded = true;
            vgcSender.DataSource = DocData;
            vgcSender.LayoutChanged();
            vgcReceiver.DataSource = DocData;
            vgcReceiver.LayoutChanged();
            vgcAdditional.DataSource = DocData;
            vgcAdditional.LayoutChanged();

            xtpPage_Balance.PageVisible = false;
            xtpPage_ServiceDocs.PageVisible = false;
            xtpPage_Errors.PageVisible = false;
            bool isFirstPage = true;
            DataTable DocViewSettings = DAO.GetDocViewSettings(this.DOC_TYPE);
            if (DocViewSettings.Rows.Count > 0)
            {
                if ((int)DocViewSettings.Rows[0]["SHOW_BALANCE"] == 1)
                {
                    xtpPage_Balance.PageVisible = true;
                    if (isFirstPage)
                    {
                        xtcPages.SelectedTabPage = xtpPage_Balance;
                        //GetDocBody();
                        documentSSCCView.RefreshData();
                        isFirstPage = false;
                    }

                    vBalance.CheckBoxesPost();
                }
                if ((int)DocViewSettings.Rows[0]["SHOW_UNION"] == 1)
                {
                    xtpPage_Union.PageVisible = true;
                    xtcPages.SelectedPageChanged -= xtcPages_SelectedPageChanged;
                    xtcPages.SelectedPageChanged += xtcPages_SelectedPageChanged;
                    if (isFirstPage)
                    {
                        xtcPages.SelectedTabPage = xtpPage_Union;
                        Refresh_Union();
                        isFirstPage = false;
                    }

                    vUnion.CheckBoxesPost();
                }
                if ((int)DocViewSettings.Rows[0]["SHOW_SERVICEDOCS"] == 1)
                {
                    xtpPage_ServiceDocs.PageVisible = true;
                    xtcPages.SelectedPageChanged -= xtcPages_SelectedPageChanged;
                    xtcPages.SelectedPageChanged += xtcPages_SelectedPageChanged;
                    if (isFirstPage)
                    {
                        xtcPages.SelectedTabPage = xtpPage_ServiceDocs;
                        Refresh_ServiceDocuments();
                        isFirstPage = false;
                    }

                    vServiceDocs.CheckBoxesPost();
                    Sys.GridColumns.CreateFormatRules(vServiceDocs, "RejectedCols", "TICKET_RESULT", $"[TICKET_RESULT] == 'Rejected'", false);
                }
                if ((int)DocViewSettings.Rows[0]["SHOW_ERRORS"] == 1)
                {
                    xtpPage_Errors.PageVisible = true;
                    if (isFirstPage)
                    {
                        xtcPages.SelectedTabPage = xtpPage_Errors;
                        Refresh_Errors();
                        isFirstPage = false;
                    }
                }
            }
            else
            {
                ShowDocBodyXml();
            }
            
            tsmiOpenDocParent.Visible = (this.DOC_PARENT != 0);
            gfvUnion.SetGridView(vBalance);
            gfvUnion.SetColumn(gcBalance_SGTIN.FieldName);
            //tbHelper.Text = Doc["HELPER"].ToString();

            tsmiAction_Admin.Visible = Sys.Global.USER_LOGIN != "USER";
        }

        private void GetDocBody(int? sscc_id = null)
        {
            cBalance.DataSource = DAO.GetDocBodyList(this.doc_id, sscc_id);
            vBalance.LayoutChanged();
            GC.Collect();
            Background.Visible = false;
        }

        private void Refresh_ServiceDocuments()
        {
            List<int> handleSelected = new List<int>();
            if ((DataTable)cServiceDocs.DataSource != null && tsmiSetting_Selected.Checked)
            {
                foreach (DataRow row in ((DataTable)cServiceDocs.DataSource).Rows)
                {
                    if ((int)row["HANDLE_SELECT"] == 1)
                        handleSelected.Add((int)row["ID"]);
                }
            }

            cServiceDocs.DataSource = DAO.GetServiceDocumentsByParentId(this.doc_id);
            vServiceDocs.LayoutChanged();

            if (((DataTable)cServiceDocs.DataSource).Rows.Count > 0 && tsmiSetting_Selected.Checked)
            {
                foreach (int item in handleSelected)
                {
                    foreach (DataRow row in ((DataTable)cServiceDocs.DataSource).Rows)
                    {
                        if ((int)row["ID"] == item)
                            row["HANDLE_SELECT"] = 1;
                    }
                }
            }

            SelectServiceDoc();
            GC.Collect();
        }

        private void Refresh_Errors()
        {
            cErrors.DataSource = DAO.GetDocumentErrors(doc_id);
            vErrors.LayoutChanged();
        }

        // ============================================================================================
        // ============================================================================================

        #region API Методы
        /// <summary>
        /// 8.5.4 Метод для получения публичной информации о производимом ЛП
        /// </summary>
        private void ApiN_8_5_4()
        {
            try
            {
                string GTIN = vBalance.GetDataSourceRow()["GTIN"].ToString();
                WebMethods.GetInfoByGtin(this, GTIN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        /// <summary>
        /// 8.3.2. Метод поиска по реестру КИЗ по списку значений
        /// </summary>
        private void ApiN_8_3_2()
        {
            List<string> SGTINs = new List<string>();
            int doc_id = 0;
            foreach (DataRow row in (cBalance.DataSource as DataTable).Rows)
            {
                if ((int)row["HANDLE_SELECT"] != 1)
                    continue;
                SGTINs.Add(row["SGTIN"].ToString());
                if (doc_id == 0)
                    doc_id = Int32.Parse(row["o_doc_id"].ToString());
            }
            bool res = WebMethods.KizSerchBySgtin(this, doc_id, SGTINs);
            if (res)
                GetDocBody();
        }
        #endregion


        //===================================================================================
        //===================================================================================

        #region Вспомогательные
        private void vGridControl_RecordCellStyle(object sender, DevExpress.XtraVerticalGrid.Events.GetCustomRowCellStyleEventArgs e)
        {
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
        }
        private void vUnion_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = null;
            try
            {
                row = vBalance.GetDataRow(e.FocusedRowHandle);
                SgtinDetails(row);
            }
            catch (Exception ex)
            {
                return;
            }
        }
        private void SgtinDetails(DataRow row)
        {
            if (row == null)
            {
                vgcGTIN.DataSource = new DataTable();
                vgcGTIN.LayoutChanged();

                vgcSGTIN.DataSource = new DataTable();
                vgcSGTIN.LayoutChanged();

                return;
            }

            string gtin = row["GTIN"].ToString();
            int sgtin_id = 0;
            if (row["SGTIN_ID"] != DBNull.Value)
                sgtin_id = Convert.ToInt32(row["SGTIN_ID"]);

            if (vgcGTIN.DataSource != null)
            {
                if ((vgcGTIN.DataSource as DataTable).Rows.Count > 0)
                {
                    try
                    {
                        if ((vgcGTIN.DataSource as DataTable).Rows[0]["GTIN"].ToString() != gtin)
                        {
                            vgcGTIN.DataSource = DAO.GetGtinInfoByGtin(gtin);
                            vgcGTIN.LayoutChanged();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            else
            {
                vgcGTIN.DataSource = DAO.GetGtinInfoByGtin(gtin);
                vgcGTIN.LayoutChanged();
            }

            vgcSGTIN.DataSource = DAO.GetSgtinInfo(sgtin_id);
            vgcSGTIN.LayoutChanged();
        }
        private void GetSSCC_DialogResult(DialogResult res)
        {
            if (res == DialogResult.OK)
                GetDocBody();
        }
        /// <summary>
        /// Установить строки VGridControl в ReadOnly
        /// </summary>
        /// <param name="ctrl"></param>
        private void SetReadOnlyVGridRows(VGridControl ctrl)
        {
            foreach (BaseRow row in ctrl.Rows)
            {
                SetReadOnlyVGridRows_Child(row);
            }
        }
        /// <summary>
        /// Установить дочерние строки VGridControl в ReadOnly
        /// </summary>
        /// <param name="row"></param>
        private void SetReadOnlyVGridRows_Child(BaseRow row)
        {
            if (row.ChildRows.Count == 0)
            {
                row.Properties.AllowEdit = true;
                row.Properties.ReadOnly = true;
            }
            else
            {
                foreach (BaseRow ChildRow in row.ChildRows)
                {
                    SetReadOnlyVGridRows_Child(ChildRow);
                    ChildRow.Properties.AllowEdit = true;
                    ChildRow.Properties.ReadOnly = true;
                }
            }
        }
        private void FilterBalanceId(List<string> text)
        {
            if (text.Count > 0)
            {
                string s = text[0];
                switch (s)
                {
                    case "ALL":
                        vBalance.ViewCaption = "Список содержимого: Весь документ";
                        GetDocBody();
                        break;

                    case "OUTBOX":
                        vBalance.ViewCaption = "Список содержимого: РОССЫПЬ";
                        GetDocBody(0);
                        break;

                    case "":
                        vBalance.ViewCaption = "Список содержимого";
                        break;

                    default:
                        try
                        {
                            int sscc_id = 0;
                            if (Int32.TryParse(s, out sscc_id))
                            {
                                vBalance.ViewCaption = "Список содержимого: " + s;
                                GetDocBody(sscc_id);
                            }
                        }
                        catch (Exception ex)
                        {
                            //
                        }
                        break;
                }
            }
            //TFiltered:
            //vUnion.SetFilter("SSCC_BALANCE_ID", text);
        }
        #endregion
        #region Меню и кнопки
        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewShow();
        }
        private void получениеПубличнойИнформацииОбЛПToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("8.5.4 Получение публичной информации о производимом ЛП");
        }
        private void методПоискаПоРееструКИЗПоСпискуЗначенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApiN_8_3_2();
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ApiN_8_5_4();
        }
        private void методПоискаПоОбщедоступномуРееструКИЗПоСпискуЗначенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ApiN_8_3_3();
        }
        private void методДляПолученияДетальнойИнформацииОКИЗИСвязаннымСНимЛПToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string SGTIN = vBalance.GetDataSourceRow()["SGTIN"].ToString();
                WebMethods.KizGetInfo(SGTIN);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void сформироватьДочернийДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateChildDocument frm = new frmCreateChildDocument(this.doc_id);
            frm.ShowDialog();
        }
        private void обновитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GetDocBody();
        }
        private void метаданныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 5.9. Получение метаданных документа
                WebMethods.DocumentGetMetadata(DOCUMENT_ID, DIRECT);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void документToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 5.10 Получение документа по идентификатору
                WebMethods.DocumentGetDoc(DOCUMENT_ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void квитанциюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 5.12 Получение квитанции по номеру исходящего документа
                WebMethods.DocumentGetTiket(DOCUMENT_ID, DIRECT);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void списокДокументовПоИдентификаторуЗапросаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 5.11 Получение списка документов по идентификатору запроса
                WebMethods.DocumentGetListByRequestId(REQUEST_ID, DIRECT);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void электроннуюПодписьИсходящегоДокументаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // 5.13 Получить электронную подпись исходящего документа
                WebMethods.DocumentGetECP(DOCUMENT_ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void телоДокументаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDocBodyXml();
        }

        private void ShowDocBodyXml()
        {
            DataTable bodys = DAO.GetXmlDocBody(this.doc_id);
            if (bodys.Rows.Count > 0)
                DocXmlBody.BuildXmlTree(bodys.Rows[0]["DOC_BODY"].ToString());
        }

        private void телоЭтикеткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDocTicketXml();
        }

        private void ShowDocTicketXml()
        {
            DataTable bodys = DAO.GetXmlDocBody(this.doc_id);
            if (bodys.Rows.Count > 0)
                DocXmlBody.BuildXmlTree(bodys.Rows[0]["TICKET_BODY"].ToString());
        }

        private void метаданныеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            #region Старый вариант
            /*bool isExist = false;
            foreach (DataRow row in (cServiceDocs.DataSource as DataTable).Rows)
            {
                if ((int)row["HANDLE_SELECT"] == 1)
                {
                    try
                    {
                        // 5.9. Получение метаданных документа
                        WebMethods.DocumentGetMetadata(row["DOCUMENT_ID"].ToString(), (int)row["DIRECT"], false);
                        isExist = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            MessageBox.Show("Выполнено!");
            if (isExist)
                Refresh_ServiceDocuments();*/
            #endregion
            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadMetaData));
            readThread.Start();
        }

        private void ThreadMetaData()
        {
            process = new frmProccess();
            InizializeProcessForm();
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
            cServiceDocs.Invoke(new RefreshServiceDoc(Refresh_ServiceDocuments));
        }

        private void документToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            #region Старый вариант
            /*bool isExist = false;
            foreach (DataRow row in (cServiceDocs.DataSource as DataTable).Rows)
            {
                if ((int)row["HANDLE_SELECT"] == 1)
                {
                    try
                    {
                        // 5.10 Получение документа по идентификатору
                        WebMethods.DocumentGetDoc(row["DOCUMENT_ID"].ToString(), false);
                        isExist = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            MessageBox.Show("Выполнено!");
            if (isExist)
                Refresh_ServiceDocuments();*/
            #endregion
            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadDocument));
            readThread.Start();
        }

        private void ThreadDocument()
        {
            process = new frmProccess();
            InizializeProcessForm();
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
            cServiceDocs.Invoke(new RefreshServiceDoc(Refresh_ServiceDocuments));
        }

        private void квитанциюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            #region Старый способ
            /*bool isExist = false;
            foreach (DataRow row in (cServiceDocs.DataSource as DataTable).Rows)
            {
                if ((int)row["HANDLE_SELECT"] == 1)
                {
                    try
                    {
                        // 5.12 Получение квитанции по номеру исходящего документа
                        WebMethods.DocumentGetTiket(row["DOCUMENT_ID"].ToString().ToLower(), (int)row["id"], false);
                        isExist = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            MessageBox.Show("Выполнено!");
            if (isExist)
                Refresh_ServiceDocuments();*/
            #endregion
            ThreadTicket();
            //System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadTicket));
            //readThread.Start();
        }

        public void ThreadTicket()
        {
            process = new frmProccess();
            InizializeProcessForm();
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
            cServiceDocs.Invoke(new RefreshServiceDoc(Refresh_ServiceDocuments));
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            снятьВыделениеToolStripMenuItem_Click(null, null);
            foreach (DataRow row in vServiceDocs.GetFilteredRows())
            {
                row["HANDLE_SELECT"] = 1;
            }
        }

        private void снятьВыделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in (cServiceDocs.DataSource as DataTable).Rows)
            {
                row["HANDLE_SELECT"] = 0;
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DataRow row = vServiceDocs.GetDataSourceRow();            
            if (row != null)
            {
                DataTable bodys = DAO.GetXmlDocBody((int)row["ID"]);
                if (bodys.Rows.Count > 0)
                    ServiceDocXmlBody.BuildXmlTree(bodys.Rows[0]["DOC_BODY"].ToString());
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            DataRow row = vServiceDocs.GetDataSourceRow();
            if (row != null)
            {
                DataTable bodys = DAO.GetXmlDocBody((int)row["ID"]);
                if (bodys.Rows.Count > 0)
                    ServiceDocXmlBody.BuildXmlTree(bodys.Rows[0]["TICKET_BODY"].ToString());
            }
        }

        private void tsimProcessBox_Click(object sender, EventArgs e)
        {
            //System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProcessBox));
            //readThread.Start();
            ThreadProcessBox();
        }
        #endregion

        private void GetChildsSscc(ref List<SsccInfo> sscc_info, XmlNode parent_node, int level)
        {
            XmlNodeList childs_node = parent_node.SelectNodes("//sscc_info");
            string parent_value = parent_node.ParentNode.SelectSingleNode("sscc").InnerText ?? String.Empty;
            int i = level++;
            foreach(XmlNode node in childs_node)
            {
                if (node.ParentNode == parent_node)
                {
                    SsccInfo ssccInfo = new SsccInfo();
                    ssccInfo.sscc = node.SelectSingleNode("sscc").InnerText;
                    ssccInfo.level = level;
                    ssccInfo.release_date = node.SelectSingleNode("packing_date").InnerText;
                    ssccInfo.parent_sscc = parent_value;
                    ssccInfo.system_subj_id = Doc["sender_sys_id"].ToString();
                    ssccInfo.status = 1;
                    sscc_info.Add(ssccInfo);

                    GetChildsSscc(ref sscc_info, node.SelectSingleNode("childs"), i);
                }
            }
            
        }

        public void ThreadProcessBox()
        {
            process = new frmProccess();
            InizializeProcessForm();

            DataRow[] rows = (cServiceDocs.DataSource as DataTable).Select("handle_select = 1 and doc_type = 220");

            process.progressBarControl.Properties.Maximum = rows.Count();
            process.Show();

            process.progressPanel.Description = "Подготавливаем таблицы ...";
            Application.DoEvents();
            Sys.Global.DataProvider.DeleteTempSgtin((int)Doc["id"]);
            process.progressPanel.Description = "Отключаем индексы...";
            Application.DoEvents();
            Sys.Global.DataProvider.ChangeIndexStatus("TBL_SGTIN_INFO_TMP", 0);

            process.progressPanel.Description = "Сохраняем коробки...";            
            Application.DoEvents();
            foreach (DataRow row in rows)
            {
                try
                {

                    #region Подготовка
                    string xmlTicketBody = "";
                    DataTable bodys = DAO.GetXmlDocBody((int)row["id"]);
                    if (bodys.Rows.Count > 0)
                        xmlTicketBody = bodys.Rows[0]["TICKET_BODY"].ToString();

                    if (string.IsNullOrEmpty(xmlTicketBody))
                    {
                        Console.WriteLine("Ошибка обработки коробок: не получен ticket_body");
                        continue;
                    }
                    #endregion
                    #region Сохраняем коробки
                    List<SsccInfo> sscc_info = new List<SsccInfo>();
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.LoadXml(xmlTicketBody);
                    try
                    {
                        // Сначала вставляем коробки, коробка верхнего уровня вставлена при обработке основного документа
                        XmlNode parent = xdoc.SelectSingleNode("//documents//hierarchy_info//sscc_down//sscc_info//childs");
                        GetChildsSscc(ref sscc_info, parent, 1);
                        if (sscc_info.Count > 0)
                            Sys.Global.DataProvider.SaveSsccInfo(sscc_info, (int)Doc["id"]);
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            string warningTagOpen = "<operation_warning>";
                            string warningTagClose = "</operation_warning>";
                            if (xmlTicketBody.Contains(warningTagOpen))
                            {
                                int iSubsStart = xmlTicketBody.IndexOf(warningTagOpen) + warningTagOpen.Length;
                                int iSubsEnd = xmlTicketBody.IndexOf(warningTagClose) - iSubsStart;
                                throw new Exception("ОШИБКА от МДЛП: " + xmlTicketBody.Substring(iSubsStart, iSubsEnd));
                            }
                            else
                                throw ex;
                        }
                        catch (Exception exx)
                        {
                            //MessageBox.Show("Сохранение SSCC", exx.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //goto TEnd;
                            continue;
                        }
                    }
                    #endregion
                    #region Сохраняем SGTIN
                    process.progressPanel.Description = "Сохраняем SGTIN...";
                    Application.DoEvents();
                    // Вставляем Sgtins
                    try
                    {
                        XmlNodeList sgtinInfo = xdoc.SelectNodes("//sgtin_info");
                        List<InfoSgtin> info_sgtin = new List<InfoSgtin>();
                        foreach (XmlNode node in sgtinInfo)
                        {
                            InfoSgtin sgtin = new InfoSgtin();
                            sgtin.sgtin = node.SelectSingleNode("sgtin").InnerText;
                            sgtin.gtin = node.SelectSingleNode("gtin").InnerText;
                            sgtin.sscc = node.SelectSingleNode("sscc").InnerText;
                            sgtin.series_number = node.SelectSingleNode("series_number").InnerText;
                            sgtin.status = node.SelectSingleNode("status").InnerText;
                            sgtin.expiration_date = node.SelectSingleNode("expiration_date").InnerText;
                            info_sgtin.Add(sgtin);
                        }
                        if (info_sgtin.Count > 0)
                            Sys.Global.DataProvider.SaveSgtinInfoTmp(info_sgtin, (int)Doc["id"]);
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Сохранение SGTIN", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                    #endregion

                    // Меняем статус документа на "Ответ обработан"
                    Sys.Global.DataProvider.ChangeDocResult((int)row["id"], 2005);
                    // Сохраняем информацию об SGTIN (с очисткой временной таблицы)
                    Sys.Global.DataProvider.SaveSgtinInfo();

                    process.progressBarControl.Position++;
                    Application.DoEvents();
                }
                catch { }
            }

            TEnd:
            process.progressPanel.Description = "Включаем индексы...";
            Application.DoEvents();
            Sys.Global.DataProvider.ChangeIndexStatus("TBL_SGTIN_INFO_TMP", 1);
            process.progressPanel.Description = "Пересчитываем статистику по индексам...";
            Application.DoEvents();
            Sys.Global.DataProvider.SetIndexStatistic("TBL_SGTIN_INFO_TMP");

            process.Close();
            OnWorkIsDone?.Invoke(this, EventArgs.Empty);
            cServiceDocs.Invoke(new RefreshServiceDoc(Refresh_ServiceDocuments));
        }

        private void tsmiGetDocByRequestId_Click(object sender, EventArgs e)
        {
            DataRow row = vServiceDocs.GetDataSourceRow();
            WebMethods.DocumentGetListByRequestId(row["REQUEST_ID"].ToString().ToLower(), (int)row["id"]);
        }

        private void tsmiLinkTW4_Click(object sender, EventArgs e)
        {
            frmDocumentLinkToTW4 frm = new frmDocumentLinkToTW4(this.doc_id);
            frm.ShowDialog();
        }

        private void выделитьВсеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cBalance.GridSelectAll("HANDLE_SELECT", 1);
        }

        private void снятьВыделениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cBalance.GridSelectAll("HANDLE_SELECT", 0);
        }

        private void tsmiAction_CreateDocument_Click(object sender, EventArgs e)
        {
            List<int> docs_id = new List<int>();
            docs_id.Add(this.doc_id);
            frmCreateDocument frm = new frmCreateDocument(docs_id);
            frm.ShowDialog();
        }

        private void tsmiDocToXml_Click(object sender, EventArgs e)
        {
            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            {
                using (frmProccess process = new frmProccess())
                {
                    process.progressBarControl.Properties.Maximum = (cServiceDocs.DataSource as DataTable).Select("handle_select = 1 and doc_result = 2000").Count();
                    process.Show();
                    Application.DoEvents();
                    /*foreach (DataRow row in (cServiceDocs.DataSource as DataTable).Select("handle_select = 1 and doc_result = 2000"))
                    {*/
                        try
                        {
                            Sys.Global.Api.ProcessedDocXml();

                            //MessageBox.Show("Выполнено");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка! " + ex.Message);
                        }
                        process.progressBarControl.Position = process.progressBarControl.Properties.Maximum;
                        Application.DoEvents();
                    //}
                    process.Close();
                    OnWorkIsDone?.Invoke(this, EventArgs.Empty);
                    cServiceDocs.Invoke(new RefreshServiceDoc(Refresh_ServiceDocuments));
                }
            }));
            readThread.Start();
        }

        private void tsmiUoloadDoc_Click(object sender, EventArgs e)
        {
            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            {
                using (frmProccess process = new frmProccess())
                {
                    List<int> ids = new List<int>();
                    foreach (DataRow row in (cServiceDocs.DataSource as DataTable).Rows)
                    {
                        if ((int)row["HANDLE_SELECT"] == 1 && string.IsNullOrEmpty(row["DOCUMENT_ID"].ToString()))
                        {
                            ids.Add((int)row["id"]);
                        }
                    }

                    process.progressBarControl.Properties.Maximum = ids.Count();
                    process.Show();
                    Application.DoEvents();

                    foreach (int id in ids)
                    {
                        try
                        {
                            string xmlDocBody = "";
                            DataTable bodys = DAO.GetXmlDocBody(id);
                            if (bodys.Rows.Count > 0)
                                xmlDocBody = bodys.Rows[0]["DOC_BODY"].ToString();

                            if (!string.IsNullOrEmpty(xmlDocBody))
                                WebMethods.DocumentSend(xmlDocBody, id, false);

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
                    cServiceDocs.Invoke(new RefreshServiceDoc(Refresh_ServiceDocuments));
                }
            }));
            readThread.Start();
        }

        private void tsmiErrors_Action_Process_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Обработать ошибки документа?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            using (frmProccess process = new frmProccess())
            {
                List<object> listErrors = new List<object>();

                DataTable new_docs = DAO.DocumentProcessingError(this.doc_id);
                process.progressPanel.Text = "Обработка ошибок документа " + this.doc_id.ToString();
                process.progressBarControl.Properties.Maximum = new_docs.Rows.Count;
                process.Show();
                Application.DoEvents();

                foreach (DataRow row in new_docs.Rows)
                {
                    try
                    {
                        object new_doc_id = row["NEW_DOC_ID"];
                        if (new_doc_id != null)
                        {
                            DataRow new_doc = DAO.GetDocumentById(Sys.Global.USER_ID, (int)new_doc_id).Rows[0];
                            string xmlDocBody = "";
                            DataTable bodys = DAO.GetXmlDocBody((int)new_doc_id);
                            if (bodys.Rows.Count > 0)
                                xmlDocBody = bodys.Rows[0]["DOC_BODY"].ToString();

                            // 5.1 Отправка документа
                            WebMethods.DocumentSend(xmlDocBody, (int)new_doc["id"], false);
                            System.Threading.Thread.Sleep(1000);
                        }
                        else
                            throw new Exception(row["MSG"].ToString());
                    }
                    catch (Exception ex)
                    {
                        listErrors.Add(ex.Message);
                    }
                    finally
                    {
                        process.progressBarControl.Position++;
                        Application.DoEvents();
                    }
                }
                process.Close();
                if (listErrors.Count == 0)
                    MessageBox.Show("Выполнено. Список данных будет обновлен");
                else
                {
                    frmStringList frm = new frmStringList(listErrors, "Список ошибок");
                    frm.ShowDialog();
                }
                Refresh_Errors();
            }
        }

        private void tsmiErrors_Action_Refresh_Click(object sender, EventArgs e)
        {
            Refresh_Errors();
        }

        private void tsmiAction_CreateDocAccept_Click(object sender, EventArgs e)
        {
            CreateOutcomeDocument("accept");
        }

        private void tsmiAction_CreateDocDecline_Click(object sender, EventArgs e)
        {
            CreateOutcomeDocument("decline");
        }

        private void CreateOutcomeDocument(string mode)
        {
            try
            {
                List<int> docs_id = new List<int>();
                docs_id.Add(this.doc_id);
                frmCreateDocumentActions frm = new frmCreateDocumentActions(docs_id, mode);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (frm.ResDocId > 0)
                    {
                        MessageBox.Show($"Создан документ № {frm.ResDocId}");
                    }
                    else
                    {
                        MessageBox.Show("Документ не создан", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch { }
        }

        private void tsmiSD_Refresh_Click(object sender, EventArgs e)
        {
            Refresh_ServiceDocuments();
        }

        private void xtcPages_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == xtpPage_ServiceDocs)
            {
                Refresh_ServiceDocuments();
            }
            if (e.Page == xtpPage_Union)
            {
                Refresh_Union();
            }
        }

        private void vServiceDocs_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            SelectServiceDoc();
        }

        TextBox tbServiceDocsError = new TextBox();
        private void SelectServiceDoc()
        {
            DataRow row = vServiceDocs.GetDataSourceRow();
            int ServiceDoc_ID = (row != null) ? (int)row["ID"] : 0;
            string OperationResult = (row != null) ? row["TICKET_RESULT"].ToString() : "";

            if (OperationResult == "Rejected")
            {
                scServiceDocs_Main.Panel2Collapsed = false;
                DataTable dtErrors = DAO.GetDocumentErrors(ServiceDoc_ID);
                tbServiceDocsError.Visible = false;

                if (dtErrors.Rows.Count == 0)
                {
                    string xmlTicketBody = "";
                    DataTable bodys = DAO.GetXmlDocBody((int)row["id"]);
                    if (bodys.Rows.Count > 0)
                        xmlTicketBody = bodys.Rows[0]["TICKET_BODY"].ToString();

                    if (string.IsNullOrEmpty(xmlTicketBody))
                        return;
                    ProfitMed.DataContract.Documents XmlTicket = new ProfitMed.DataContract.Documents();
                    try
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(ProfitMed.DataContract.Documents));
                        using (TextReader reader = new StringReader(xmlTicketBody))
                        {
                            XmlTicket = (ProfitMed.DataContract.Documents)serializer.Deserialize(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        XmlTicket = new ProfitMed.DataContract.Documents();
                    }

                    string errText = $"Операция: {XmlTicket.result.operation}" + Environment.NewLine
                                   + $"ID: {XmlTicket.result.operation_id}" + Environment.NewLine
                                   + $"Статус: {XmlTicket.result.operation_result}" + Environment.NewLine
                                   + $"Описание: {XmlTicket.result.operation_comment}";

                    // Подложка для случаев, когда списка ошибок нет
                    if (tbServiceDocsError.Parent == null)
                    {
                        tbServiceDocsError = new TextBox
                        {
                            Parent = pServiceDocs_Errors,
                            Dock = DockStyle.Fill,
                            ReadOnly = true,
                            Multiline = true,
                            Text = errText,
                            Font = new Font(Font.FontFamily, 10),
                            ScrollBars = ScrollBars.Vertical,
                            WordWrap = true,
                            ForeColor = Color.Red
                        };
                    }
                    tbServiceDocsError.Visible = true;
                    tbServiceDocsError.BringToFront();
                }
                else
                {
                    tbServiceDocsError.Visible = false;
                    cServiceDocs_Errors.DataSource = dtErrors;
                    vServiceDocs_Errors.LayoutChanged();
                }
            }
            else
            {
                scServiceDocs_Main.Panel2Collapsed = true;
                tbServiceDocsError.Visible = false;
            }
        }

        private void tsmiActionUnion_FixSgtinBalance_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Исправить привязки SGTIN по балансу?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool res = false;
                try
                {
                    res = DAO.FixSgtinBalance(this.doc_id);

                    MessageBox.Show(res ? "Выполнено успешно. Список данных будет обновлен." : "Привязки обновлять не требуется.");
                    GetDocBody();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmiAction_MoveDoc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выполнить перемещение документа?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataTable data = new DataTable();
                data.Columns.Add("OBJECT", typeof(string));
                Additional.MoveDocBody("Document", this.doc_id, data);
            }
        }

        private void tsmiActionUnion_MoveSgtin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выполнить перемещение SGTIN?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if ((cBalance.DataSource as DataTable).Rows.Count == 0)
                {
                    MessageBox.Show("Отсутствуют SGTIN для перемещения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable data = new DataTable();
                data.Columns.Add("OBJECT", typeof(string));
                data.PrimaryKey = new DataColumn[] { data.Columns["OBJECT"] };

                foreach (DataRow urow in (cBalance.DataSource as DataTable).Rows.GetSelected())
                {
                    DataRow row = data.NewRow();
                    row[0] = urow["SGTIN"].ToString();

                    if (!data.Rows.Contains(row))
                        data.Rows.Add(row);
                }
                if (data.Rows.Count == 0)
                {
                    //if (MessageBox.Show("Вы не выбрали ни одного SGTIN. Будут перемещены все. Продолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    //    goto ToMove;
                    //else
                    MessageBox.Show("Вы не выбрали ни одного SGTIN для перемещения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //ToMove:
                Additional.MoveDocBody("SGTIN", this.doc_id, data);
            }
        }

        private void tsmiDocHistory_Click(object sender, EventArgs e)
        {
            DataTable res = DAO.GetDocHistory(this.doc_id);
            frmGrid frm = new frmGrid($"История состояний документа {this.doc_id}", res);
            frm.ShowDialog();
        }

        private void tsmiOpenDocParent_Click(object sender, EventArgs e)
        {
            dAddPage(new DocumentView(this.DOC_PARENT, dAddPage));
        }

        private void vUnion_ColumnFilterChanged(object sender, EventArgs e)
        {
            try
            {
                DataRow row = vBalance.GetDataSourceRow();
                SgtinDetails(row);
            }
            catch (Exception ex)
            {
                //
            }
        }

        private void btnSD_Filter701_Click(object sender, EventArgs e)
        {
            vServiceDocs.SetFilter("DOC_TYPE", "701");
        }

        private void btnSD_Filter912_Click(object sender, EventArgs e)
        {
            vServiceDocs.SetFilter("DOC_TYPE", "912");
        }

        private void btnSD_Filter431_Click(object sender, EventArgs e)
        {
            vServiceDocs.SetFilter("DOC_TYPE", "431");
        }

        private void btnSD_Filter220_Click(object sender, EventArgs e)
        {
            vServiceDocs.SetFilter("DOC_TYPE", "220");
        }

        private void tsmiAction_Admin_Parse_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выполнить обработку XML содержимого документа?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool isEnjoy = false;
                using (frmProccess proccess = new frmProccess())
                {
                    try
                    {
                        if (this.DIRECT == 1)
                        {
                            string doc_body = Sys.Global.DataProvider.GetDocBody(this.doc_id);
                            if (!string.IsNullOrEmpty(doc_body))
                            {
                                bool resDel = DAO.DelParseDoc(this.doc_id);    // Собрать документ по разобранному XML

                                ProfitMedService.ParseXML parser = new ProfitMedService.ParseXML();
                                DataTable parseTable = parser.CreateEDGETable();

                                DataTable table = parser.ParseXmlToTable(doc_body);
                                foreach (DataRow r in table.Rows)
                                {
                                    r["doc_id"] = this.doc_id;
                                    r["doc_type"] = this.DOC_TYPE;
                                    parseTable.ImportRow(r);
                                }
                                Sys.Global.DataProvider.SaveXMLToTable(parseTable);
                                bool resPrs = DAO.ParseXml(this.doc_id);    // Собрать документ по разобранному XML
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        proccess.Close();
                        if (isEnjoy)
                        {
                            MessageBox.Show("Выполнено.");
                            ViewShow();
                        }
                    }
                }
            }
        }

        private void tsmiSD_702_Click(object sender, EventArgs e)
        {
            vServiceDocs.SetFilter("DOC_TYPE", "702");
        }

        private void tsmiAction_Create702_Click(object sender, EventArgs e)
        {
            frmTextBox frmPass = new frmTextBox("Введите пароль", "Пароль");
            if (frmPass.ShowDialog() == DialogResult.OK)
            {
                if (frmPass.Data != Sys.Global.AdminPassword)
                {
                    MessageBox.Show("Пароль не верен!");
                    return;
                }

                process = new frmProccess();
                InizializeProcessForm();
                process.progressBarControl.Properties.Maximum = (cServiceDocs.DataSource as DataTable).Select("handle_select = 1").Count();
                process.Show();
                Application.DoEvents();
                foreach (DataRow row in (cServiceDocs.DataSource as DataTable).Select("handle_select = 1"))
                {
                    try
                    {
                        int doc_type = (int)row["DOC_TYPE"];
                        int doc_id = (int)row["ID"];
                        if ((doc_type == 701 || doc_type == 431) && this.DOC_TYPE == 601) // По хорошему только на Reject и на Reject позиции Partial
                        {
                            int new_doc_id = DAO.CreateOutcomeDocument(doc_id, 702, Sys.Global.SYS_OBJ_ID, null, null, null, 1);
                            //string xml = "";
                            //DataTable xmlLines = DAO.CreateXmlDocument702(new_doc_id);
                            //foreach (DataRow xmlRow in xmlLines.Rows)
                            //{
                            //    xml += xmlRow["XML_STR"].ToString() + Environment.NewLine;
                            //}
                            //bool resSave = DAO.SaveXmlDocumentToBlob(new_doc_id, xml);
                            //bool resResult = DAO.ChangeDocResult(new_doc_id, 702010);
                            //bool resResult = DAO.ChangeDocResult(new_doc_id, 2001);
                        }
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
                cServiceDocs.Invoke(new RefreshServiceDoc(Refresh_ServiceDocuments));
            }
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            Refresh_Union();            
        }

        private void Refresh_Union()
        {
            DataTable union = DAO.GetUnionByDocId(this.doc_id);
            cUnion.DataSource = union;
            vUnion.LayoutChanged();
            vUnion.ExpandAllGroups();
        }

        private void vUnion_CellMerge(object sender, CellMergeEventArgs e)
        {
            /*GridView view = sender as GridView;
            if (view == null) return;
            if (e.Column == bandedGridColumn1)
            {
                string text1 = view.GetRowCellDisplayText(e.RowHandle1, bandedGridColumn1);
                string text2 = view.GetRowCellDisplayText(e.RowHandle2, bandedGridColumn1);
                e.Merge = (text1 == text2);
                e.Handled = true;
            }*/
        }

        private void cellmergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vUnion.OptionsView.AllowCellMerge = !vUnion.OptionsView.AllowCellMerge;
            tsmiUnion_MergeCell.Text = (vUnion.OptionsView.AllowCellMerge) ? "Разъединить строки" : "Объединить строки";
        }

        private void tsslShowGtinInfo_Click(object sender, EventArgs e)
        {
            scUnion.Panel2Collapsed = !scUnion.Panel2Collapsed;
            tsslShowGtinInfo.Text = ((scUnion.Panel2Collapsed) ? "Показать" : "Скрыть") + " информацию о GTIN";
        }
    }
}
