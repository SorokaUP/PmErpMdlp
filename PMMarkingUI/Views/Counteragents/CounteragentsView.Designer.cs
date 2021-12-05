namespace PMMarkingUI.Views
{
    partial class CounteragentsView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleContains formatConditionRuleContains2 = new DevExpress.XtraEditors.FormatConditionRuleContains();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CounteragentsView));
            this.colSYS_ID_CBX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ricbxBool = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.scCounteragents = new System.Windows.Forms.SplitContainer();
            this.pCounteragents = new System.Windows.Forms.Panel();
            this.cCounteragents = new DevExpress.XtraGrid.GridControl();
            this.vCounteragents = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPARENT_LID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPARENT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIS_VERIFY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSYS_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFilterView = new PMMarkingUI.Views.Filters.GridFilterView();
            this.tlFolders = new DevExpress.XtraTreeList.TreeList();
            this.tlcID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcNAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.msCounteragentsTW4 = new System.Windows.Forms.MenuStrip();
            this.tsmiActions = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAction_Verify = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_Verify_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_Verify_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAction_Verify_SyncForMdlp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_LinkToTW4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_LinkToTW4_ForMdlp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_LinkToTW4_Handle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_LinkToTW4_ForInn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAction_LinkToTW4_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_SyncToTW4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_SyncToTW4_Counteragents = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_SyncToTW4_Addresses = new System.Windows.Forms.ToolStripMenuItem();
            this.синхронизироватьАдресаПомеченныхКонтрагентовСTW4ВСЕХToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAction_SyncToTW4_CounteragentsSysId = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_SyncToTW4_CounteragentsSysId_All = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAction_SyncToTW4_AddressesBranchId = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_SyncToTW4_AddressesBranchId_All = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAction_SyncToTW4_FiasHandle = new System.Windows.Forms.ToolStripMenuItem();
            this.адресаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьАдресаКонтрагентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получитьФИАСПоАдресамПомеченныхКонтрагентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.связатьАдресаКонтрагентовСМДЛППоФИАСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_Filters = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_Filters_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_Filters_ShowOnlyVerify = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_Filters_ShowOnlyNonVerify = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_Filters_ShowOnlyErrorInn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_Service = new System.Windows.Forms.ToolStripMenuItem();
            this.мАССОВЫЕОПЕРАЦИИToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.синхронизироватьКонтрагентовСTW4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синхронизироватьАдресаКонтрагентовСTW4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.связатьКонтрагентовTW4ИМДЛППоИННToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получитьДетальнуюИнформациюПоАдресамКонтрагентовTW4ФИАСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.связатьАдресаTW4ИМДЛППоФИАСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКонтрагентовВДоверенныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.снятьВыделениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.выделитьВсехДоверенныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсехНеДоверенныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.карточкаКонтрагентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_SyncToTW4_FiasAll = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ricbxBool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scCounteragents)).BeginInit();
            this.scCounteragents.Panel1.SuspendLayout();
            this.scCounteragents.Panel2.SuspendLayout();
            this.scCounteragents.SuspendLayout();
            this.pCounteragents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cCounteragents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCounteragents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlFolders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.msCounteragentsTW4.SuspendLayout();
            this.SuspendLayout();
            // 
            // colSYS_ID_CBX
            // 
            this.colSYS_ID_CBX.Caption = "Связка с МДЛП";
            this.colSYS_ID_CBX.ColumnEdit = this.ricbxBool;
            this.colSYS_ID_CBX.FieldName = "SYS_ID_CBX";
            this.colSYS_ID_CBX.Name = "colSYS_ID_CBX";
            this.colSYS_ID_CBX.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SYS_ID_CBX", "{0:#.##}")});
            this.colSYS_ID_CBX.Visible = true;
            this.colSYS_ID_CBX.VisibleIndex = 6;
            this.colSYS_ID_CBX.Width = 100;
            // 
            // ricbxBool
            // 
            this.ricbxBool.AutoHeight = false;
            this.ricbxBool.DisplayValueChecked = "1";
            this.ricbxBool.DisplayValueGrayed = "-1";
            this.ricbxBool.DisplayValueUnchecked = "0";
            this.ricbxBool.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value;
            this.ricbxBool.Name = "ricbxBool";
            this.ricbxBool.ValueChecked = 1;
            this.ricbxBool.ValueGrayed = -1;
            this.ricbxBool.ValueUnchecked = 0;
            // 
            // scCounteragents
            // 
            this.scCounteragents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scCounteragents.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scCounteragents.Location = new System.Drawing.Point(0, 24);
            this.scCounteragents.Name = "scCounteragents";
            // 
            // scCounteragents.Panel1
            // 
            this.scCounteragents.Panel1.Controls.Add(this.pCounteragents);
            // 
            // scCounteragents.Panel2
            // 
            this.scCounteragents.Panel2.Controls.Add(this.tlFolders);
            this.scCounteragents.Size = new System.Drawing.Size(1024, 744);
            this.scCounteragents.SplitterDistance = 680;
            this.scCounteragents.TabIndex = 10;
            // 
            // pCounteragents
            // 
            this.pCounteragents.Controls.Add(this.cCounteragents);
            this.pCounteragents.Controls.Add(this.gridFilterView);
            this.pCounteragents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCounteragents.Location = new System.Drawing.Point(0, 0);
            this.pCounteragents.Name = "pCounteragents";
            this.pCounteragents.Size = new System.Drawing.Size(680, 744);
            this.pCounteragents.TabIndex = 10;
            // 
            // cCounteragents
            // 
            this.cCounteragents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cCounteragents.Location = new System.Drawing.Point(0, 45);
            this.cCounteragents.MainView = this.vCounteragents;
            this.cCounteragents.Name = "cCounteragents";
            this.cCounteragents.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ricbxBool});
            this.cCounteragents.Size = new System.Drawing.Size(680, 699);
            this.cCounteragents.TabIndex = 9;
            this.cCounteragents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vCounteragents});
            // 
            // vCounteragents
            // 
            this.vCounteragents.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSelect,
            this.colID,
            this.colLID,
            this.colCODE,
            this.colNAME,
            this.colINN,
            this.colPARENT_LID,
            this.colPARENT_NAME,
            this.colIS_VERIFY,
            this.colSYS_ID,
            this.colSYS_ID_CBX});
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Column = this.colSYS_ID_CBX;
            gridFormatRule2.Name = "FormatNoLinkMdlp";
            formatConditionRuleContains2.Appearance.BackColor = System.Drawing.Color.White;
            formatConditionRuleContains2.Appearance.BackColor2 = System.Drawing.Color.PeachPuff;
            formatConditionRuleContains2.Appearance.Options.UseBackColor = true;
            formatConditionRuleContains2.Values = ((System.Collections.IList)(resources.GetObject("formatConditionRuleContains2.Values")));
            gridFormatRule2.Rule = formatConditionRuleContains2;
            this.vCounteragents.FormatRules.Add(gridFormatRule2);
            this.vCounteragents.GridControl = this.cCounteragents;
            this.vCounteragents.Name = "vCounteragents";
            this.vCounteragents.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.vCounteragents.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.vCounteragents.OptionsBehavior.AllowIncrementalSearch = true;
            this.vCounteragents.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.vCounteragents.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.vCounteragents.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.vCounteragents.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.vCounteragents.OptionsView.ColumnAutoWidth = false;
            this.vCounteragents.OptionsView.ShowFooter = true;
            this.vCounteragents.OptionsView.ShowGroupPanel = false;
            this.vCounteragents.OptionsView.ShowViewCaption = true;
            this.vCounteragents.ViewCaption = "Список контрагентов TW4";
            this.vCounteragents.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.vCounteragents_RowCellClick);
            // 
            // colSelect
            // 
            this.colSelect.Caption = "Выбрать";
            this.colSelect.ColumnEdit = this.ricbxBool;
            this.colSelect.FieldName = "HANDLE_SELECT";
            this.colSelect.Name = "colSelect";
            this.colSelect.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HANDLE_SELECT", "{0:#.##}")});
            this.colSelect.Visible = true;
            this.colSelect.VisibleIndex = 0;
            this.colSelect.Width = 60;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // colLID
            // 
            this.colLID.Caption = "LID";
            this.colLID.FieldName = "LID";
            this.colLID.Name = "colLID";
            this.colLID.OptionsColumn.ReadOnly = true;
            // 
            // colCODE
            // 
            this.colCODE.Caption = "Код";
            this.colCODE.FieldName = "CODE";
            this.colCODE.Name = "colCODE";
            this.colCODE.OptionsColumn.ReadOnly = true;
            this.colCODE.Visible = true;
            this.colCODE.VisibleIndex = 1;
            // 
            // colNAME
            // 
            this.colNAME.Caption = "Наименование";
            this.colNAME.FieldName = "NAME";
            this.colNAME.MinWidth = 250;
            this.colNAME.Name = "colNAME";
            this.colNAME.OptionsColumn.ReadOnly = true;
            this.colNAME.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "NAME", "{0}")});
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 2;
            this.colNAME.Width = 250;
            // 
            // colINN
            // 
            this.colINN.Caption = "ИНН";
            this.colINN.FieldName = "INN";
            this.colINN.MinWidth = 120;
            this.colINN.Name = "colINN";
            this.colINN.OptionsColumn.ReadOnly = true;
            this.colINN.Visible = true;
            this.colINN.VisibleIndex = 3;
            this.colINN.Width = 150;
            // 
            // colPARENT_LID
            // 
            this.colPARENT_LID.Caption = "PARENT_LID";
            this.colPARENT_LID.FieldName = "PARENT_LID";
            this.colPARENT_LID.Name = "colPARENT_LID";
            this.colPARENT_LID.OptionsColumn.ReadOnly = true;
            // 
            // colPARENT_NAME
            // 
            this.colPARENT_NAME.Caption = "Папка";
            this.colPARENT_NAME.FieldName = "PARENT_NAME";
            this.colPARENT_NAME.MinWidth = 150;
            this.colPARENT_NAME.Name = "colPARENT_NAME";
            this.colPARENT_NAME.OptionsColumn.ReadOnly = true;
            this.colPARENT_NAME.Visible = true;
            this.colPARENT_NAME.VisibleIndex = 4;
            this.colPARENT_NAME.Width = 150;
            // 
            // colIS_VERIFY
            // 
            this.colIS_VERIFY.Caption = "Доверенный";
            this.colIS_VERIFY.ColumnEdit = this.ricbxBool;
            this.colIS_VERIFY.FieldName = "IS_VERIFY";
            this.colIS_VERIFY.Name = "colIS_VERIFY";
            this.colIS_VERIFY.OptionsColumn.ReadOnly = true;
            this.colIS_VERIFY.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IS_VERIFY", "{0:#.##}")});
            this.colIS_VERIFY.Visible = true;
            this.colIS_VERIFY.VisibleIndex = 5;
            // 
            // colSYS_ID
            // 
            this.colSYS_ID.Caption = "SYS_ID";
            this.colSYS_ID.FieldName = "SYS_ID";
            this.colSYS_ID.Name = "colSYS_ID";
            this.colSYS_ID.OptionsColumn.ReadOnly = true;
            // 
            // gridFilterView
            // 
            this.gridFilterView.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridFilterView.Location = new System.Drawing.Point(0, 0);
            this.gridFilterView.Name = "gridFilterView";
            this.gridFilterView.Size = new System.Drawing.Size(680, 45);
            this.gridFilterView.TabIndex = 10;
            // 
            // tlFolders
            // 
            this.tlFolders.Caption = "Группы контрагентов";
            this.tlFolders.CheckBoxFieldName = "cbx";
            this.tlFolders.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcID,
            this.tlcNAME});
            this.tlFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlFolders.Location = new System.Drawing.Point(0, 0);
            this.tlFolders.Name = "tlFolders";
            this.tlFolders.BeginUnboundLoad();
            this.tlFolders.AppendNode(new object[] {
            "Все коробки",
            "Все коробки"}, -1);
            this.tlFolders.EndUnboundLoad();
            this.tlFolders.OptionsBehavior.AllowExpandOnDblClick = false;
            this.tlFolders.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.tlFolders.OptionsBehavior.Editable = false;
            this.tlFolders.OptionsBehavior.EditorShowMode = DevExpress.XtraTreeList.TreeListEditorShowMode.MouseDownFocused;
            this.tlFolders.OptionsBehavior.PopulateServiceColumns = true;
            this.tlFolders.OptionsBehavior.ReadOnly = true;
            this.tlFolders.OptionsFind.AllowIncrementalSearch = true;
            this.tlFolders.OptionsView.BestFitMode = DevExpress.XtraTreeList.TreeListBestFitMode.Full;
            this.tlFolders.OptionsView.RootCheckBoxStyle = DevExpress.XtraTreeList.NodeCheckBoxStyle.None;
            this.tlFolders.OptionsView.ShowCaption = true;
            this.tlFolders.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.tlFolders.Size = new System.Drawing.Size(340, 744);
            this.tlFolders.TabIndex = 13;
            this.tlFolders.RowClick += new DevExpress.XtraTreeList.RowClickEventHandler(this.tlFolders_RowClick);
            // 
            // tlcID
            // 
            this.tlcID.Caption = "ID";
            this.tlcID.FieldName = "tlcID";
            this.tlcID.Name = "tlcID";
            // 
            // tlcNAME
            // 
            this.tlcNAME.Caption = "Группа";
            this.tlcNAME.FieldName = "tlcNAME";
            this.tlcNAME.Name = "tlcNAME";
            this.tlcNAME.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Count;
            this.tlcNAME.Visible = true;
            this.tlcNAME.VisibleIndex = 0;
            this.tlcNAME.Width = 182;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.ValueChecked = 1;
            this.repositoryItemCheckEdit2.ValueUnchecked = 0;
            // 
            // msCounteragentsTW4
            // 
            this.msCounteragentsTW4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiActions,
            this.выделениеToolStripMenuItem,
            this.карточкаКонтрагентаToolStripMenuItem});
            this.msCounteragentsTW4.Location = new System.Drawing.Point(0, 0);
            this.msCounteragentsTW4.Name = "msCounteragentsTW4";
            this.msCounteragentsTW4.Size = new System.Drawing.Size(1024, 24);
            this.msCounteragentsTW4.TabIndex = 8;
            this.msCounteragentsTW4.Text = "menuStrip1";
            // 
            // tsmiActions
            // 
            this.tsmiActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьСписокToolStripMenuItem,
            this.toolStripMenuItem2,
            this.tsmiAction_Verify,
            this.tsmiAction_LinkToTW4,
            this.tsmiAction_SyncToTW4,
            this.адресаToolStripMenuItem,
            this.tsmiAction_Filters,
            this.tsmiAction_Service});
            this.tsmiActions.Name = "tsmiActions";
            this.tsmiActions.Size = new System.Drawing.Size(70, 20);
            this.tsmiActions.Text = "Действия";
            // 
            // обновитьСписокToolStripMenuItem
            // 
            this.обновитьСписокToolStripMenuItem.Name = "обновитьСписокToolStripMenuItem";
            this.обновитьСписокToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.обновитьСписокToolStripMenuItem.Text = "Обновить список";
            this.обновитьСписокToolStripMenuItem.Click += new System.EventHandler(this.обновитьСписокToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(193, 6);
            // 
            // tsmiAction_Verify
            // 
            this.tsmiAction_Verify.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAction_Verify_Add,
            this.tsmiAction_Verify_Del,
            this.toolStripMenuItem4,
            this.tsmiAction_Verify_SyncForMdlp});
            this.tsmiAction_Verify.Name = "tsmiAction_Verify";
            this.tsmiAction_Verify.Size = new System.Drawing.Size(196, 22);
            this.tsmiAction_Verify.Text = "Доверенные";
            // 
            // tsmiAction_Verify_Add
            // 
            this.tsmiAction_Verify_Add.Name = "tsmiAction_Verify_Add";
            this.tsmiAction_Verify_Add.Size = new System.Drawing.Size(520, 22);
            this.tsmiAction_Verify_Add.Text = "Добавить помеченных в доверенные";
            this.tsmiAction_Verify_Add.Click += new System.EventHandler(this.добавитьВДоверенныеToolStripMenuItem_Click);
            // 
            // tsmiAction_Verify_Del
            // 
            this.tsmiAction_Verify_Del.Name = "tsmiAction_Verify_Del";
            this.tsmiAction_Verify_Del.Size = new System.Drawing.Size(520, 22);
            this.tsmiAction_Verify_Del.Text = "Убрать помеченных из доверенных";
            this.tsmiAction_Verify_Del.Click += new System.EventHandler(this.убратьИзДоверенныхToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(517, 6);
            // 
            // tsmiAction_Verify_SyncForMdlp
            // 
            this.tsmiAction_Verify_SyncForMdlp.Name = "tsmiAction_Verify_SyncForMdlp";
            this.tsmiAction_Verify_SyncForMdlp.Size = new System.Drawing.Size(520, 22);
            this.tsmiAction_Verify_SyncForMdlp.Text = "Синхронизировать информацию о доверенных контрагентах из МДЛП (по всем)";
            this.tsmiAction_Verify_SyncForMdlp.Click += new System.EventHandler(this.tsmiAction_Verify_SyncForMdlp_Click);
            // 
            // tsmiAction_LinkToTW4
            // 
            this.tsmiAction_LinkToTW4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAction_LinkToTW4_ForMdlp,
            this.tsmiAction_LinkToTW4_Handle,
            this.tsmiAction_LinkToTW4_ForInn,
            this.toolStripMenuItem5,
            this.tsmiAction_LinkToTW4_Delete});
            this.tsmiAction_LinkToTW4.Name = "tsmiAction_LinkToTW4";
            this.tsmiAction_LinkToTW4.Size = new System.Drawing.Size(196, 22);
            this.tsmiAction_LinkToTW4.Text = "Связать контрагентов";
            // 
            // tsmiAction_LinkToTW4_ForMdlp
            // 
            this.tsmiAction_LinkToTW4_ForMdlp.Name = "tsmiAction_LinkToTW4_ForMdlp";
            this.tsmiAction_LinkToTW4_ForMdlp.Size = new System.Drawing.Size(382, 22);
            this.tsmiAction_LinkToTW4_ForMdlp.Text = "Связать контрагентов с МДЛП (с поиском по МДЛП)";
            this.tsmiAction_LinkToTW4_ForMdlp.Click += new System.EventHandler(this.актуализироватьСвязкиКонтрагентовНаОсновеИННToolStripMenuItem_Click);
            // 
            // tsmiAction_LinkToTW4_Handle
            // 
            this.tsmiAction_LinkToTW4_Handle.Name = "tsmiAction_LinkToTW4_Handle";
            this.tsmiAction_LinkToTW4_Handle.Size = new System.Drawing.Size(382, 22);
            this.tsmiAction_LinkToTW4_Handle.Text = "Связать контрагентов с МДЛП (вручную произвольно)";
            this.tsmiAction_LinkToTW4_Handle.Click += new System.EventHandler(this.ручнаяПривязкаКонтрагентовToolStripMenuItem_Click);
            // 
            // tsmiAction_LinkToTW4_ForInn
            // 
            this.tsmiAction_LinkToTW4_ForInn.Name = "tsmiAction_LinkToTW4_ForInn";
            this.tsmiAction_LinkToTW4_ForInn.Size = new System.Drawing.Size(382, 22);
            this.tsmiAction_LinkToTW4_ForInn.Text = "Связать контрагентов с МДЛП (автоматически по ИНН)";
            this.tsmiAction_LinkToTW4_ForInn.Click += new System.EventHandler(this.tsmiAction_LinkToTW4_ForInn_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(379, 6);
            // 
            // tsmiAction_LinkToTW4_Delete
            // 
            this.tsmiAction_LinkToTW4_Delete.Name = "tsmiAction_LinkToTW4_Delete";
            this.tsmiAction_LinkToTW4_Delete.Size = new System.Drawing.Size(382, 22);
            this.tsmiAction_LinkToTW4_Delete.Text = "Удалить привязку контрагента с МДЛП";
            this.tsmiAction_LinkToTW4_Delete.Click += new System.EventHandler(this.удалитьПривязкуToolStripMenuItem_Click);
            // 
            // tsmiAction_SyncToTW4
            // 
            this.tsmiAction_SyncToTW4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAction_SyncToTW4_Counteragents,
            this.tsmiAction_SyncToTW4_Addresses,
            this.синхронизироватьАдресаПомеченныхКонтрагентовСTW4ВСЕХToolStripMenuItem,
            this.toolStripMenuItem6,
            this.tsmiAction_SyncToTW4_CounteragentsSysId,
            this.tsmiAction_SyncToTW4_CounteragentsSysId_All,
            this.toolStripMenuItem7,
            this.tsmiAction_SyncToTW4_AddressesBranchId,
            this.tsmiAction_SyncToTW4_AddressesBranchId_All,
            this.toolStripMenuItem8,
            this.tsmiAction_SyncToTW4_FiasHandle,
            this.tsmiAction_SyncToTW4_FiasAll});
            this.tsmiAction_SyncToTW4.Name = "tsmiAction_SyncToTW4";
            this.tsmiAction_SyncToTW4.Size = new System.Drawing.Size(196, 22);
            this.tsmiAction_SyncToTW4.Text = "Синхронизация с TW4";
            // 
            // tsmiAction_SyncToTW4_Counteragents
            // 
            this.tsmiAction_SyncToTW4_Counteragents.Name = "tsmiAction_SyncToTW4_Counteragents";
            this.tsmiAction_SyncToTW4_Counteragents.Size = new System.Drawing.Size(655, 22);
            this.tsmiAction_SyncToTW4_Counteragents.Text = "Синхронизировать всех контрагентов с TW4";
            this.tsmiAction_SyncToTW4_Counteragents.Click += new System.EventHandler(this.синхронизироватьСTW4ToolStripMenuItem_Click);
            // 
            // tsmiAction_SyncToTW4_Addresses
            // 
            this.tsmiAction_SyncToTW4_Addresses.Name = "tsmiAction_SyncToTW4_Addresses";
            this.tsmiAction_SyncToTW4_Addresses.Size = new System.Drawing.Size(655, 22);
            this.tsmiAction_SyncToTW4_Addresses.Text = "Синхронизировать адреса помеченных контрагентов с TW4";
            this.tsmiAction_SyncToTW4_Addresses.Click += new System.EventHandler(this.синхронизироватьАдресаСTW4ToolStripMenuItem_Click);
            // 
            // синхронизироватьАдресаПомеченныхКонтрагентовСTW4ВСЕХToolStripMenuItem
            // 
            this.синхронизироватьАдресаПомеченныхКонтрагентовСTW4ВСЕХToolStripMenuItem.Name = "синхронизироватьАдресаПомеченныхКонтрагентовСTW4ВСЕХToolStripMenuItem";
            this.синхронизироватьАдресаПомеченныхКонтрагентовСTW4ВСЕХToolStripMenuItem.Size = new System.Drawing.Size(655, 22);
            this.синхронизироватьАдресаПомеченныхКонтрагентовСTW4ВСЕХToolStripMenuItem.Text = "Синхронизировать адреса всех контрагентов с TW4";
            this.синхронизироватьАдресаПомеченныхКонтрагентовСTW4ВСЕХToolStripMenuItem.Click += new System.EventHandler(this.синхронизироватьАдресаПомеченныхКонтрагентовСTW4ВСЕХToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(652, 6);
            // 
            // tsmiAction_SyncToTW4_CounteragentsSysId
            // 
            this.tsmiAction_SyncToTW4_CounteragentsSysId.Name = "tsmiAction_SyncToTW4_CounteragentsSysId";
            this.tsmiAction_SyncToTW4_CounteragentsSysId.Size = new System.Drawing.Size(655, 22);
            this.tsmiAction_SyncToTW4_CounteragentsSysId.Text = "Синхронизировать рег. номера МДЛП на карточке помеченных контрагентов (SYS_ID)";
            this.tsmiAction_SyncToTW4_CounteragentsSysId.Click += new System.EventHandler(this.tsmiAction_SetSystemSubjId_TW4_Click);
            // 
            // tsmiAction_SyncToTW4_CounteragentsSysId_All
            // 
            this.tsmiAction_SyncToTW4_CounteragentsSysId_All.Name = "tsmiAction_SyncToTW4_CounteragentsSysId_All";
            this.tsmiAction_SyncToTW4_CounteragentsSysId_All.Size = new System.Drawing.Size(655, 22);
            this.tsmiAction_SyncToTW4_CounteragentsSysId_All.Text = "Синхронизировать рег. номера МДЛП на карточке всех контрагентов (SYS_ID)";
            this.tsmiAction_SyncToTW4_CounteragentsSysId_All.Click += new System.EventHandler(this.tsmiAction_SyncToTW4_CounteragentsSysId_All_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(652, 6);
            // 
            // tsmiAction_SyncToTW4_AddressesBranchId
            // 
            this.tsmiAction_SyncToTW4_AddressesBranchId.Name = "tsmiAction_SyncToTW4_AddressesBranchId";
            this.tsmiAction_SyncToTW4_AddressesBranchId.Size = new System.Drawing.Size(655, 22);
            this.tsmiAction_SyncToTW4_AddressesBranchId.Text = "Синхронизировать идентификаторы адресов МДЛП на карточке помеченных контрагентов " +
    "(BRANCH_ID)";
            this.tsmiAction_SyncToTW4_AddressesBranchId.Click += new System.EventHandler(this.tsmiAction_SetBranchIdAddresses_TW4_Click);
            // 
            // tsmiAction_SyncToTW4_AddressesBranchId_All
            // 
            this.tsmiAction_SyncToTW4_AddressesBranchId_All.Name = "tsmiAction_SyncToTW4_AddressesBranchId_All";
            this.tsmiAction_SyncToTW4_AddressesBranchId_All.Size = new System.Drawing.Size(655, 22);
            this.tsmiAction_SyncToTW4_AddressesBranchId_All.Text = "Синхронизировать идентификаторы адресов МДЛП на карточке всех контрагентов (BRANC" +
    "H_ID)";
            this.tsmiAction_SyncToTW4_AddressesBranchId_All.Click += new System.EventHandler(this.tsmiAction_SyncToTW4_AddressesBranchId_All_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(652, 6);
            // 
            // tsmiAction_SyncToTW4_FiasHandle
            // 
            this.tsmiAction_SyncToTW4_FiasHandle.Name = "tsmiAction_SyncToTW4_FiasHandle";
            this.tsmiAction_SyncToTW4_FiasHandle.Size = new System.Drawing.Size(655, 22);
            this.tsmiAction_SyncToTW4_FiasHandle.Text = "Синхронизировать ФИАС адресов с TW4 по выбранным контрагентам";
            this.tsmiAction_SyncToTW4_FiasHandle.Click += new System.EventHandler(this.tsmiAction_SyncToTW4_Fias_Click);
            // 
            // адресаToolStripMenuItem
            // 
            this.адресаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьАдресаКонтрагентовToolStripMenuItem,
            this.получитьФИАСПоАдресамПомеченныхКонтрагентовToolStripMenuItem,
            this.toolStripMenuItem1,
            this.связатьАдресаКонтрагентовСМДЛППоФИАСToolStripMenuItem});
            this.адресаToolStripMenuItem.Name = "адресаToolStripMenuItem";
            this.адресаToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.адресаToolStripMenuItem.Text = "Адреса";
            // 
            // обновитьАдресаКонтрагентовToolStripMenuItem
            // 
            this.обновитьАдресаКонтрагентовToolStripMenuItem.Name = "обновитьАдресаКонтрагентовToolStripMenuItem";
            this.обновитьАдресаКонтрагентовToolStripMenuItem.Size = new System.Drawing.Size(423, 22);
            this.обновитьАдресаКонтрагентовToolStripMenuItem.Text = "Обновить адреса помеченных контрагентов из МДЛП";
            this.обновитьАдресаКонтрагентовToolStripMenuItem.Click += new System.EventHandler(this.tsmiAction_RefreshCounteragent_Click);
            // 
            // получитьФИАСПоАдресамПомеченныхКонтрагентовToolStripMenuItem
            // 
            this.получитьФИАСПоАдресамПомеченныхКонтрагентовToolStripMenuItem.Name = "получитьФИАСПоАдресамПомеченныхКонтрагентовToolStripMenuItem";
            this.получитьФИАСПоАдресамПомеченныхКонтрагентовToolStripMenuItem.Size = new System.Drawing.Size(423, 22);
            this.получитьФИАСПоАдресамПомеченныхКонтрагентовToolStripMenuItem.Text = "Получить ФИАС по адресам из TW4 помеченных контрагентов";
            this.получитьФИАСПоАдресамПомеченныхКонтрагентовToolStripMenuItem.Click += new System.EventHandler(this.получитьДетальнуюИнформациюПоАдресамПомеченныхКонтрагентовTW4ФИАСToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(420, 6);
            // 
            // связатьАдресаКонтрагентовСМДЛППоФИАСToolStripMenuItem
            // 
            this.связатьАдресаКонтрагентовСМДЛППоФИАСToolStripMenuItem.Name = "связатьАдресаКонтрагентовСМДЛППоФИАСToolStripMenuItem";
            this.связатьАдресаКонтрагентовСМДЛППоФИАСToolStripMenuItem.Size = new System.Drawing.Size(423, 22);
            this.связатьАдресаКонтрагентовСМДЛППоФИАСToolStripMenuItem.Text = "Связать адреса помеченных контрагентов с МДЛП по ФИАС";
            this.связатьАдресаКонтрагентовСМДЛППоФИАСToolStripMenuItem.Click += new System.EventHandler(this.связатьАдресаКонтрагентовСМДЛППоФИАСToolStripMenuItem_Click);
            // 
            // tsmiAction_Filters
            // 
            this.tsmiAction_Filters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAction_Filters_Clear,
            this.tsmiAction_Filters_ShowOnlyVerify,
            this.tsmiAction_Filters_ShowOnlyNonVerify,
            this.tsmiAction_Filters_ShowOnlyErrorInn});
            this.tsmiAction_Filters.Name = "tsmiAction_Filters";
            this.tsmiAction_Filters.Size = new System.Drawing.Size(196, 22);
            this.tsmiAction_Filters.Text = "Фильтр";
            // 
            // tsmiAction_Filters_Clear
            // 
            this.tsmiAction_Filters_Clear.Name = "tsmiAction_Filters_Clear";
            this.tsmiAction_Filters_Clear.Size = new System.Drawing.Size(353, 22);
            this.tsmiAction_Filters_Clear.Text = "Очистить фильтры";
            this.tsmiAction_Filters_Clear.Click += new System.EventHandler(this.очиститьФильтрыToolStripMenuItem_Click);
            // 
            // tsmiAction_Filters_ShowOnlyVerify
            // 
            this.tsmiAction_Filters_ShowOnlyVerify.Name = "tsmiAction_Filters_ShowOnlyVerify";
            this.tsmiAction_Filters_ShowOnlyVerify.Size = new System.Drawing.Size(353, 22);
            this.tsmiAction_Filters_ShowOnlyVerify.Text = "Показать только доверенных";
            this.tsmiAction_Filters_ShowOnlyVerify.Click += new System.EventHandler(this.показатьТолькоДоверенныхToolStripMenuItem_Click);
            // 
            // tsmiAction_Filters_ShowOnlyNonVerify
            // 
            this.tsmiAction_Filters_ShowOnlyNonVerify.Name = "tsmiAction_Filters_ShowOnlyNonVerify";
            this.tsmiAction_Filters_ShowOnlyNonVerify.Size = new System.Drawing.Size(353, 22);
            this.tsmiAction_Filters_ShowOnlyNonVerify.Text = "Показать только не доверенных";
            this.tsmiAction_Filters_ShowOnlyNonVerify.Click += new System.EventHandler(this.показатьТолькоНеДоверенныхToolStripMenuItem_Click);
            // 
            // tsmiAction_Filters_ShowOnlyErrorInn
            // 
            this.tsmiAction_Filters_ShowOnlyErrorInn.Name = "tsmiAction_Filters_ShowOnlyErrorInn";
            this.tsmiAction_Filters_ShowOnlyErrorInn.Size = new System.Drawing.Size(353, 22);
            this.tsmiAction_Filters_ShowOnlyErrorInn.Text = "Показать только контрагентов с ошибками в ИНН";
            this.tsmiAction_Filters_ShowOnlyErrorInn.Click += new System.EventHandler(this.показатьТолькоКонтрагентовСОшибкамиToolStripMenuItem_Click);
            // 
            // tsmiAction_Service
            // 
            this.tsmiAction_Service.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мАССОВЫЕОПЕРАЦИИToolStripMenuItem1});
            this.tsmiAction_Service.Name = "tsmiAction_Service";
            this.tsmiAction_Service.Size = new System.Drawing.Size(196, 22);
            this.tsmiAction_Service.Text = "Служебные";
            // 
            // мАССОВЫЕОПЕРАЦИИToolStripMenuItem1
            // 
            this.мАССОВЫЕОПЕРАЦИИToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.синхронизироватьКонтрагентовСTW4ToolStripMenuItem,
            this.синхронизироватьАдресаКонтрагентовСTW4ToolStripMenuItem,
            this.связатьКонтрагентовTW4ИМДЛППоИННToolStripMenuItem,
            this.получитьДетальнуюИнформациюПоАдресамКонтрагентовTW4ФИАСToolStripMenuItem,
            this.связатьАдресаTW4ИМДЛППоФИАСToolStripMenuItem,
            this.добавитьКонтрагентовВДоверенныеToolStripMenuItem});
            this.мАССОВЫЕОПЕРАЦИИToolStripMenuItem1.Name = "мАССОВЫЕОПЕРАЦИИToolStripMenuItem1";
            this.мАССОВЫЕОПЕРАЦИИToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.мАССОВЫЕОПЕРАЦИИToolStripMenuItem1.Text = "МАССОВЫЕ ОПЕРАЦИИ";
            // 
            // синхронизироватьКонтрагентовСTW4ToolStripMenuItem
            // 
            this.синхронизироватьКонтрагентовСTW4ToolStripMenuItem.Name = "синхронизироватьКонтрагентовСTW4ToolStripMenuItem";
            this.синхронизироватьКонтрагентовСTW4ToolStripMenuItem.Size = new System.Drawing.Size(496, 22);
            this.синхронизироватьКонтрагентовСTW4ToolStripMenuItem.Text = "1. Синхронизировать контрагентов с TW4";
            this.синхронизироватьКонтрагентовСTW4ToolStripMenuItem.Click += new System.EventHandler(this.синхронизироватьКонтрагентовСTW4ToolStripMenuItem_Click);
            // 
            // синхронизироватьАдресаКонтрагентовСTW4ToolStripMenuItem
            // 
            this.синхронизироватьАдресаКонтрагентовСTW4ToolStripMenuItem.Name = "синхронизироватьАдресаКонтрагентовСTW4ToolStripMenuItem";
            this.синхронизироватьАдресаКонтрагентовСTW4ToolStripMenuItem.Size = new System.Drawing.Size(496, 22);
            this.синхронизироватьАдресаКонтрагентовСTW4ToolStripMenuItem.Text = "2. Синхронизировать адреса контрагентов с TW4";
            this.синхронизироватьАдресаКонтрагентовСTW4ToolStripMenuItem.Click += new System.EventHandler(this.синхронизироватьАдресаКонтрагентовСTW4ToolStripMenuItem_Click);
            // 
            // связатьКонтрагентовTW4ИМДЛППоИННToolStripMenuItem
            // 
            this.связатьКонтрагентовTW4ИМДЛППоИННToolStripMenuItem.Name = "связатьКонтрагентовTW4ИМДЛППоИННToolStripMenuItem";
            this.связатьКонтрагентовTW4ИМДЛППоИННToolStripMenuItem.Size = new System.Drawing.Size(496, 22);
            this.связатьКонтрагентовTW4ИМДЛППоИННToolStripMenuItem.Text = "3. Связать контрагентов TW4 и МДЛП по ИНН";
            this.связатьКонтрагентовTW4ИМДЛППоИННToolStripMenuItem.Click += new System.EventHandler(this.связатьКонтрагентовTW4ИМДЛППоИННToolStripMenuItem_Click);
            // 
            // получитьДетальнуюИнформациюПоАдресамКонтрагентовTW4ФИАСToolStripMenuItem
            // 
            this.получитьДетальнуюИнформациюПоАдресамКонтрагентовTW4ФИАСToolStripMenuItem.Name = "получитьДетальнуюИнформациюПоАдресамКонтрагентовTW4ФИАСToolStripMenuItem";
            this.получитьДетальнуюИнформациюПоАдресамКонтрагентовTW4ФИАСToolStripMenuItem.Size = new System.Drawing.Size(496, 22);
            this.получитьДетальнуюИнформациюПоАдресамКонтрагентовTW4ФИАСToolStripMenuItem.Text = "4. Получить детальную информацию по адресам контрагентов TW4 (ФИАС)";
            this.получитьДетальнуюИнформациюПоАдресамКонтрагентовTW4ФИАСToolStripMenuItem.Click += new System.EventHandler(this.получитьДетальнуюИнформациюПоАдресамКонтрагентовTW4ФИАСToolStripMenuItem_Click);
            // 
            // связатьАдресаTW4ИМДЛППоФИАСToolStripMenuItem
            // 
            this.связатьАдресаTW4ИМДЛППоФИАСToolStripMenuItem.Name = "связатьАдресаTW4ИМДЛППоФИАСToolStripMenuItem";
            this.связатьАдресаTW4ИМДЛППоФИАСToolStripMenuItem.Size = new System.Drawing.Size(496, 22);
            this.связатьАдресаTW4ИМДЛППоФИАСToolStripMenuItem.Text = "5. Связать адреса TW4 и МДЛП по ФИАС";
            this.связатьАдресаTW4ИМДЛППоФИАСToolStripMenuItem.Click += new System.EventHandler(this.связатьАдресаTW4ИМДЛППоФИАСToolStripMenuItem_Click);
            // 
            // добавитьКонтрагентовВДоверенныеToolStripMenuItem
            // 
            this.добавитьКонтрагентовВДоверенныеToolStripMenuItem.Name = "добавитьКонтрагентовВДоверенныеToolStripMenuItem";
            this.добавитьКонтрагентовВДоверенныеToolStripMenuItem.Size = new System.Drawing.Size(496, 22);
            this.добавитьКонтрагентовВДоверенныеToolStripMenuItem.Text = "6. Добавить контрагентов в доверенные";
            this.добавитьКонтрагентовВДоверенныеToolStripMenuItem.Click += new System.EventHandler(this.добавитьКонтрагентовВДоверенныеToolStripMenuItem_Click);
            // 
            // выделениеToolStripMenuItem
            // 
            this.выделениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выделитьВсеToolStripMenuItem,
            this.снятьВыделениеToolStripMenuItem,
            this.toolStripMenuItem3,
            this.выделитьВсехДоверенныхToolStripMenuItem,
            this.выделитьВсехНеДоверенныхToolStripMenuItem});
            this.выделениеToolStripMenuItem.Name = "выделениеToolStripMenuItem";
            this.выделениеToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.выделениеToolStripMenuItem.Text = "Выделение";
            // 
            // выделитьВсеToolStripMenuItem
            // 
            this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.выделитьВсеToolStripMenuItem.Text = "Выделить все";
            this.выделитьВсеToolStripMenuItem.Click += new System.EventHandler(this.SelectAll);
            // 
            // снятьВыделениеToolStripMenuItem
            // 
            this.снятьВыделениеToolStripMenuItem.Name = "снятьВыделениеToolStripMenuItem";
            this.снятьВыделениеToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.снятьВыделениеToolStripMenuItem.Text = "Снять выделение";
            this.снятьВыделениеToolStripMenuItem.Click += new System.EventHandler(this.UnselectAll);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(235, 6);
            // 
            // выделитьВсехДоверенныхToolStripMenuItem
            // 
            this.выделитьВсехДоверенныхToolStripMenuItem.Name = "выделитьВсехДоверенныхToolStripMenuItem";
            this.выделитьВсехДоверенныхToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.выделитьВсехДоверенныхToolStripMenuItem.Text = "Выделить всех доверенных";
            this.выделитьВсехДоверенныхToolStripMenuItem.Click += new System.EventHandler(this.SelectAllVerify);
            // 
            // выделитьВсехНеДоверенныхToolStripMenuItem
            // 
            this.выделитьВсехНеДоверенныхToolStripMenuItem.Name = "выделитьВсехНеДоверенныхToolStripMenuItem";
            this.выделитьВсехНеДоверенныхToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.выделитьВсехНеДоверенныхToolStripMenuItem.Text = "Выделить всех не доверенных";
            this.выделитьВсехНеДоверенныхToolStripMenuItem.Click += new System.EventHandler(this.SelectAllNonVerify);
            // 
            // карточкаКонтрагентаToolStripMenuItem
            // 
            this.карточкаКонтрагентаToolStripMenuItem.Name = "карточкаКонтрагентаToolStripMenuItem";
            this.карточкаКонтрагентаToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.карточкаКонтрагентаToolStripMenuItem.Text = "Карточка контрагента";
            this.карточкаКонтрагентаToolStripMenuItem.Click += new System.EventHandler(this.карточкаКонтрагентаToolStripMenuItem_Click);
            // 
            // tsmiAction_SyncToTW4_FiasAll
            // 
            this.tsmiAction_SyncToTW4_FiasAll.Name = "tsmiAction_SyncToTW4_FiasAll";
            this.tsmiAction_SyncToTW4_FiasAll.Size = new System.Drawing.Size(655, 22);
            this.tsmiAction_SyncToTW4_FiasAll.Text = "Синхронизировать ФИАС адресов с TW4 по всем контрагентам";
            this.tsmiAction_SyncToTW4_FiasAll.Click += new System.EventHandler(this.tsmiAction_SyncToTW4_FiasAll_Click);
            // 
            // CounteragentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scCounteragents);
            this.Controls.Add(this.msCounteragentsTW4);
            this.Name = "CounteragentsView";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.ricbxBool)).EndInit();
            this.scCounteragents.Panel1.ResumeLayout(false);
            this.scCounteragents.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scCounteragents)).EndInit();
            this.scCounteragents.ResumeLayout(false);
            this.pCounteragents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cCounteragents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCounteragents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlFolders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.msCounteragentsTW4.ResumeLayout(false);
            this.msCounteragentsTW4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msCounteragentsTW4;
        private System.Windows.Forms.ToolStripMenuItem tsmiActions;
        private System.Windows.Forms.ToolStripMenuItem обновитьСписокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_SyncToTW4_Counteragents;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_LinkToTW4_ForMdlp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_LinkToTW4_Handle;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_LinkToTW4_Delete;
        private DevExpress.XtraGrid.GridControl cCounteragents;
        private DevExpress.XtraGrid.Views.Grid.GridView vCounteragents;
        private DevExpress.XtraGrid.Columns.GridColumn colSelect;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ricbxBool;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colLID;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colINN;
        private DevExpress.XtraGrid.Columns.GridColumn colPARENT_LID;
        private DevExpress.XtraGrid.Columns.GridColumn colPARENT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colIS_VERIFY;
        private DevExpress.XtraGrid.Columns.GridColumn colSYS_ID;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_Verify_Add;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_Verify_Del;
        private System.Windows.Forms.SplitContainer scCounteragents;
        private DevExpress.XtraTreeList.TreeList tlFolders;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcNAME;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private System.Windows.Forms.Panel pCounteragents;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_Filters_ShowOnlyVerify;
        private System.Windows.Forms.ToolStripMenuItem выделениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem снятьВыделениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсехДоверенныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсехНеДоверенныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem карточкаКонтрагентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_Filters_ShowOnlyNonVerify;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_Filters_ShowOnlyErrorInn;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_SyncToTW4_Addresses;
        private System.Windows.Forms.ToolStripMenuItem синхронизироватьКонтрагентовСTW4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синхронизироватьАдресаКонтрагентовСTW4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem связатьКонтрагентовTW4ИМДЛППоИННToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получитьДетальнуюИнформациюПоАдресамКонтрагентовTW4ФИАСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem связатьАдресаTW4ИМДЛППоФИАСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мАССОВЫЕОПЕРАЦИИToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьКонтрагентовВДоверенныеToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colSYS_ID_CBX;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_Filters_Clear;
        private Filters.GridFilterView gridFilterView;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_Filters;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_SyncToTW4;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_Verify;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_LinkToTW4;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_Service;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_Verify_SyncForMdlp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_LinkToTW4_ForInn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_SyncToTW4_CounteragentsSysId;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_SyncToTW4_AddressesBranchId;
        private System.Windows.Forms.ToolStripMenuItem адресаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьАдресаКонтрагентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получитьФИАСПоАдресамПомеченныхКонтрагентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem связатьАдресаКонтрагентовСМДЛППоФИАСToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem синхронизироватьАдресаПомеченныхКонтрагентовСTW4ВСЕХToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_SyncToTW4_CounteragentsSysId_All;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_SyncToTW4_AddressesBranchId_All;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_SyncToTW4_FiasHandle;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_SyncToTW4_FiasAll;
    }
}
