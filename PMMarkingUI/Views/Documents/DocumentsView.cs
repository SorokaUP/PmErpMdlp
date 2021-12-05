using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PMMarkingUI.Delegats;
using PMMarkingUI.Forms;
using PMMarkingUI.Classes;
using ProfitMed.DataContract;
using ProfitMed.Firebird;

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace PMMarkingUI.Views
{
    public partial class DocumentsView : UserControl
    {
        public event DelegateAddPage dapDocument;

        DataTable Docs;
        DocFilterDb docFilter;
        DevExpress.XtraWaitForm.ProgressPanel ctrlLoad;
        public DocumentsView(DelegateAddPage ntp)
        {
            InitializeComponent();
            Text = "Документы";
            Tag = false;
            vDocs.SetDefaultGridViewOptions();
            ctrlLoad = new DevExpress.XtraWaitForm.ProgressPanel {
                Parent = pDocs,
                BarAnimationElementThickness = 2,
                ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter,
                RingAnimationDiameter = 75,
                ShowCaption = false,
                ShowDescription = false,
                ShowToolTips = false,
                WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring,
                Dock = DockStyle.Fill,
                Visible = false
            };
            ctrlLoad.BringToFront();

            // Передаем значение делегата в событие (frmMain)
            dapDocument = ntp;
            docFilterDbPanel.SetDelegate(GetFilter);

            tsmiMsSend_Group.Enabled = false;
            tsmiMsGet_Group.Enabled = false;
        }

        //===================================================================================
        #region Документы
        private void GetFilter(DocFilterDb docFilter)
        {
            tsmiMsSend_Group.Enabled = true;
            tsmiMsGet_Group.Enabled = true;

            this.docFilter = docFilter;
            Refresh_Docs();
            tsmiGetOutcome_Group.Enabled = (this.docFilter.Direction == -1);
            //tsmiGetCountragentInfo.Enabled = (this.docFilter.Direction == 1);
        }

        /// <summary>
        /// Обновляет список документов
        /// </summary>
        private async void Refresh_Docs()
        {
            ctrlLoad.Visible = true;
            docFilterDbPanel.Enabled = false;
            msDocs.Enabled = false;

            await Task.Run(() =>
            {
                List<int> handleSelected = new List<int>();
                if (Docs != null && tsmiSetting_Selected.Checked)
                {
                    foreach (DataRow row in Docs.Rows)
                    {
                        if ((int)row["HANDLE_SELECT"] == 1)
                            handleSelected.Add((int)row["ID"]);
                    }
                }

                Docs = DAO.GetDocumentByFilter(
                Sys.Global.USER_ID,
                docFilter.FromDate,
                docFilter.ToDate,
                docFilter.Direction,
                0,
                docFilter.Counteragent,
                docFilter.DocumentType
                );

                if (Docs.Rows.Count > 0 && tsmiSetting_Selected.Checked)
                {
                    foreach (int item in handleSelected)
                    {
                        foreach (DataRow row in Docs.Rows)
                        {
                            if ((int)row["ID"] == item)
                                row["HANDLE_SELECT"] = 1;
                        }
                    }
                }
            });
            cDocs.DataSource = Docs;
            try
            {
                int cntAccepted = 0;
                foreach (DataRow row in Docs.Rows)
                {
                    if (row["TICKET_RESULT"].ToString() == "Accepted")
                        cntAccepted++;
                }
                vDocs.ViewCaption = $"Документы по схеме {docFilter.DocumentType}, Accepted: {cntAccepted} из {Docs.Rows.Count} | [{docFilter.FromDate.ToShortDateString()} - {docFilter.ToDate.ToShortDateString()}]";
            }
            catch (Exception ex)
            { }
            //vDocs.Columns["REQUEST_ID"].Group();

            docFilterDbPanel.Enabled = true;
            ctrlLoad.Visible = false;
            msDocs.Enabled = true;
        }

        /// <summary>
        /// Выбрать текущий документ (на котором сейчас стоит курсор)
        /// </summary>
        private void SelectDoc()
        {
            string xmlBody = "";
            int id = 0;

            try
            {
                DataRow row = vDocs.GetDataSourceRow();
                xmlBody = row["DOC_BODY"].ToString();
                id = Convert.ToInt32(row["ID"]);

                // Открываем вкладку
                // Вызываем событие по делегату
                dapDocument(new DocumentView(id, dapDocument));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
        #endregion
        #region Меню и кнопки
        public event OnWorkIsDoneHandler OnWorkIsDone; // Событие окна: завершение потока чтения.
        private void SendDoc(object sender, EventArgs e)
        {
            List<DataRow> SelectedRows = vDocs.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
            if (SelectedRows.Count == 0)
            {
                MessageBox.Show("Ничего не выбрано. Необходимо поставить галочку на документе!");
                return;
            }

            //System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(() => 
            {
                using (frmProccess process = new frmProccess())
                {
                    process.progressBarControl.Properties.Maximum = SelectedRows.Count();
                    process.Show();
                    Application.DoEvents();
                    foreach (DataRow row in SelectedRows)
                    {
                        try
                        {
                            int doc_id = (int)row["ID"];
                            string doc_body = DAO.GetDocBody(doc_id);
                            if (!string.IsNullOrEmpty(doc_body))
                            {
                                // 5.1 Отправка документа
                                WebMethods.DocumentSend(doc_body, doc_id, false);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        process.progressBarControl.Position++;
                        Application.DoEvents();
                    }
                    process.Close();
                    OnWorkIsDone?.Invoke(this, EventArgs.Empty);
                    cDocs.Invoke(new DelegateVoid(Refresh_Docs));
                }
            }
            //    }));
            //readThread.Start();
        }

        private void SendDocLarge(object sender, EventArgs e)
        {
            List<DataRow> SelectedRows = vDocs.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
            if (SelectedRows.Count == 0)
            {
                MessageBox.Show("Ничего не выбрано. Необходимо поставить галочку на документе!");
                return;
            }

            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            {
                using (frmProccess process = new frmProccess())
                {
                    process.progressBarControl.Properties.Maximum = SelectedRows.Count();
                    process.Show();
                    Application.DoEvents();
                    foreach (DataRow row in SelectedRows)
                    {
                        try
                        {
                            // 5.2 Отправка документа большого объема
                            WebMethods.DocumentSendLarge(row["DOC_BODY"].ToString(), Int32.Parse(row["id"].ToString()));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        process.progressBarControl.Position++;
                        Application.DoEvents();
                    }
                    process.Close();
                    OnWorkIsDone?.Invoke(this, EventArgs.Empty);
                    cDocs.Invoke(new DelegateVoid(Refresh_Docs));
                }
            }));
            readThread.Start();
        }
        private void LoadDocLarge(object sender, EventArgs e)
        {
            List<DataRow> SelectedRows = vDocs.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
            if (SelectedRows.Count == 0)
            {
                MessageBox.Show("Ничего не выбрано. Необходимо поставить галочку на документе!");
                return;
            }

            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            {
                using (frmProccess process = new frmProccess())
                {
                    process.progressBarControl.Properties.Maximum = SelectedRows.Count();
                    process.Show();
                    Application.DoEvents();
                    foreach (DataRow row in SelectedRows)
                    {
                        try
                        {
                            MessageBox.Show("В разработке");
                            break;
                            // 5.3 Загрузка документа большого объема
                            //WebMethods.DocumentLoadLarge(row["DOC_BODY"].ToString());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        process.progressBarControl.Position++;
                        Application.DoEvents();
                    }
                    process.Close();
                    OnWorkIsDone?.Invoke(this, EventArgs.Empty);
                    cDocs.Invoke(new DelegateVoid(Refresh_Docs));
                }
            }));
            readThread.Start();
        }
        private void GetDoc(object sender, EventArgs e)
        {
            List<DataRow> SelectedRows = vDocs.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
            if (SelectedRows.Count == 0)
            {
                MessageBox.Show("Ничего не выбрано. Необходимо поставить галочку на документе!");
                return;
            }

            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            {
                using (frmProccess process = new frmProccess())
                {
                    process.progressBarControl.Properties.Maximum = SelectedRows.Count();
                    process.Show();
                    Application.DoEvents();
                    foreach (DataRow row in SelectedRows)
                    {
                        try
                        {
                            // 5.10 Получение документа по идентификатору
                            WebMethods.DocumentGetDoc(row["DOCUMENT_ID"].ToString(), false);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        process.progressBarControl.Position++;
                        Application.DoEvents();
                    }
                    process.Close();
                    OnWorkIsDone?.Invoke(this, EventArgs.Empty);
                    cDocs.Invoke(new DelegateVoid(Refresh_Docs));
                }
            }));
            readThread.Start();
        }
        private void GetTiket(object sender, EventArgs e)
        {
            List<DataRow> SelectedRows = vDocs.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
            if (SelectedRows.Count == 0)
            {
                MessageBox.Show("Ничего не выбрано. Необходимо поставить галочку на документе!");
                return;
            }

            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            {
                using (frmProccess process = new frmProccess())
                {
                    process.progressBarControl.Properties.Maximum = SelectedRows.Count();
                    process.Show();
                    Application.DoEvents();
                    foreach (DataRow row in SelectedRows)
                    {
                        try
                        {
                            // 5.12 Получение квитанции по номеру исходящего документа
                            WebMethods.DocumentGetTiket(row["DOCUMENT_ID"].ToString(), (int)row["id"], false);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        process.progressBarControl.Position++;
                        Application.DoEvents();
                    }
                    process.Close();
                    OnWorkIsDone?.Invoke(this, EventArgs.Empty);
                    cDocs.Invoke(new DelegateVoid(Refresh_Docs));
                }
            }));
            readThread.Start();
        }
        private void GetMetadata(object sender, EventArgs e)
        {
            List<DataRow> SelectedRows = vDocs.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
            if (SelectedRows.Count == 0)
            {
                MessageBox.Show("Ничего не выбрано. Необходимо поставить галочку на документе!");
                return;
            }
            
            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            {
                using (frmProccess process = new frmProccess())
                {
                    process.progressBarControl.Properties.Maximum = SelectedRows.Count();
                    process.Show();
                    Application.DoEvents();
                    foreach (DataRow row in SelectedRows)
                    {
                        try
                        {
                            // 5.9. Получение метаданных документа
                            WebMethods.DocumentGetMetadata(row["DOCUMENT_ID"].ToString(), (int)row["DIRECT"], false);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        process.progressBarControl.Position++;
                        Application.DoEvents();
                    }
                    process.Close();
                    OnWorkIsDone?.Invoke(this, EventArgs.Empty);
                    cDocs.Invoke(new DelegateVoid(Refresh_Docs));
                }
            }));
            readThread.Start();
        }
        private void получениеСпискаДокументовПоИдентификаторуЗапросаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<DataRow> SelectedRows = vDocs.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
            if (SelectedRows.Count == 0)
            {
                MessageBox.Show("Ничего не выбрано. Необходимо поставить галочку на документе!");
                return;
            }

            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            {
                using (frmProccess process = new frmProccess())
                {
                    process.progressBarControl.Properties.Maximum = SelectedRows.Count();
                    process.Show();
                    Application.DoEvents();
                    foreach (DataRow row in SelectedRows)
                    {
                        try
                        {
                            // 5.11 Получение списка документов по идентификатору запроса
                            WebMethods.DocumentGetListByRequestId(row["REQUEST_ID"].ToString(), (int)row["id"]);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        process.progressBarControl.Position++;
                        Application.DoEvents();
                    }
                    process.Close();
                    OnWorkIsDone?.Invoke(this, EventArgs.Empty);
                    cDocs.Invoke(new DelegateVoid(Refresh_Docs));
                }
            }));
            readThread.Start();
        }
        private void получениеЭлектроннойПодписиИсходящегоДокументаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<DataRow> SelectedRows = vDocs.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
            if (SelectedRows.Count == 0)
            {
                MessageBox.Show("Ничего не выбрано. Необходимо поставить галочку на документе!");
                return;
            }

            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            {
                using (frmProccess process = new frmProccess())
                {
                    process.progressBarControl.Properties.Maximum = SelectedRows.Count();
                    process.Show();
                    Application.DoEvents();
                    foreach (DataRow row in SelectedRows)
                    {
                        try
                        {
                            // 5.13 Получить электронную подпись исходящего документа
                            WebMethods.DocumentGetECP(row["DOCUMENT_ID"].ToString());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        process.progressBarControl.Position++;
                        Application.DoEvents();
                    }
                    process.Close();
                    OnWorkIsDone?.Invoke(this, EventArgs.Empty);
                    cDocs.Invoke(new DelegateVoid(Refresh_Docs));
                }
            }));
            readThread.Start();
        }
        private void tsmiProcessXML_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("(!!!) Обработать входящие документы повторно? Это УДАЛИТ всю структуру документа (кроме сервисных документов) и обработает ее заново на основе полученного XML документа. Вы уверены?", "ВНИМАНИЕ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(() =>
                {
                    using (frmProccess process = new frmProccess())
                    {
                        int errCount = 0;
                        List<DataRow> SelectedRows = vDocs.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
                        process.progressBarControl.Properties.Maximum = SelectedRows.Count();
                        process.Show();
                        Application.DoEvents();
                        foreach (DataRow row in SelectedRows)
                        {
                            try
                            {
                                // Обработать все
                                //Sys.Global.Api.ProcessedXmlBody();

                                int direct = (int)row["DIRECT"];
                                int doc_type = (int)row["DOC_TYPE"];
                                int isDocBody = (int)row["IS_DOC_BODY"];
                                if (direct == 1 && isDocBody == 1)
                                {
                                    int doc_id = (int)row["ID"];
                                    string doc_body = Sys.Global.DataProvider.GetDocBody(doc_id);
                                    bool resDel = DAO.DelParseDoc(doc_id);    // Собрать документ по разобранному XML

                                    ProfitMedService.ParseXML parser = new ProfitMedService.ParseXML();
                                    DataTable parseTable = parser.CreateEDGETable();
                                    
                                    DataTable table = parser.ParseXmlToTable(doc_body);
                                    foreach (DataRow r in table.Rows)
                                    {
                                        r["doc_id"] = doc_id;
                                        r["doc_type"] = doc_type;
                                        parseTable.ImportRow(r);
                                    }
                                    Sys.Global.DataProvider.SaveXMLToTable(parseTable);
                                    bool resPrs = DAO.ParseXml(doc_id);    // Собрать документ по разобранному XML
                                }
                            }
                            catch (Exception ex)
                            {
                                errCount++;
                            }
                            process.progressBarControl.Position++;
                            Application.DoEvents();
                        }
                        if (errCount > 0)
                            MessageBox.Show("Выполнено с ошибками: " + errCount.ToString());
                        else
                            MessageBox.Show("Выполнено");
                        process.Close();
                        //OnWorkIsDone?.Invoke(this, EventArgs.Empty);
                        cDocs.Invoke(new DelegateVoid(Refresh_Docs));
                    }
                };
                //}));
                //readThread.Start();
            }
        }

        private void tsmiDocToXml_Click(object sender, EventArgs e)
        {
            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            {
                using (frmProccess process = new frmProccess())
                {
                    //List<DataRow> SelectedRows = vDocs.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
                    //process.progressBarControl.Properties.Maximum = SelectedRows.Count();
                    //process.Show();
                    //Application.DoEvents();
                    //foreach (DataRow row in SelectedRows)
                    {
                        try
                        {
                            Sys.Global.Api.ProcessedDocXml();

                            //MessageBox.Show("Выполнено");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка! " + ex.Message);
                        }
                        //process.progressBarControl.Position++;
                        Application.DoEvents();
                    }
                    process.Close();
                    OnWorkIsDone?.Invoke(this, EventArgs.Empty);
                    cDocs.Invoke(new DelegateVoid(Refresh_Docs));
                }
            }));
            readThread.Start();
        }
        #endregion

        private void tsmiGetCountragentInfo_Click(object sender, EventArgs e)
        {
            List<DataRow> SelectedRows = vDocs.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
            if (SelectedRows.Count == 0)
            {
                MessageBox.Show("Ничего не выбрано. Необходимо поставить галочку на документе!");
                return;
            }

            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            {
                using (frmProccess process = new frmProccess())
                {
                    process.progressBarControl.Properties.Maximum = SelectedRows.Count();
                    process.Show();
                    Application.DoEvents();
                    foreach (DataRow row in SelectedRows)
                    {
                        try
                        {
                            string sys_id = row["sender_sys_id"].ToString();
                            WebMethods.GetCounteragentInfoBySysId(sys_id);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        process.progressBarControl.Position++;
                        Application.DoEvents();
                    }                    
                    process.Close();
                    OnWorkIsDone?.Invoke(this, EventArgs.Empty);
                    cDocs.Invoke(new DelegateVoid(Refresh_Docs));
                }
            }));
            readThread.Start();
        }

        private void создатьДочернийДокументToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCreateChildDocument frm = new frmCreateChildDocument();
            frm.ShowDialog();
        }

        private void связатьДокументСTW4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = vDocs.GetDataSourceRow();
            if (row == null)
            {
                MessageBox.Show("Не выбран документ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = Convert.ToInt32(row["ID"]);

            frmDocumentLinkToTW4 frm = new frmDocumentLinkToTW4(id);
            frm.ShowDialog();
        }

        private void tsmiAction_CreateDocument_Click(object sender, EventArgs e)
        {
            List<int> docs_id = new List<int>();
            List<DataRow> SelectedRows = vDocs.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
            foreach (DataRow row in SelectedRows)
            {
                try
                {
                    if ((int)row["DOC_TYPE"] != 617)
                        continue;
                    docs_id.Add((int)row["ID"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (docs_id.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одного документа типа 617", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmCreateDocument frm = new frmCreateDocument(docs_id);
            frm.ShowDialog();
        }

        private void tsmiAction_CreateDocumentOutcome_Click(object sender, EventArgs e)
        {
            frmCreateDocumentOutcome frm = new frmCreateDocumentOutcome();
            frm.ShowDialog();
        }

        private void DocumentsView_Load(object sender, EventArgs e)
        {
            OnWorkIsDone += OnWorkEnd;
        }

        private void OnWorkEnd(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнено!");
        }

        private void tsmiGetListIncomeDoc_Click(object sender, EventArgs e)
        {
            DocFilterDb filterPanel = docFilterDbPanel.GetFilter();
            DocFilters filters = new DocFilters();
            filters.filter = new DocFilter();
            filters.start_from = 0;
            filters.count = 100;
            filters.filter.start_date = filterPanel.FromDate.ToString("yyyy-MM-dd HH:mm:ss");
            filters.filter.end_date = filterPanel.ToDate.ToString("yyyy-MM-dd HH:mm:ss");
            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(ThreadGetListDocIncome));
            readThread.Start(filters);
        }

        private void ThreadGetListDocIncome(object filter)
        {
            DocFilters filters = (DocFilters)filter;
            using (frmProccess process = new frmProccess())
            {
                process.progressPanel.Description = "Получаем список документов...";
                process.Show();
                Application.DoEvents();

                process.Close();
                OnWorkIsDone?.Invoke(this, EventArgs.Empty);
                //tlSSCC.Invoke(new RefreshSscc(RefreshData));
            }
        }

        private void tsmiAction_CreateDocAccept_Click(object sender, EventArgs e)
        {
            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            {
                CreateOutcomeDocument("accept");
            }));
            readThread.Start();
        }

        private void CreateOutcomeDocument(string mode)
        {
            List<int> docs_id = new List<int>();
            List<DataRow> SelectedRows = vDocs.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
            foreach (DataRow row in SelectedRows)
            {
                try
                {
                    docs_id.Add((int)row["ID"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (docs_id.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одного документа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmCreateDocumentActions frm = new frmCreateDocumentActions(docs_id, mode);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (docs_id.Count == 1)
                {
                    if (frm.ResDocId > 0)
                    {
                        if (MessageBox.Show($"Создан документ № {frm.ResDocId}. Открыть его?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            dapDocument(new DocumentView(frm.ResDocId, this.dapDocument));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Документ не создан", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                if (docs_id.Count > 1)
                {
                    if (frm.ResDocsId.Count > 0)
                    {
                        if (MessageBox.Show($"Созданы документы. Открыть их?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            foreach (ParentAndChild pacDoc in frm.ResDocsId)
                            {
                                dapDocument(new DocumentView(pacDoc.child, this.dapDocument));
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ни один документ не создан", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void tsmiAction_CreateDocDecline_Click(object sender, EventArgs e)
        {
            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            {
                CreateOutcomeDocument("decline");
            }));
            readThread.Start();
        }

        private void vDocs_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                SelectDoc();
                vDocs.CloseEditor();
            }
        }

        private void tsmiGetSsccInfoFromDocByKIZ_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Получить информацию по коробкам из реестра КИЗ по выбранным документам?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(GetSsccInfoFromDocByKIZ));
                //readThread.Start();
                GetSsccInfoFromDocByKIZ();
            }
        }

        private void GetSsccInfoFromDocByKIZ()
        {
            List<int> docs_id = new List<int>();
            List<DataRow> SelectedRows = vDocs.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
            foreach (DataRow row in SelectedRows)
            {
                try
                {
                    if ((int)row["DOC_TYPE"] != 601)
                        continue;

                    docs_id.Add((int)row["ID"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (docs_id.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одного документа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (frmProccess process = new frmProccess())
            {
                process.Show();
                process.progressBarControl.Properties.Maximum = docs_id.Count;

                foreach (int doc_id in docs_id)
                {
                    DataTable SSCC = DAO.GetSsccList(doc_id);
                    if (SSCC.Rows.Count > 0)
                    {
                        List<string> ssccList = new List<string>();
                        foreach (DataRow row in SSCC.Rows)
                        {
                            string sscc = row["SSCC"].ToString();
                            if (!ssccList.Contains(sscc))
                                ssccList.Add(sscc);
                        }
                        Additional.dGetInfoByKIZ += () => {
                            process.progressBarControl.Position++;
                            Application.DoEvents();
                        };
                        Additional.GetInfoByKIZ(doc_id, ssccList);
                    }

                    process.progressBarControl.Position++;
                }

                process.Close();
                MessageBox.Show("Выполнено. Список данных будет обновлен.");
                Refresh_Docs();
            }
        }

        private void tsmiSelect_All_Click(object sender, EventArgs e)
        {
            tsmiSelect_Unselect_Click(null, null);
            foreach (DataRow row in vDocs.GetFilteredRows())
            {
                row["HANDLE_SELECT"] = 1;
            }
        }

        private void tsmiSelect_Unselect_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in (cDocs.DataSource as DataTable).Rows)
            {
                row["HANDLE_SELECT"] = 0;
            }
        }

        private void tsmiAction_CreateDocMove_Click(object sender, EventArgs e)
        {
            //System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            //{
                CreateDocumentMove();
            //}));
            //readThread.Start();            
        }

        private void CreateDocumentMove()
        {
            List<int> docs_id = new List<int>();
            List<DataRow> SelectedRows = vDocs.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
            foreach (DataRow row in SelectedRows)
            {
                try
                {
                    docs_id.Add((int)row["ID"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (docs_id.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одного документа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int cnt = 0;
            if (MessageBox.Show("Вы уверены, что хотите выполнить перемещение документа?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataTable data = new DataTable();
                data.Columns.Add("OBJECT", typeof(string));

                // Передавать строго паренты коробок (верхний уровень) (самый-самый верхний)
                DataTable dtWHS = DAO.GetWhsByBid();
                RefRes refRes = Sys.Global.GetRef(dtWHS, "Адрес склада", "ID", "NAME");
                if (refRes.DResult != DialogResult.OK)
                {
                    MessageBox.Show("Операция отменена", "ВНИМАНИЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (int doc_id in docs_id)
                {
                    try
                    {
                        Additional.MoveDocBody("Document", doc_id, data, refRes);
                        cnt++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show($"Документы перемещения созданы для {cnt} документов.");
                if (cnt > 0)
                    Refresh_Docs();
            }
        }

        private void tsmiAction_DisbambedBoxes_Click(object sender, EventArgs e)
        {
            DisbambedSscc();
        }

        private void DisbambedSscc()
        {
            if (MessageBox.Show("Вы уверены, что хотите выполнить расформирование коробок верхнего уровня?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            List<int> docs_id = new List<int>();
            List<DataRow> SelectedRows = vDocs.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
            foreach (DataRow row in SelectedRows)
            {
                try
                {
                    docs_id.Add((int)row["ID"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (docs_id.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одного документа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (frmProccess process = new frmProccess())
            {
                process.Show();
                process.progressBarControl.Properties.Maximum = docs_id.Count;

                foreach (int doc_id in docs_id)
                {
                    DataTable res = DAO.GetSsccNoDisbambed(doc_id);
                    foreach (DataRow row in res.Rows)
                    {
                        int res_doc_id = DAO.CreateOutcomeDocument(doc_id, 912, null, row["SSCC"].ToString(), null, null, 1);
                        WebMethods.DocumentSend(Sys.Global.DataProvider.GetDocBody(res_doc_id), res_doc_id, false);                        
                    }
                    process.progressBarControl.Position++;
                    Application.DoEvents();
                }

                process.Close();
                MessageBox.Show("Выполнено. Список данных будет обновлен.");
                Refresh_Docs();
            }
        }

        private void tsmiAction_CreateNewDocument_Click(object sender, EventArgs e)
        {
            dapDocument(new CreateDocumentView());
        }

        private void действияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmiAction_IsOk_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Пометить выбранные документы как \"Отработанный\"?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            List<int> docs_id = new List<int>();
            List<DataRow> SelectedRows = vDocs.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
            foreach (DataRow row in SelectedRows)
            {
                try
                {
                    docs_id.Add((int)row["ID"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (docs_id.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одного документа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (frmProccess process = new frmProccess())
            {
                process.Show();
                process.progressBarControl.Properties.Maximum = docs_id.Count;

                foreach (int doc_id in docs_id)
                {
                    bool res = DAO.DocSetIsOk(doc_id, 1);
                    process.progressBarControl.Position++;
                    Application.DoEvents();
                }

                process.Close();
                MessageBox.Show("Выполнено. Список данных будет обновлен.");
                Refresh_Docs();
            }
        }

        private void tsmiAction_Description_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Изменить примечание к текущему документу документу?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            int doc_id = 0;
            string desc = "";
            try
            {
                DataRow row = vDocs.GetDataSourceRow();
                doc_id = (int)row["ID"];
                desc = row["DESCRIPTION"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string msg = "";
            using (frmTextBox frm = new frmTextBox("Введите примечание", "Примечание", desc))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    msg = frm.Data;
                }
            }

            using (frmProccess process = new frmProccess())
            {
                process.Show();
                process.progressBarControl.Properties.Maximum = 1;

                try
                {
                    bool res = DAO.DocSetDescription(doc_id, msg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                process.Close();
                MessageBox.Show("Выполнено. Список данных будет обновлен.");
                Refresh_Docs();
            }
        }

        private void удалитьСвязкуДокументаСTW4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить связку выбранных документов МДЛП и TW4?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            List<int> docs_id = new List<int>();
            List<DataRow> SelectedRows = vDocs.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
            foreach (DataRow row in SelectedRows)
            {
                try
                {
                    docs_id.Add((int)row["ID"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (docs_id.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одного документа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (frmProccess process = new frmProccess())
            {
                process.Show();
                process.progressBarControl.Properties.Maximum = docs_id.Count;

                foreach (int doc_id in docs_id)
                {
                    bool res = DAO.DocumentSetLinkDid(doc_id, 0);
                    process.progressBarControl.Position++;
                    Application.DoEvents();
                }

                process.Close();
                MessageBox.Show("Выполнено. Список данных будет обновлен.");
                Refresh_Docs();
            }
        }

        private void обработатьКоробкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProccess process = new frmProccess();
            DataRow[] rows = (cDocs.DataSource as DataTable).Select("handle_select = 1 and doc_type = 220");

            process.progressBarControl.Properties.Maximum = rows.Count();
            process.Show();

            process.progressPanel.Description = "Подготавливаем таблицы ...";
            Application.DoEvents();
            //Sys.Global.DataProvider.DeleteTempSgtin((int)Doc["id"]);
            process.progressPanel.Description = "Отключаем индексы...";
            Application.DoEvents();
            Sys.Global.DataProvider.ChangeIndexStatus("TBL_SGTIN_INFO_TMP", 0);

            process.progressPanel.Description = "Сохраняем коробки...";
            Application.DoEvents();
            foreach (DataRow row in rows)
            {
                #region Подготовка
                string xmlTicketBody = "";
                Sys.Global.DataProvider.DeleteTempSgtin((int)row["parent"]);
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
                    GetChildsSscc(ref sscc_info, parent, 1, row["sender_sys_id"].ToString());
                    if (sscc_info.Count > 0)
                        Sys.Global.DataProvider.SaveSsccInfo(sscc_info, (int)row["parent"]);
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
                        MessageBox.Show("Сохранение SSCC", exx.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto TEnd;
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
                        Sys.Global.DataProvider.SaveSgtinInfoTmp(info_sgtin, (int)row["parent"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сохранение SGTIN", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto TEnd;
                }
                #endregion

                // Меняем статус документа на "Ответ обработан"
                Sys.Global.DataProvider.ChangeDocResult((int)row["id"], 2005);
                // Сохраняем информацию об SGTIN (с очисткой временной таблицы)
                Sys.Global.DataProvider.SaveSgtinInfo();

                process.progressBarControl.Position++;
                Application.DoEvents();
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
        }

        private void GetChildsSscc(ref List<SsccInfo> sscc_info, XmlNode parent_node, int level, string sender_sys_id)
        {
            XmlNodeList childs_node = parent_node.SelectNodes("//sscc_info");
            string parent_value = parent_node.ParentNode.SelectSingleNode("sscc").InnerText ?? String.Empty;
            int i = level++;
            foreach (XmlNode node in childs_node)
            {
                if (node.ParentNode == parent_node)
                {
                    SsccInfo ssccInfo = new SsccInfo();
                    ssccInfo.sscc = node.SelectSingleNode("sscc").InnerText;
                    ssccInfo.level = level;
                    ssccInfo.release_date = node.SelectSingleNode("packing_date").InnerText;
                    ssccInfo.parent_sscc = parent_value;
                    ssccInfo.system_subj_id = sender_sys_id;
                    ssccInfo.status = 1;
                    sscc_info.Add(ssccInfo);

                    GetChildsSscc(ref sscc_info, node.SelectSingleNode("childs"), i, sender_sys_id);
                }
            }

        }
    }
}
