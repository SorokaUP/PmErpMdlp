namespace PMMarkingUI.Views
{
    partial class CounteragentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CounteragentView));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.pTWCounteragent = new System.Windows.Forms.Panel();
            this.vgcTWCounteragent = new DevExpress.XtraVerticalGrid.VGridControl();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.rootTWCounteragent = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.rowTW_ID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTW_LID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTW_NAME = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTW_PARENT_NAME = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTW_PARENT_ID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTW_INN = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTW_CODE = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTW_IS_VERIFY = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTW_SYS_ID_CBX = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.xtcPages = new DevExpress.XtraTab.XtraTabControl();
            this.xtpAddresses = new DevExpress.XtraTab.XtraTabPage();
            this.counteragentsAddresses = new PMMarkingUI.Views.CounteragentsAddresses();
            this.xtpContract = new DevExpress.XtraTab.XtraTabPage();
            this.scContracts = new System.Windows.Forms.SplitContainer();
            this.tlContracts = new DevExpress.XtraTreeList.TreeList();
            this.tlcC_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcC_Name = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcC_Date = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlTerms = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.rowTW_SYS_ID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.pTWCounteragent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vgcTWCounteragent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPages)).BeginInit();
            this.xtcPages.SuspendLayout();
            this.xtpAddresses.SuspendLayout();
            this.xtpContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContracts)).BeginInit();
            this.scContracts.Panel1.SuspendLayout();
            this.scContracts.Panel2.SuspendLayout();
            this.scContracts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlTerms)).BeginInit();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.pTWCounteragent);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.xtcPages);
            this.scMain.Size = new System.Drawing.Size(1024, 768);
            this.scMain.SplitterDistance = 193;
            this.scMain.TabIndex = 0;
            // 
            // pTWCounteragent
            // 
            this.pTWCounteragent.Controls.Add(this.vgcTWCounteragent);
            this.pTWCounteragent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTWCounteragent.Location = new System.Drawing.Point(0, 0);
            this.pTWCounteragent.Name = "pTWCounteragent";
            this.pTWCounteragent.Size = new System.Drawing.Size(1024, 193);
            this.pTWCounteragent.TabIndex = 1;
            // 
            // vgcTWCounteragent
            // 
            this.vgcTWCounteragent.Appearance.ReadOnlyRecordValue.ForeColor = System.Drawing.Color.Black;
            this.vgcTWCounteragent.Appearance.ReadOnlyRecordValue.Options.UseForeColor = true;
            this.vgcTWCounteragent.Appearance.ReadOnlyRow.ForeColor = System.Drawing.Color.Black;
            this.vgcTWCounteragent.Appearance.ReadOnlyRow.Options.UseFont = true;
            this.vgcTWCounteragent.Appearance.ReadOnlyRow.Options.UseForeColor = true;
            this.vgcTWCounteragent.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.vgcTWCounteragent.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.vgcTWCounteragent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vgcTWCounteragent.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vgcTWCounteragent.Location = new System.Drawing.Point(0, 0);
            this.vgcTWCounteragent.Name = "vgcTWCounteragent";
            this.vgcTWCounteragent.OptionsFilter.AllowFilter = false;
            this.vgcTWCounteragent.OptionsFilter.AllowFilterEditor = false;
            this.vgcTWCounteragent.RecordWidth = 150;
            this.vgcTWCounteragent.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemCheckEdit1});
            this.vgcTWCounteragent.RowHeaderWidth = 50;
            this.vgcTWCounteragent.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rootTWCounteragent});
            this.vgcTWCounteragent.Size = new System.Drawing.Size(1024, 193);
            this.vgcTWCounteragent.TabIndex = 1;
            this.vgcTWCounteragent.RecordCellStyle += new DevExpress.XtraVerticalGrid.Events.GetCustomRowCellStyleEventHandler(this.vGridControl_RecordCellStyle);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // rootTWCounteragent
            // 
            this.rootTWCounteragent.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowTW_ID,
            this.rowTW_LID,
            this.rowTW_NAME,
            this.rowTW_PARENT_NAME,
            this.rowTW_INN,
            this.rowTW_CODE,
            this.rowTW_IS_VERIFY,
            this.rowTW_SYS_ID_CBX,
            this.rowTW_SYS_ID});
            this.rootTWCounteragent.Name = "rootTWCounteragent";
            this.rootTWCounteragent.Properties.Caption = "Контрагент TW4";
            // 
            // rowTW_ID
            // 
            this.rowTW_ID.Name = "rowTW_ID";
            this.rowTW_ID.Properties.Caption = "ID";
            this.rowTW_ID.Properties.FieldName = "ID";
            this.rowTW_ID.Properties.ReadOnly = true;
            // 
            // rowTW_LID
            // 
            this.rowTW_LID.Name = "rowTW_LID";
            this.rowTW_LID.Properties.Caption = "LID";
            this.rowTW_LID.Properties.FieldName = "LID";
            this.rowTW_LID.Properties.ReadOnly = true;
            // 
            // rowTW_NAME
            // 
            this.rowTW_NAME.Name = "rowTW_NAME";
            this.rowTW_NAME.Properties.Caption = "Наименование";
            this.rowTW_NAME.Properties.FieldName = "NAME";
            // 
            // rowTW_PARENT_NAME
            // 
            this.rowTW_PARENT_NAME.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowTW_PARENT_ID});
            this.rowTW_PARENT_NAME.Name = "rowTW_PARENT_NAME";
            this.rowTW_PARENT_NAME.Properties.Caption = "Папка";
            this.rowTW_PARENT_NAME.Properties.FieldName = "PARENT_NAME";
            this.rowTW_PARENT_NAME.Properties.ReadOnly = true;
            // 
            // rowTW_PARENT_ID
            // 
            this.rowTW_PARENT_ID.Name = "rowTW_PARENT_ID";
            this.rowTW_PARENT_ID.Properties.Caption = "PARENT_ID";
            this.rowTW_PARENT_ID.Properties.FieldName = "PARENT_ID";
            this.rowTW_PARENT_ID.Properties.ReadOnly = true;
            // 
            // rowTW_INN
            // 
            this.rowTW_INN.Name = "rowTW_INN";
            this.rowTW_INN.Properties.Caption = "ИНН";
            this.rowTW_INN.Properties.FieldName = "INN";
            this.rowTW_INN.Properties.ReadOnly = true;
            // 
            // rowTW_CODE
            // 
            this.rowTW_CODE.Name = "rowTW_CODE";
            this.rowTW_CODE.Properties.Caption = "Короткий код";
            this.rowTW_CODE.Properties.FieldName = "CODE";
            this.rowTW_CODE.Properties.ReadOnly = true;
            // 
            // rowTW_IS_VERIFY
            // 
            this.rowTW_IS_VERIFY.Name = "rowTW_IS_VERIFY";
            this.rowTW_IS_VERIFY.Properties.AllowEdit = false;
            this.rowTW_IS_VERIFY.Properties.Caption = "Доверенный";
            this.rowTW_IS_VERIFY.Properties.FieldName = "IS_VERIFY";
            this.rowTW_IS_VERIFY.Properties.ReadOnly = true;
            this.rowTW_IS_VERIFY.Properties.RowEdit = this.repositoryItemCheckEdit1;
            // 
            // rowTW_SYS_ID_CBX
            // 
            this.rowTW_SYS_ID_CBX.Name = "rowTW_SYS_ID_CBX";
            this.rowTW_SYS_ID_CBX.Properties.Caption = "Связан с МДЛП";
            this.rowTW_SYS_ID_CBX.Properties.FieldName = "SYS_ID";
            this.rowTW_SYS_ID_CBX.Properties.ReadOnly = true;
            // 
            // xtcPages
            // 
            this.xtcPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtcPages.Location = new System.Drawing.Point(0, 0);
            this.xtcPages.LookAndFeel.SkinName = "Office 2013";
            this.xtcPages.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xtcPages.Name = "xtcPages";
            this.xtcPages.SelectedTabPage = this.xtpAddresses;
            this.xtcPages.Size = new System.Drawing.Size(1024, 571);
            this.xtcPages.TabIndex = 1;
            this.xtcPages.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpAddresses,
            this.xtpContract});
            // 
            // xtpAddresses
            // 
            this.xtpAddresses.Controls.Add(this.counteragentsAddresses);
            this.xtpAddresses.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtpAddresses.ImageOptions.SvgImage")));
            this.xtpAddresses.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.xtpAddresses.Name = "xtpAddresses";
            this.xtpAddresses.Size = new System.Drawing.Size(1022, 544);
            this.xtpAddresses.Text = "Адресные данные";
            // 
            // counteragentsAddresses
            // 
            this.counteragentsAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.counteragentsAddresses.Location = new System.Drawing.Point(0, 0);
            this.counteragentsAddresses.Name = "counteragentsAddresses";
            this.counteragentsAddresses.Size = new System.Drawing.Size(1022, 544);
            this.counteragentsAddresses.TabIndex = 0;
            // 
            // xtpContract
            // 
            this.xtpContract.Controls.Add(this.scContracts);
            this.xtpContract.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("xtpContract.ImageOptions.SvgImage")));
            this.xtpContract.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.xtpContract.Name = "xtpContract";
            this.xtpContract.Size = new System.Drawing.Size(1022, 544);
            this.xtpContract.Text = "Договоры";
            // 
            // scContracts
            // 
            this.scContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContracts.Location = new System.Drawing.Point(0, 0);
            this.scContracts.Name = "scContracts";
            // 
            // scContracts.Panel1
            // 
            this.scContracts.Panel1.Controls.Add(this.tlContracts);
            // 
            // scContracts.Panel2
            // 
            this.scContracts.Panel2.Controls.Add(this.tlTerms);
            this.scContracts.Size = new System.Drawing.Size(1022, 544);
            this.scContracts.SplitterDistance = 517;
            this.scContracts.TabIndex = 0;
            // 
            // tlContracts
            // 
            this.tlContracts.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcC_ID,
            this.tlcC_Name,
            this.tlcC_Date});
            this.tlContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlContracts.Location = new System.Drawing.Point(0, 0);
            this.tlContracts.Name = "tlContracts";
            this.tlContracts.OptionsView.AutoWidth = false;
            this.tlContracts.Size = new System.Drawing.Size(517, 544);
            this.tlContracts.TabIndex = 0;
            // 
            // tlcC_ID
            // 
            this.tlcC_ID.Caption = "ID (xec)";
            this.tlcC_ID.FieldName = "ID (xec)";
            this.tlcC_ID.Name = "tlcC_ID";
            this.tlcC_ID.Visible = true;
            this.tlcC_ID.VisibleIndex = 0;
            this.tlcC_ID.Width = 70;
            // 
            // tlcC_Name
            // 
            this.tlcC_Name.Caption = "Наименование";
            this.tlcC_Name.FieldName = "NAME";
            this.tlcC_Name.Name = "tlcC_Name";
            this.tlcC_Name.Visible = true;
            this.tlcC_Name.VisibleIndex = 1;
            this.tlcC_Name.Width = 150;
            // 
            // tlcC_Date
            // 
            this.tlcC_Date.Caption = "Дата";
            this.tlcC_Date.FieldName = "DATE";
            this.tlcC_Date.Name = "tlcC_Date";
            this.tlcC_Date.Visible = true;
            this.tlcC_Date.VisibleIndex = 2;
            this.tlcC_Date.Width = 100;
            // 
            // tlTerms
            // 
            this.tlTerms.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.tlTerms.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.tlTerms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlTerms.Location = new System.Drawing.Point(0, 0);
            this.tlTerms.Name = "tlTerms";
            this.tlTerms.OptionsView.AutoWidth = false;
            this.tlTerms.Size = new System.Drawing.Size(501, 544);
            this.tlTerms.TabIndex = 1;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "ID (xec)";
            this.treeListColumn1.FieldName = "ID";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 70;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Наименование";
            this.treeListColumn2.FieldName = "NAME";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 250;
            // 
            // rowTW_SYS_ID
            // 
            this.rowTW_SYS_ID.Name = "rowTW_SYS_ID";
            this.rowTW_SYS_ID.Properties.Caption = "Контрагент МДЛП (SYSTEM_SUBJ_ID)";
            this.rowTW_SYS_ID.Properties.FieldName = "SYS_ID";
            // 
            // CounteragentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scMain);
            this.Name = "CounteragentView";
            this.Size = new System.Drawing.Size(1024, 768);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.pTWCounteragent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vgcTWCounteragent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPages)).EndInit();
            this.xtcPages.ResumeLayout(false);
            this.xtpAddresses.ResumeLayout(false);
            this.xtpContract.ResumeLayout(false);
            this.scContracts.Panel1.ResumeLayout(false);
            this.scContracts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContracts)).EndInit();
            this.scContracts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlTerms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.Panel pTWCounteragent;
        private DevExpress.XtraTab.XtraTabControl xtcPages;
        private DevExpress.XtraTab.XtraTabPage xtpAddresses;
        private DevExpress.XtraTab.XtraTabPage xtpContract;
        private DevExpress.XtraVerticalGrid.VGridControl vgcTWCounteragent;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private CounteragentsAddresses counteragentsAddresses;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow rootTWCounteragent;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTW_ID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTW_LID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTW_NAME;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTW_PARENT_NAME;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTW_PARENT_ID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTW_INN;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTW_CODE;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTW_IS_VERIFY;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTW_SYS_ID_CBX;
        private System.Windows.Forms.SplitContainer scContracts;
        private DevExpress.XtraTreeList.TreeList tlContracts;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcC_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcC_Name;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcC_Date;
        private DevExpress.XtraTreeList.TreeList tlTerms;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTW_SYS_ID;
    }
}
