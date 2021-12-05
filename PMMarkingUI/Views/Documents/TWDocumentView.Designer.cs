namespace PMMarkingUI.Views
{
    partial class TWDocumentView
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
            this.scDocs = new System.Windows.Forms.SplitContainer();
            this.pHeader = new System.Windows.Forms.Panel();
            this.vGridControl = new DevExpress.XtraVerticalGrid.VGridControl();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.TW_DID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.TW_DCODE = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.TW_DDATE1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.TW_DID1_NAME = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.TW_DID1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowMDLP_Contr = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.MDLP_CID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.MDLP_SYSTEM_SUBJ_ID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.MDLP_INN = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.MDLP_KPP = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.MDLP_ORG_NAME = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.TW_DCONCEPT_NAME = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.TW_DCONCEPT = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.TW_DSTATE_NAME = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.TW_DSTATE = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.TW_ADDRESS_NAME = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.TW_ADDRESS_ID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.MDLP_TW_LNK_ID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.MDLP_TW_FIAS_HOUSE = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowMDLP_Addr = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.MDLP_BID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.MDLP_ADDRESS_ID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.MDLP_HOUSEGUID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.MDLP_ADDRESS_NAME = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.MDLP_IS_SAFE_WAREHOUSES = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.gGOODS = new DevExpress.XtraGrid.GridControl();
            this.vGOODS = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EIDDOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.L800_LTEXT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.L800_LNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ENUM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ENUM4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ENUM14 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scDocs)).BeginInit();
            this.scDocs.Panel1.SuspendLayout();
            this.scDocs.Panel2.SuspendLayout();
            this.scDocs.SuspendLayout();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gGOODS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGOODS)).BeginInit();
            this.SuspendLayout();
            // 
            // scDocs
            // 
            this.scDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scDocs.Location = new System.Drawing.Point(0, 0);
            this.scDocs.Name = "scDocs";
            this.scDocs.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scDocs.Panel1
            // 
            this.scDocs.Panel1.Controls.Add(this.pHeader);
            // 
            // scDocs.Panel2
            // 
            this.scDocs.Panel2.Controls.Add(this.gGOODS);
            this.scDocs.Size = new System.Drawing.Size(720, 480);
            this.scDocs.SplitterDistance = 152;
            this.scDocs.TabIndex = 3;
            // 
            // pHeader
            // 
            this.pHeader.Controls.Add(this.vGridControl);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(720, 152);
            this.pHeader.TabIndex = 0;
            // 
            // vGridControl
            // 
            this.vGridControl.Appearance.ReadOnlyRecordValue.ForeColor = System.Drawing.Color.Black;
            this.vGridControl.Appearance.ReadOnlyRecordValue.Options.UseForeColor = true;
            this.vGridControl.Appearance.ReadOnlyRow.ForeColor = System.Drawing.Color.Black;
            this.vGridControl.Appearance.ReadOnlyRow.Options.UseForeColor = true;
            this.vGridControl.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.vGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl.Location = new System.Drawing.Point(0, 0);
            this.vGridControl.Name = "vGridControl";
            this.vGridControl.OptionsFilter.AllowFilter = false;
            this.vGridControl.OptionsFilter.AllowFilterEditor = false;
            this.vGridControl.RecordWidth = 150;
            this.vGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.vGridControl.RowHeaderWidth = 50;
            this.vGridControl.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.TW_DID,
            this.TW_DCODE,
            this.TW_DDATE1,
            this.TW_DID1_NAME,
            this.TW_DCONCEPT_NAME,
            this.TW_DSTATE_NAME,
            this.TW_ADDRESS_NAME});
            this.vGridControl.Size = new System.Drawing.Size(720, 152);
            this.vGridControl.TabIndex = 0;
            this.vGridControl.RecordCellStyle += new DevExpress.XtraVerticalGrid.Events.GetCustomRowCellStyleEventHandler(this.vGridControl_RecordCellStyle);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // TW_DID
            // 
            this.TW_DID.Name = "TW_DID";
            this.TW_DID.Properties.Caption = "DID";
            this.TW_DID.Properties.FieldName = "DID";
            this.TW_DID.Properties.ReadOnly = false;
            // 
            // TW_DCODE
            // 
            this.TW_DCODE.Name = "TW_DCODE";
            this.TW_DCODE.Properties.Caption = "Код документа";
            this.TW_DCODE.Properties.FieldName = "DCODE";
            this.TW_DCODE.Properties.ReadOnly = false;
            // 
            // TW_DDATE1
            // 
            this.TW_DDATE1.Name = "TW_DDATE1";
            this.TW_DDATE1.Properties.Caption = "Дата документа";
            this.TW_DDATE1.Properties.FieldName = "DDATE1";
            // 
            // TW_DID1_NAME
            // 
            this.TW_DID1_NAME.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.TW_DID1,
            this.rowMDLP_Contr});
            this.TW_DID1_NAME.Name = "TW_DID1_NAME";
            this.TW_DID1_NAME.Properties.Caption = "Контрагент";
            this.TW_DID1_NAME.Properties.FieldName = "DID1_NAME";
            this.TW_DID1_NAME.Properties.ReadOnly = false;
            // 
            // TW_DID1
            // 
            this.TW_DID1.Name = "TW_DID1";
            this.TW_DID1.Properties.Caption = "LID";
            this.TW_DID1.Properties.FieldName = "DID1";
            this.TW_DID1.Properties.ReadOnly = false;
            // 
            // rowMDLP_Contr
            // 
            this.rowMDLP_Contr.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.MDLP_CID,
            this.MDLP_SYSTEM_SUBJ_ID,
            this.MDLP_INN,
            this.MDLP_KPP,
            this.MDLP_ORG_NAME});
            this.rowMDLP_Contr.Name = "rowMDLP_Contr";
            this.rowMDLP_Contr.Properties.Caption = "Данные в системе МДЛП";
            // 
            // MDLP_CID
            // 
            this.MDLP_CID.Name = "MDLP_CID";
            this.MDLP_CID.Properties.Caption = "CID";
            this.MDLP_CID.Properties.FieldName = "MDLP_CID";
            // 
            // MDLP_SYSTEM_SUBJ_ID
            // 
            this.MDLP_SYSTEM_SUBJ_ID.Name = "MDLP_SYSTEM_SUBJ_ID";
            this.MDLP_SYSTEM_SUBJ_ID.Properties.Caption = "SYSTEM_SUBJ_ID";
            this.MDLP_SYSTEM_SUBJ_ID.Properties.FieldName = "MDLP_SYSTEM_SUBJ_ID";
            // 
            // MDLP_INN
            // 
            this.MDLP_INN.Name = "MDLP_INN";
            this.MDLP_INN.Properties.Caption = "ИНН";
            this.MDLP_INN.Properties.FieldName = "MDLP_INN";
            // 
            // MDLP_KPP
            // 
            this.MDLP_KPP.Name = "MDLP_KPP";
            this.MDLP_KPP.Properties.Caption = "КПП";
            this.MDLP_KPP.Properties.FieldName = "MDLP_KPP";
            // 
            // MDLP_ORG_NAME
            // 
            this.MDLP_ORG_NAME.Name = "MDLP_ORG_NAME";
            this.MDLP_ORG_NAME.Properties.Caption = "Организация";
            this.MDLP_ORG_NAME.Properties.FieldName = "MDLP_ORG_NAME";
            // 
            // TW_DCONCEPT_NAME
            // 
            this.TW_DCONCEPT_NAME.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.TW_DCONCEPT});
            this.TW_DCONCEPT_NAME.Name = "TW_DCONCEPT_NAME";
            this.TW_DCONCEPT_NAME.Properties.Caption = "Тип документа";
            this.TW_DCONCEPT_NAME.Properties.FieldName = "DCONCEPT_NAME";
            this.TW_DCONCEPT_NAME.Properties.ReadOnly = false;
            // 
            // TW_DCONCEPT
            // 
            this.TW_DCONCEPT.Name = "TW_DCONCEPT";
            this.TW_DCONCEPT.Properties.Caption = "DCONCEPT";
            this.TW_DCONCEPT.Properties.FieldName = "DCONCEPT";
            this.TW_DCONCEPT.Properties.ReadOnly = false;
            // 
            // TW_DSTATE_NAME
            // 
            this.TW_DSTATE_NAME.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.TW_DSTATE});
            this.TW_DSTATE_NAME.Name = "TW_DSTATE_NAME";
            this.TW_DSTATE_NAME.Properties.Caption = "Состояние";
            this.TW_DSTATE_NAME.Properties.FieldName = "DSTATE_NAME";
            // 
            // TW_DSTATE
            // 
            this.TW_DSTATE.Name = "TW_DSTATE";
            this.TW_DSTATE.Properties.Caption = "DSTATE";
            this.TW_DSTATE.Properties.FieldName = "DSTATE";
            // 
            // TW_ADDRESS_NAME
            // 
            this.TW_ADDRESS_NAME.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.TW_ADDRESS_ID,
            this.MDLP_TW_LNK_ID,
            this.MDLP_TW_FIAS_HOUSE,
            this.rowMDLP_Addr});
            this.TW_ADDRESS_NAME.Name = "TW_ADDRESS_NAME";
            this.TW_ADDRESS_NAME.Properties.Caption = "Адрес";
            this.TW_ADDRESS_NAME.Properties.FieldName = "ADDRESS_NAME";
            // 
            // TW_ADDRESS_ID
            // 
            this.TW_ADDRESS_ID.Name = "TW_ADDRESS_ID";
            this.TW_ADDRESS_ID.Properties.Caption = "ADDRESS_ID";
            this.TW_ADDRESS_ID.Properties.FieldName = "ADDRESS_ID";
            // 
            // MDLP_TW_LNK_ID
            // 
            this.MDLP_TW_LNK_ID.Name = "MDLP_TW_LNK_ID";
            this.MDLP_TW_LNK_ID.Properties.Caption = "MDLP_TW_LNK_ID";
            this.MDLP_TW_LNK_ID.Properties.FieldName = "MDLP_TW_LNK_ID";
            // 
            // MDLP_TW_FIAS_HOUSE
            // 
            this.MDLP_TW_FIAS_HOUSE.Name = "MDLP_TW_FIAS_HOUSE";
            this.MDLP_TW_FIAS_HOUSE.Properties.Caption = "MDLP_TW_FIAS_HOUSE";
            this.MDLP_TW_FIAS_HOUSE.Properties.FieldName = "MDLP_TW_FIAS_HOUSE";
            // 
            // rowMDLP_Addr
            // 
            this.rowMDLP_Addr.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.MDLP_BID,
            this.MDLP_ADDRESS_ID,
            this.MDLP_HOUSEGUID,
            this.MDLP_ADDRESS_NAME,
            this.MDLP_IS_SAFE_WAREHOUSES});
            this.rowMDLP_Addr.Name = "rowMDLP_Addr";
            this.rowMDLP_Addr.Properties.Caption = "Данные в системе МДЛП";
            // 
            // MDLP_BID
            // 
            this.MDLP_BID.Name = "MDLP_BID";
            this.MDLP_BID.Properties.Caption = "BID";
            this.MDLP_BID.Properties.FieldName = "MDLP_BID";
            // 
            // MDLP_ADDRESS_ID
            // 
            this.MDLP_ADDRESS_ID.Name = "MDLP_ADDRESS_ID";
            this.MDLP_ADDRESS_ID.Properties.Caption = "MDLP_ADDRESS_ID";
            this.MDLP_ADDRESS_ID.Properties.FieldName = "MDLP_ADDRESS_ID";
            // 
            // MDLP_HOUSEGUID
            // 
            this.MDLP_HOUSEGUID.Name = "MDLP_HOUSEGUID";
            this.MDLP_HOUSEGUID.Properties.Caption = "MDLP_HOUSEGUID";
            this.MDLP_HOUSEGUID.Properties.FieldName = "MDLP_HOUSEGUID";
            // 
            // MDLP_ADDRESS_NAME
            // 
            this.MDLP_ADDRESS_NAME.Name = "MDLP_ADDRESS_NAME";
            this.MDLP_ADDRESS_NAME.Properties.Caption = "MDLP_ADDRESS_NAME";
            this.MDLP_ADDRESS_NAME.Properties.FieldName = "MDLP_ADDRESS_NAME";
            // 
            // MDLP_IS_SAFE_WAREHOUSES
            // 
            this.MDLP_IS_SAFE_WAREHOUSES.Name = "MDLP_IS_SAFE_WAREHOUSES";
            this.MDLP_IS_SAFE_WAREHOUSES.Properties.Caption = "MDLP_IS_SAFE_WAREHOUSES";
            this.MDLP_IS_SAFE_WAREHOUSES.Properties.FieldName = "MDLP_IS_SAFE_WAREHOUSES";
            // 
            // gGOODS
            // 
            this.gGOODS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gGOODS.Location = new System.Drawing.Point(0, 0);
            this.gGOODS.MainView = this.vGOODS;
            this.gGOODS.Name = "gGOODS";
            this.gGOODS.Size = new System.Drawing.Size(720, 324);
            this.gGOODS.TabIndex = 2;
            this.gGOODS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vGOODS});
            // 
            // vGOODS
            // 
            this.vGOODS.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EID,
            this.EIDDOC,
            this.EID1,
            this.L800_LTEXT1,
            this.L800_LNAME,
            this.ENUM1,
            this.ENUM4,
            this.ENUM14});
            this.vGOODS.GridControl = this.gGOODS;
            this.vGOODS.Name = "vGOODS";
            this.vGOODS.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.vGOODS.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.vGOODS.OptionsBehavior.AllowIncrementalSearch = true;
            this.vGOODS.OptionsBehavior.Editable = false;
            this.vGOODS.OptionsView.ColumnAutoWidth = false;
            this.vGOODS.OptionsView.ShowGroupPanel = false;
            this.vGOODS.OptionsView.ShowViewCaption = true;
            this.vGOODS.ViewCaption = "Товарные позиции";
            this.vGOODS.DoubleClick += new System.EventHandler(this.vGOODS_DoubleClick);
            // 
            // EID
            // 
            this.EID.Caption = "EID";
            this.EID.FieldName = "EID";
            this.EID.Name = "EID";
            this.EID.Visible = true;
            this.EID.VisibleIndex = 0;
            this.EID.Width = 100;
            // 
            // EIDDOC
            // 
            this.EIDDOC.Caption = "EIDDOC";
            this.EIDDOC.FieldName = "EIDDOC";
            this.EIDDOC.Name = "EIDDOC";
            this.EIDDOC.Width = 100;
            // 
            // EID1
            // 
            this.EID1.Caption = "EID1";
            this.EID1.FieldName = "EID1";
            this.EID1.Name = "EID1";
            // 
            // L800_LTEXT1
            // 
            this.L800_LTEXT1.Caption = "Артикул";
            this.L800_LTEXT1.FieldName = "L800_LTEXT1";
            this.L800_LTEXT1.Name = "L800_LTEXT1";
            this.L800_LTEXT1.Visible = true;
            this.L800_LTEXT1.VisibleIndex = 2;
            this.L800_LTEXT1.Width = 150;
            // 
            // L800_LNAME
            // 
            this.L800_LNAME.Caption = "Наименование";
            this.L800_LNAME.FieldName = "L800_LNAME";
            this.L800_LNAME.Name = "L800_LNAME";
            this.L800_LNAME.Visible = true;
            this.L800_LNAME.VisibleIndex = 1;
            this.L800_LNAME.Width = 300;
            // 
            // ENUM1
            // 
            this.ENUM1.Caption = "Количество";
            this.ENUM1.FieldName = "ENUM1";
            this.ENUM1.Name = "ENUM1";
            this.ENUM1.Visible = true;
            this.ENUM1.VisibleIndex = 5;
            // 
            // ENUM4
            // 
            this.ENUM4.Caption = "Цена";
            this.ENUM4.FieldName = "ENUM4";
            this.ENUM4.Name = "ENUM4";
            this.ENUM4.Visible = true;
            this.ENUM4.VisibleIndex = 3;
            // 
            // ENUM14
            // 
            this.ENUM14.Caption = "Сумма";
            this.ENUM14.FieldName = "ENUM14";
            this.ENUM14.Name = "ENUM14";
            this.ENUM14.Visible = true;
            this.ENUM14.VisibleIndex = 4;
            // 
            // TWDocumentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scDocs);
            this.Name = "TWDocumentView";
            this.Size = new System.Drawing.Size(720, 480);
            this.scDocs.Panel1.ResumeLayout(false);
            this.scDocs.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scDocs)).EndInit();
            this.scDocs.ResumeLayout(false);
            this.pHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gGOODS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGOODS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scDocs;
        private DevExpress.XtraGrid.GridControl gGOODS;
        private DevExpress.XtraGrid.Views.Grid.GridView vGOODS;
        private System.Windows.Forms.Panel pHeader;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow TW_DID;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn EID;
        private DevExpress.XtraGrid.Columns.GridColumn EID1;
        private DevExpress.XtraGrid.Columns.GridColumn L800_LTEXT1;
        private DevExpress.XtraGrid.Columns.GridColumn L800_LNAME;
        private DevExpress.XtraGrid.Columns.GridColumn ENUM1;
        private DevExpress.XtraGrid.Columns.GridColumn ENUM4;
        private DevExpress.XtraGrid.Columns.GridColumn ENUM14;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow TW_DCODE;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow TW_DDATE1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow TW_DSTATE;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow TW_DSTATE_NAME;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow TW_DID1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow TW_DID1_NAME;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow TW_DCONCEPT;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow TW_DCONCEPT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn EIDDOC;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowMDLP_Contr;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow MDLP_CID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow MDLP_SYSTEM_SUBJ_ID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow MDLP_INN;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow MDLP_KPP;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow MDLP_ORG_NAME;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow TW_ADDRESS_NAME;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow TW_ADDRESS_ID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowMDLP_Addr;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow MDLP_BID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow MDLP_ADDRESS_ID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow MDLP_TW_FIAS_HOUSE;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow MDLP_HOUSEGUID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow MDLP_ADDRESS_NAME;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow MDLP_IS_SAFE_WAREHOUSES;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow MDLP_TW_LNK_ID;
    }
}
