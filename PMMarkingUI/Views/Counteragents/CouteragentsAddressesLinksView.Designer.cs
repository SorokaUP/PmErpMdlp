namespace PMMarkingUI.Views
{
    partial class CouteragentsAddressesLinksView
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
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.gMDLP_Counteragents = new DevExpress.XtraGrid.GridControl();
            this.cmsMDLP_Counteragents = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSelectCounteragent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRefreshCounteragentList = new System.Windows.Forms.ToolStripMenuItem();
            this.vMDLP_Counteragents = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ricbxBool = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.msCounteragents = new System.Windows.Forms.MenuStrip();
            this.tsmiMsRefreshCounteragentList = new System.Windows.Forms.ToolStripMenuItem();
            this.counteragentsAddresses = new PMMarkingUI.Views.CounteragentsAddresses();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gMDLP_Counteragents)).BeginInit();
            this.cmsMDLP_Counteragents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vMDLP_Counteragents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricbxBool)).BeginInit();
            this.msCounteragents.SuspendLayout();
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
            this.scMain.Panel1.Controls.Add(this.gMDLP_Counteragents);
            this.scMain.Panel1.Controls.Add(this.msCounteragents);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.counteragentsAddresses);
            this.scMain.Size = new System.Drawing.Size(720, 480);
            this.scMain.SplitterDistance = 168;
            this.scMain.TabIndex = 0;
            // 
            // gMDLP_Counteragents
            // 
            this.gMDLP_Counteragents.ContextMenuStrip = this.cmsMDLP_Counteragents;
            this.gMDLP_Counteragents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMDLP_Counteragents.Location = new System.Drawing.Point(0, 24);
            this.gMDLP_Counteragents.MainView = this.vMDLP_Counteragents;
            this.gMDLP_Counteragents.Name = "gMDLP_Counteragents";
            this.gMDLP_Counteragents.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ricbxBool});
            this.gMDLP_Counteragents.Size = new System.Drawing.Size(720, 144);
            this.gMDLP_Counteragents.TabIndex = 0;
            this.gMDLP_Counteragents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vMDLP_Counteragents});
            // 
            // cmsMDLP_Counteragents
            // 
            this.cmsMDLP_Counteragents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSelectCounteragent,
            this.toolStripMenuItem1,
            this.tsmiRefreshCounteragentList});
            this.cmsMDLP_Counteragents.Name = "cmsMDLP_Counteragents";
            this.cmsMDLP_Counteragents.Size = new System.Drawing.Size(192, 54);
            // 
            // tsmiSelectCounteragent
            // 
            this.tsmiSelectCounteragent.Name = "tsmiSelectCounteragent";
            this.tsmiSelectCounteragent.Size = new System.Drawing.Size(191, 22);
            this.tsmiSelectCounteragent.Text = "Выбрать контрагента";
            this.tsmiSelectCounteragent.Click += new System.EventHandler(this.tsmiSelectCounteragent_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(188, 6);
            // 
            // tsmiRefreshCounteragentList
            // 
            this.tsmiRefreshCounteragentList.Name = "tsmiRefreshCounteragentList";
            this.tsmiRefreshCounteragentList.Size = new System.Drawing.Size(191, 22);
            this.tsmiRefreshCounteragentList.Text = "Обновить список";
            this.tsmiRefreshCounteragentList.Click += new System.EventHandler(this.tsmiRefreshCounteragentList_Click);
            // 
            // vMDLP_Counteragents
            // 
            this.vMDLP_Counteragents.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.vMDLP_Counteragents.GridControl = this.gMDLP_Counteragents;
            this.vMDLP_Counteragents.Name = "vMDLP_Counteragents";
            this.vMDLP_Counteragents.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.vMDLP_Counteragents.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.vMDLP_Counteragents.OptionsBehavior.AllowIncrementalSearch = true;
            this.vMDLP_Counteragents.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.vMDLP_Counteragents.OptionsBehavior.ReadOnly = true;
            this.vMDLP_Counteragents.OptionsView.ShowGroupPanel = false;
            this.vMDLP_Counteragents.OptionsView.ShowViewCaption = true;
            this.vMDLP_Counteragents.ViewCaption = "Список контрагентов из МДЛП";
            this.vMDLP_Counteragents.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.vMDLP_Counteragents_RowCellClick);
            this.vMDLP_Counteragents.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vMDLP_Counteragents_KeyPress);
            // 
            // ricbxBool
            // 
            this.ricbxBool.AutoHeight = false;
            this.ricbxBool.DisplayValueChecked = "1";
            this.ricbxBool.DisplayValueGrayed = "-1";
            this.ricbxBool.DisplayValueUnchecked = "0";
            this.ricbxBool.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value;
            this.ricbxBool.Name = "ricbxBool";
            this.ricbxBool.ValueChecked = 1;
            this.ricbxBool.ValueGrayed = -1;
            this.ricbxBool.ValueUnchecked = 0;
            // 
            // msCounteragents
            // 
            this.msCounteragents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMsRefreshCounteragentList});
            this.msCounteragents.Location = new System.Drawing.Point(0, 0);
            this.msCounteragents.Name = "msCounteragents";
            this.msCounteragents.Size = new System.Drawing.Size(720, 24);
            this.msCounteragents.TabIndex = 6;
            this.msCounteragents.Text = "menuStrip1";
            // 
            // tsmiMsRefreshCounteragentList
            // 
            this.tsmiMsRefreshCounteragentList.Name = "tsmiMsRefreshCounteragentList";
            this.tsmiMsRefreshCounteragentList.Size = new System.Drawing.Size(115, 20);
            this.tsmiMsRefreshCounteragentList.Text = "Обновить список";
            this.tsmiMsRefreshCounteragentList.Click += new System.EventHandler(this.tsmiMsRefreshCounteragentList_Click);
            // 
            // counteragentsAddresses
            // 
            this.counteragentsAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.counteragentsAddresses.Location = new System.Drawing.Point(0, 0);
            this.counteragentsAddresses.Name = "counteragentsAddresses";
            this.counteragentsAddresses.Size = new System.Drawing.Size(720, 308);
            this.counteragentsAddresses.TabIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "LID";
            this.gridColumn2.FieldName = "LID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Код";
            this.gridColumn3.FieldName = "CODE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Наименование";
            this.gridColumn4.FieldName = "NAME";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "ИНН";
            this.gridColumn5.FieldName = "INN";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "PARENT_LID";
            this.gridColumn6.FieldName = "PARENT_LID";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Папка";
            this.gridColumn7.FieldName = "PARENT_NAME";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Доверенный";
            this.gridColumn8.FieldName = "IS_VERIFY";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "SYS_ID";
            this.gridColumn9.FieldName = "SYS_ID";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // CouteragentsAddressesLinksView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scMain);
            this.Name = "CouteragentsAddressesLinksView";
            this.Size = new System.Drawing.Size(720, 480);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gMDLP_Counteragents)).EndInit();
            this.cmsMDLP_Counteragents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vMDLP_Counteragents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricbxBool)).EndInit();
            this.msCounteragents.ResumeLayout(false);
            this.msCounteragents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private DevExpress.XtraGrid.GridControl gMDLP_Counteragents;
        private DevExpress.XtraGrid.Views.Grid.GridView vMDLP_Counteragents;
        private System.Windows.Forms.ToolTip toolTip;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ricbxBool;
        private System.Windows.Forms.ContextMenuStrip cmsMDLP_Counteragents;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectCounteragent;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshCounteragentList;
        private System.Windows.Forms.MenuStrip msCounteragents;
        private System.Windows.Forms.ToolStripMenuItem tsmiMsRefreshCounteragentList;
        private CounteragentsAddresses counteragentsAddresses;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
    }
}
