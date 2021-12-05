namespace PMMarkingUI.Views
{
    partial class DocumentsForAgencyContract
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
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.cDocs = new DevExpress.XtraGrid.GridControl();
            this.vDocs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cLines = new DevExpress.XtraGrid.GridControl();
            this.vLines = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.scParameters = new System.Windows.Forms.SplitContainer();
            this.docFilterDbPanel = new PMMarkingUI.Views.DocFilterDbAgencyContractView();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scParameters)).BeginInit();
            this.scParameters.Panel1.SuspendLayout();
            this.scParameters.Panel2.SuspendLayout();
            this.scParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.cDocs);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.cLines);
            this.scMain.Size = new System.Drawing.Size(793, 768);
            this.scMain.SplitterDistance = 480;
            this.scMain.TabIndex = 0;
            // 
            // cDocs
            // 
            this.cDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cDocs.Location = new System.Drawing.Point(0, 0);
            this.cDocs.MainView = this.vDocs;
            this.cDocs.Name = "cDocs";
            this.cDocs.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.cDocs.Size = new System.Drawing.Size(793, 480);
            this.cDocs.TabIndex = 5;
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
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14});
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
            this.vDocs.ViewCaption = "Документы по агентскому договору";
            this.vDocs.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.vDocs_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "SGD_ID";
            this.gridColumn1.FieldName = "SGD_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "DID";
            this.gridColumn2.FieldName = "SGD_DID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 115;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Код заказа";
            this.gridColumn3.FieldName = "SGD_DCODE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 131;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Дата заказа";
            this.gridColumn4.FieldName = "SGD_DDATE1";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 87;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "DID1";
            this.gridColumn5.FieldName = "DID1";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Концепт";
            this.gridColumn6.FieldName = "DCONCEPT";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 115;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Тип документа";
            this.gridColumn7.FieldName = "DOC_TYPE";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            this.gridColumn7.Width = 245;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Код клиента";
            this.gridColumn8.FieldName = "L4000_CODE";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            this.gridColumn8.Width = 85;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Контрагент";
            this.gridColumn9.FieldName = "L4000_NAME";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            this.gridColumn9.Width = 361;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Код адреса";
            this.gridColumn10.FieldName = "ADDR_CODE";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 7;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Адрес";
            this.gridColumn11.FieldName = "ADDR_VAL";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.ReadOnly = true;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 8;
            this.gridColumn11.Width = 407;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "CONFIRM_VAL";
            this.gridColumn12.FieldName = "CONFIRM_VAL";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "TURNOVER_TYPE";
            this.gridColumn13.FieldName = "TURNOVER_TYPE";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "SENDER_SYS_ID";
            this.gridColumn14.FieldName = "SENDER_SYS_ID";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.ReadOnly = true;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit2.ValueChecked = 1;
            this.repositoryItemCheckEdit2.ValueUnchecked = 0;
            // 
            // cLines
            // 
            this.cLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cLines.Location = new System.Drawing.Point(0, 0);
            this.cLines.MainView = this.vLines;
            this.cLines.Name = "cLines";
            this.cLines.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.cLines.Size = new System.Drawing.Size(793, 284);
            this.cLines.TabIndex = 7;
            this.cLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vLines});
            // 
            // vLines
            // 
            this.vLines.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn23,
            this.gridColumn24,
            this.gridColumn25,
            this.gridColumn26});
            this.vLines.GridControl = this.cLines;
            this.vLines.Name = "vLines";
            this.vLines.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.vLines.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.vLines.OptionsBehavior.AllowIncrementalSearch = true;
            this.vLines.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.vLines.OptionsBehavior.ReadOnly = true;
            this.vLines.OptionsView.ColumnAutoWidth = false;
            this.vLines.OptionsView.ShowFooter = true;
            this.vLines.OptionsView.ShowGroupPanel = false;
            this.vLines.OptionsView.ShowViewCaption = true;
            this.vLines.ViewCaption = "Строки документа";
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "SGL_ID";
            this.gridColumn15.FieldName = "SGL_ID";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "SGL_DID";
            this.gridColumn16.FieldName = "SGL_DID";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.ReadOnly = true;
            this.gridColumn16.Width = 124;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Пользователь";
            this.gridColumn17.FieldName = "SGL_USER";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.OptionsColumn.ReadOnly = true;
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 5;
            this.gridColumn17.Width = 82;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Тип";
            this.gridColumn18.FieldName = "SGL_TYPE";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.OptionsColumn.ReadOnly = true;
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 3;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "SGTIN";
            this.gridColumn19.FieldName = "SGL_CODE";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsColumn.ReadOnly = true;
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 0;
            this.gridColumn19.Width = 258;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Коробка";
            this.gridColumn20.FieldName = "SGL_OUT_SSCC";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.OptionsColumn.ReadOnly = true;
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 1;
            this.gridColumn20.Width = 123;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Синхронизирован";
            this.gridColumn21.FieldName = "SGL_SYNC";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.OptionsColumn.ReadOnly = true;
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 4;
            this.gridColumn21.Width = 100;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "SGL_EID";
            this.gridColumn22.FieldName = "SGL_EID";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "SGL_SB_NMB";
            this.gridColumn23.FieldName = "SGL_SB_NMB";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.OptionsColumn.ReadOnly = true;
            this.gridColumn23.Width = 85;
            // 
            // gridColumn24
            // 
            this.gridColumn24.Caption = "SGL_OUT_OB_ID";
            this.gridColumn24.FieldName = "SGL_OUT_OB_ID";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn25
            // 
            this.gridColumn25.Caption = "Товар";
            this.gridColumn25.FieldName = "SGL_L800";
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.OptionsColumn.ReadOnly = true;
            this.gridColumn25.Visible = true;
            this.gridColumn25.VisibleIndex = 2;
            this.gridColumn25.Width = 337;
            // 
            // gridColumn26
            // 
            this.gridColumn26.Caption = "SGL_STOCK_ID";
            this.gridColumn26.FieldName = "SGL_STOCK_ID";
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.OptionsColumn.ReadOnly = true;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // scParameters
            // 
            this.scParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scParameters.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scParameters.Location = new System.Drawing.Point(0, 0);
            this.scParameters.Name = "scParameters";
            // 
            // scParameters.Panel1
            // 
            this.scParameters.Panel1.Controls.Add(this.docFilterDbPanel);
            // 
            // scParameters.Panel2
            // 
            this.scParameters.Panel2.Controls.Add(this.scMain);
            this.scParameters.Size = new System.Drawing.Size(1024, 768);
            this.scParameters.SplitterDistance = 227;
            this.scParameters.TabIndex = 1;
            // 
            // docFilterDbPanel
            // 
            this.docFilterDbPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docFilterDbPanel.Location = new System.Drawing.Point(0, 0);
            this.docFilterDbPanel.Name = "docFilterDbPanel";
            this.docFilterDbPanel.Size = new System.Drawing.Size(227, 768);
            this.docFilterDbPanel.TabIndex = 0;
            // 
            // DocumentsForAgencyContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scParameters);
            this.Name = "DocumentsForAgencyContract";
            this.Size = new System.Drawing.Size(1024, 768);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.scParameters.Panel1.ResumeLayout(false);
            this.scParameters.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scParameters)).EndInit();
            this.scParameters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private DevExpress.XtraGrid.GridControl cDocs;
        private DevExpress.XtraGrid.Views.Grid.GridView vDocs;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private System.Windows.Forms.SplitContainer scParameters;
        private DocFilterDbAgencyContractView docFilterDbPanel;
        private DevExpress.XtraGrid.GridControl cLines;
        private DevExpress.XtraGrid.Views.Grid.GridView vLines;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
    }
}
