namespace PMMarkingUI.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbLogin = new System.Windows.Forms.ComboBox();
            this.cbxSaveLogin = new System.Windows.Forms.CheckBox();
            this.btnSetupManager = new System.Windows.Forms.Button();
            this.ssFooter = new System.Windows.Forms.StatusStrip();
            this.tsslCapsLock = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNumLock = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslScrollLock = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslInsert = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLanguage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbVersion = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.ssFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя пользователя";
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(15, 68);
            this.tbPassword.MaxLength = 80;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(270, 23);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnOk, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 120);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 41);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Khaki;
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Location = new System.Drawing.Point(0, 0);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(125, 41);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Войти";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightPink;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(145, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 41);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbLogin
            // 
            this.cbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbLogin.FormattingEnabled = true;
            this.cbLogin.Location = new System.Drawing.Point(15, 25);
            this.cbLogin.Name = "cbLogin";
            this.cbLogin.Size = new System.Drawing.Size(270, 24);
            this.cbLogin.TabIndex = 5;
            this.cbLogin.SelectedIndexChanged += new System.EventHandler(this.cbLogin_SelectedIndexChanged);
            // 
            // cbxSaveLogin
            // 
            this.cbxSaveLogin.AutoSize = true;
            this.cbxSaveLogin.Location = new System.Drawing.Point(15, 97);
            this.cbxSaveLogin.Name = "cbxSaveLogin";
            this.cbxSaveLogin.Size = new System.Drawing.Size(114, 17);
            this.cbxSaveLogin.TabIndex = 6;
            this.cbxSaveLogin.Text = "Запомнить логин";
            this.cbxSaveLogin.UseVisualStyleBackColor = true;
            // 
            // btnSetupManager
            // 
            this.btnSetupManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetupManager.Location = new System.Drawing.Point(15, 167);
            this.btnSetupManager.Name = "btnSetupManager";
            this.btnSetupManager.Size = new System.Drawing.Size(270, 23);
            this.btnSetupManager.TabIndex = 7;
            this.btnSetupManager.Text = "Мастер первоначальной настройки";
            this.btnSetupManager.UseVisualStyleBackColor = true;
            this.btnSetupManager.Click += new System.EventHandler(this.btnSetupManager_Click);
            // 
            // ssFooter
            // 
            this.ssFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslCapsLock,
            this.tsslNumLock,
            this.tsslScrollLock,
            this.tsslInsert,
            this.tsslLanguage});
            this.ssFooter.Location = new System.Drawing.Point(0, 196);
            this.ssFooter.Name = "ssFooter";
            this.ssFooter.Size = new System.Drawing.Size(297, 24);
            this.ssFooter.SizingGrip = false;
            this.ssFooter.TabIndex = 11;
            // 
            // tsslCapsLock
            // 
            this.tsslCapsLock.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslCapsLock.Name = "tsslCapsLock";
            this.tsslCapsLock.Size = new System.Drawing.Size(65, 19);
            this.tsslCapsLock.Text = "Caps Lock";
            // 
            // tsslNumLock
            // 
            this.tsslNumLock.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslNumLock.Name = "tsslNumLock";
            this.tsslNumLock.Size = new System.Drawing.Size(66, 19);
            this.tsslNumLock.Text = "Num Lock";
            // 
            // tsslScrollLock
            // 
            this.tsslScrollLock.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslScrollLock.Name = "tsslScrollLock";
            this.tsslScrollLock.Size = new System.Drawing.Size(68, 19);
            this.tsslScrollLock.Text = "Scroll Lock";
            // 
            // tsslInsert
            // 
            this.tsslInsert.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslInsert.Name = "tsslInsert";
            this.tsslInsert.Size = new System.Drawing.Size(40, 19);
            this.tsslInsert.Text = "Insert";
            // 
            // tsslLanguage
            // 
            this.tsslLanguage.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslLanguage.Name = "tsslLanguage";
            this.tsslLanguage.Size = new System.Drawing.Size(24, 19);
            this.tsslLanguage.Text = "En";
            // 
            // lbVersion
            // 
            this.lbVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVersion.Location = new System.Drawing.Point(160, 98);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(125, 16);
            this.lbVersion.TabIndex = 12;
            this.lbVersion.Text = "Версия";
            this.lbVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(297, 220);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.btnSetupManager);
            this.Controls.Add(this.cbxSaveLogin);
            this.Controls.Add(this.cbLogin);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ssFooter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Activated += new System.EventHandler(this.frmLogin_Activated);
            this.Shown += new System.EventHandler(this.frmLogin_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ssFooter.ResumeLayout(false);
            this.ssFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbLogin;
        private System.Windows.Forms.CheckBox cbxSaveLogin;
        private System.Windows.Forms.Button btnSetupManager;
        private System.Windows.Forms.StatusStrip ssFooter;
        private System.Windows.Forms.ToolStripStatusLabel tsslCapsLock;
        private System.Windows.Forms.ToolStripStatusLabel tsslNumLock;
        private System.Windows.Forms.ToolStripStatusLabel tsslScrollLock;
        private System.Windows.Forms.ToolStripStatusLabel tsslInsert;
        private System.Windows.Forms.ToolStripStatusLabel tsslLanguage;
        private System.Windows.Forms.Label lbVersion;
    }
}