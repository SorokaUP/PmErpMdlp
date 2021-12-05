namespace PMMarkingUI
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiMenu_Counteragents = new System.Windows.Forms.ToolStripMenuItem();
            this.контрагентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMenu_CounteragentAddressLinks = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMenu_Documents = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMenu_DocutentList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMenu_GTD = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiMenu_DocumentsForAgencyContract = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMenu_TWDocutentList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMenu_BadSscc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiMenu_GetDocutentsFromMdlp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdmin_OpenDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdmin_SerchFromDocs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdmin_SerchSgtinInMdlp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdmin_SerchDocNum = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdmin_SerchByObjectList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdmin_CreateDocumentHandle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAdmin_Test = new System.Windows.Forms.ToolStripMenuItem();
            this.получитьСписокЗапущенныхПроцессовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фиксНеЗатянутыхSGTINToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиСканераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.генерацияORDERDETAILToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получитьВсеКИЗНаходящиесяВКотельникахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webMethod000ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискСпискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализДокументаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализСпискаКоробокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получитьВсеКИЗНаходящиесяВСтатусеПринятНаСкладЗТКToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdmin_Root = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьXSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОПодключенииToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.распарситьОшибки617ДокументаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.справочникВебметодыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеОРГАНИЗАЦИИToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xtcPages = new DevExpress.XtraTab.XtraTabControl();
            this.cmsPages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiClosePage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCloseRightPages = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCloseAllWithoutThisPage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCloseAllPages = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStatus = new System.Windows.Forms.ToolStrip();
            this.tslUserLogin = new System.Windows.Forms.ToolStripLabel();
            this.tslVersion = new System.Windows.Forms.ToolStripLabel();
            this.tslToken = new System.Windows.Forms.ToolStripLabel();
            this.tsslTimerDisconnect = new System.Windows.Forms.ToolStripLabel();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.timerDisconnect = new System.Windows.Forms.Timer(this.components);
            this.ctrlPath1111 = new PMMarkingUI.ctrlPath111();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPages)).BeginInit();
            this.cmsPages.SuspendLayout();
            this.tsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMenu_Counteragents,
            this.tsmiMenu_Documents,
            this.администрированиеToolStripMenuItem,
            this.пользовательToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(684, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmiMenu_Counteragents
            // 
            this.tsmiMenu_Counteragents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.контрагентыToolStripMenuItem,
            this.tsmiMenu_CounteragentAddressLinks,
            this.товарыToolStripMenuItem});
            this.tsmiMenu_Counteragents.Image = global::PMMarkingUI.Properties.Resources.icon_info;
            this.tsmiMenu_Counteragents.Name = "tsmiMenu_Counteragents";
            this.tsmiMenu_Counteragents.Size = new System.Drawing.Size(110, 20);
            this.tsmiMenu_Counteragents.Text = "Справочники";
            // 
            // контрагентыToolStripMenuItem
            // 
            this.контрагентыToolStripMenuItem.Name = "контрагентыToolStripMenuItem";
            this.контрагентыToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.контрагентыToolStripMenuItem.Text = "Контрагенты";
            this.контрагентыToolStripMenuItem.Click += new System.EventHandler(this.контрагентыToolStripMenuItem_Click);
            // 
            // tsmiMenu_CounteragentAddressLinks
            // 
            this.tsmiMenu_CounteragentAddressLinks.Name = "tsmiMenu_CounteragentAddressLinks";
            this.tsmiMenu_CounteragentAddressLinks.Size = new System.Drawing.Size(173, 22);
            this.tsmiMenu_CounteragentAddressLinks.Text = "Адресные данные";
            this.tsmiMenu_CounteragentAddressLinks.Click += new System.EventHandler(this.tsmiMenu_CounteragentAddressLinks_Click);
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.товарыToolStripMenuItem.Text = "Товары";
            this.товарыToolStripMenuItem.Click += new System.EventHandler(this.товарыToolStripMenuItem_Click);
            // 
            // tsmiMenu_Documents
            // 
            this.tsmiMenu_Documents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMenu_DocutentList,
            this.tsmiMenu_GTD,
            this.toolStripMenuItem6,
            this.tsmiMenu_DocumentsForAgencyContract,
            this.tsmiMenu_TWDocutentList,
            this.tsmiMenu_BadSscc,
            this.toolStripMenuItem2,
            this.tsmiMenu_GetDocutentsFromMdlp,
            this.toolStripMenuItem5});
            this.tsmiMenu_Documents.Image = global::PMMarkingUI.Properties.Resources.icon_file;
            this.tsmiMenu_Documents.Name = "tsmiMenu_Documents";
            this.tsmiMenu_Documents.Size = new System.Drawing.Size(98, 20);
            this.tsmiMenu_Documents.Text = "Документы";
            // 
            // tsmiMenu_DocutentList
            // 
            this.tsmiMenu_DocutentList.Image = global::PMMarkingUI.Properties.Resources.icon_file;
            this.tsmiMenu_DocutentList.Name = "tsmiMenu_DocutentList";
            this.tsmiMenu_DocutentList.Size = new System.Drawing.Size(274, 22);
            this.tsmiMenu_DocutentList.Text = "Документы";
            this.tsmiMenu_DocutentList.Click += new System.EventHandler(this.tsmiMenu_DocutentList_Click);
            // 
            // tsmiMenu_GTD
            // 
            this.tsmiMenu_GTD.Image = global::PMMarkingUI.Properties.Resources.truck;
            this.tsmiMenu_GTD.Name = "tsmiMenu_GTD";
            this.tsmiMenu_GTD.Size = new System.Drawing.Size(274, 22);
            this.tsmiMenu_GTD.Text = "Таможенные документы";
            this.tsmiMenu_GTD.Click += new System.EventHandler(this.tsmiMenu_GTD_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(271, 6);
            // 
            // tsmiMenu_DocumentsForAgencyContract
            // 
            this.tsmiMenu_DocumentsForAgencyContract.Image = global::PMMarkingUI.Properties.Resources.icon_file2;
            this.tsmiMenu_DocumentsForAgencyContract.Name = "tsmiMenu_DocumentsForAgencyContract";
            this.tsmiMenu_DocumentsForAgencyContract.Size = new System.Drawing.Size(274, 22);
            this.tsmiMenu_DocumentsForAgencyContract.Text = "Документы по агентскому договору";
            this.tsmiMenu_DocumentsForAgencyContract.Click += new System.EventHandler(this.tsmiMenu_TWDocutentList_rev2_Click);
            // 
            // tsmiMenu_TWDocutentList
            // 
            this.tsmiMenu_TWDocutentList.Image = global::PMMarkingUI.Properties.Resources.icon_file2;
            this.tsmiMenu_TWDocutentList.Name = "tsmiMenu_TWDocutentList";
            this.tsmiMenu_TWDocutentList.Size = new System.Drawing.Size(274, 22);
            this.tsmiMenu_TWDocutentList.Text = "Документы TW4";
            this.tsmiMenu_TWDocutentList.Click += new System.EventHandler(this.tsmiMenu_TWDocutentList_Click);
            // 
            // tsmiMenu_BadSscc
            // 
            this.tsmiMenu_BadSscc.Image = global::PMMarkingUI.Properties.Resources.box2;
            this.tsmiMenu_BadSscc.Name = "tsmiMenu_BadSscc";
            this.tsmiMenu_BadSscc.Size = new System.Drawing.Size(274, 22);
            this.tsmiMenu_BadSscc.Text = "Коробки без содержимого";
            this.tsmiMenu_BadSscc.Click += new System.EventHandler(this.tsmiMenu_BadSscc_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(271, 6);
            // 
            // tsmiMenu_GetDocutentsFromMdlp
            // 
            this.tsmiMenu_GetDocutentsFromMdlp.Image = global::PMMarkingUI.Properties.Resources.action;
            this.tsmiMenu_GetDocutentsFromMdlp.Name = "tsmiMenu_GetDocutentsFromMdlp";
            this.tsmiMenu_GetDocutentsFromMdlp.Size = new System.Drawing.Size(274, 22);
            this.tsmiMenu_GetDocutentsFromMdlp.Text = "Получить документы";
            this.tsmiMenu_GetDocutentsFromMdlp.Click += new System.EventHandler(this.tsmiMenu_GetDocutentsFromMdlp_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(271, 6);
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdmin_OpenDoc,
            this.tsmiAdmin_SerchFromDocs,
            this.tsmiAdmin_SerchSgtinInMdlp,
            this.tsmiAdmin_SerchDocNum,
            this.tsmiAdmin_SerchByObjectList,
            this.tsmiAdmin_CreateDocumentHandle,
            this.toolStripMenuItem3,
            this.tsmiAdmin_Test,
            this.tsmiAdmin_Root});
            this.администрированиеToolStripMenuItem.Image = global::PMMarkingUI.Properties.Resources.action;
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            // 
            // tsmiAdmin_OpenDoc
            // 
            this.tsmiAdmin_OpenDoc.Name = "tsmiAdmin_OpenDoc";
            this.tsmiAdmin_OpenDoc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.tsmiAdmin_OpenDoc.Size = new System.Drawing.Size(311, 22);
            this.tsmiAdmin_OpenDoc.Text = "Открыть документ...";
            this.tsmiAdmin_OpenDoc.Click += new System.EventHandler(this.tsmiAdmin_OpenDoc_Click);
            // 
            // tsmiAdmin_SerchFromDocs
            // 
            this.tsmiAdmin_SerchFromDocs.Name = "tsmiAdmin_SerchFromDocs";
            this.tsmiAdmin_SerchFromDocs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.tsmiAdmin_SerchFromDocs.Size = new System.Drawing.Size(311, 22);
            this.tsmiAdmin_SerchFromDocs.Text = "Поиск по документам";
            this.tsmiAdmin_SerchFromDocs.Click += new System.EventHandler(this.tsmiAdmin_SerchFromDocs_Click);
            // 
            // tsmiAdmin_SerchSgtinInMdlp
            // 
            this.tsmiAdmin_SerchSgtinInMdlp.Name = "tsmiAdmin_SerchSgtinInMdlp";
            this.tsmiAdmin_SerchSgtinInMdlp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1)));
            this.tsmiAdmin_SerchSgtinInMdlp.Size = new System.Drawing.Size(311, 22);
            this.tsmiAdmin_SerchSgtinInMdlp.Text = "Поиск SGTIN по МДЛП";
            this.tsmiAdmin_SerchSgtinInMdlp.Click += new System.EventHandler(this.поискSGTINПоМДЛПToolStripMenuItem_Click);
            // 
            // tsmiAdmin_SerchDocNum
            // 
            this.tsmiAdmin_SerchDocNum.Name = "tsmiAdmin_SerchDocNum";
            this.tsmiAdmin_SerchDocNum.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2)));
            this.tsmiAdmin_SerchDocNum.Size = new System.Drawing.Size(311, 22);
            this.tsmiAdmin_SerchDocNum.Text = "Поиск накладной по номеру и дате";
            this.tsmiAdmin_SerchDocNum.Click += new System.EventHandler(this.tsmiAdmin_SerchDocNum_Click);
            // 
            // tsmiAdmin_SerchByObjectList
            // 
            this.tsmiAdmin_SerchByObjectList.Name = "tsmiAdmin_SerchByObjectList";
            this.tsmiAdmin_SerchByObjectList.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.tsmiAdmin_SerchByObjectList.Size = new System.Drawing.Size(311, 22);
            this.tsmiAdmin_SerchByObjectList.Text = "Поиск по списку объектов в базе";
            this.tsmiAdmin_SerchByObjectList.Click += new System.EventHandler(this.tsmiAdmin_SerchByObjectList_Click);
            // 
            // tsmiAdmin_CreateDocumentHandle
            // 
            this.tsmiAdmin_CreateDocumentHandle.Name = "tsmiAdmin_CreateDocumentHandle";
            this.tsmiAdmin_CreateDocumentHandle.Size = new System.Drawing.Size(311, 22);
            this.tsmiAdmin_CreateDocumentHandle.Text = "Ручная генерация тела документа";
            this.tsmiAdmin_CreateDocumentHandle.Click += new System.EventHandler(this.ручнаяГенерацияТелаДокументаToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(308, 6);
            // 
            // tsmiAdmin_Test
            // 
            this.tsmiAdmin_Test.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.получитьСписокЗапущенныхПроцессовToolStripMenuItem,
            this.фиксНеЗатянутыхSGTINToolStripMenuItem1,
            this.настройкиСканераToolStripMenuItem,
            this.генерацияORDERDETAILToolStripMenuItem,
            this.получитьВсеКИЗНаходящиесяВКотельникахToolStripMenuItem,
            this.webMethod000ToolStripMenuItem,
            this.поискСпискаToolStripMenuItem,
            this.анализДокументаToolStripMenuItem,
            this.анализСпискаКоробокToolStripMenuItem,
            this.получитьВсеКИЗНаходящиесяВСтатусеПринятНаСкладЗТКToolStripMenuItem});
            this.tsmiAdmin_Test.Image = global::PMMarkingUI.Properties.Resources.warning;
            this.tsmiAdmin_Test.Name = "tsmiAdmin_Test";
            this.tsmiAdmin_Test.Size = new System.Drawing.Size(311, 22);
            this.tsmiAdmin_Test.Text = "Тестирование";
            // 
            // получитьСписокЗапущенныхПроцессовToolStripMenuItem
            // 
            this.получитьСписокЗапущенныхПроцессовToolStripMenuItem.Name = "получитьСписокЗапущенныхПроцессовToolStripMenuItem";
            this.получитьСписокЗапущенныхПроцессовToolStripMenuItem.Size = new System.Drawing.Size(431, 22);
            this.получитьСписокЗапущенныхПроцессовToolStripMenuItem.Text = "Получить список запущенных процессов";
            this.получитьСписокЗапущенныхПроцессовToolStripMenuItem.Click += new System.EventHandler(this.получитьСписокЗапущенныхПроцессовToolStripMenuItem_Click);
            // 
            // фиксНеЗатянутыхSGTINToolStripMenuItem1
            // 
            this.фиксНеЗатянутыхSGTINToolStripMenuItem1.Name = "фиксНеЗатянутыхSGTINToolStripMenuItem1";
            this.фиксНеЗатянутыхSGTINToolStripMenuItem1.Size = new System.Drawing.Size(431, 22);
            this.фиксНеЗатянутыхSGTINToolStripMenuItem1.Text = "Фикс не затянутых SGTIN";
            this.фиксНеЗатянутыхSGTINToolStripMenuItem1.Click += new System.EventHandler(this.фиксНеЗатянутыхSGTINToolStripMenuItem1_Click);
            // 
            // настройкиСканераToolStripMenuItem
            // 
            this.настройкиСканераToolStripMenuItem.Name = "настройкиСканераToolStripMenuItem";
            this.настройкиСканераToolStripMenuItem.Size = new System.Drawing.Size(431, 22);
            this.настройкиСканераToolStripMenuItem.Text = "Настройки сканера";
            this.настройкиСканераToolStripMenuItem.Click += new System.EventHandler(this.настройкиСканераToolStripMenuItem_Click);
            // 
            // генерацияORDERDETAILToolStripMenuItem
            // 
            this.генерацияORDERDETAILToolStripMenuItem.Name = "генерацияORDERDETAILToolStripMenuItem";
            this.генерацияORDERDETAILToolStripMenuItem.Size = new System.Drawing.Size(431, 22);
            this.генерацияORDERDETAILToolStripMenuItem.Text = "Генерация ORDER_DETAIL";
            this.генерацияORDERDETAILToolStripMenuItem.Click += new System.EventHandler(this.генерацияORDERDETAILToolStripMenuItem_Click);
            // 
            // получитьВсеКИЗНаходящиесяВКотельникахToolStripMenuItem
            // 
            this.получитьВсеКИЗНаходящиесяВКотельникахToolStripMenuItem.Name = "получитьВсеКИЗНаходящиесяВКотельникахToolStripMenuItem";
            this.получитьВсеКИЗНаходящиесяВКотельникахToolStripMenuItem.Size = new System.Drawing.Size(431, 22);
            this.получитьВсеКИЗНаходящиесяВКотельникахToolStripMenuItem.Text = "Получить все КИЗ находящиеся в Котельниках";
            this.получитьВсеКИЗНаходящиесяВКотельникахToolStripMenuItem.Click += new System.EventHandler(this.получитьВсеКИЗНаходящиесяВКотельникахToolStripMenuItem_Click);
            // 
            // webMethod000ToolStripMenuItem
            // 
            this.webMethod000ToolStripMenuItem.Name = "webMethod000ToolStripMenuItem";
            this.webMethod000ToolStripMenuItem.Size = new System.Drawing.Size(431, 22);
            this.webMethod000ToolStripMenuItem.Text = "WebMethod000";
            this.webMethod000ToolStripMenuItem.Click += new System.EventHandler(this.webMethod000ToolStripMenuItem_Click);
            // 
            // поискСпискаToolStripMenuItem
            // 
            this.поискСпискаToolStripMenuItem.Name = "поискСпискаToolStripMenuItem";
            this.поискСпискаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F12)));
            this.поискСпискаToolStripMenuItem.Size = new System.Drawing.Size(431, 22);
            this.поискСпискаToolStripMenuItem.Text = "Поиск списка";
            this.поискСпискаToolStripMenuItem.Click += new System.EventHandler(this.поискСпискаToolStripMenuItem_Click);
            // 
            // анализДокументаToolStripMenuItem
            // 
            this.анализДокументаToolStripMenuItem.Name = "анализДокументаToolStripMenuItem";
            this.анализДокументаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F11)));
            this.анализДокументаToolStripMenuItem.Size = new System.Drawing.Size(431, 22);
            this.анализДокументаToolStripMenuItem.Text = "Анализ документа";
            this.анализДокументаToolStripMenuItem.Click += new System.EventHandler(this.анализДокументаToolStripMenuItem_Click);
            // 
            // анализСпискаКоробокToolStripMenuItem
            // 
            this.анализСпискаКоробокToolStripMenuItem.Name = "анализСпискаКоробокToolStripMenuItem";
            this.анализСпискаКоробокToolStripMenuItem.Size = new System.Drawing.Size(431, 22);
            this.анализСпискаКоробокToolStripMenuItem.Text = "Анализ списка коробок";
            this.анализСпискаКоробокToolStripMenuItem.Click += new System.EventHandler(this.анализСпискаКоробокToolStripMenuItem_Click);
            // 
            // получитьВсеКИЗНаходящиесяВСтатусеПринятНаСкладЗТКToolStripMenuItem
            // 
            this.получитьВсеКИЗНаходящиесяВСтатусеПринятНаСкладЗТКToolStripMenuItem.Name = "получитьВсеКИЗНаходящиесяВСтатусеПринятНаСкладЗТКToolStripMenuItem";
            this.получитьВсеКИЗНаходящиесяВСтатусеПринятНаСкладЗТКToolStripMenuItem.Size = new System.Drawing.Size(431, 22);
            this.получитьВсеКИЗНаходящиесяВСтатусеПринятНаСкладЗТКToolStripMenuItem.Text = "Получить все КИЗ находящиеся в статусе \"Принят на склад ЗТК\"";
            this.получитьВсеКИЗНаходящиесяВСтатусеПринятНаСкладЗТКToolStripMenuItem.Click += new System.EventHandler(this.получитьВсеКИЗНаходящиесяВСтатусеПринятНаСкладЗТКToolStripMenuItem_Click);
            // 
            // tsmiAdmin_Root
            // 
            this.tsmiAdmin_Root.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьXSDToolStripMenuItem,
            this.информацияОПодключенииToolStripMenuItem1,
            this.распарситьОшибки617ДокументаToolStripMenuItem,
            this.toolStripMenuItem4,
            this.справочникВебметодыToolStripMenuItem1,
            this.данныеОРГАНИЗАЦИИToolStripMenuItem});
            this.tsmiAdmin_Root.Image = global::PMMarkingUI.Properties.Resources.warning2;
            this.tsmiAdmin_Root.Name = "tsmiAdmin_Root";
            this.tsmiAdmin_Root.Size = new System.Drawing.Size(311, 22);
            this.tsmiAdmin_Root.Text = "ROOT";
            // 
            // загрузитьXSDToolStripMenuItem
            // 
            this.загрузитьXSDToolStripMenuItem.Name = "загрузитьXSDToolStripMenuItem";
            this.загрузитьXSDToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.загрузитьXSDToolStripMenuItem.Text = "Загрузить XSD";
            this.загрузитьXSDToolStripMenuItem.Click += new System.EventHandler(this.загрузитьXSDToolStripMenuItem_Click);
            // 
            // информацияОПодключенииToolStripMenuItem1
            // 
            this.информацияОПодключенииToolStripMenuItem1.Name = "информацияОПодключенииToolStripMenuItem1";
            this.информацияОПодключенииToolStripMenuItem1.Size = new System.Drawing.Size(267, 22);
            this.информацияОПодключенииToolStripMenuItem1.Text = "Информация о подключении";
            this.информацияОПодключенииToolStripMenuItem1.Click += new System.EventHandler(this.информацияОПодключенииToolStripMenuItem1_Click);
            // 
            // распарситьОшибки617ДокументаToolStripMenuItem
            // 
            this.распарситьОшибки617ДокументаToolStripMenuItem.Name = "распарситьОшибки617ДокументаToolStripMenuItem";
            this.распарситьОшибки617ДокументаToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.распарситьОшибки617ДокументаToolStripMenuItem.Text = "Распарсить ошибки 617 документа";
            this.распарситьОшибки617ДокументаToolStripMenuItem.Click += new System.EventHandler(this.распарситьОшибки617ДокументаToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(264, 6);
            // 
            // справочникВебметодыToolStripMenuItem1
            // 
            this.справочникВебметодыToolStripMenuItem1.Name = "справочникВебметодыToolStripMenuItem1";
            this.справочникВебметодыToolStripMenuItem1.Size = new System.Drawing.Size(267, 22);
            this.справочникВебметодыToolStripMenuItem1.Text = "Справочник: Веб-методы";
            this.справочникВебметодыToolStripMenuItem1.Click += new System.EventHandler(this.справочникВебметодыToolStripMenuItem1_Click);
            // 
            // данныеОРГАНИЗАЦИИToolStripMenuItem
            // 
            this.данныеОРГАНИЗАЦИИToolStripMenuItem.Name = "данныеОРГАНИЗАЦИИToolStripMenuItem";
            this.данныеОРГАНИЗАЦИИToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.данныеОРГАНИЗАЦИИToolStripMenuItem.Text = "Данные ОРГАНИЗАЦИИ";
            this.данныеОРГАНИЗАЦИИToolStripMenuItem.Click += new System.EventHandler(this.данныеОРГАНИЗАЦИИToolStripMenuItem_Click);
            // 
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьПользователяToolStripMenuItem});
            this.пользовательToolStripMenuItem.Image = global::PMMarkingUI.Properties.Resources.icon_contact;
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem_Click);
            // 
            // xtcPages
            // 
            this.xtcPages.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.Khaki;
            this.xtcPages.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.xtcPages.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.xtcPages.CustomHeaderButtons.AddRange(new DevExpress.XtraTab.Buttons.CustomHeaderButton[] {
            new DevExpress.XtraTab.Buttons.CustomHeaderButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.xtcPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtcPages.Location = new System.Drawing.Point(0, 24);
            this.xtcPages.LookAndFeel.SkinName = "Office 2013";
            this.xtcPages.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xtcPages.Name = "xtcPages";
            this.xtcPages.Size = new System.Drawing.Size(684, 412);
            this.xtcPages.TabIndex = 1;
            this.xtcPages.CloseButtonClick += new System.EventHandler(this.xtcPages_CloseButtonClick);
            this.xtcPages.CustomHeaderButtonClick += new DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventHandler(this.xtcPages_CustomHeaderButtonClick);
            this.xtcPages.MouseUp += new System.Windows.Forms.MouseEventHandler(this.xtcPages_MouseUp);
            // 
            // cmsPages
            // 
            this.cmsPages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClosePage,
            this.tsmiCloseRightPages,
            this.tsmiCloseAllWithoutThisPage,
            this.toolStripMenuItem1,
            this.tsmiCloseAllPages});
            this.cmsPages.Name = "cmsPages";
            this.cmsPages.Size = new System.Drawing.Size(230, 98);
            // 
            // tsmiClosePage
            // 
            this.tsmiClosePage.Name = "tsmiClosePage";
            this.tsmiClosePage.Size = new System.Drawing.Size(229, 22);
            this.tsmiClosePage.Text = "Закрыть вкладку";
            this.tsmiClosePage.Click += new System.EventHandler(this.tsmiClosePage_Click);
            // 
            // tsmiCloseRightPages
            // 
            this.tsmiCloseRightPages.Name = "tsmiCloseRightPages";
            this.tsmiCloseRightPages.Size = new System.Drawing.Size(229, 22);
            this.tsmiCloseRightPages.Text = "Закрыть вкладки справа";
            this.tsmiCloseRightPages.Click += new System.EventHandler(this.tsmiCloseRightPages_Click);
            // 
            // tsmiCloseAllWithoutThisPage
            // 
            this.tsmiCloseAllWithoutThisPage.Name = "tsmiCloseAllWithoutThisPage";
            this.tsmiCloseAllWithoutThisPage.Size = new System.Drawing.Size(229, 22);
            this.tsmiCloseAllWithoutThisPage.Text = "Закрыть все кроме текущей";
            this.tsmiCloseAllWithoutThisPage.Click += new System.EventHandler(this.tsmiCloseAllWithoutThisPage_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(226, 6);
            // 
            // tsmiCloseAllPages
            // 
            this.tsmiCloseAllPages.Name = "tsmiCloseAllPages";
            this.tsmiCloseAllPages.Size = new System.Drawing.Size(229, 22);
            this.tsmiCloseAllPages.Text = "Закрыть все вкладки";
            this.tsmiCloseAllPages.Click += new System.EventHandler(this.tsmiCloseAllPages_Click);
            // 
            // tsStatus
            // 
            this.tsStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsStatus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslUserLogin,
            this.tslVersion,
            this.tslToken,
            this.tsslTimerDisconnect});
            this.tsStatus.Location = new System.Drawing.Point(0, 436);
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(684, 25);
            this.tsStatus.TabIndex = 2;
            this.tsStatus.Text = "toolStrip1";
            // 
            // tslUserLogin
            // 
            this.tslUserLogin.Name = "tslUserLogin";
            this.tslUserLogin.Size = new System.Drawing.Size(84, 22);
            this.tslUserLogin.Text = "Пользователь";
            // 
            // tslVersion
            // 
            this.tslVersion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslVersion.Name = "tslVersion";
            this.tslVersion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tslVersion.Size = new System.Drawing.Size(58, 22);
            this.tslVersion.Text = "Сборка";
            // 
            // tslToken
            // 
            this.tslToken.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslToken.Name = "tslToken";
            this.tslToken.Size = new System.Drawing.Size(40, 22);
            this.tslToken.Text = "Токен";
            this.tslToken.Visible = false;
            // 
            // tsslTimerDisconnect
            // 
            this.tsslTimerDisconnect.Name = "tsslTimerDisconnect";
            this.tsslTimerDisconnect.Size = new System.Drawing.Size(132, 22);
            this.tsslTimerDisconnect.Text = "До окончания сессии: ";
            // 
            // timerMain
            // 
            this.timerMain.Interval = 300000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // timerDisconnect
            // 
            this.timerDisconnect.Enabled = true;
            this.timerDisconnect.Interval = 1000;
            this.timerDisconnect.Tick += new System.EventHandler(this.timerDisconnect_Tick);
            // 
            // ctrlPath1111
            // 
            this.ctrlPath1111.DATA = null;
            this.ctrlPath1111.Location = new System.Drawing.Point(115, 91);
            this.ctrlPath1111.Name = "ctrlPath1111";
            this.ctrlPath1111.Size = new System.Drawing.Size(519, 54);
            this.ctrlPath1111.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.xtcPages);
            this.Controls.Add(this.tsStatus);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Интерфейс взаимодействия с ИС Маркировка";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPages)).EndInit();
            this.cmsPages.ResumeLayout(false);
            this.tsStatus.ResumeLayout(false);
            this.tsStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenu_Counteragents;
        private DevExpress.XtraTab.XtraTabControl xtcPages;
        private System.Windows.Forms.ContextMenuStrip cmsPages;
        private System.Windows.Forms.ToolStripMenuItem tsmiClosePage;
        private System.Windows.Forms.ToolStripMenuItem tsmiCloseRightPages;
        private System.Windows.Forms.ToolStripMenuItem tsmiCloseAllWithoutThisPage;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCloseAllPages;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenu_CounteragentAddressLinks;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenu_Documents;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenu_DocutentList;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenu_GetDocutentsFromMdlp;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenu_TWDocutentList;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsStatus;
        private System.Windows.Forms.ToolStripLabel tslUserLogin;
        private System.Windows.Forms.ToolStripLabel tslVersion;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenu_DocumentsForAgencyContract;
        private System.Windows.Forms.ToolStripMenuItem контрагентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdmin_OpenDoc;
        private System.Windows.Forms.ToolStripLabel tslToken;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdmin_SerchFromDocs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdmin_SerchSgtinInMdlp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdmin_SerchDocNum;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdmin_CreateDocumentHandle;
        private System.Windows.Forms.ToolStripLabel tsslTimerDisconnect;
        private System.Windows.Forms.Timer timerDisconnect;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenu_BadSscc;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdmin_Test;
        private System.Windows.Forms.ToolStripMenuItem получитьСписокЗапущенныхПроцессовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdmin_SerchByObjectList;
        private System.Windows.Forms.ToolStripMenuItem фиксНеЗатянутыхSGTINToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem настройкиСканераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem генерацияORDERDETAILToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdmin_Root;
        private System.Windows.Forms.ToolStripMenuItem справочникВебметодыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьXSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОПодключенииToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem распарситьОшибки617ДокументаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem данныеОРГАНИЗАЦИИToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получитьВсеКИЗНаходящиесяВКотельникахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenu_GTD;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem webMethod000ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискСпискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализДокументаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализСпискаКоробокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получитьВсеКИЗНаходящиесяВСтатусеПринятНаСкладЗТКToolStripMenuItem;
        private ctrlPath111 ctrlPath1111;
    }
}

