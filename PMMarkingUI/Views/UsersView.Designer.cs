namespace PMMarkingUI.Views
{
    partial class UsersView
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
            this.gUsers = new DevExpress.XtraGrid.GridControl();
            this.vUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.USER_UID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USER_LOGIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USER_FIRST_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USER_LAST_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USER_MIDDLE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USER_SYS_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USER_POSITION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USER_IS_ADMIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USER_EMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.USER_AUTH_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vUsers)).BeginInit();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gUsers
            // 
            this.gUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gUsers.Location = new System.Drawing.Point(0, 24);
            this.gUsers.MainView = this.vUsers;
            this.gUsers.Name = "gUsers";
            this.gUsers.Size = new System.Drawing.Size(720, 456);
            this.gUsers.TabIndex = 5;
            this.gUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vUsers});
            // 
            // vUsers
            // 
            this.vUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.USER_UID,
            this.USER_LOGIN,
            this.USER_ID,
            this.USER_FIRST_NAME,
            this.USER_LAST_NAME,
            this.USER_MIDDLE_NAME,
            this.USER_SYS_ID,
            this.USER_POSITION,
            this.USER_IS_ADMIN,
            this.USER_EMAIL,
            this.USER_AUTH_TYPE});
            this.vUsers.GridControl = this.gUsers;
            this.vUsers.Name = "vUsers";
            this.vUsers.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.vUsers.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.vUsers.OptionsBehavior.AllowIncrementalSearch = true;
            this.vUsers.OptionsBehavior.Editable = false;
            this.vUsers.OptionsView.ColumnAutoWidth = false;
            this.vUsers.OptionsView.ShowGroupPanel = false;
            // 
            // USER_UID
            // 
            this.USER_UID.Caption = "UID";
            this.USER_UID.FieldName = "USER_UID";
            this.USER_UID.Name = "USER_UID";
            this.USER_UID.Visible = true;
            this.USER_UID.VisibleIndex = 0;
            // 
            // USER_LOGIN
            // 
            this.USER_LOGIN.Caption = "Логин";
            this.USER_LOGIN.FieldName = "USER_LOGIN";
            this.USER_LOGIN.Name = "USER_LOGIN";
            this.USER_LOGIN.Visible = true;
            this.USER_LOGIN.VisibleIndex = 1;
            this.USER_LOGIN.Width = 194;
            // 
            // USER_ID
            // 
            this.USER_ID.Caption = "USER_ID";
            this.USER_ID.FieldName = "USER_ID";
            this.USER_ID.Name = "USER_ID";
            // 
            // USER_FIRST_NAME
            // 
            this.USER_FIRST_NAME.Caption = "Имя";
            this.USER_FIRST_NAME.FieldName = "USER_FIRST_NAME";
            this.USER_FIRST_NAME.Name = "USER_FIRST_NAME";
            this.USER_FIRST_NAME.Visible = true;
            this.USER_FIRST_NAME.VisibleIndex = 2;
            this.USER_FIRST_NAME.Width = 137;
            // 
            // USER_LAST_NAME
            // 
            this.USER_LAST_NAME.Caption = "Фамилия";
            this.USER_LAST_NAME.FieldName = "USER_LAST_NAME";
            this.USER_LAST_NAME.Name = "USER_LAST_NAME";
            this.USER_LAST_NAME.Visible = true;
            this.USER_LAST_NAME.VisibleIndex = 3;
            this.USER_LAST_NAME.Width = 166;
            // 
            // USER_MIDDLE_NAME
            // 
            this.USER_MIDDLE_NAME.Caption = "Отчество";
            this.USER_MIDDLE_NAME.FieldName = "USER_MIDDLE_NAME";
            this.USER_MIDDLE_NAME.Name = "USER_MIDDLE_NAME";
            this.USER_MIDDLE_NAME.Visible = true;
            this.USER_MIDDLE_NAME.VisibleIndex = 4;
            this.USER_MIDDLE_NAME.Width = 147;
            // 
            // USER_SYS_ID
            // 
            this.USER_SYS_ID.Caption = "USER_SYS_ID";
            this.USER_SYS_ID.FieldName = "USER_SYS_ID";
            this.USER_SYS_ID.Name = "USER_SYS_ID";
            // 
            // USER_POSITION
            // 
            this.USER_POSITION.Caption = "POSITION";
            this.USER_POSITION.FieldName = "USER_POSITION";
            this.USER_POSITION.Name = "USER_POSITION";
            this.USER_POSITION.Visible = true;
            this.USER_POSITION.VisibleIndex = 5;
            // 
            // USER_IS_ADMIN
            // 
            this.USER_IS_ADMIN.Caption = "Админ.";
            this.USER_IS_ADMIN.FieldName = "USER_IS_ADMIN";
            this.USER_IS_ADMIN.Name = "USER_IS_ADMIN";
            this.USER_IS_ADMIN.Visible = true;
            this.USER_IS_ADMIN.VisibleIndex = 6;
            // 
            // USER_EMAIL
            // 
            this.USER_EMAIL.Caption = "E-mail";
            this.USER_EMAIL.FieldName = "USER_EMAIL";
            this.USER_EMAIL.Name = "USER_EMAIL";
            this.USER_EMAIL.Visible = true;
            this.USER_EMAIL.VisibleIndex = 7;
            this.USER_EMAIL.Width = 146;
            // 
            // USER_AUTH_TYPE
            // 
            this.USER_AUTH_TYPE.Caption = "Тип авторизации";
            this.USER_AUTH_TYPE.FieldName = "USER_AUTH_TYPE";
            this.USER_AUTH_TYPE.Name = "USER_AUTH_TYPE";
            this.USER_AUTH_TYPE.Visible = true;
            this.USER_AUTH_TYPE.VisibleIndex = 8;
            this.USER_AUTH_TYPE.Width = 96;
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(720, 24);
            this.msMain.TabIndex = 6;
            this.msMain.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // UsersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gUsers);
            this.Controls.Add(this.msMain);
            this.Name = "UsersView";
            this.Size = new System.Drawing.Size(720, 480);
            ((System.ComponentModel.ISupportInitialize)(this.gUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vUsers)).EndInit();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView vUsers;
        private DevExpress.XtraGrid.Columns.GridColumn USER_UID;
        private DevExpress.XtraGrid.Columns.GridColumn USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn USER_FIRST_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn USER_LAST_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn USER_MIDDLE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn USER_SYS_ID;
        private DevExpress.XtraGrid.Columns.GridColumn USER_POSITION;
        private DevExpress.XtraGrid.Columns.GridColumn USER_IS_ADMIN;
        private DevExpress.XtraGrid.Columns.GridColumn USER_EMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn USER_AUTH_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn USER_LOGIN;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}
