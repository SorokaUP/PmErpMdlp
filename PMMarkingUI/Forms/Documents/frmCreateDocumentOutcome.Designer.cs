namespace PMMarkingUI.Forms
{
    partial class frmCreateDocumentOutcome
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
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.docFilterTWDbView1 = new PMMarkingUI.Views.DocFilterTWDbView();
            this.scDocs = new System.Windows.Forms.SplitContainer();
            this.cDocs = new DevExpress.XtraGrid.GridControl();
            this.vDocs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.scLins = new System.Windows.Forms.SplitContainer();
            this.cLins = new DevExpress.XtraGrid.GridControl();
            this.vLins = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.tlSGTIN = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiActions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_CreateDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAction_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_ShowSelected = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scDocs)).BeginInit();
            this.scDocs.Panel1.SuspendLayout();
            this.scDocs.Panel2.SuspendLayout();
            this.scDocs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scLins)).BeginInit();
            this.scLins.Panel1.SuspendLayout();
            this.scLins.Panel2.SuspendLayout();
            this.scLins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlSGTIN)).BeginInit();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.Location = new System.Drawing.Point(0, 24);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.docFilterTWDbView1);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scDocs);
            this.scMain.Size = new System.Drawing.Size(851, 576);
            this.scMain.SplitterDistance = 166;
            this.scMain.TabIndex = 0;
            // 
            // docFilterTWDbView1
            // 
            this.docFilterTWDbView1.AutoScroll = true;
            this.docFilterTWDbView1.DelegateGetDocFilterTW = null;
            this.docFilterTWDbView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docFilterTWDbView1.Location = new System.Drawing.Point(0, 0);
            this.docFilterTWDbView1.Name = "docFilterTWDbView1";
            this.docFilterTWDbView1.Size = new System.Drawing.Size(166, 576);
            this.docFilterTWDbView1.TabIndex = 0;
            // 
            // scDocs
            // 
            this.scDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scDocs.Location = new System.Drawing.Point(0, 0);
            this.scDocs.Name = "scDocs";
            // 
            // scDocs.Panel1
            // 
            this.scDocs.Panel1.Controls.Add(this.cDocs);
            // 
            // scDocs.Panel2
            // 
            this.scDocs.Panel2.Controls.Add(this.scLins);
            this.scDocs.Size = new System.Drawing.Size(681, 576);
            this.scDocs.SplitterDistance = 226;
            this.scDocs.TabIndex = 0;
            // 
            // cDocs
            // 
            this.cDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cDocs.Location = new System.Drawing.Point(0, 0);
            this.cDocs.MainView = this.vDocs;
            this.cDocs.Name = "cDocs";
            this.cDocs.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit4});
            this.cDocs.Size = new System.Drawing.Size(226, 576);
            this.cDocs.TabIndex = 6;
            this.cDocs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vDocs});
            // 
            // vDocs
            // 
            this.vDocs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn16,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn17,
            this.gridColumn18});
            this.vDocs.GridControl = this.cDocs;
            this.vDocs.Name = "vDocs";
            this.vDocs.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.vDocs.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.vDocs.OptionsBehavior.AllowIncrementalSearch = true;
            this.vDocs.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.vDocs.OptionsBehavior.ReadOnly = true;
            this.vDocs.OptionsView.ColumnAutoWidth = false;
            this.vDocs.OptionsView.ShowFooter = true;
            this.vDocs.OptionsView.ShowViewCaption = true;
            this.vDocs.ViewCaption = "Документы TW4";
            this.vDocs.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.vDocs_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "DID";
            this.gridColumn1.FieldName = "DID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Номер";
            this.gridColumn2.FieldName = "DCODE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Дата";
            this.gridColumn3.FieldName = "DDATE1";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "DID1";
            this.gridColumn4.FieldName = "DID1";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Код контрагента";
            this.gridColumn16.FieldName = "DID1_CODE";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 4;
            this.gridColumn16.Width = 98;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Контрагент";
            this.gridColumn5.FieldName = "DID1_NAME";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 257;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Сумма";
            this.gridColumn6.FieldName = "DSUM";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "DSTATE";
            this.gridColumn17.FieldName = "DSTATE";
            this.gridColumn17.Name = "gridColumn17";
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Состояние";
            this.gridColumn18.FieldName = "DSTATE_NAME";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 6;
            this.gridColumn18.Width = 127;
            // 
            // repositoryItemCheckEdit4
            // 
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            this.repositoryItemCheckEdit4.ValueChecked = 1;
            this.repositoryItemCheckEdit4.ValueUnchecked = 0;
            // 
            // scLins
            // 
            this.scLins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scLins.Location = new System.Drawing.Point(0, 0);
            this.scLins.Name = "scLins";
            this.scLins.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scLins.Panel1
            // 
            this.scLins.Panel1.Controls.Add(this.cLins);
            // 
            // scLins.Panel2
            // 
            this.scLins.Panel2.Controls.Add(this.tlSGTIN);
            this.scLins.Size = new System.Drawing.Size(451, 576);
            this.scLins.SplitterDistance = 228;
            this.scLins.TabIndex = 0;
            // 
            // cLins
            // 
            this.cLins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cLins.Location = new System.Drawing.Point(0, 0);
            this.cLins.MainView = this.vLins;
            this.cLins.Name = "cLins";
            this.cLins.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.cLins.Size = new System.Drawing.Size(451, 228);
            this.cLins.TabIndex = 7;
            this.cLins.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vLins});
            // 
            // vLins
            // 
            this.vLins.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn14,
            this.gridColumn9,
            this.gridColumn15,
            this.gridColumn10,
            this.gridColumn13,
            this.gridColumn11,
            this.gridColumn12});
            this.vLins.GridControl = this.cLins;
            this.vLins.Name = "vLins";
            this.vLins.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.vLins.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.vLins.OptionsBehavior.AllowIncrementalSearch = true;
            this.vLins.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.vLins.OptionsBehavior.ReadOnly = true;
            this.vLins.OptionsView.ColumnAutoWidth = false;
            this.vLins.OptionsView.ShowFooter = true;
            this.vLins.OptionsView.ShowViewCaption = true;
            this.vLins.ViewCaption = "Строки документа";
            this.vLins.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.vLins_FocusedRowChanged);
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "EID";
            this.gridColumn7.FieldName = "EID";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "GOOD_ID";
            this.gridColumn8.FieldName = "GOOD_ID";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Артикул";
            this.gridColumn14.FieldName = "GOOD_CODE";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 2;
            this.gridColumn14.Width = 86;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Наименование";
            this.gridColumn9.FieldName = "GOOD_NAME";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            this.gridColumn9.Width = 169;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Серия";
            this.gridColumn15.FieldName = "SER_NAME";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 4;
            this.gridColumn15.Width = 120;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "ID Серии";
            this.gridColumn10.FieldName = "SER_ID";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Width = 90;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Кол-во";
            this.gridColumn13.FieldName = "QNT";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 5;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Цена";
            this.gridColumn11.FieldName = "PRICE";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 6;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Сумма";
            this.gridColumn12.FieldName = "SUMM";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 7;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // tlSGTIN
            // 
            this.tlSGTIN.Caption = "SGTIN";
            this.tlSGTIN.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn4,
            this.treeListColumn3,
            this.treeListColumn2,
            this.treeListColumn5,
            this.treeListColumn6});
            this.tlSGTIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlSGTIN.Location = new System.Drawing.Point(0, 0);
            this.tlSGTIN.Name = "tlSGTIN";
            this.tlSGTIN.OptionsBehavior.EditorShowMode = DevExpress.XtraTreeList.TreeListEditorShowMode.MouseDownFocused;
            this.tlSGTIN.OptionsBehavior.PopulateServiceColumns = true;
            this.tlSGTIN.OptionsBehavior.ReadOnly = true;
            this.tlSGTIN.OptionsView.BestFitMode = DevExpress.XtraTreeList.TreeListBestFitMode.Full;
            this.tlSGTIN.OptionsView.CheckBoxStyle = DevExpress.XtraTreeList.DefaultNodeCheckBoxStyle.Check;
            this.tlSGTIN.OptionsView.RootCheckBoxStyle = DevExpress.XtraTreeList.NodeCheckBoxStyle.Check;
            this.tlSGTIN.OptionsView.ShowCaption = true;
            this.tlSGTIN.Size = new System.Drawing.Size(451, 344);
            this.tlSGTIN.TabIndex = 0;
            this.tlSGTIN.NodeChanged += new DevExpress.XtraTreeList.NodeChangedEventHandler(this.tlSGTIN_NodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "SID";
            this.treeListColumn1.FieldName = "SID";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "GID";
            this.treeListColumn4.FieldName = "GID";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 3;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "SSCC_ID";
            this.treeListColumn3.FieldName = "SSCC_ID";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "ID";
            this.treeListColumn2.FieldName = "ID";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "GTIN";
            this.treeListColumn5.FieldName = "GTIN";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 4;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "SGTIN";
            this.treeListColumn6.FieldName = "SGTIN";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 5;
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiActions});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(851, 24);
            this.msMain.TabIndex = 7;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiActions
            // 
            this.tsmiActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAction_CreateDoc,
            this.tsmiAction_ShowSelected,
            this.toolStripMenuItem1,
            this.tsmiAction_Exit});
            this.tsmiActions.Name = "tsmiActions";
            this.tsmiActions.Size = new System.Drawing.Size(70, 20);
            this.tsmiActions.Text = "Действия";
            // 
            // tsmiAction_CreateDoc
            // 
            this.tsmiAction_CreateDoc.Name = "tsmiAction_CreateDoc";
            this.tsmiAction_CreateDoc.Size = new System.Drawing.Size(211, 22);
            this.tsmiAction_CreateDoc.Text = "Создать документ МДЛП";
            this.tsmiAction_CreateDoc.Click += new System.EventHandler(this.tsmiAction_CreateDoc_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(208, 6);
            // 
            // tsmiAction_Exit
            // 
            this.tsmiAction_Exit.Name = "tsmiAction_Exit";
            this.tsmiAction_Exit.Size = new System.Drawing.Size(211, 22);
            this.tsmiAction_Exit.Text = "Выход";
            this.tsmiAction_Exit.Click += new System.EventHandler(this.tsmiAction_Exit_Click);
            // 
            // tsmiAction_ShowSelected
            // 
            this.tsmiAction_ShowSelected.Name = "tsmiAction_ShowSelected";
            this.tsmiAction_ShowSelected.Size = new System.Drawing.Size(211, 22);
            this.tsmiAction_ShowSelected.Text = "Показать выбранное";
            this.tsmiAction_ShowSelected.Click += new System.EventHandler(this.tsmiAction_ShowSelected_Click);
            // 
            // frmCreateDocumentOutcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 600);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "frmCreateDocumentOutcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание отгрузочных документов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.frmCreateDocumentOutcome_Shown);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scDocs.Panel1.ResumeLayout(false);
            this.scDocs.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scDocs)).EndInit();
            this.scDocs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            this.scLins.Panel1.ResumeLayout(false);
            this.scLins.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scLins)).EndInit();
            this.scLins.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cLins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlSGTIN)).EndInit();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private Views.DocFilterTWDbView docFilterTWDbView1;
        private System.Windows.Forms.SplitContainer scDocs;
        private System.Windows.Forms.SplitContainer scLins;
        private DevExpress.XtraGrid.GridControl cDocs;
        private DevExpress.XtraGrid.Views.Grid.GridView vDocs;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private DevExpress.XtraGrid.GridControl cLins;
        private DevExpress.XtraGrid.Views.Grid.GridView vLins;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiActions;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_Exit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_CreateDoc;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private DevExpress.XtraTreeList.TreeList tlSGTIN;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_ShowSelected;
    }
}