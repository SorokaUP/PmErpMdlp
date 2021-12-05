namespace PMMarkingUI.Views
{
    partial class TWDocumentsView
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
            this.cmsDocs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCmsSendDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsGetTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCmsGetMetadata = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCmsGetDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.docFilterTWDbPanel = new PMMarkingUI.Views.DocFilterTWDbView();
            this.pDocs = new System.Windows.Forms.Panel();
            this.gDocs = new DevExpress.XtraGrid.GridControl();
            this.vDocs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDATE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDID1_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DCONCEPT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DCONCEPT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DSTATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DSTATE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.msDocs = new System.Windows.Forms.MenuStrip();
            this.tsmiMsSend_Group = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMsGet_Group = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDocs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.pDocs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDocs)).BeginInit();
            this.msDocs.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsDocs
            // 
            this.cmsDocs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCmsSendDoc,
            this.tsmiCmsGetTicket,
            this.tsmiCmsGetMetadata,
            this.toolStripMenuItem1,
            this.tsmiCmsGetDoc});
            this.cmsDocs.Name = "cmsDocs";
            this.cmsDocs.Size = new System.Drawing.Size(251, 98);
            // 
            // tsmiCmsSendDoc
            // 
            this.tsmiCmsSendDoc.Name = "tsmiCmsSendDoc";
            this.tsmiCmsSendDoc.Size = new System.Drawing.Size(250, 22);
            this.tsmiCmsSendDoc.Text = "Отправить";
            this.tsmiCmsSendDoc.Click += new System.EventHandler(this.SendDoc);
            // 
            // tsmiCmsGetTicket
            // 
            this.tsmiCmsGetTicket.Name = "tsmiCmsGetTicket";
            this.tsmiCmsGetTicket.Size = new System.Drawing.Size(250, 22);
            this.tsmiCmsGetTicket.Text = "Получить квитанцию / этикетку";
            // 
            // tsmiCmsGetMetadata
            // 
            this.tsmiCmsGetMetadata.Name = "tsmiCmsGetMetadata";
            this.tsmiCmsGetMetadata.Size = new System.Drawing.Size(250, 22);
            this.tsmiCmsGetMetadata.Text = "Получить мета-данные";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(247, 6);
            // 
            // tsmiCmsGetDoc
            // 
            this.tsmiCmsGetDoc.Name = "tsmiCmsGetDoc";
            this.tsmiCmsGetDoc.Size = new System.Drawing.Size(250, 22);
            this.tsmiCmsGetDoc.Text = "Получить документ";
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.docFilterTWDbPanel);
            this.scMain.Panel1MinSize = 200;
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.pDocs);
            this.scMain.Size = new System.Drawing.Size(720, 480);
            this.scMain.SplitterDistance = 200;
            this.scMain.TabIndex = 1;
            // 
            // docFilterTWDbPanel
            // 
            this.docFilterTWDbPanel.DelegateGetDocFilterTW = null;
            this.docFilterTWDbPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docFilterTWDbPanel.Location = new System.Drawing.Point(0, 0);
            this.docFilterTWDbPanel.Name = "docFilterTWDbPanel";
            this.docFilterTWDbPanel.Size = new System.Drawing.Size(200, 480);
            this.docFilterTWDbPanel.TabIndex = 0;
            // 
            // pDocs
            // 
            this.pDocs.Controls.Add(this.gDocs);
            this.pDocs.Controls.Add(this.msDocs);
            this.pDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDocs.Location = new System.Drawing.Point(0, 0);
            this.pDocs.Name = "pDocs";
            this.pDocs.Size = new System.Drawing.Size(516, 480);
            this.pDocs.TabIndex = 2;
            // 
            // gDocs
            // 
            this.gDocs.ContextMenuStrip = this.cmsDocs;
            this.gDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gDocs.Location = new System.Drawing.Point(0, 24);
            this.gDocs.MainView = this.vDocs;
            this.gDocs.Name = "gDocs";
            this.gDocs.Size = new System.Drawing.Size(516, 456);
            this.gDocs.TabIndex = 4;
            this.gDocs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vDocs});
            // 
            // vDocs
            // 
            this.vDocs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDID,
            this.colDCODE,
            this.colDDATE1,
            this.colDID1,
            this.colDID1_NAME,
            this.DCONCEPT,
            this.DCONCEPT_NAME,
            this.DSTATE,
            this.DSTATE_NAME});
            this.vDocs.GridControl = this.gDocs;
            this.vDocs.Name = "vDocs";
            this.vDocs.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.vDocs.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.vDocs.OptionsBehavior.AllowIncrementalSearch = true;
            this.vDocs.OptionsBehavior.Editable = false;
            this.vDocs.OptionsView.ColumnAutoWidth = false;
            this.vDocs.DoubleClick += new System.EventHandler(this.vDocs_DoubleClick);
            // 
            // colDID
            // 
            this.colDID.Caption = "DID";
            this.colDID.FieldName = "DID";
            this.colDID.Name = "colDID";
            this.colDID.Visible = true;
            this.colDID.VisibleIndex = 0;
            // 
            // colDCODE
            // 
            this.colDCODE.Caption = "Код";
            this.colDCODE.FieldName = "DCODE";
            this.colDCODE.Name = "colDCODE";
            this.colDCODE.Visible = true;
            this.colDCODE.VisibleIndex = 1;
            this.colDCODE.Width = 150;
            // 
            // colDDATE1
            // 
            this.colDDATE1.Caption = "Дата документа";
            this.colDDATE1.FieldName = "DDATE1";
            this.colDDATE1.Name = "colDDATE1";
            this.colDDATE1.Visible = true;
            this.colDDATE1.VisibleIndex = 2;
            this.colDDATE1.Width = 101;
            // 
            // colDID1
            // 
            this.colDID1.Caption = "DID1";
            this.colDID1.FieldName = "DID1";
            this.colDID1.Name = "colDID1";
            // 
            // colDID1_NAME
            // 
            this.colDID1_NAME.Caption = "Контрагент";
            this.colDID1_NAME.FieldName = "DID1_NAME";
            this.colDID1_NAME.Name = "colDID1_NAME";
            this.colDID1_NAME.Visible = true;
            this.colDID1_NAME.VisibleIndex = 3;
            this.colDID1_NAME.Width = 157;
            // 
            // DCONCEPT
            // 
            this.DCONCEPT.Caption = "DCONCEPT";
            this.DCONCEPT.FieldName = "DCONCEPT";
            this.DCONCEPT.Name = "DCONCEPT";
            // 
            // DCONCEPT_NAME
            // 
            this.DCONCEPT_NAME.Caption = "Тип документа";
            this.DCONCEPT_NAME.FieldName = "DCONCEPT_NAME";
            this.DCONCEPT_NAME.Name = "DCONCEPT_NAME";
            this.DCONCEPT_NAME.Visible = true;
            this.DCONCEPT_NAME.VisibleIndex = 4;
            this.DCONCEPT_NAME.Width = 200;
            // 
            // DSTATE
            // 
            this.DSTATE.Caption = "DSTATE";
            this.DSTATE.FieldName = "DSTATE";
            this.DSTATE.Name = "DSTATE";
            // 
            // DSTATE_NAME
            // 
            this.DSTATE_NAME.Caption = "Состояние";
            this.DSTATE_NAME.FieldName = "DSTATE_NAME";
            this.DSTATE_NAME.Name = "DSTATE_NAME";
            this.DSTATE_NAME.Visible = true;
            this.DSTATE_NAME.VisibleIndex = 5;
            this.DSTATE_NAME.Width = 150;
            // 
            // msDocs
            // 
            this.msDocs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMsSend_Group,
            this.tsmiMsGet_Group,
            this.сформироватьДокументToolStripMenuItem});
            this.msDocs.Location = new System.Drawing.Point(0, 0);
            this.msDocs.Name = "msDocs";
            this.msDocs.Size = new System.Drawing.Size(516, 24);
            this.msDocs.TabIndex = 5;
            this.msDocs.Text = "menuStrip1";
            // 
            // tsmiMsSend_Group
            // 
            this.tsmiMsSend_Group.Name = "tsmiMsSend_Group";
            this.tsmiMsSend_Group.Size = new System.Drawing.Size(86, 20);
            this.tsmiMsSend_Group.Text = "Отправить...";
            // 
            // tsmiMsGet_Group
            // 
            this.tsmiMsGet_Group.Name = "tsmiMsGet_Group";
            this.tsmiMsGet_Group.Size = new System.Drawing.Size(82, 20);
            this.tsmiMsGet_Group.Text = "Получить...";
            // 
            // сформироватьДокументToolStripMenuItem
            // 
            this.сформироватьДокументToolStripMenuItem.Name = "сформироватьДокументToolStripMenuItem";
            this.сформироватьДокументToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.сформироватьДокументToolStripMenuItem.Text = "Сформировать документ";
            this.сформироватьДокументToolStripMenuItem.Click += new System.EventHandler(this.сформироватьДокументToolStripMenuItem_Click);
            // 
            // TWDocumentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scMain);
            this.Name = "TWDocumentsView";
            this.Size = new System.Drawing.Size(720, 480);
            this.cmsDocs.ResumeLayout(false);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.pDocs.ResumeLayout(false);
            this.pDocs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDocs)).EndInit();
            this.msDocs.ResumeLayout(false);
            this.msDocs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsDocs;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsSendDoc;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsGetTicket;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsGetMetadata;
        private System.Windows.Forms.ToolStripMenuItem tsmiCmsGetDoc;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.Panel pDocs;
        private DevExpress.XtraGrid.GridControl gDocs;
        private DevExpress.XtraGrid.Views.Grid.GridView vDocs;
        private DevExpress.XtraGrid.Columns.GridColumn colDCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colDDATE1;
        private DevExpress.XtraGrid.Columns.GridColumn colDID1;
        private DevExpress.XtraGrid.Columns.GridColumn colDID;
        private DevExpress.XtraGrid.Columns.GridColumn colDID1_NAME;
        private System.Windows.Forms.MenuStrip msDocs;
        private System.Windows.Forms.ToolStripMenuItem tsmiMsSend_Group;
        private System.Windows.Forms.ToolStripMenuItem tsmiMsGet_Group;
        private DevExpress.XtraGrid.Columns.GridColumn DCONCEPT;
        private DevExpress.XtraGrid.Columns.GridColumn DCONCEPT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn DSTATE;
        private DevExpress.XtraGrid.Columns.GridColumn DSTATE_NAME;
        private System.Windows.Forms.ToolStripMenuItem сформироватьДокументToolStripMenuItem;
        private DocFilterTWDbView docFilterTWDbPanel;
    }
}
