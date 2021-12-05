namespace PMMarkingUI.Forms.Documents
{
    partial class frmDocument335
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.custom_procedure_code_enum = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.pUnion = new System.Windows.Forms.Panel();
            this.cData = new DevExpress.XtraGrid.GridControl();
            this.vData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gcOBJECT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCOST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.cmsGtin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.получитьДетальнуюИнформациюИнформациюПоNjdfheGTINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получениеПубличнойИнформацииОбЛПToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHeader = new System.Windows.Forms.Panel();
            this.vGridControl = new DevExpress.XtraVerticalGrid.VGridControl();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiActionDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActionDoc_Create = new System.Windows.Forms.ToolStripMenuItem();
            this.scDocs = new System.Windows.Forms.SplitContainer();
            this.customs_code = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.registration_date = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.gtd_number = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.custom_procedure_code = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.riDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gcTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcGTIN = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.custom_procedure_code_enum)).BeginInit();
            this.pUnion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            this.cmsGtin.SuspendLayout();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl)).BeginInit();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scDocs)).BeginInit();
            this.scDocs.Panel1.SuspendLayout();
            this.scDocs.Panel2.SuspendLayout();
            this.scDocs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // custom_procedure_code_enum
            // 
            this.custom_procedure_code_enum.AutoHeight = false;
            this.custom_procedure_code_enum.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.custom_procedure_code_enum.Items.AddRange(new object[] {
            "40 - выпуск для внутреннего потребления",
            "93 - уничтожение",
            "94 - отказ в пользу государства",
            "31 - реэкспорт",
            "10 - экспорт",
            "80 - таможенный транзит"});
            this.custom_procedure_code_enum.Name = "custom_procedure_code_enum";
            // 
            // pUnion
            // 
            this.pUnion.Controls.Add(this.cData);
            this.pUnion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pUnion.Location = new System.Drawing.Point(0, 0);
            this.pUnion.Name = "pUnion";
            this.pUnion.Size = new System.Drawing.Size(800, 333);
            this.pUnion.TabIndex = 8;
            // 
            // cData
            // 
            this.cData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cData.Location = new System.Drawing.Point(0, 0);
            this.cData.MainView = this.vData;
            this.cData.Name = "cData";
            this.cData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2,
            this.repositoryItemCalcEdit1});
            this.cData.Size = new System.Drawing.Size(800, 333);
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
            this.gcNDS,
            this.gcTax,
            this.gcGTIN});
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
            this.vData.GroupCount = 1;
            this.vData.Name = "vData";
            this.vData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.vData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.vData.OptionsBehavior.AllowIncrementalSearch = true;
            this.vData.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.vData.OptionsView.ColumnAutoWidth = false;
            this.vData.OptionsView.ShowFooter = true;
            this.vData.OptionsView.ShowViewCaption = true;
            this.vData.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcGTIN, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            // gcOBJECT_ID
            // 
            this.gcOBJECT_ID.Caption = "Код SSCC/SGTIN";
            this.gcOBJECT_ID.FieldName = "OBJECT_ID";
            this.gcOBJECT_ID.Name = "gcOBJECT_ID";
            this.gcOBJECT_ID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "OBJECT_ID", "{0}")});
            this.gcOBJECT_ID.Visible = true;
            this.gcOBJECT_ID.VisibleIndex = 0;
            this.gcOBJECT_ID.Width = 261;
            // 
            // gcCOST
            // 
            this.gcCOST.Caption = "Цена ИНВОЙС";
            this.gcCOST.FieldName = "COST";
            this.gcCOST.Name = "gcCOST";
            this.gcCOST.Visible = true;
            this.gcCOST.VisibleIndex = 1;
            this.gcCOST.Width = 94;
            // 
            // gcNDS
            // 
            this.gcNDS.Caption = "Ставка НДС, %";
            this.gcNDS.FieldName = "NDS";
            this.gcNDS.Name = "gcNDS";
            this.gcNDS.Visible = true;
            this.gcNDS.VisibleIndex = 2;
            this.gcNDS.Width = 90;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
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
            // pHeader
            // 
            this.pHeader.Controls.Add(this.vGridControl);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(800, 89);
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
            this.vGridControl.RecordWidth = 123;
            this.vGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.custom_procedure_code_enum,
            this.riDateEdit,
            this.repositoryItemTextEdit1});
            this.vGridControl.RowHeaderWidth = 77;
            this.vGridControl.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.customs_code,
            this.registration_date,
            this.gtd_number,
            this.custom_procedure_code});
            this.vGridControl.Size = new System.Drawing.Size(800, 89);
            this.vGridControl.TabIndex = 0;
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiActionDoc});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(800, 24);
            this.msMain.TabIndex = 8;
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
            this.scDocs.Size = new System.Drawing.Size(800, 426);
            this.scDocs.SplitterDistance = 89;
            this.scDocs.TabIndex = 7;
            // 
            // customs_code
            // 
            this.customs_code.Name = "customs_code";
            this.customs_code.Properties.Caption = "Код таможенного органа (*/-/-)";
            this.customs_code.Properties.RowEdit = this.repositoryItemTextEdit1;
            // 
            // registration_date
            // 
            this.registration_date.Name = "registration_date";
            this.registration_date.Properties.Caption = "Дата регистрации декларации на товары (-/*/-)";
            this.registration_date.Properties.RowEdit = this.riDateEdit;
            // 
            // gtd_number
            // 
            this.gtd_number.Name = "gtd_number";
            this.gtd_number.Properties.Caption = "Регистрационный номер декларации на товары (-/-/*)";
            this.gtd_number.Properties.RowEdit = this.repositoryItemTextEdit1;
            // 
            // custom_procedure_code
            // 
            this.custom_procedure_code.Name = "custom_procedure_code";
            this.custom_procedure_code.Properties.Caption = "Код таможенной операции";
            this.custom_procedure_code.Properties.RowEdit = this.custom_procedure_code_enum;
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
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.MaxLength = 10;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // gcTax
            // 
            this.gcTax.Caption = "Наценка Там.Органа., %";
            this.gcTax.Name = "gcTax";
            this.gcTax.Visible = true;
            this.gcTax.VisibleIndex = 3;
            this.gcTax.Width = 137;
            // 
            // gcGTIN
            // 
            this.gcGTIN.Caption = "GTIN";
            this.gcGTIN.Name = "gcGTIN";
            this.gcGTIN.Visible = true;
            this.gcGTIN.VisibleIndex = 4;
            this.gcGTIN.Width = 163;
            // 
            // frmDocument335
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scDocs);
            this.Controls.Add(this.msMain);
            this.Name = "frmDocument335";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[335] Таможенное оформление";
            ((System.ComponentModel.ISupportInitialize)(this.custom_procedure_code_enum)).EndInit();
            this.pUnion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            this.cmsGtin.ResumeLayout(false);
            this.pHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl)).EndInit();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.scDocs.Panel1.ResumeLayout(false);
            this.scDocs.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scDocs)).EndInit();
            this.scDocs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox custom_procedure_code_enum;
        private System.Windows.Forms.Panel pUnion;
        private DevExpress.XtraGrid.GridControl cData;
        private DevExpress.XtraGrid.Views.Grid.GridView vData;
        private DevExpress.XtraGrid.Columns.GridColumn gcHS;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gcOBJECT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn gcCOST;
        private DevExpress.XtraGrid.Columns.GridColumn gcNDS;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private System.Windows.Forms.ContextMenuStrip cmsGtin;
        private System.Windows.Forms.ToolStripMenuItem получитьДетальнуюИнформациюИнформациюПоNjdfheGTINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получениеПубличнойИнформацииОбЛПToolStripMenuItem;
        private System.Windows.Forms.Panel pHeader;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit riDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow customs_code;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow registration_date;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow gtd_number;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow custom_procedure_code;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionDoc;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionDoc_Create;
        private System.Windows.Forms.SplitContainer scDocs;
        private DevExpress.XtraGrid.Columns.GridColumn gcTax;
        private DevExpress.XtraGrid.Columns.GridColumn gcGTIN;
    }
}