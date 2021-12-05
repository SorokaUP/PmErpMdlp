namespace PMMarkingUI.Views
{
    partial class CounteragentsAddresses
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
            this.components = new System.ComponentModel.Container();
            this.tpAddresses = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.picLinkAdd = new System.Windows.Forms.PictureBox();
            this.picLinkDel = new System.Windows.Forms.PictureBox();
            this.gMDLP_Addresses = new DevExpress.XtraGrid.GridControl();
            this.vMDLP_Addresses = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFlagLinked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMDLP_CID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gTW_Addresses = new DevExpress.XtraGrid.GridControl();
            this.cmsTW_Addresses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCmsTWA_LinkAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsTWA_LinkDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCmsTWA_LinkForApi = new System.Windows.Forms.ToolStripMenuItem();
            this.vTW_Addresses = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTW_FLAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTW_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVAL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTW_BRANCH_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiAction = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_GetAddressesFromMdlp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_GetAddressesFromTw4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAction_LinkAllForFIAS = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colBRANCH_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTW_Dost = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tpAddresses)).BeginInit();
            this.tpAddresses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMDLP_Addresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMDLP_Addresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTW_Addresses)).BeginInit();
            this.cmsTW_Addresses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vTW_Addresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpAddresses
            // 
            this.tpAddresses.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 60F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tpAddresses.Controls.Add(this.tablePanel1);
            this.tpAddresses.Controls.Add(this.gMDLP_Addresses);
            this.tpAddresses.Controls.Add(this.gTW_Addresses);
            this.tpAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpAddresses.Location = new System.Drawing.Point(0, 24);
            this.tpAddresses.Name = "tpAddresses";
            this.tpAddresses.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tpAddresses.Size = new System.Drawing.Size(720, 456);
            this.tpAddresses.TabIndex = 7;
            // 
            // tablePanel1
            // 
            this.tpAddresses.SetColumn(this.tablePanel1, 1);
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.picLinkAdd);
            this.tablePanel1.Controls.Add(this.picLinkDel);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(333, 3);
            this.tablePanel1.Name = "tablePanel1";
            this.tpAddresses.SetRow(this.tablePanel1, 0);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(54, 450);
            this.tablePanel1.TabIndex = 2;
            // 
            // picLinkAdd
            // 
            this.tablePanel1.SetColumn(this.picLinkAdd, 0);
            this.picLinkAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLinkAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLinkAdd.Image = global::PMMarkingUI.Properties.Resources.icon_link_add;
            this.picLinkAdd.Location = new System.Drawing.Point(3, 168);
            this.picLinkAdd.Name = "picLinkAdd";
            this.tablePanel1.SetRow(this.picLinkAdd, 1);
            this.picLinkAdd.Size = new System.Drawing.Size(48, 44);
            this.picLinkAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLinkAdd.TabIndex = 4;
            this.picLinkAdd.TabStop = false;
            this.picLinkAdd.Click += new System.EventHandler(this.picLinkAdd_Click);
            // 
            // picLinkDel
            // 
            this.tablePanel1.SetColumn(this.picLinkDel, 0);
            this.picLinkDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLinkDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLinkDel.Image = global::PMMarkingUI.Properties.Resources.icon_link_del;
            this.picLinkDel.Location = new System.Drawing.Point(3, 238);
            this.picLinkDel.Name = "picLinkDel";
            this.tablePanel1.SetRow(this.picLinkDel, 3);
            this.picLinkDel.Size = new System.Drawing.Size(48, 44);
            this.picLinkDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLinkDel.TabIndex = 5;
            this.picLinkDel.TabStop = false;
            this.picLinkDel.Click += new System.EventHandler(this.picLinkDel_Click);
            // 
            // gMDLP_Addresses
            // 
            this.tpAddresses.SetColumn(this.gMDLP_Addresses, 0);
            this.gMDLP_Addresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMDLP_Addresses.Location = new System.Drawing.Point(3, 3);
            this.gMDLP_Addresses.MainView = this.vMDLP_Addresses;
            this.gMDLP_Addresses.Name = "gMDLP_Addresses";
            this.gMDLP_Addresses.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riCheckEdit});
            this.tpAddresses.SetRow(this.gMDLP_Addresses, 0);
            this.gMDLP_Addresses.Size = new System.Drawing.Size(324, 450);
            this.gMDLP_Addresses.TabIndex = 3;
            this.gMDLP_Addresses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vMDLP_Addresses});
            // 
            // vMDLP_Addresses
            // 
            this.vMDLP_Addresses.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFlagLinked,
            this.colBID,
            this.colADDRESS,
            this.colMDLP_CID,
            this.colBRANCH_ID});
            this.vMDLP_Addresses.CustomizationFormBounds = new System.Drawing.Rectangle(569, 369, 260, 232);
            this.vMDLP_Addresses.GridControl = this.gMDLP_Addresses;
            this.vMDLP_Addresses.Name = "vMDLP_Addresses";
            this.vMDLP_Addresses.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.vMDLP_Addresses.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.vMDLP_Addresses.OptionsBehavior.AllowIncrementalSearch = true;
            this.vMDLP_Addresses.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.vMDLP_Addresses.OptionsBehavior.ReadOnly = true;
            this.vMDLP_Addresses.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.vMDLP_Addresses.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.vMDLP_Addresses.OptionsView.ShowFooter = true;
            this.vMDLP_Addresses.OptionsView.ShowGroupPanel = false;
            this.vMDLP_Addresses.OptionsView.ShowViewCaption = true;
            this.vMDLP_Addresses.ViewCaption = "Адресные данные из МДЛП";
            this.vMDLP_Addresses.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.vMDLP_Addresses_FocusedRowChanged);
            // 
            // colFlagLinked
            // 
            this.colFlagLinked.Caption = "Привязка";
            this.colFlagLinked.ColumnEdit = this.riCheckEdit;
            this.colFlagLinked.FieldName = "FLAG";
            this.colFlagLinked.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colFlagLinked.MaxWidth = 60;
            this.colFlagLinked.MinWidth = 60;
            this.colFlagLinked.Name = "colFlagLinked";
            this.colFlagLinked.Visible = true;
            this.colFlagLinked.VisibleIndex = 0;
            this.colFlagLinked.Width = 60;
            // 
            // riCheckEdit
            // 
            this.riCheckEdit.AutoHeight = false;
            this.riCheckEdit.Name = "riCheckEdit";
            this.riCheckEdit.ValueChecked = 1;
            this.riCheckEdit.ValueUnchecked = 0;
            // 
            // colBID
            // 
            this.colBID.FieldName = "BID";
            this.colBID.Name = "colBID";
            this.colBID.OptionsColumn.ReadOnly = true;
            // 
            // colADDRESS
            // 
            this.colADDRESS.Caption = "Адрес";
            this.colADDRESS.FieldName = "ADDRESS";
            this.colADDRESS.Name = "colADDRESS";
            this.colADDRESS.OptionsColumn.ReadOnly = true;
            this.colADDRESS.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ADDRESS", "{0}")});
            this.colADDRESS.Visible = true;
            this.colADDRESS.VisibleIndex = 1;
            // 
            // colMDLP_CID
            // 
            this.colMDLP_CID.Caption = "CID";
            this.colMDLP_CID.FieldName = "CID";
            this.colMDLP_CID.Name = "colMDLP_CID";
            this.colMDLP_CID.OptionsColumn.ReadOnly = true;
            // 
            // gTW_Addresses
            // 
            this.tpAddresses.SetColumn(this.gTW_Addresses, 2);
            this.gTW_Addresses.ContextMenuStrip = this.cmsTW_Addresses;
            this.gTW_Addresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gTW_Addresses.Location = new System.Drawing.Point(393, 3);
            this.gTW_Addresses.MainView = this.vTW_Addresses;
            this.gTW_Addresses.Name = "gTW_Addresses";
            this.gTW_Addresses.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.tpAddresses.SetRow(this.gTW_Addresses, 0);
            this.gTW_Addresses.Size = new System.Drawing.Size(324, 450);
            this.gTW_Addresses.TabIndex = 5;
            this.gTW_Addresses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vTW_Addresses});
            // 
            // cmsTW_Addresses
            // 
            this.cmsTW_Addresses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCmsTWA_LinkAdd,
            this.tsmiCmsTWA_LinkDel,
            this.toolStripMenuItem2,
            this.tsmiCmsTWA_LinkForApi});
            this.cmsTW_Addresses.Name = "cmsTW_Addresses";
            this.cmsTW_Addresses.Size = new System.Drawing.Size(257, 76);
            // 
            // tsmiCmsTWA_LinkAdd
            // 
            this.tsmiCmsTWA_LinkAdd.Name = "tsmiCmsTWA_LinkAdd";
            this.tsmiCmsTWA_LinkAdd.Size = new System.Drawing.Size(256, 22);
            this.tsmiCmsTWA_LinkAdd.Text = "Связать выбранные";
            this.tsmiCmsTWA_LinkAdd.Click += new System.EventHandler(this.tsmiCmsTWA_LinkAdd_Click);
            // 
            // tsmiCmsTWA_LinkDel
            // 
            this.tsmiCmsTWA_LinkDel.Name = "tsmiCmsTWA_LinkDel";
            this.tsmiCmsTWA_LinkDel.Size = new System.Drawing.Size(256, 22);
            this.tsmiCmsTWA_LinkDel.Text = "Удалить связь";
            this.tsmiCmsTWA_LinkDel.Click += new System.EventHandler(this.tsmiCmsTWA_LinkDel_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(253, 6);
            // 
            // tsmiCmsTWA_LinkForApi
            // 
            this.tsmiCmsTWA_LinkForApi.Name = "tsmiCmsTWA_LinkForApi";
            this.tsmiCmsTWA_LinkForApi.Size = new System.Drawing.Size(256, 22);
            this.tsmiCmsTWA_LinkForApi.Text = "Определить и связать (через API)";
            this.tsmiCmsTWA_LinkForApi.Click += new System.EventHandler(this.tsmiCmsTWA_LinkForApi_Click);
            // 
            // vTW_Addresses
            // 
            this.vTW_Addresses.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLID,
            this.colTW_FLAG,
            this.colCODE,
            this.colTW_ID,
            this.colVAL,
            this.colTW_BRANCH_ID,
            this.colTW_Dost});
            this.vTW_Addresses.CustomizationFormBounds = new System.Drawing.Rectangle(569, 369, 260, 232);
            this.vTW_Addresses.GridControl = this.gTW_Addresses;
            this.vTW_Addresses.Name = "vTW_Addresses";
            this.vTW_Addresses.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.vTW_Addresses.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.vTW_Addresses.OptionsBehavior.AllowIncrementalSearch = true;
            this.vTW_Addresses.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.vTW_Addresses.OptionsBehavior.ReadOnly = true;
            this.vTW_Addresses.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.vTW_Addresses.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.vTW_Addresses.OptionsView.ShowFooter = true;
            this.vTW_Addresses.OptionsView.ShowGroupPanel = false;
            this.vTW_Addresses.OptionsView.ShowViewCaption = true;
            this.vTW_Addresses.ViewCaption = "Адресные данные из ТВ";
            this.vTW_Addresses.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.vTW_Addresses_FocusedRowChanged);
            // 
            // colLID
            // 
            this.colLID.FieldName = "LID";
            this.colLID.Name = "colLID";
            this.colLID.OptionsColumn.ReadOnly = true;
            // 
            // colTW_FLAG
            // 
            this.colTW_FLAG.Caption = "Привязка";
            this.colTW_FLAG.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colTW_FLAG.FieldName = "FLAG";
            this.colTW_FLAG.Name = "colTW_FLAG";
            this.colTW_FLAG.OptionsColumn.FixedWidth = true;
            this.colTW_FLAG.Visible = true;
            this.colTW_FLAG.VisibleIndex = 0;
            this.colTW_FLAG.Width = 60;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // colCODE
            // 
            this.colCODE.Caption = "Короткий код";
            this.colCODE.FieldName = "CODE";
            this.colCODE.Name = "colCODE";
            this.colCODE.OptionsColumn.FixedWidth = true;
            this.colCODE.OptionsColumn.ReadOnly = true;
            this.colCODE.Visible = true;
            this.colCODE.VisibleIndex = 1;
            this.colCODE.Width = 100;
            // 
            // colTW_ID
            // 
            this.colTW_ID.FieldName = "TW_ID";
            this.colTW_ID.Name = "colTW_ID";
            this.colTW_ID.OptionsColumn.ReadOnly = true;
            // 
            // colVAL
            // 
            this.colVAL.Caption = "Адрес";
            this.colVAL.FieldName = "VAL";
            this.colVAL.Name = "colVAL";
            this.colVAL.OptionsColumn.ReadOnly = true;
            this.colVAL.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "VAL", "{0}")});
            this.colVAL.Visible = true;
            this.colVAL.VisibleIndex = 2;
            this.colVAL.Width = 146;
            // 
            // colTW_BRANCH_ID
            // 
            this.colTW_BRANCH_ID.Caption = "BRANCH_ID";
            this.colTW_BRANCH_ID.FieldName = "BRANCH_ID";
            this.colTW_BRANCH_ID.Name = "colTW_BRANCH_ID";
            this.colTW_BRANCH_ID.OptionsColumn.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAction,
            this.обновитьСписокToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(720, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiAction
            // 
            this.tsmiAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAction_GetAddressesFromMdlp,
            this.tsmiAction_GetAddressesFromTw4,
            this.toolStripMenuItem1,
            this.tsmiAction_LinkAllForFIAS});
            this.tsmiAction.Name = "tsmiAction";
            this.tsmiAction.Size = new System.Drawing.Size(70, 20);
            this.tsmiAction.Text = "Действия";
            // 
            // tsmiAction_GetAddressesFromMdlp
            // 
            this.tsmiAction_GetAddressesFromMdlp.Name = "tsmiAction_GetAddressesFromMdlp";
            this.tsmiAction_GetAddressesFromMdlp.Size = new System.Drawing.Size(318, 22);
            this.tsmiAction_GetAddressesFromMdlp.Text = "Запросить адреса из МДЛП";
            this.tsmiAction_GetAddressesFromMdlp.Click += new System.EventHandler(this.tsmiAction_GetAddressesFromMdlp_Click);
            // 
            // tsmiAction_GetAddressesFromTw4
            // 
            this.tsmiAction_GetAddressesFromTw4.Name = "tsmiAction_GetAddressesFromTw4";
            this.tsmiAction_GetAddressesFromTw4.Size = new System.Drawing.Size(318, 22);
            this.tsmiAction_GetAddressesFromTw4.Text = "Запросить адреса из TW4";
            this.tsmiAction_GetAddressesFromTw4.Click += new System.EventHandler(this.tsmiAction_GetAddressesFromTw4_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(315, 6);
            // 
            // tsmiAction_LinkAllForFIAS
            // 
            this.tsmiAction_LinkAllForFIAS.Name = "tsmiAction_LinkAllForFIAS";
            this.tsmiAction_LinkAllForFIAS.Size = new System.Drawing.Size(318, 22);
            this.tsmiAction_LinkAllForFIAS.Text = "Автоматическая привязка адресов по ФИАС";
            this.tsmiAction_LinkAllForFIAS.Click += new System.EventHandler(this.tsmiAction_LinkAllForFIAS_Click);
            // 
            // обновитьСписокToolStripMenuItem
            // 
            this.обновитьСписокToolStripMenuItem.Name = "обновитьСписокToolStripMenuItem";
            this.обновитьСписокToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.обновитьСписокToolStripMenuItem.Text = "Обновить данные";
            this.обновитьСписокToolStripMenuItem.Click += new System.EventHandler(this.обновитьСписокToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // colBRANCH_ID
            // 
            this.colBRANCH_ID.Caption = "BRANCH_ID";
            this.colBRANCH_ID.FieldName = "BRANCH_ID";
            this.colBRANCH_ID.Name = "colBRANCH_ID";
            this.colBRANCH_ID.Visible = true;
            this.colBRANCH_ID.VisibleIndex = 2;
            // 
            // colTW_Dost
            // 
            this.colTW_Dost.Caption = "Доставка";
            this.colTW_Dost.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colTW_Dost.FieldName = "TW_DOST";
            this.colTW_Dost.Name = "colTW_Dost";
            this.colTW_Dost.Visible = true;
            this.colTW_Dost.VisibleIndex = 3;
            // 
            // CounteragentsAddresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpAddresses);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CounteragentsAddresses";
            this.Size = new System.Drawing.Size(720, 480);
            ((System.ComponentModel.ISupportInitialize)(this.tpAddresses)).EndInit();
            this.tpAddresses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLinkAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMDLP_Addresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMDLP_Addresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTW_Addresses)).EndInit();
            this.cmsTW_Addresses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vTW_Addresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tpAddresses;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.PictureBox picLinkAdd;
        private System.Windows.Forms.PictureBox picLinkDel;
        private DevExpress.XtraGrid.GridControl gMDLP_Addresses;
        private DevExpress.XtraGrid.Views.Grid.GridView vMDLP_Addresses;
        private DevExpress.XtraGrid.Columns.GridColumn colFlagLinked;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riCheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colBID;
        private DevExpress.XtraGrid.Columns.GridColumn colADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colMDLP_CID;
        private DevExpress.XtraGrid.GridControl gTW_Addresses;
        private DevExpress.XtraGrid.Views.Grid.GridView vTW_Addresses;
        private DevExpress.XtraGrid.Columns.GridColumn colLID;
        private DevExpress.XtraGrid.Columns.GridColumn colTW_FLAG;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colTW_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colVAL;
        private DevExpress.XtraGrid.Columns.GridColumn colTW_BRANCH_ID;
        private System.Windows.Forms.ContextMenuStrip cmsTW_Addresses;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsTWA_LinkAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsTWA_LinkDel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsTWA_LinkForApi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обновитьСписокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_GetAddressesFromMdlp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_GetAddressesFromTw4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_LinkAllForFIAS;
        private DevExpress.XtraGrid.Columns.GridColumn colBRANCH_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colTW_Dost;
    }
}
