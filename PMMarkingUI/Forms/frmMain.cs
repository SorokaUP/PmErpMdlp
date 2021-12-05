using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml;
using System.IO;
using System.Drawing;

using PMMarkingUI.Views;
using PMMarkingUI.Forms;
using PMMarkingUI.Delegats;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;


namespace PMMarkingUI
{
    public partial class frmMain : Form
    {
        public event OnWorkIsDoneHandler OnWorkIsDone; // Событие окна: завершение потока

        public frmMain()
        {
            InitializeComponent();
            FormShow();
        }

        private void SetBackground(Control ctrl, bool isVisible = true)
        {
            background = new Label();
            background.Parent = ctrl;
            background.Dock = DockStyle.Fill;
            background.TextAlign = ContentAlignment.MiddleCenter;
            background.Text = "Подождите, данные подготавливаются...";
            background.Font = new Font(background.Font.FontFamily, 14);
            background.Visible = isVisible;
            background.BringToFront();
        }

        Label background = new Label();
        private void FormShow()
        {
            this.Show();
            tslUserLogin.Text = "Пользователь: " + Sys.Global.USER_LOGIN;
            tslVersion.Text = "Версия: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            Sys.Global.dTokenChange += TokenChange;
            //timerMain_Tick(this, null);
            TokenChange();

            SetBackground(this, false);
            //AddPage(new Views.Documents.HandleCreateDocBody.CreateDocBody415View());

            if (Sys.Global.USER_LOGIN == "USER")
            {
                tsmiMenu_Counteragents.Visible = false;
                tsmiMenu_DocumentsForAgencyContract.Visible = false;
                tsmiMenu_TWDocutentList.Visible = false;
                tsmiMenu_GetDocutentsFromMdlp.Visible = false;
                tsmiMenu_BadSscc.Visible = false;

                tsmiAdmin_Test.Visible = false;
                tsmiAdmin_Root.Visible = false;
            }

            ProfitMed.Firebird.Global.eventRunConnectMdlp += RestartDbSession;
        }

        /// <summary>
        /// Переотрисовка токена
        /// </summary>
        private void TokenChange()
        {
            tslToken.ForeColor = SystemColors.ControlText;
            tslToken.Text = "Токен: " + Sys.Global.TOKEN_DATE.ToString("dd.MM.yyyy HH:mm");            
        }

        #region Вкладки        
        /// <summary>
        /// Добавление вкладки на панель вкладок
        /// </summary>
        /// <param name="view"></param>
        public void AddPage(Control view)
        {
            bool isDoc = new string[] { "DocumentView", "TWDocumentView" }.Contains(view.GetType().Name);
            bool isCounteragent = new string[] { "CounteragentView" }.Contains(view.GetType().Name);
            try
            {
                bool isOne = false;                
                try
                {
                    isOne = Convert.ToBoolean(view.Tag);
                }
                catch { isOne = false; }                
                
                // Строго один экземпляр, если указан Tag как TRUE
                if (isOne || isDoc || isCounteragent)
                {
                    foreach (XtraTabPage p in xtcPages.TabPages)
                    {
                        foreach (Control c in p.Controls)
                        {
                            if (c.Name == view.Name)
                            {
                                bool isDocDiff = false;
                                if (isDoc)
                                {
                                    try
                                    {
                                        isDocDiff = Convert.ToInt32(c.Tag) == Convert.ToInt32(view.Tag);
                                    }
                                    catch { isDocDiff = false; }
                                }

                                // -----------------------------------------------

                                bool isCounteragentDiff = false;
                                if (isCounteragent)
                                {
                                    try
                                    {
                                        isCounteragentDiff = Convert.ToInt32(c.Tag) == Convert.ToInt32(view.Tag);
                                    }
                                    catch { isCounteragentDiff = false; }
                                }

                                // Не открываем еще один экземпляр вкладки, если
                                if (
                                    (!isDoc && !isCounteragent) ||              // Это не документ или контрагент
                                    (isDoc && isDocDiff) ||                     // Это документ и экземпляр существует
                                    (isCounteragent && isCounteragentDiff)      // Это контрагент и экземпляр существует
                                   )
                                {
                                    view.Dispose();
                                    xtcPages.SelectedTabPage = p;
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            catch { }

            XtraTabPage page = new XtraTabPage
            {
                Name = "page",
                Text = view.Text
            };

            xtcPages.TabPages.Add(page);
            xtcPages.SelectedTabPage = page;

            view.Parent = page;
            view.Dock = DockStyle.Fill;

            SetBackground(page);            
            Application.DoEvents();

            if (isDoc)
            {
                try
                {
                    if (view is DocumentView)
                        (view as DocumentView).ViewShow();
                    if (view is TWDocumentView)
                        (view as TWDocumentView).ViewShow();

                    page.Text = view.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    xtcPages.TabPages.Remove(page);
                    return;
                }
            }

            background.Visible = false;
        }

        /// <summary>
        /// Закрыть вкладку
        /// </summary>
        /// <param name="index"></param>
        private void RemovePage(int index)
        {
            for (int i = xtcPages.TabPages[index].Controls.Count - 1; i >= 0; i--)
                xtcPages.TabPages[index].Controls[i].Dispose();
            xtcPages.TabPages.RemoveAt(index);
            GC.Collect();            
        }

        /// <summary>
        /// Закрыть вкладку
        /// </summary>
        /// <param name="page"></param>
        private void RemovePage(XtraTabPage page)
        {
            for (int i = page.Controls.Count - 1; i >= 0; i--)
                page.Controls[i].Dispose();
            xtcPages.TabPages.Remove(page);
            GC.Collect();
        }

        #region Список вкладок
        private void xtcPages_CustomHeaderButtonClick(object sender, CustomHeaderButtonEventArgs e)
        {
            // Вывод списка всех вкладок в ListBox справа на форме
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
            {
                ListBox listPages = new ListBox();
                listPages.Parent = this;
                listPages.BringToFront();
                listPages.Width = 250;
                listPages.Dock = DockStyle.Right;

                int i = 0;
                foreach (XtraTabPage p in xtcPages.TabPages)
                {
                    i++;
                    listPages.Items.Add($"[{i}] {p.Text}"); // + Вкладки
                }

                // Присваиваем фокус к элементу и настраиваем события
                listPages.Focus();
                listPages.Leave += ListBox_Leave;
                listPages.KeyDown += ListBox_KeyDown;
                listPages.DoubleClick += ListBox_DoubleClick;
            }
        }

        private void ListBox_Leave(object sender, EventArgs e)
        {
            (sender as ListBox).Dispose();
        }

        private void ListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListBox_SelectItem(sender);
            }
        }

        private void ListBox_DoubleClick(object sender, EventArgs e)
        {
            ListBox_SelectItem(sender);
        }

        private void ListBox_SelectItem(object sender)
        {
            ListBox listPages = sender as ListBox;
            try
            {
                string item = listPages.SelectedItem.ToString();
                // Определяем индекс вкладки по маске "[index] name"
                int indexPage = Convert.ToInt32(item.Substring(1, item.IndexOf(']') - 1)) - 1;
                xtcPages.SelectedTabPage = xtcPages.TabPages[indexPage];
            }
            catch { }
            listPages.Dispose();
        }
        #endregion
        #endregion
        #region Контекстное меню: Закрытие вкладок
        private void xtcPages_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            RemovePage((arg.Page as XtraTabPage));
            //((arg.Page as XtraTabPage).Parent as XtraTabControl).TabPages.Remove(arg.Page as XtraTabPage);
        }

        private void tsmiClosePage_Click(object sender, EventArgs e)
        {
            // Закрыть вкладку
            RemovePage(xtcPages.SelectedTabPage);
        }

        private void tsmiCloseRightPages_Click(object sender, EventArgs e)
        {
            // Закрыть все вкладки справа
            int cnt = xtcPages.TabPages.Count;
            int sel = xtcPages.SelectedTabPageIndex;

            try
            {
                cnt -= sel;
                if (cnt > 0)
                {
                    for (int i = 0; i < cnt; i++)
                    {
                        RemovePage(sel + 1);
                    }
                }
            }
            catch { }
        }

        private void tsmiCloseAllWithoutThisPage_Click(object sender, EventArgs e)
        {
            // Закрыть все вкладки кроме текущей
            int sel = xtcPages.SelectedTabPageIndex;
            int cnt = xtcPages.TabPages.Count;

            // Убираем вкладки слева от текущей
            if (sel > 0)
                for (int i = 0; i < sel; i++)
                    RemovePage(0);

            // Убираем вкладки справа от текущей
            if (sel < cnt)
                for (int i = sel + 1; i < cnt; i++)
                    RemovePage(1);
        }

        private void tsmiCloseAllPages_Click(object sender, EventArgs e)
        {
            // Закрыть все вкладки
            xtcPages.TabPages.Clear();
        }
        #endregion
        #region Горизонтальное меню: Пункты меню
        private void tsmiMenu_CounteragentAddressLinks_Click(object sender, EventArgs e)
        {
            AddPage(new CouteragentsAddressesLinksView());
        }
        private void tsmiMenu_DocutentList_Click(object sender, EventArgs e)
        {
            AddPage(new DocumentsView(AddPage));
        }
        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPage(new GoodsView(AddPage));
        }
        private void tsmiMenu_GetDocutentsFromMdlp_Click(object sender, EventArgs e)
        {
            AddPage(new GetDocumentsFromMdlpView());
        }
        private void tsmiMenu_TWDocutentList_Click(object sender, EventArgs e)
        {
            AddPage(new TWDocumentsView(AddPage));
        }
        private void tsmiMenu_TWDocutentList_rev2_Click(object sender, EventArgs e)
        {
            AddPage(new DocumentsForAgencyContract());
        }
        private void контрагентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPage(new CounteragentsView(AddPage));
        }
        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeUser();
        }
        #endregion

        private void xtcPages_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                for (int i = 0; i < xtcPages.TabPages.Count; ++i)
                {
                    Rectangle r = xtcPages.TabPages[i].ClientRectangle;
                    if (r.Contains(e.Location) /* && it is the header that was clicked*/)
                    {                        
                        cmsPages.Show(this, e.Location);
                        break;
                    }
                }
            }
            base.OnMouseUp(e);
        }

        private void ChangeUser()
        {
            if (MessageBox.Show("Вы уверены, что хотите сменить пользователя? Это приведет к закрытию открытых вкладок без сохранения!", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            this.Hide();
            if (new frmLogin().ShowDialog() == DialogResult.OK)
            {
                FormShow();
                xtcPages.TabPages.Clear();
                GC.Collect();
            }
            else
                this.Close();
        }

        private void tsmiAdmin_OpenDoc_Click(object sender, EventArgs e)
        {
            frmTextBox frm = new frmTextBox("Открыть документ", "ID документа по TBL_DOCUMENT");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int doc_id = Convert.ToInt32(frm.Data);
                    AddPage(new DocumentView(doc_id, AddPage));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            System.Threading.Thread readThread = new System.Threading.Thread(new System.Threading.ThreadStart(() =>
            {
                Sys.Global.RefreshToken();
                int TimeHasPassedMinutes = (int)Math.Abs((DateTime.Now - Sys.Global.TOKEN_DATE).TotalMinutes);
                if (TimeHasPassedMinutes >= (int)(Sys.Global.TOKEN_LIFE_TIME / 1.2))
                {
                    tslToken.ForeColor = Color.Red;
                }
            }));
            readThread.Start();
        }

        private void tsmiAdmin_SerchFromDocs_Click(object sender, EventArgs e)
        {
            AddPage(new SerchFromDocumentsView(AddPage));
        }

        private void поискSGTINПоМДЛПToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSgtinSerch frm = new frmSgtinSerch();
            frm.ShowDialog();
        }

        private void tsmiAdmin_SerchDocNum_Click(object sender, EventArgs e)
        {
            frmTextBoxDate frm = new frmTextBoxDate("Поиск 602 документа по номеру накладной", "Введите Номер докумекнта", "Введите Дату документа");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                List<object> resList = new List<object>();
                try
                {
                    System.Data.DataTable res = ProfitMed.Firebird.DAO.GetDoc602ByDocNum(frm.Data[0].ToString(), Convert.ToDateTime(frm.Data[1]));
                    foreach (System.Data.DataRow row in res.Rows)
                    {
                        resList.Add($"Номер документа: {row["DOC_NUM"].ToString()}");
                        resList.Add($"Дата документа: {row["DOC_DATE"].ToString()}");
                        resList.Add($"ID 602 документа: {row["DOC_ID"].ToString()}");
                        resList.Add($"Результат: {row["DOC_701_TICKET_RESULT"].ToString()}");
                    }
                }
                catch (Exception ex)
                { }
                frmStringList frmRes = new frmStringList(resList, $"Информация документу");
                frmRes.ShowDialog();
            }
        }

        int doMinutes = 30 * 60;
        int timeInnaction = 0;
        TimeSpan spWorkMin;
        private void timerDisconnect_Tick(object sender, EventArgs e)
        {            
            if (doMinutes == timeInnaction)
            {
                tsslTimerDisconnect.Text = $"Сессия окончена";
                tsslTimerDisconnect.ForeColor = Color.Red;
                ProfitMed.Firebird.Global.Connect().Close();

                timerDisconnect.Enabled = false;
                /*if (MessageBox.Show("Ваша сессия истекла. Хотите продолжить?", "ВНИМАНИЕ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    RestartDbSession();
                }*/
            }
            else
            {
                timeInnaction++;
                spWorkMin = TimeSpan.FromSeconds(doMinutes - timeInnaction);
                tsslTimerDisconnect.Text = $"До окончания сессии: {string.Format("{0:00}:{1:00}",(int)spWorkMin.Minutes, spWorkMin.Seconds)}";
            }
        }

        public void RestartDbSession()
        {
            tsStatus.Invoke((Action)delegate {
                timeInnaction = 0;
                tsslTimerDisconnect.ForeColor = Color.Black;
                if (!timerDisconnect.Enabled)
                    timerDisconnect.Enabled = true;
            });            
        }

        private void tsmiMenu_BadSscc_Click(object sender, EventArgs e)
        {
            AddPage(new Views.Documents.BadSsccView());
        }

        private void получитьСписокЗапущенныхПроцессовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process[] procList = System.Diagnostics.Process.GetProcesses();
            foreach (System.Diagnostics.Process process in procList)
            {
                if (process.ProcessName == "PMMarkingUI")
                {

                }
            }
            Console.WriteLine("");
        }

        private void tsmiAdmin_SerchByObjectList_Click(object sender, EventArgs e)
        {
            frmSerchByObjectList frm = new frmSerchByObjectList();
            frm.ShowDialog();
        }

        private void фиксНеЗатянутыхSGTINToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ОТКЛЮЧЕНО");
            return;
            ProfitMed.DataContract.SSFilter WebFilter = new ProfitMed.DataContract.SSFilter();
            int[] doc_ids = new int[] { 686195, 686195, 686195, 686195, 686195, 686195, 474794, 731434, 2367979, 45529, 42767, 2400428, 2400463, 80817, 2400566, 2400649, 429610, 230140, 692504, 2404949, 38456, 38458, 2489215, 2439169, 607593, 607705, 47956, 230166, 230166, 27643, 694657, 2451556, 1923068, 2471276, 1927777, 1935205, 2821284, 2821315, 512732, 1990383, 1990546, 1990571, 1991760, 1992640, 230415, 2469937, 693846, 295184, 712050, 32445, 636992, 1502911, 712157, 2470052, 2470053, 2470067, 692989, 47856, 2295172, 715398, 2302677, 2302702, 2302710, 2302951, 1553398, 1571659, 747668, 755178, 755190, 688066, 690154, 9020, 746317, 693172, 757072, 757083, 605405, 747992, 2452094, 683896, 153463, 711357, 279752, 686188, 686188, 296230, 15355, 15356, 7333, 44025, 44059, 417733, 613182, 14987, 109787, 11259, 14441, 14441, 394313, 48494, 101984, 8798, 48691, 48693, 575182, 575206, 575225, 2850708 };
            foreach (int doc_id in doc_ids)
            {
                try
                {
                    ProfitMed.DataContract.Sfilter Filter = new ProfitMed.DataContract.Sfilter();
                    Filter.sgtins = new List<string>();
                    DataTable sgtins = ProfitMed.Firebird.DAO.GetSgtinsWithoutBatch(doc_id);
                    foreach (DataRow row in sgtins.Rows)
                    {
                        Filter.sgtins.Add(row["SGTIN"].ToString());
                    }
                    WebFilter.filter = Filter;
                    ProfitMed.DataContract.PublicSgtinByList data = Sys.Global.WebMethod<ProfitMed.DataContract.PublicSgtinByList>(150, WebFilter);

                    DataSet ds = Sys.Global.DataProvider.ClassToDataSet(data.entries);
                    ds.Tables["PublicSgtin"].TableName = "sgtin";
                    ds.Tables["sgtin"].Columns.Add(new DataColumn("sscc_id", typeof(int)) { DefaultValue = 0 });
                    ds.Tables["sgtin"].Columns.Add(new DataColumn("doc_id", typeof(int)) { DefaultValue = doc_id });
                    ProfitMed.Firebird.DAO.SaveSgtin(ds);
                    DataTable res = ProfitMed.Firebird.DAO.Doc601SyncFlag(doc_id, 0);
                }
                catch (Exception ex)
                { }
            }

            MessageBox.Show("Выполнено");
        }

        private void ручнаяГенерацияТелаДокументаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPage(new Views.Documents.HandleCreateDocBody.CreateDocBodyUniversalView());
        }

        private void настройкиСканераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sys.Global.ScanerSet();
        }

        private void генерацияORDERDETAILToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPage(new GenerateXmlOrderDetailView());
        }

        private void справочникВебметодыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddPage(new WebMethodsView());
        }

        private void загрузитьXSDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcessingXSDSchema frmXsd = new frmProcessingXSDSchema();
            frmXsd.Show();
        }

        private void информацияОПодключенииToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<object> res = new List<object>();
            res.Add("База данных МДЛП: " + ProfitMed.Firebird.Global.Connect().DataSource + "   " + ProfitMed.Firebird.Global.Connect().Database);
            res.Add("База данных TW4: " + ProfitMed.Firebird.Global.ConnectTW().DataSource + "   " + ProfitMed.Firebird.Global.ConnectTW().Database);
            frmStringList frm = new frmStringList(res, "Информация о подключении");
            frm.ShowDialog();
        }

        private void распарситьОшибки617ДокументаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable doc617NonParse = ProfitMed.Firebird.DAO.GetDoc617NonParse();
            frmProccess process = new frmProccess();
            process.progressBarControl.Properties.Maximum = doc617NonParse.Rows.Count;
            process.Show();

            foreach (DataRow row in doc617NonParse.Rows)
            {
                int doc_id = (int)row["DOC_ID"];
                string XmlBody = "";// row["DOC_BODY"].ToString();
                DataTable bodys = ProfitMed.Firebird.DAO.GetXmlDocBody(doc_id);
                if (bodys.Rows.Count > 0)
                    XmlBody = bodys.Rows[0]["DOC_BODY"].ToString();


                if (!string.IsNullOrEmpty(XmlBody))
                {
                    XmlDocument xdoc = new XmlDocument();
                    try
                    {
                        xdoc.LoadXml(XmlBody);

                        XmlNodeList errors_nodes = xdoc.SelectNodes("//documents//order_details//errors");
                        List<ProfitMed.DataContract.Errors_service> errors = new List<ProfitMed.DataContract.Errors_service>();
                        foreach (XmlNode node in errors_nodes)
                        {
                            errors.Add(new ProfitMed.DataContract.Errors_service
                            {
                                error_code = node.SelectSingleNode("error_code").InnerText,
                                error_desc = node.SelectSingleNode("error_desc").InnerText,
                                object_id = node.SelectSingleNode("object_id").InnerText
                            });
                        }
                        if (errors.Count > 0)
                            Sys.Global.DataProvider.SaveTicketErrors(errors, doc_id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                process.progressBarControl.Properties.Maximum = 1;
            }

            process.Dispose();
            MessageBox.Show("Выполнено");
        }

        private void данныеОРГАНИЗАЦИИToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPage(new OrganizationsView());
        }

        private void получитьВсеКИЗНаходящиесяВКотельникахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ProfitMed.DataContract.SgtinsFilter WebFilter = new ProfitMed.DataContract.SgtinsFilter();
            //WebFilter.start_from = 0;
            //WebFilter.count = 10;
            //WebFilter.filter = new ProfitMed.DataContract.SgtinFilter();
            //WebFilter.filter.sys_id = "00000000172389";

            //List<object> resList = new List<object>();
            //ProfitMed.DataContract.SgtinByList resOrg = Sys.Global.WebMethod<ProfitMed.DataContract.SgtinByList>(148, WebFilter);
            //frmStringList frmRes = new frmStringList(resList, "Что лежит в Котельниках");
            //frmRes.ShowDialog();


            frmProccess process = new frmProccess();
            process.progressBarControl.Properties.Maximum = 0;
            process.Show();
            Application.DoEvents();
            try
            {   
                ProfitMed.DataContract.Filters<ProfitMed.DataContract.SgtinFilter> WebFilter = new ProfitMed.DataContract.Filters<ProfitMed.DataContract.SgtinFilter>
                {
                    filter = new ProfitMed.DataContract.SgtinFilter(),
                    start_from = 0,
                    count = 500
                };
                WebFilter.filter.sys_id = "00000000172389";
                WebFilter.filter.status = new List<string>();
                WebFilter.filter.status.Add("in_circulation");

                List<ProfitMed.DataContract.Sgtin> res = Sys.Global.WebMethodFiltered
                    <
                        ProfitMed.DataContract.SgtinFilter,
                        ProfitMed.DataContract.SgtinByList,
                        ProfitMed.DataContract.Sgtin
                    >(148, WebFilter);

                process.progressBarControl.Properties.Maximum = res.Count;
                Application.DoEvents();

                foreach (ProfitMed.DataContract.Sgtin item in res)
                {
                    ProfitMed.Firebird.DAO.Balance431_INS(item.pack3_id, item.sgtin, item.status);

                    process.progressBarControl.Position++;
                    Application.DoEvents();
                }

                MessageBox.Show("Выполнено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            process.Close();
        }

        private void tsmiMenu_GTD_Click(object sender, EventArgs e)
        {
            AddPage(new Views.Documents.GTDView(AddPage));
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (MessageBox.Show("Завершить работу с Интерфейсом Маркировки?", "Завершение работы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No);
        }

        private void webMethod000ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string res = Sys.Global.WebMethod000();
        }

        private void поискСпискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPage(new SerchObjectsInMdlpByListView());
        }

        private void анализДокументаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPage(new WhatWithDocView());
        }

        private void анализСпискаКоробокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPage(new SerchSsccInMdlpByListView());
        }

        private void получитьВсеКИЗНаходящиесяВСтатусеПринятНаСкладЗТКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProccess process = new frmProccess();
            process.progressBarControl.Properties.Maximum = 0;
            process.Show();
            Application.DoEvents();
            try
            {
                ProfitMed.DataContract.Filters<ProfitMed.DataContract.SgtinFilter> WebFilter = new ProfitMed.DataContract.Filters<ProfitMed.DataContract.SgtinFilter>
                {
                    filter = new ProfitMed.DataContract.SgtinFilter(),
                    start_from = 0,
                    count = 500
                };
                //WebFilter.filter.sys_id = "00000000172389";
                //WebFilter.filter.sys_id = "00000000146887";
                WebFilter.filter.status = new List<string>();
                WebFilter.filter.status.Add("declared_warehouse");

                List<ProfitMed.DataContract.Sgtin> res = Sys.Global.WebMethodFiltered
                    <
                        ProfitMed.DataContract.SgtinFilter,
                        ProfitMed.DataContract.SgtinByList,
                        ProfitMed.DataContract.Sgtin
                    >(148, WebFilter);

                process.progressBarControl.Properties.Maximum = res.Count;
                Application.DoEvents();

                foreach (ProfitMed.DataContract.Sgtin item in res)
                {
                    ProfitMed.Firebird.DAO.Balance431_INS(item.pack3_id, item.sgtin, item.status);

                    process.progressBarControl.Position++;
                    Application.DoEvents();
                }

                MessageBox.Show("Выполнено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            process.Close();
        }
    }
}
