namespace PMMarkingUI.Views
{
    partial class CreateDocumentView
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.gcOBJECT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmsGtin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.получитьДетальнуюИнформациюИнформациюПоNjdfheGTINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получениеПубличнойИнформацииОбЛПToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scDocs = new System.Windows.Forms.SplitContainer();
            this.pHeader = new System.Windows.Forms.Panel();
            this.vGridControl = new DevExpress.XtraVerticalGrid.VGridControl();
            this.riDateEdit_DocDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.rilueDocType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rilueSender = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rilueReceiver = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rowDOC_TYPE = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDOC_DATE = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowSENDER = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowRECEIVER = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.pUnion = new System.Windows.Forms.Panel();
            this.cData = new DevExpress.XtraGrid.GridControl();
            this.vData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gcCOST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.gcVAT_VALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIS_BALANCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMSG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.msData = new System.Windows.Forms.MenuStrip();
            this.tsmiActionData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActionData_LoadFromExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActionData_Check = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiActionData_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActionData_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiActionData_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiActionDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActionDoc_Create = new System.Windows.Forms.ToolStripMenuItem();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cmsGtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scDocs)).BeginInit();
            this.scDocs.Panel1.SuspendLayout();
            this.scDocs.Panel2.SuspendLayout();
            this.scDocs.SuspendLayout();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit_DocDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit_DocDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueDocType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueSender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueReceiver)).BeginInit();
            this.pUnion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            this.msData.SuspendLayout();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcOBJECT_ID
            // 
            this.gcOBJECT_ID.Caption = "Код SSCC/SGTIN";
            this.gcOBJECT_ID.FieldName = "OBJECT_ID";
            this.gcOBJECT_ID.Name = "gcOBJECT_ID";
            this.gcOBJECT_ID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "OBJECT_ID", "{0}")});
            this.gcOBJECT_ID.Visible = true;
            this.gcOBJECT_ID.VisibleIndex = 1;
            this.gcOBJECT_ID.Width = 261;
            // 
            // cmsGtin
            // 
            this.cmsGtin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.получитьДетальнуюИнформациюИнформациюПоNjdfheGTINToolStripMenuItem,
            this.получениеПубличнойИнформацииОбЛПToolStripMenuItem});
            this.cmsGtin.Name = "cmsGtin";
            this.cmsGtin.Size = new System.Drawing.Size(468, 48);
            // 
            // получитьДетальнуюИнформациюИнформациюПоNjdfheGTINToolStripMenuItem
            // 
            this.получитьДетальнуюИнформациюИнформациюПоNjdfheGTINToolStripMenuItem.Name = "получитьДетальнуюИнформациюИнформациюПоNjdfheGTINToolStripMenuItem";
            this.получитьДетальнуюИнформациюИнформациюПоNjdfheGTINToolStripMenuItem.Size = new System.Drawing.Size(467, 22);
            this.получитьДетальнуюИнформациюИнформациюПоNjdfheGTINToolStripMenuItem.Text = "8.5.2 Получить детальную информацию информацию по njdfhe (GTIN)";
            // 
            // получениеПубличнойИнформацииОбЛПToolStripMenuItem
            // 
            this.получениеПубличнойИнформацииОбЛПToolStripMenuItem.Name = "получениеПубличнойИнформацииОбЛПToolStripMenuItem";
            this.получениеПубличнойИнформацииОбЛПToolStripMenuItem.Size = new System.Drawing.Size(467, 22);
            this.получениеПубличнойИнформацииОбЛПToolStripMenuItem.Text = "8.5.4 Получение публичной информации об ЛП";
            // 
            // scDocs
            // 
            this.scDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scDocs.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scDocs.Location = new System.Drawing.Point(0, 24);
            this.scDocs.Name = "scDocs";
            this.scDocs.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scDocs.Panel1
            // 
            this.scDocs.Panel1.Controls.Add(this.pHeader);
            // 
            // scDocs.Panel2
            // 
            this.scDocs.Panel2.Controls.Add(this.pUnion);
            this.scDocs.Size = new System.Drawing.Size(720, 456);
            this.scDocs.SplitterDistance = 86;
            this.scDocs.TabIndex = 4;
            // 
            // pHeader
            // 
            this.pHeader.Controls.Add(this.vGridControl);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(720, 86);
            this.pHeader.TabIndex = 0;
            // 
            // vGridControl
            // 
            this.vGridControl.Appearance.ReadOnlyRecordValue.ForeColor = System.Drawing.Color.Black;
            this.vGridControl.Appearance.ReadOnlyRecordValue.Options.UseForeColor = true;
            this.vGridControl.Appearance.ReadOnlyRow.ForeColor = System.Drawing.Color.Black;
            this.vGridControl.Appearance.ReadOnlyRow.Options.UseForeColor = true;
            this.vGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.vGridControl.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.vGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl.Location = new System.Drawing.Point(0, 0);
            this.vGridControl.Name = "vGridControl";
            this.vGridControl.OptionsFilter.AllowFilter = false;
            this.vGridControl.OptionsFilter.AllowFilterEditor = false;
            this.vGridControl.RecordWidth = 166;
            this.vGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riDateEdit_DocDate,
            this.rilueDocType,
            this.rilueSender,
            this.rilueReceiver,
            this.repositoryItemLookUpEdit1});
            this.vGridControl.RowHeaderWidth = 34;
            this.vGridControl.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowDOC_TYPE,
            this.rowDOC_DATE,
            this.rowSENDER,
            this.rowRECEIVER});
            this.vGridControl.Size = new System.Drawing.Size(720, 86);
            this.vGridControl.TabIndex = 0;
            // 
            // riDateEdit_DocDate
            // 
            this.riDateEdit_DocDate.AutoHeight = false;
            this.riDateEdit_DocDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riDateEdit_DocDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riDateEdit_DocDate.Name = "riDateEdit_DocDate";
            // 
            // rilueDocType
            // 
            this.rilueDocType.AutoHeight = false;
            this.rilueDocType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close)});
            this.rilueDocType.Name = "rilueDocType";
            this.rilueDocType.NullText = "[не выбрано]";
            this.rilueDocType.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.rilueDocType.ShowFooter = false;
            this.rilueDocType.ShowHeader = false;
            // 
            // rilueSender
            // 
            this.rilueSender.AutoHeight = false;
            this.rilueSender.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close)});
            this.rilueSender.Name = "rilueSender";
            this.rilueSender.NullText = "[не выбрано]";
            this.rilueSender.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.rilueSender.ShowFooter = false;
            this.rilueSender.ShowHeader = false;
            // 
            // rilueReceiver
            // 
            this.rilueReceiver.AutoHeight = false;
            this.rilueReceiver.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close)});
            this.rilueReceiver.Name = "rilueReceiver";
            this.rilueReceiver.NullText = "[не выбрано]";
            this.rilueReceiver.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.rilueReceiver.ShowFooter = false;
            this.rilueReceiver.ShowHeader = false;
            // 
            // rowDOC_TYPE
            // 
            this.rowDOC_TYPE.Name = "rowDOC_TYPE";
            this.rowDOC_TYPE.Properties.Caption = "Тип документа";
            this.rowDOC_TYPE.Properties.FieldName = "DOC_TYPE";
            this.rowDOC_TYPE.Properties.ReadOnly = false;
            this.rowDOC_TYPE.Properties.RowEdit = this.rilueDocType;
            // 
            // rowDOC_DATE
            // 
            this.rowDOC_DATE.Name = "rowDOC_DATE";
            this.rowDOC_DATE.Properties.Caption = "Дата документа";
            this.rowDOC_DATE.Properties.FieldName = "DOC_DATE";
            this.rowDOC_DATE.Properties.ReadOnly = false;
            this.rowDOC_DATE.Properties.RowEdit = this.riDateEdit_DocDate;
            // 
            // rowSENDER
            // 
            this.rowSENDER.Name = "rowSENDER";
            this.rowSENDER.Properties.Caption = "Отправитель";
            this.rowSENDER.Properties.FieldName = "SENDER";
            this.rowSENDER.Properties.ReadOnly = false;
            this.rowSENDER.Properties.RowEdit = this.rilueSender;
            // 
            // rowRECEIVER
            // 
            this.rowRECEIVER.Name = "rowRECEIVER";
            this.rowRECEIVER.Properties.Caption = "Получатель";
            this.rowRECEIVER.Properties.FieldName = "RECEIVER";
            this.rowRECEIVER.Properties.ReadOnly = false;
            this.rowRECEIVER.Properties.RowEdit = this.rilueReceiver;
            // 
            // pUnion
            // 
            this.pUnion.Controls.Add(this.cData);
            this.pUnion.Controls.Add(this.msData);
            this.pUnion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pUnion.Location = new System.Drawing.Point(0, 0);
            this.pUnion.Name = "pUnion";
            this.pUnion.Size = new System.Drawing.Size(720, 366);
            this.pUnion.TabIndex = 8;
            // 
            // cData
            // 
            this.cData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cData.Location = new System.Drawing.Point(0, 24);
            this.cData.MainView = this.vData;
            this.cData.Name = "cData";
            this.cData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2,
            this.repositoryItemCalcEdit1});
            this.cData.Size = new System.Drawing.Size(720, 342);
            this.cData.TabIndex = 5;
            this.cData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vData});
            // 
            // vData
            // 
            this.vData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcHS,
            this.gcOBJECT_ID,
            this.gcCOST,
            this.gcVAT_VALUE,
            this.gcIS_BALANCE,
            this.gcMSG});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.gcOBJECT_ID;
            gridFormatRule1.Name = "FormatObjectIdLength";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(191)))));
            formatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression1.Expression = "Not Len([OBJECT_ID]) In (18, 27) Or [IS_BALANCE] <> 1";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "FormatChecked";
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.Honeydew;
            formatConditionRuleExpression2.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression2.Expression = "[IS_BALANCE] = 1";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            this.vData.FormatRules.Add(gridFormatRule1);
            this.vData.FormatRules.Add(gridFormatRule2);
            this.vData.GridControl = this.cData;
            this.vData.Name = "vData";
            this.vData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.vData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.vData.OptionsBehavior.AllowIncrementalSearch = true;
            this.vData.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.vData.OptionsView.ColumnAutoWidth = false;
            this.vData.OptionsView.ShowFooter = true;
            this.vData.OptionsView.ShowGroupPanel = false;
            this.vData.OptionsView.ShowViewCaption = true;
            this.vData.ViewCaption = "Содержимое документа";
            // 
            // gcHS
            // 
            this.gcHS.AppearanceHeader.Options.UseTextOptions = true;
            this.gcHS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcHS.Caption = "✔";
            this.gcHS.ColumnEdit = this.repositoryItemCheckEdit2;
            this.gcHS.FieldName = "HANDLE_SELECT";
            this.gcHS.Name = "gcHS";
            this.gcHS.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gcHS.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HANDLE_SELECT", "{0}")});
            this.gcHS.Visible = true;
            this.gcHS.VisibleIndex = 0;
            this.gcHS.Width = 62;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit2.ValueChecked = 1;
            this.repositoryItemCheckEdit2.ValueUnchecked = 0;
            // 
            // gcCOST
            // 
            this.gcCOST.Caption = "Цена";
            this.gcCOST.ColumnEdit = this.repositoryItemCalcEdit1;
            this.gcCOST.FieldName = "COST";
            this.gcCOST.Name = "gcCOST";
            this.gcCOST.Visible = true;
            this.gcCOST.VisibleIndex = 2;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // gcVAT_VALUE
            // 
            this.gcVAT_VALUE.Caption = "НДС";
            this.gcVAT_VALUE.ColumnEdit = this.repositoryItemCalcEdit1;
            this.gcVAT_VALUE.FieldName = "VAT_VALUE";
            this.gcVAT_VALUE.Name = "gcVAT_VALUE";
            this.gcVAT_VALUE.Visible = true;
            this.gcVAT_VALUE.VisibleIndex = 3;
            // 
            // gcIS_BALANCE
            // 
            this.gcIS_BALANCE.Caption = "Проверен";
            this.gcIS_BALANCE.ColumnEdit = this.repositoryItemCheckEdit2;
            this.gcIS_BALANCE.FieldName = "IS_BALANCE";
            this.gcIS_BALANCE.Name = "gcIS_BALANCE";
            this.gcIS_BALANCE.OptionsColumn.AllowEdit = false;
            this.gcIS_BALANCE.OptionsColumn.ReadOnly = true;
            this.gcIS_BALANCE.Visible = true;
            this.gcIS_BALANCE.VisibleIndex = 4;
            this.gcIS_BALANCE.Width = 62;
            // 
            // gcMSG
            // 
            this.gcMSG.Caption = "Примечание";
            this.gcMSG.FieldName = "MSG";
            this.gcMSG.Name = "gcMSG";
            this.gcMSG.OptionsColumn.AllowEdit = false;
            this.gcMSG.OptionsColumn.ReadOnly = true;
            this.gcMSG.Visible = true;
            this.gcMSG.VisibleIndex = 5;
            this.gcMSG.Width = 196;
            // 
            // msData
            // 
            this.msData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiActionData});
            this.msData.Location = new System.Drawing.Point(0, 0);
            this.msData.Name = "msData";
            this.msData.Size = new System.Drawing.Size(720, 24);
            this.msData.TabIndex = 3;
            this.msData.Text = "menuStrip1";
            // 
            // tsmiActionData
            // 
            this.tsmiActionData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiActionData_LoadFromExcel,
            this.tsmiActionData_Check,
            this.toolStripMenuItem1,
            this.tsmiActionData_Add,
            this.tsmiActionData_Del,
            this.toolStripMenuItem2,
            this.tsmiActionData_Clear});
            this.tsmiActionData.Image = global::PMMarkingUI.Properties.Resources.action;
            this.tsmiActionData.Name = "tsmiActionData";
            this.tsmiActionData.Size = new System.Drawing.Size(86, 20);
            this.tsmiActionData.Text = "Действия";
            // 
            // tsmiActionData_LoadFromExcel
            // 
            this.tsmiActionData_LoadFromExcel.Image = global::PMMarkingUI.Properties.Resources.icon_file2;
            this.tsmiActionData_LoadFromExcel.Name = "tsmiActionData_LoadFromExcel";
            this.tsmiActionData_LoadFromExcel.Size = new System.Drawing.Size(180, 22);
            this.tsmiActionData_LoadFromExcel.Text = "Импорт из Excel";
            this.tsmiActionData_LoadFromExcel.Click += new System.EventHandler(this.tsmiActionData_LoadFromExcel_Click);
            // 
            // tsmiActionData_Check
            // 
            this.tsmiActionData_Check.Image = global::PMMarkingUI.Properties.Resources.ok_green1;
            this.tsmiActionData_Check.Name = "tsmiActionData_Check";
            this.tsmiActionData_Check.Size = new System.Drawing.Size(180, 22);
            this.tsmiActionData_Check.Text = "Проверить данные";
            this.tsmiActionData_Check.Click += new System.EventHandler(this.tsmiActionData_Check_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiActionData_Add
            // 
            this.tsmiActionData_Add.Image = global::PMMarkingUI.Properties.Resources.icon_add;
            this.tsmiActionData_Add.Name = "tsmiActionData_Add";
            this.tsmiActionData_Add.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert)));
            this.tsmiActionData_Add.Size = new System.Drawing.Size(180, 22);
            this.tsmiActionData_Add.Text = "Добавить";
            this.tsmiActionData_Add.Click += new System.EventHandler(this.tsmiActionData_Add_Click);
            // 
            // tsmiActionData_Del
            // 
            this.tsmiActionData_Del.Image = global::PMMarkingUI.Properties.Resources.icon_cancel_color;
            this.tsmiActionData_Del.Name = "tsmiActionData_Del";
            this.tsmiActionData_Del.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.tsmiActionData_Del.Size = new System.Drawing.Size(180, 22);
            this.tsmiActionData_Del.Text = "Удалить";
            this.tsmiActionData_Del.Click += new System.EventHandler(this.tsmiActionData_Del_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiActionData_Clear
            // 
            this.tsmiActionData_Clear.Image = global::PMMarkingUI.Properties.Resources.icon_delete;
            this.tsmiActionData_Clear.Name = "tsmiActionData_Clear";
            this.tsmiActionData_Clear.Size = new System.Drawing.Size(180, 22);
            this.tsmiActionData_Clear.Text = "Очистить все";
            this.tsmiActionData_Clear.Click += new System.EventHandler(this.tsmiActionData_Clear_Click);
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiActionDoc});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(720, 24);
            this.msMain.TabIndex = 4;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiActionDoc
            // 
            this.tsmiActionDoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiActionDoc_Create});
            this.tsmiActionDoc.Image = global::PMMarkingUI.Properties.Resources.action;
            this.tsmiActionDoc.Name = "tsmiActionDoc";
            this.tsmiActionDoc.Size = new System.Drawing.Size(86, 20);
            this.tsmiActionDoc.Text = "Действия";
            // 
            // tsmiActionDoc_Create
            // 
            this.tsmiActionDoc_Create.Image = global::PMMarkingUI.Properties.Resources.icon_file;
            this.tsmiActionDoc_Create.Name = "tsmiActionDoc_Create";
            this.tsmiActionDoc_Create.Size = new System.Drawing.Size(213, 22);
            this.tsmiActionDoc_Create.Text = "Сформировать документ";
            this.tsmiActionDoc_Create.Click += new System.EventHandler(this.tsmiActionDoc_Create_Click);
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // CreateDocumentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scDocs);
            this.Controls.Add(this.msMain);
            this.Name = "CreateDocumentView";
            this.Size = new System.Drawing.Size(720, 480);
            this.cmsGtin.ResumeLayout(false);
            this.scDocs.Panel1.ResumeLayout(false);
            this.scDocs.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scDocs)).EndInit();
            this.scDocs.ResumeLayout(false);
            this.pHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit_DocDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit_DocDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueDocType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueSender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueReceiver)).EndInit();
            this.pUnion.ResumeLayout(false);
            this.pUnion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            this.msData.ResumeLayout(false);
            this.msData.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsGtin;
        private System.Windows.Forms.ToolStripMenuItem получитьДетальнуюИнформациюИнформациюПоNjdfheGTINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получениеПубличнойИнформацииОбЛПToolStripMenuItem;
        private System.Windows.Forms.SplitContainer scDocs;
        private System.Windows.Forms.Panel pHeader;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit riDateEdit_DocDate;
        private System.Windows.Forms.Panel pUnion;
        private System.Windows.Forms.MenuStrip msData;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDOC_TYPE;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDOC_DATE;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowSENDER;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowRECEIVER;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionData;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionData_LoadFromExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionData_Add;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionData_Del;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionData_Clear;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionDoc;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionDoc_Create;
        private DevExpress.XtraGrid.GridControl cData;
        private DevExpress.XtraGrid.Views.Grid.GridView vData;
        private DevExpress.XtraGrid.Columns.GridColumn gcHS;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gcOBJECT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn gcCOST;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gcVAT_VALUE;
        private DevExpress.XtraGrid.Columns.GridColumn gcIS_BALANCE;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionData_Check;
        private DevExpress.XtraGrid.Columns.GridColumn gcMSG;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueDocType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueSender;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueReceiver;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    }
}
