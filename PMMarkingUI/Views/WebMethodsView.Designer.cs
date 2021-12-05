namespace PMMarkingUI.Views
{
    partial class WebMethodsView
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
            this.cMethods = new DevExpress.XtraGrid.GridControl();
            this.vMethods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PARENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TYPE_REQUEST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riComboBox_TypeRequest = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.REQUEST_QUERY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.REQUEST_TIMEOUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riCalcEdit_RequestTimeout = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.IS_GROUP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riCheckEdit_IsGroup = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.IS_ARCHIVE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.обновитьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cMethods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMethods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComboBox_TypeRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCalcEdit_RequestTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEdit_IsGroup)).BeginInit();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cMethods
            // 
            this.cMethods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cMethods.Location = new System.Drawing.Point(0, 24);
            this.cMethods.MainView = this.vMethods;
            this.cMethods.Name = "cMethods";
            this.cMethods.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riComboBox_TypeRequest,
            this.riCalcEdit_RequestTimeout,
            this.riCheckEdit_IsGroup});
            this.cMethods.Size = new System.Drawing.Size(720, 456);
            this.cMethods.TabIndex = 7;
            this.cMethods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vMethods});
            // 
            // vMethods
            // 
            this.vMethods.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.PARENT,
            this.CODE,
            this.NAME,
            this.TYPE_REQUEST,
            this.REQUEST_QUERY,
            this.REQUEST_TIMEOUT,
            this.IS_GROUP,
            this.IS_ARCHIVE});
            this.vMethods.GridControl = this.cMethods;
            this.vMethods.Name = "vMethods";
            this.vMethods.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.vMethods.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.vMethods.OptionsBehavior.AllowIncrementalSearch = true;
            this.vMethods.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.vMethods.OptionsView.ColumnAutoWidth = false;
            this.vMethods.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.vMethods.OptionsView.ShowFooter = true;
            this.vMethods.OptionsView.ShowGroupPanel = false;
            this.vMethods.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.vMethods_RowDeleting);
            this.vMethods.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.vMethods_RowUpdated);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // PARENT
            // 
            this.PARENT.Caption = "Входит в состав (ID)";
            this.PARENT.FieldName = "PARENT";
            this.PARENT.Name = "PARENT";
            this.PARENT.OptionsColumn.AllowEdit = false;
            this.PARENT.Visible = true;
            this.PARENT.VisibleIndex = 1;
            // 
            // CODE
            // 
            this.CODE.Caption = "Номер";
            this.CODE.FieldName = "CODE";
            this.CODE.Name = "CODE";
            this.CODE.Visible = true;
            this.CODE.VisibleIndex = 2;
            // 
            // NAME
            // 
            this.NAME.Caption = "Наименование";
            this.NAME.FieldName = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "NAME", "{0}")});
            this.NAME.Visible = true;
            this.NAME.VisibleIndex = 3;
            this.NAME.Width = 429;
            // 
            // TYPE_REQUEST
            // 
            this.TYPE_REQUEST.Caption = "Тип запроса";
            this.TYPE_REQUEST.ColumnEdit = this.riComboBox_TypeRequest;
            this.TYPE_REQUEST.FieldName = "TYPE_REQUEST";
            this.TYPE_REQUEST.Name = "TYPE_REQUEST";
            this.TYPE_REQUEST.Visible = true;
            this.TYPE_REQUEST.VisibleIndex = 4;
            this.TYPE_REQUEST.Width = 104;
            // 
            // riComboBox_TypeRequest
            // 
            this.riComboBox_TypeRequest.AutoHeight = false;
            this.riComboBox_TypeRequest.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riComboBox_TypeRequest.Items.AddRange(new object[] {
            "POST",
            "GET",
            "DELETE",
            "PUT"});
            this.riComboBox_TypeRequest.Name = "riComboBox_TypeRequest";
            // 
            // REQUEST_QUERY
            // 
            this.REQUEST_QUERY.Caption = "Запрос";
            this.REQUEST_QUERY.FieldName = "REQUEST_QUERY";
            this.REQUEST_QUERY.Name = "REQUEST_QUERY";
            this.REQUEST_QUERY.Visible = true;
            this.REQUEST_QUERY.VisibleIndex = 5;
            this.REQUEST_QUERY.Width = 417;
            // 
            // REQUEST_TIMEOUT
            // 
            this.REQUEST_TIMEOUT.Caption = "Тайм-аут";
            this.REQUEST_TIMEOUT.ColumnEdit = this.riCalcEdit_RequestTimeout;
            this.REQUEST_TIMEOUT.FieldName = "REQUEST_TIMEOUT";
            this.REQUEST_TIMEOUT.Name = "REQUEST_TIMEOUT";
            this.REQUEST_TIMEOUT.Visible = true;
            this.REQUEST_TIMEOUT.VisibleIndex = 6;
            // 
            // riCalcEdit_RequestTimeout
            // 
            this.riCalcEdit_RequestTimeout.AutoHeight = false;
            this.riCalcEdit_RequestTimeout.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riCalcEdit_RequestTimeout.Name = "riCalcEdit_RequestTimeout";
            // 
            // IS_GROUP
            // 
            this.IS_GROUP.Caption = "Групповой";
            this.IS_GROUP.ColumnEdit = this.riCheckEdit_IsGroup;
            this.IS_GROUP.FieldName = "IS_GROUP";
            this.IS_GROUP.Name = "IS_GROUP";
            this.IS_GROUP.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IS_GROUP", "{0:#.##}")});
            this.IS_GROUP.Visible = true;
            this.IS_GROUP.VisibleIndex = 7;
            // 
            // riCheckEdit_IsGroup
            // 
            this.riCheckEdit_IsGroup.AutoHeight = false;
            this.riCheckEdit_IsGroup.Name = "riCheckEdit_IsGroup";
            this.riCheckEdit_IsGroup.ValueChecked = ((short)(1));
            this.riCheckEdit_IsGroup.ValueUnchecked = ((short)(0));
            // 
            // IS_ARCHIVE
            // 
            this.IS_ARCHIVE.Caption = "Архивный";
            this.IS_ARCHIVE.ColumnEdit = this.riCheckEdit_IsGroup;
            this.IS_ARCHIVE.FieldName = "IS_ARCHIVE";
            this.IS_ARCHIVE.Name = "IS_ARCHIVE";
            this.IS_ARCHIVE.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IS_ARCHIVE", "{0:#.##}")});
            this.IS_ARCHIVE.Visible = true;
            this.IS_ARCHIVE.VisibleIndex = 8;
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьСписокToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(720, 24);
            this.msMain.TabIndex = 8;
            this.msMain.Text = "menuStrip1";
            // 
            // обновитьСписокToolStripMenuItem
            // 
            this.обновитьСписокToolStripMenuItem.Name = "обновитьСписокToolStripMenuItem";
            this.обновитьСписокToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.обновитьСписокToolStripMenuItem.Text = "Обновить список";
            this.обновитьСписокToolStripMenuItem.Click += new System.EventHandler(this.обновитьСписокToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // WebMethodsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cMethods);
            this.Controls.Add(this.msMain);
            this.Name = "WebMethodsView";
            this.Size = new System.Drawing.Size(720, 480);
            ((System.ComponentModel.ISupportInitialize)(this.cMethods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMethods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riComboBox_TypeRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCalcEdit_RequestTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckEdit_IsGroup)).EndInit();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl cMethods;
        private DevExpress.XtraGrid.Views.Grid.GridView vMethods;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn PARENT;
        private DevExpress.XtraGrid.Columns.GridColumn CODE;
        private DevExpress.XtraGrid.Columns.GridColumn NAME;
        private DevExpress.XtraGrid.Columns.GridColumn TYPE_REQUEST;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox riComboBox_TypeRequest;
        private DevExpress.XtraGrid.Columns.GridColumn REQUEST_QUERY;
        private DevExpress.XtraGrid.Columns.GridColumn REQUEST_TIMEOUT;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit riCalcEdit_RequestTimeout;
        private DevExpress.XtraGrid.Columns.GridColumn IS_GROUP;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riCheckEdit_IsGroup;
        private DevExpress.XtraGrid.Columns.GridColumn IS_ARCHIVE;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьСписокToolStripMenuItem;
    }
}
