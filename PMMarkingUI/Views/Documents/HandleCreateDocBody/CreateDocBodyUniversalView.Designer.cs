namespace PMMarkingUI.Views.Documents.HandleCreateDocBody
{
    partial class CreateDocBodyUniversalView
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
            this.gcOBJECT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riDateTimeEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.riComboBox_turnover_type = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.riComboBox_source = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.riComboBox_contract_type = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.riComboBox_MD = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.pUnion = new System.Windows.Forms.Panel();
            this.cData = new DevExpress.XtraGrid.GridControl();
            this.vData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riCheckBox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.riCalc = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.msData = new System.Windows.Forms.MenuStrip();
            this.tsmiActionData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActionData_LoadFromExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiActionData_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiActionData_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_ValueToAllRows = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActionData_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsGtin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.получитьДетальнуюИнформациюИнформациюПоNjdfheGTINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получениеПубличнойИнформацииОбЛПToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vGridControl = new DevExpress.XtraVerticalGrid.VGridControl();
            this.riDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiActionDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActionDoc_Create = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAction_ChangeDocType = new System.Windows.Forms.ToolStripMenuItem();
            this.scDocs = new System.Windows.Forms.SplitContainer();
            this.pHeader = new System.Windows.Forms.Panel();
            this.cbxOperationDate_CurrentTimestamp = new System.Windows.Forms.CheckBox();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.repositoryItemTimeSpanEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateTimeEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateTimeEdit.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComboBox_turnover_type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComboBox_source)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComboBox_contract_type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComboBox_MD)).BeginInit();
            this.pUnion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCalc)).BeginInit();
            this.msData.SuspendLayout();
            this.cmsGtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit.CalendarTimeProperties)).BeginInit();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scDocs)).BeginInit();
            this.scDocs.Panel1.SuspendLayout();
            this.scDocs.Panel2.SuspendLayout();
            this.scDocs.SuspendLayout();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeSpanEdit1)).BeginInit();
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
            // riDateTimeEdit
            // 
            this.riDateTimeEdit.AutoHeight = false;
            this.riDateTimeEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riDateTimeEdit.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.riDateTimeEdit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riDateTimeEdit.CalendarTimeProperties.DisplayFormat.FormatString = "dd.MM.yyyy hh:mm:ss";
            this.riDateTimeEdit.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.riDateTimeEdit.CalendarTimeProperties.EditFormat.FormatString = "dd.MM.yyyy hh:mm:ss";
            this.riDateTimeEdit.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.riDateTimeEdit.DisplayFormat.FormatString = "dd.MM.yyyy hh:mm:ss";
            this.riDateTimeEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.riDateTimeEdit.EditFormat.FormatString = "dd.MM.yyyy hh:mm:ss";
            this.riDateTimeEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.riDateTimeEdit.Mask.EditMask = "dd.MM.yyyy hh:mm:ss";
            this.riDateTimeEdit.Name = "riDateTimeEdit";
            this.riDateTimeEdit.NullText = "Не выбрано";
            this.riDateTimeEdit.TimeEditWidth = 1;
            // 
            // riComboBox_turnover_type
            // 
            this.riComboBox_turnover_type.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riComboBox_turnover_type.Items.AddRange(new object[] {
            "1 - продажа",
            "2 - возврат"});
            this.riComboBox_turnover_type.Name = "riComboBox_turnover_type";
            this.riComboBox_turnover_type.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // riComboBox_source
            // 
            this.riComboBox_source.AutoHeight = false;
            this.riComboBox_source.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riComboBox_source.Items.AddRange(new object[] {
            "1 - собственные средства",
            "2 - средства федерального бюджета",
            "3 - средства регионального бюджета"});
            this.riComboBox_source.Name = "riComboBox_source";
            this.riComboBox_source.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // riComboBox_contract_type
            // 
            this.riComboBox_contract_type.AutoHeight = false;
            this.riComboBox_contract_type.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riComboBox_contract_type.Items.AddRange(new object[] {
            "1 - купля продажа",
            "2 - комиссия",
            "3 - агентский договор",
            "4 - передача на безвозмездной основе",
            "5 - возврат контрактному производителю",
            "6 - государственное лекарственное обеспечение",
            "7 - договор консигнации",
            "8 - собственные средства"});
            this.riComboBox_contract_type.Name = "riComboBox_contract_type";
            this.riComboBox_contract_type.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // riComboBox_MD
            // 
            this.riComboBox_MD.AutoHeight = false;
            this.riComboBox_MD.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riComboBox_MD.Items.AddRange(new object[] {
            "00000000146887 – ПрофитМед (Марьина Роща)",
            "00000000172389 – ПрофитМед (Котельники)",
            "00000000279052 – ПМ-Фарма",
            "00000000183929 – ПрофитМед СПб",
            "00000000279106 – ФармПрофиль",
            "e53bc6e8-eca5-49e5-b5dd-1ff78f81bdd5 - ЗАО \"ПрофитМед\"",
            "29dd7576-5d4d-4cbb-a01d-fd856567f055 - ООО \"ПМ-фарма\"",
            "244adc59-8f6c-4879-99fe-578625c4fa0a - ООО \"ПрофитМед Санкт-Петербург\"",
            "7252a7d8-1214-440e-ab38-17e38f5c3fa9 - ООО \"ФАРМПРОФИЛЬ\""});
            this.riComboBox_MD.Name = "riComboBox_MD";
            // 
            // pUnion
            // 
            this.pUnion.Controls.Add(this.cData);
            this.pUnion.Controls.Add(this.msData);
            this.pUnion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pUnion.Location = new System.Drawing.Point(0, 0);
            this.pUnion.Name = "pUnion";
            this.pUnion.Size = new System.Drawing.Size(720, 269);
            this.pUnion.TabIndex = 8;
            // 
            // cData
            // 
            this.cData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cData.Location = new System.Drawing.Point(0, 24);
            this.cData.MainView = this.vData;
            this.cData.Name = "cData";
            this.cData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riCheckBox,
            this.riCalc});
            this.cData.Size = new System.Drawing.Size(720, 245);
            this.cData.TabIndex = 5;
            this.cData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vData});
            // 
            // vData
            // 
            this.vData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcHS,
            this.gcOBJECT_ID});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.gcOBJECT_ID;
            gridFormatRule1.Name = "FormatRed";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression1.Expression = "Len([OBJECT_ID]) > 1 And Len([OBJECT_ID]) <> 18 And Len([OBJECT_ID]) <> 27";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.vData.FormatRules.Add(gridFormatRule1);
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
            this.gcHS.ColumnEdit = this.riCheckBox;
            this.gcHS.FieldName = "HANDLE_SELECT";
            this.gcHS.Name = "gcHS";
            this.gcHS.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gcHS.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HANDLE_SELECT", "{0}")});
            this.gcHS.Visible = true;
            this.gcHS.VisibleIndex = 0;
            this.gcHS.Width = 62;
            // 
            // riCheckBox
            // 
            this.riCheckBox.AutoHeight = false;
            this.riCheckBox.Name = "riCheckBox";
            this.riCheckBox.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.riCheckBox.ValueChecked = 1;
            this.riCheckBox.ValueUnchecked = 0;
            // 
            // riCalc
            // 
            this.riCalc.AutoHeight = false;
            this.riCalc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riCalc.Name = "riCalc";
            // 
            // msData
            // 
            this.msData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiActionData,
            this.tsmiActionData_Add});
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
            this.toolStripMenuItem1,
            this.tsmiActionData_Del,
            this.toolStripMenuItem2,
            this.tsmiActionData_Clear,
            this.tsmiAction_ValueToAllRows});
            this.tsmiActionData.Image = global::PMMarkingUI.Properties.Resources.action;
            this.tsmiActionData.Name = "tsmiActionData";
            this.tsmiActionData.Size = new System.Drawing.Size(86, 20);
            this.tsmiActionData.Text = "Действия";
            // 
            // tsmiActionData_LoadFromExcel
            // 
            this.tsmiActionData_LoadFromExcel.Image = global::PMMarkingUI.Properties.Resources.icon_file2;
            this.tsmiActionData_LoadFromExcel.Name = "tsmiActionData_LoadFromExcel";
            this.tsmiActionData_LoadFromExcel.Size = new System.Drawing.Size(332, 22);
            this.tsmiActionData_LoadFromExcel.Text = "Импорт из Excel";
            this.tsmiActionData_LoadFromExcel.Click += new System.EventHandler(this.ActionLoadFromExcel);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(329, 6);
            // 
            // tsmiActionData_Del
            // 
            this.tsmiActionData_Del.Image = global::PMMarkingUI.Properties.Resources.icon_cancel_color;
            this.tsmiActionData_Del.Name = "tsmiActionData_Del";
            this.tsmiActionData_Del.Size = new System.Drawing.Size(332, 22);
            this.tsmiActionData_Del.Text = "Удалить";
            this.tsmiActionData_Del.Click += new System.EventHandler(this.ActionDel);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(329, 6);
            // 
            // tsmiActionData_Clear
            // 
            this.tsmiActionData_Clear.Image = global::PMMarkingUI.Properties.Resources.icon_delete;
            this.tsmiActionData_Clear.Name = "tsmiActionData_Clear";
            this.tsmiActionData_Clear.Size = new System.Drawing.Size(332, 22);
            this.tsmiActionData_Clear.Text = "Очистить все";
            this.tsmiActionData_Clear.Click += new System.EventHandler(this.ActionClear);
            // 
            // tsmiAction_ValueToAllRows
            // 
            this.tsmiAction_ValueToAllRows.Name = "tsmiAction_ValueToAllRows";
            this.tsmiAction_ValueToAllRows.Size = new System.Drawing.Size(332, 22);
            this.tsmiAction_ValueToAllRows.Text = "Прописать значение во все строки по колонке";
            this.tsmiAction_ValueToAllRows.Visible = false;
            // 
            // tsmiActionData_Add
            // 
            this.tsmiActionData_Add.Image = global::PMMarkingUI.Properties.Resources.icon_add;
            this.tsmiActionData_Add.Name = "tsmiActionData_Add";
            this.tsmiActionData_Add.Size = new System.Drawing.Size(87, 20);
            this.tsmiActionData_Add.Text = "Добавить";
            this.tsmiActionData_Add.Click += new System.EventHandler(this.ActionAdd);
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
            // vGridControl
            // 
            this.vGridControl.Appearance.ReadOnlyRecordValue.ForeColor = System.Drawing.Color.Black;
            this.vGridControl.Appearance.ReadOnlyRecordValue.Options.UseForeColor = true;
            this.vGridControl.Appearance.ReadOnlyRow.ForeColor = System.Drawing.Color.Black;
            this.vGridControl.Appearance.ReadOnlyRow.Options.UseForeColor = true;
            this.vGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.vGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl.Location = new System.Drawing.Point(0, 0);
            this.vGridControl.Name = "vGridControl";
            this.vGridControl.OptionsFilter.AllowFilter = false;
            this.vGridControl.OptionsFilter.AllowFilterEditor = false;
            this.vGridControl.RecordWidth = 144;
            this.vGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riDateTimeEdit,
            this.riComboBox_turnover_type,
            this.riComboBox_source,
            this.riComboBox_contract_type,
            this.riComboBox_MD,
            this.riDateEdit});
            this.vGridControl.RowHeaderWidth = 56;
            this.vGridControl.Size = new System.Drawing.Size(720, 153);
            this.vGridControl.TabIndex = 0;
            // 
            // riDateEdit
            // 
            this.riDateEdit.AutoHeight = false;
            this.riDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riDateEdit.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.riDateEdit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riDateEdit.Name = "riDateEdit";
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiActionDoc});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(720, 24);
            this.msMain.TabIndex = 8;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiActionDoc
            // 
            this.tsmiActionDoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiActionDoc_Create,
            this.toolStripMenuItem3,
            this.tsmiAction_ChangeDocType});
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
            this.tsmiActionDoc_Create.Click += new System.EventHandler(this.ActionCreateDocument);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(210, 6);
            // 
            // tsmiAction_ChangeDocType
            // 
            this.tsmiAction_ChangeDocType.Name = "tsmiAction_ChangeDocType";
            this.tsmiAction_ChangeDocType.Size = new System.Drawing.Size(213, 22);
            this.tsmiAction_ChangeDocType.Text = "Изменить тип документа";
            this.tsmiAction_ChangeDocType.Click += new System.EventHandler(this.ActionChangeDocType);
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
            this.scDocs.SplitterDistance = 183;
            this.scDocs.TabIndex = 7;
            // 
            // pHeader
            // 
            this.pHeader.Controls.Add(this.vGridControl);
            this.pHeader.Controls.Add(this.cbxOperationDate_CurrentTimestamp);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(720, 183);
            this.pHeader.TabIndex = 0;
            // 
            // cbxOperationDate_CurrentTimestamp
            // 
            this.cbxOperationDate_CurrentTimestamp.Checked = true;
            this.cbxOperationDate_CurrentTimestamp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxOperationDate_CurrentTimestamp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbxOperationDate_CurrentTimestamp.Location = new System.Drawing.Point(0, 153);
            this.cbxOperationDate_CurrentTimestamp.Name = "cbxOperationDate_CurrentTimestamp";
            this.cbxOperationDate_CurrentTimestamp.Size = new System.Drawing.Size(720, 30);
            this.cbxOperationDate_CurrentTimestamp.TabIndex = 1;
            this.cbxOperationDate_CurrentTimestamp.Text = "Прописать на документ дату операции автоматически (текущее время)";
            this.cbxOperationDate_CurrentTimestamp.UseVisualStyleBackColor = true;
            this.cbxOperationDate_CurrentTimestamp.CheckedChanged += new System.EventHandler(this.cbxOperationDate_CurrentTimestamp_CheckedChanged);
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // repositoryItemTimeSpanEdit1
            // 
            this.repositoryItemTimeSpanEdit1.AutoHeight = false;
            this.repositoryItemTimeSpanEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeSpanEdit1.Name = "repositoryItemTimeSpanEdit1";
            // 
            // CreateDocBodyUniversalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scDocs);
            this.Controls.Add(this.msMain);
            this.Name = "CreateDocBodyUniversalView";
            this.Size = new System.Drawing.Size(720, 480);
            ((System.ComponentModel.ISupportInitialize)(this.riDateTimeEdit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateTimeEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComboBox_turnover_type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComboBox_source)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComboBox_contract_type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComboBox_MD)).EndInit();
            this.pUnion.ResumeLayout(false);
            this.pUnion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCalc)).EndInit();
            this.msData.ResumeLayout(false);
            this.msData.PerformLayout();
            this.cmsGtin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit)).EndInit();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.scDocs.Panel1.ResumeLayout(false);
            this.scDocs.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scDocs)).EndInit();
            this.scDocs.ResumeLayout(false);
            this.pHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeSpanEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit riDateTimeEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox riComboBox_turnover_type;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox riComboBox_source;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox riComboBox_contract_type;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox riComboBox_MD;
        private System.Windows.Forms.Panel pUnion;
        private DevExpress.XtraGrid.GridControl cData;
        private DevExpress.XtraGrid.Views.Grid.GridView vData;
        private DevExpress.XtraGrid.Columns.GridColumn gcHS;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riCheckBox;
        private DevExpress.XtraGrid.Columns.GridColumn gcOBJECT_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit riCalc;
        private System.Windows.Forms.MenuStrip msData;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionData;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionData_LoadFromExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionData_Del;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionData_Clear;
        private System.Windows.Forms.ContextMenuStrip cmsGtin;
        private System.Windows.Forms.ToolStripMenuItem получитьДетальнуюИнформациюИнформациюПоNjdfheGTINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получениеПубличнойИнформацииОбЛПToolStripMenuItem;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionDoc;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionDoc_Create;
        private System.Windows.Forms.SplitContainer scDocs;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.CheckBox cbxOperationDate_CurrentTimestamp;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionData_Add;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_ChangeDocType;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_ValueToAllRows;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit riDateEdit;
    }
}
