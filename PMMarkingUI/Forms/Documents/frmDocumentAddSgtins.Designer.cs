namespace PMMarkingUI.Forms
{
    partial class frmDocumentAddSgtins
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
            this.vGridControl = new DevExpress.XtraVerticalGrid.VGridControl();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.riComboBox_DocType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.riComboBox_DocStatus = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.riComboBox_FileUplType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.riComboBox_Sender = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.riComboBox_Receiver = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.riDateEdit_DocDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.riDateEdit_ProcessedDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.DOC_DATE = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.SENDER = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.RECEIVER = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.DOC_TYPE = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.DOC_STATUS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.tplData = new System.Windows.Forms.TableLayoutPanel();
            this.pSlave = new System.Windows.Forms.Panel();
            this.tlDataSlave = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn8 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.pAction = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.pMain = new System.Windows.Forms.Panel();
            this.tlDataMain = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComboBox_DocType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComboBox_DocStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComboBox_FileUplType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComboBox_Sender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComboBox_Receiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit_DocDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit_DocDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit_ProcessedDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit_ProcessedDate.CalendarTimeProperties)).BeginInit();
            this.tplData.SuspendLayout();
            this.pSlave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlDataSlave)).BeginInit();
            this.pAction.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlDataMain)).BeginInit();
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
            this.scMain.Panel1.Controls.Add(this.vGridControl);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.tplData);
            this.scMain.Size = new System.Drawing.Size(738, 431);
            this.scMain.SplitterDistance = 117;
            this.scMain.TabIndex = 1;
            // 
            // vGridControl
            // 
            this.vGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.vGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.vGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vGridControl.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl.Location = new System.Drawing.Point(0, 0);
            this.vGridControl.Name = "vGridControl";
            this.vGridControl.OptionsFilter.AllowFilter = false;
            this.vGridControl.OptionsFilter.AllowFilterEditor = false;
            this.vGridControl.RecordWidth = 150;
            this.vGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.riComboBox_DocType,
            this.riComboBox_DocStatus,
            this.riComboBox_FileUplType,
            this.riComboBox_Sender,
            this.riComboBox_Receiver,
            this.riDateEdit_DocDate,
            this.riDateEdit_ProcessedDate});
            this.vGridControl.RowHeaderWidth = 50;
            this.vGridControl.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.ID,
            this.DOC_DATE,
            this.SENDER,
            this.RECEIVER,
            this.DOC_TYPE,
            this.DOC_STATUS});
            this.vGridControl.Size = new System.Drawing.Size(738, 117);
            this.vGridControl.TabIndex = 1;
            this.vGridControl.RecordCellStyle += new DevExpress.XtraVerticalGrid.Events.GetCustomRowCellStyleEventHandler(this.vGridControl_RecordCellStyle);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // riComboBox_DocType
            // 
            this.riComboBox_DocType.AutoHeight = false;
            this.riComboBox_DocType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riComboBox_DocType.Name = "riComboBox_DocType";
            this.riComboBox_DocType.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // riComboBox_DocStatus
            // 
            this.riComboBox_DocStatus.AutoHeight = false;
            this.riComboBox_DocStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riComboBox_DocStatus.Name = "riComboBox_DocStatus";
            this.riComboBox_DocStatus.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // riComboBox_FileUplType
            // 
            this.riComboBox_FileUplType.AutoHeight = false;
            this.riComboBox_FileUplType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riComboBox_FileUplType.Name = "riComboBox_FileUplType";
            this.riComboBox_FileUplType.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // riComboBox_Sender
            // 
            this.riComboBox_Sender.AutoHeight = false;
            this.riComboBox_Sender.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riComboBox_Sender.Name = "riComboBox_Sender";
            this.riComboBox_Sender.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // riComboBox_Receiver
            // 
            this.riComboBox_Receiver.AutoHeight = false;
            this.riComboBox_Receiver.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riComboBox_Receiver.Name = "riComboBox_Receiver";
            this.riComboBox_Receiver.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
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
            // riDateEdit_ProcessedDate
            // 
            this.riDateEdit_ProcessedDate.AutoHeight = false;
            this.riDateEdit_ProcessedDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riDateEdit_ProcessedDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riDateEdit_ProcessedDate.Name = "riDateEdit_ProcessedDate";
            // 
            // ID
            // 
            this.ID.Name = "ID";
            this.ID.Properties.Caption = "ID";
            this.ID.Properties.FieldName = "ID";
            this.ID.Properties.ReadOnly = false;
            // 
            // DOC_DATE
            // 
            this.DOC_DATE.Name = "DOC_DATE";
            this.DOC_DATE.Properties.Caption = "Дата документа";
            this.DOC_DATE.Properties.FieldName = "DOC_DATE";
            this.DOC_DATE.Properties.ReadOnly = false;
            this.DOC_DATE.Properties.RowEdit = this.riDateEdit_DocDate;
            // 
            // SENDER
            // 
            this.SENDER.Name = "SENDER";
            this.SENDER.Properties.Caption = "Отправитель";
            this.SENDER.Properties.FieldName = "SENDER";
            this.SENDER.Properties.ReadOnly = false;
            this.SENDER.Properties.RowEdit = this.riComboBox_Sender;
            // 
            // RECEIVER
            // 
            this.RECEIVER.Name = "RECEIVER";
            this.RECEIVER.Properties.Caption = "Получатель";
            this.RECEIVER.Properties.FieldName = "RECEIVER";
            this.RECEIVER.Properties.ReadOnly = false;
            this.RECEIVER.Properties.RowEdit = this.riComboBox_Receiver;
            // 
            // DOC_TYPE
            // 
            this.DOC_TYPE.Name = "DOC_TYPE";
            this.DOC_TYPE.Properties.Caption = "Тип документа";
            this.DOC_TYPE.Properties.FieldName = "DOC_TYPE";
            this.DOC_TYPE.Properties.ReadOnly = false;
            this.DOC_TYPE.Properties.RowEdit = this.riComboBox_DocType;
            // 
            // DOC_STATUS
            // 
            this.DOC_STATUS.Name = "DOC_STATUS";
            this.DOC_STATUS.Properties.Caption = "Статус";
            this.DOC_STATUS.Properties.FieldName = "DOC_STATUS";
            this.DOC_STATUS.Properties.ReadOnly = false;
            this.DOC_STATUS.Properties.RowEdit = this.riComboBox_DocStatus;
            // 
            // tplData
            // 
            this.tplData.ColumnCount = 3;
            this.tplData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tplData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplData.Controls.Add(this.pSlave, 0, 0);
            this.tplData.Controls.Add(this.pAction, 0, 0);
            this.tplData.Controls.Add(this.pMain, 0, 0);
            this.tplData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplData.Location = new System.Drawing.Point(0, 0);
            this.tplData.Name = "tplData";
            this.tplData.RowCount = 1;
            this.tplData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplData.Size = new System.Drawing.Size(738, 310);
            this.tplData.TabIndex = 0;
            // 
            // pSlave
            // 
            this.pSlave.Controls.Add(this.tlDataSlave);
            this.pSlave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSlave.Location = new System.Drawing.Point(397, 3);
            this.pSlave.Name = "pSlave";
            this.pSlave.Size = new System.Drawing.Size(338, 304);
            this.pSlave.TabIndex = 20;
            // 
            // tlDataSlave
            // 
            this.tlDataSlave.Caption = "Передаваемые данные";
            this.tlDataSlave.CheckBoxFieldName = "cbx";
            this.tlDataSlave.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn5,
            this.treeListColumn6,
            this.treeListColumn7,
            this.treeListColumn8});
            this.tlDataSlave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDataSlave.Location = new System.Drawing.Point(0, 0);
            this.tlDataSlave.Name = "tlDataSlave";
            this.tlDataSlave.BeginUnboundLoad();
            this.tlDataSlave.AppendNode(new object[] {
            "Все коробки",
            null,
            null,
            null}, -1);
            this.tlDataSlave.AppendNode(new object[] {
            null,
            null,
            null,
            null}, 0);
            this.tlDataSlave.EndUnboundLoad();
            this.tlDataSlave.OptionsBehavior.AllowExpandOnDblClick = false;
            this.tlDataSlave.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.tlDataSlave.OptionsBehavior.EditorShowMode = DevExpress.XtraTreeList.TreeListEditorShowMode.MouseDownFocused;
            this.tlDataSlave.OptionsBehavior.PopulateServiceColumns = true;
            this.tlDataSlave.OptionsBehavior.ReadOnly = true;
            this.tlDataSlave.OptionsView.BestFitMode = DevExpress.XtraTreeList.TreeListBestFitMode.Full;
            this.tlDataSlave.OptionsView.CheckBoxStyle = DevExpress.XtraTreeList.DefaultNodeCheckBoxStyle.Check;
            this.tlDataSlave.OptionsView.RootCheckBoxStyle = DevExpress.XtraTreeList.NodeCheckBoxStyle.None;
            this.tlDataSlave.OptionsView.ShowCaption = true;
            this.tlDataSlave.OptionsView.ShowRoot = false;
            this.tlDataSlave.OptionsView.ShowRowFooterSummary = true;
            this.tlDataSlave.OptionsView.ShowSummaryFooter = true;
            this.tlDataSlave.Size = new System.Drawing.Size(338, 304);
            this.tlDataSlave.TabIndex = 18;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "SSCC_ID";
            this.treeListColumn5.FieldName = "SSCC_ID";
            this.treeListColumn5.Name = "treeListColumn5";
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "SSCC";
            this.treeListColumn6.FieldName = "SSCC";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Count;
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 0;
            this.treeListColumn6.Width = 200;
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "SGTIN";
            this.treeListColumn7.FieldName = "SGTIN";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Count;
            this.treeListColumn7.Visible = true;
            this.treeListColumn7.VisibleIndex = 1;
            this.treeListColumn7.Width = 502;
            // 
            // treeListColumn8
            // 
            this.treeListColumn8.Caption = "SGTIN_ID";
            this.treeListColumn8.FieldName = "SGTIN_ID";
            this.treeListColumn8.Name = "treeListColumn8";
            this.treeListColumn8.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Count;
            // 
            // pAction
            // 
            this.pAction.Controls.Add(this.tableLayoutPanel1);
            this.pAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAction.Location = new System.Drawing.Point(347, 3);
            this.pAction.Name = "pAction";
            this.pAction.Size = new System.Drawing.Size(44, 304);
            this.pAction.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDel, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(44, 304);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(3, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 34);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDel.Location = new System.Drawing.Point(3, 165);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(38, 34);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "<<";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.tlDataMain);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(3, 3);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(338, 304);
            this.pMain.TabIndex = 18;
            // 
            // tlDataMain
            // 
            this.tlDataMain.Caption = "Данные документа \"донора\"";
            this.tlDataMain.CheckBoxFieldName = "cbx";
            this.tlDataMain.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4});
            this.tlDataMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDataMain.Location = new System.Drawing.Point(0, 0);
            this.tlDataMain.Name = "tlDataMain";
            this.tlDataMain.BeginUnboundLoad();
            this.tlDataMain.AppendNode(new object[] {
            "Все коробки",
            null,
            null,
            null}, -1);
            this.tlDataMain.AppendNode(new object[] {
            null,
            null,
            null,
            null}, 0);
            this.tlDataMain.EndUnboundLoad();
            this.tlDataMain.OptionsBehavior.AllowExpandOnDblClick = false;
            this.tlDataMain.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.tlDataMain.OptionsBehavior.EditorShowMode = DevExpress.XtraTreeList.TreeListEditorShowMode.MouseDownFocused;
            this.tlDataMain.OptionsBehavior.PopulateServiceColumns = true;
            this.tlDataMain.OptionsBehavior.ReadOnly = true;
            this.tlDataMain.OptionsView.BestFitMode = DevExpress.XtraTreeList.TreeListBestFitMode.Full;
            this.tlDataMain.OptionsView.CheckBoxStyle = DevExpress.XtraTreeList.DefaultNodeCheckBoxStyle.Check;
            this.tlDataMain.OptionsView.RootCheckBoxStyle = DevExpress.XtraTreeList.NodeCheckBoxStyle.None;
            this.tlDataMain.OptionsView.ShowCaption = true;
            this.tlDataMain.OptionsView.ShowRoot = false;
            this.tlDataMain.OptionsView.ShowRowFooterSummary = true;
            this.tlDataMain.OptionsView.ShowSummaryFooter = true;
            this.tlDataMain.Size = new System.Drawing.Size(338, 304);
            this.tlDataMain.TabIndex = 16;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "SSCC_ID";
            this.treeListColumn1.FieldName = "SSCC_ID";
            this.treeListColumn1.Name = "treeListColumn1";
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "SSCC";
            this.treeListColumn2.FieldName = "SSCC";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Count;
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            this.treeListColumn2.Width = 200;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "SGTIN";
            this.treeListColumn3.FieldName = "SGTIN";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Count;
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 1;
            this.treeListColumn3.Width = 502;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "SGTIN_ID";
            this.treeListColumn4.FieldName = "SGTIN_ID";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Count;
            // 
            // frmDocumentAddSgtins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 431);
            this.Controls.Add(this.scMain);
            this.Name = "frmDocumentAddSgtins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление данных в документ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComboBox_DocType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComboBox_DocStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComboBox_FileUplType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComboBox_Sender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComboBox_Receiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit_DocDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit_DocDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit_ProcessedDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit_ProcessedDate)).EndInit();
            this.tplData.ResumeLayout(false);
            this.pSlave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlDataSlave)).EndInit();
            this.pAction.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlDataMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.TableLayoutPanel tplData;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox riComboBox_DocType;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox riComboBox_DocStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox riComboBox_FileUplType;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox riComboBox_Sender;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox riComboBox_Receiver;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit riDateEdit_DocDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit riDateEdit_ProcessedDate;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow ID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow DOC_DATE;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow SENDER;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow RECEIVER;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow DOC_TYPE;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow DOC_STATUS;
        private System.Windows.Forms.Panel pSlave;
        private DevExpress.XtraTreeList.TreeList tlDataSlave;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn8;
        private System.Windows.Forms.Panel pAction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Panel pMain;
        private DevExpress.XtraTreeList.TreeList tlDataMain;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
    }
}