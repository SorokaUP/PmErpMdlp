namespace PMMarkingUI.Forms
{
    partial class frmSetupManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetupManager));
            this.xtcPages = new DevExpress.XtraTab.XtraTabControl();
            this.xtpPage_Step_2 = new DevExpress.XtraTab.XtraTabPage();
            this.btnSetClientSecret = new System.Windows.Forms.Button();
            this.tbClientSecret = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.xtpPage_Hello = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnToStep0 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.xtpPage_Step_0 = new DevExpress.XtraTab.XtraTabPage();
            this.btnUSER_ID = new System.Windows.Forms.Button();
            this.tbUSER_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.xtpPage_Step_1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnSetAccountSystem = new System.Windows.Forms.Button();
            this.tbAccountSystem_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xtpPage_Step_3 = new DevExpress.XtraTab.XtraTabPage();
            this.btnGetUserInfo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.xtpPage_Step_4 = new DevExpress.XtraTab.XtraTabPage();
            this.cbxStep4_IsSyncUsers = new System.Windows.Forms.CheckBox();
            this.cbxStep4_IsSyncGoods = new System.Windows.Forms.CheckBox();
            this.cbxStep4_IsSyncAddresses = new System.Windows.Forms.CheckBox();
            this.cbxStep4_IsSyncCounteragents = new System.Windows.Forms.CheckBox();
            this.lbSkip_Step_4 = new System.Windows.Forms.Label();
            this.btnSyncTw4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.xtpPage_Step_5 = new DevExpress.XtraTab.XtraTabPage();
            this.cbxStep5_IsSyncCounteragents = new System.Windows.Forms.CheckBox();
            this.cbxStep5_IsLinkCounteragents = new System.Windows.Forms.CheckBox();
            this.cbxStep5_IsToVerify = new System.Windows.Forms.CheckBox();
            this.lbSkip_Step_7 = new System.Windows.Forms.Label();
            this.btnToVerify = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.xtpPage_Step_6 = new DevExpress.XtraTab.XtraTabPage();
            this.cbxStep6_IsLinkAddresses = new System.Windows.Forms.CheckBox();
            this.lbSkip_Step_6 = new System.Windows.Forms.Label();
            this.cbxStep6_IsGetFias = new System.Windows.Forms.CheckBox();
            this.btnLinkAddresses = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pHeader = new System.Windows.Forms.Panel();
            this.tlpTable = new System.Windows.Forms.TableLayoutPanel();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.lbHeader = new System.Windows.Forms.Label();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.ppProgress = new DevExpress.XtraWaitForm.ProgressPanel();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPages)).BeginInit();
            this.xtcPages.SuspendLayout();
            this.xtpPage_Step_2.SuspendLayout();
            this.xtpPage_Hello.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.xtpPage_Step_0.SuspendLayout();
            this.xtpPage_Step_1.SuspendLayout();
            this.xtpPage_Step_3.SuspendLayout();
            this.xtpPage_Step_4.SuspendLayout();
            this.xtpPage_Step_5.SuspendLayout();
            this.xtpPage_Step_6.SuspendLayout();
            this.pHeader.SuspendLayout();
            this.tlpTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtcPages
            // 
            this.xtcPages.AppearancePage.HeaderActive.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.xtcPages.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.Black;
            this.xtcPages.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.xtcPages.AppearancePage.HeaderActive.Options.UseForeColor = true;
            this.xtcPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtcPages.Location = new System.Drawing.Point(0, 41);
            this.xtcPages.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.xtcPages.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xtcPages.Name = "xtcPages";
            this.xtcPages.SelectedTabPage = this.xtpPage_Step_2;
            this.xtcPages.Size = new System.Drawing.Size(800, 364);
            this.xtcPages.TabIndex = 0;
            this.xtcPages.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpPage_Hello,
            this.xtpPage_Step_0,
            this.xtpPage_Step_1,
            this.xtpPage_Step_2,
            this.xtpPage_Step_3,
            this.xtpPage_Step_4,
            this.xtpPage_Step_5,
            this.xtpPage_Step_6});
            this.xtcPages.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtcPages_SelectedPageChanged);
            // 
            // xtpPage_Step_2
            // 
            this.xtpPage_Step_2.Controls.Add(this.btnSetClientSecret);
            this.xtpPage_Step_2.Controls.Add(this.tbClientSecret);
            this.xtpPage_Step_2.Controls.Add(this.label3);
            this.xtpPage_Step_2.Name = "xtpPage_Step_2";
            this.xtpPage_Step_2.Size = new System.Drawing.Size(798, 339);
            this.xtpPage_Step_2.Text = "Шаг 2 - Учетная система (2 / 2)";
            // 
            // btnSetClientSecret
            // 
            this.btnSetClientSecret.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetClientSecret.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnSetClientSecret.Location = new System.Drawing.Point(0, 300);
            this.btnSetClientSecret.Name = "btnSetClientSecret";
            this.btnSetClientSecret.Size = new System.Drawing.Size(798, 39);
            this.btnSetClientSecret.TabIndex = 5;
            this.btnSetClientSecret.Text = "Принять";
            this.btnSetClientSecret.UseVisualStyleBackColor = true;
            this.btnSetClientSecret.Click += new System.EventHandler(this.btnSetClientSecret_Click);
            // 
            // tbClientSecret
            // 
            this.tbClientSecret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClientSecret.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbClientSecret.Location = new System.Drawing.Point(118, 170);
            this.tbClientSecret.MaxLength = 255;
            this.tbClientSecret.Name = "tbClientSecret";
            this.tbClientSecret.Size = new System.Drawing.Size(558, 27);
            this.tbClientSecret.TabIndex = 4;
            this.tbClientSecret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(798, 134);
            this.label3.TabIndex = 3;
            this.label3.Text = "Учетная система.\r\nВведите секретный ключ, который указан в личном кабинете для ва" +
    "шей учетной системы.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xtpPage_Hello
            // 
            this.xtpPage_Hello.Controls.Add(this.tableLayoutPanel1);
            this.xtpPage_Hello.Controls.Add(this.label1);
            this.xtpPage_Hello.Name = "xtpPage_Hello";
            this.xtpPage_Hello.Size = new System.Drawing.Size(798, 339);
            this.xtpPage_Hello.Text = "Главная";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnSkip, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnToStep0, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 290);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(798, 49);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.LightCoral;
            this.btnSkip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSkip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSkip.Location = new System.Drawing.Point(402, 3);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(393, 43);
            this.btnSkip.TabIndex = 1;
            this.btnSkip.Text = "Пропустить";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnToStep0
            // 
            this.btnToStep0.BackColor = System.Drawing.Color.GreenYellow;
            this.btnToStep0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnToStep0.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToStep0.Location = new System.Drawing.Point(3, 3);
            this.btnToStep0.Name = "btnToStep0";
            this.btnToStep0.Size = new System.Drawing.Size(393, 43);
            this.btnToStep0.TabIndex = 0;
            this.btnToStep0.Text = "Приступить к настройке";
            this.btnToStep0.UseVisualStyleBackColor = false;
            this.btnToStep0.Click += new System.EventHandler(this.btnToStep0_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(798, 134);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xtpPage_Step_0
            // 
            this.xtpPage_Step_0.Controls.Add(this.btnUSER_ID);
            this.xtpPage_Step_0.Controls.Add(this.tbUSER_ID);
            this.xtpPage_Step_0.Controls.Add(this.label5);
            this.xtpPage_Step_0.Name = "xtpPage_Step_0";
            this.xtpPage_Step_0.Size = new System.Drawing.Size(798, 339);
            this.xtpPage_Step_0.Text = "Шаг 0 - Пользователь";
            // 
            // btnUSER_ID
            // 
            this.btnUSER_ID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUSER_ID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnUSER_ID.Location = new System.Drawing.Point(0, 300);
            this.btnUSER_ID.Name = "btnUSER_ID";
            this.btnUSER_ID.Size = new System.Drawing.Size(798, 39);
            this.btnUSER_ID.TabIndex = 5;
            this.btnUSER_ID.Text = "Принять";
            this.btnUSER_ID.UseVisualStyleBackColor = true;
            this.btnUSER_ID.Click += new System.EventHandler(this.btnUSER_ID_Click);
            // 
            // tbUSER_ID
            // 
            this.tbUSER_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUSER_ID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUSER_ID.Location = new System.Drawing.Point(118, 170);
            this.tbUSER_ID.MaxLength = 255;
            this.tbUSER_ID.Name = "tbUSER_ID";
            this.tbUSER_ID.Size = new System.Drawing.Size(558, 27);
            this.tbUSER_ID.TabIndex = 4;
            this.tbUSER_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(798, 134);
            this.label5.TabIndex = 3;
            this.label5.Text = "Пользователь.\r\nДля выполнения всех операций, необходимо указать USER_ID из личног" +
    "о кабинета честныйзнак.рф";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xtpPage_Step_1
            // 
            this.xtpPage_Step_1.Controls.Add(this.btnSetAccountSystem);
            this.xtpPage_Step_1.Controls.Add(this.tbAccountSystem_Name);
            this.xtpPage_Step_1.Controls.Add(this.label2);
            this.xtpPage_Step_1.Name = "xtpPage_Step_1";
            this.xtpPage_Step_1.Size = new System.Drawing.Size(798, 339);
            this.xtpPage_Step_1.Text = "Шаг 1 - Учетная система (1 / 2)";
            // 
            // btnSetAccountSystem
            // 
            this.btnSetAccountSystem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetAccountSystem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnSetAccountSystem.Location = new System.Drawing.Point(0, 300);
            this.btnSetAccountSystem.Name = "btnSetAccountSystem";
            this.btnSetAccountSystem.Size = new System.Drawing.Size(798, 39);
            this.btnSetAccountSystem.TabIndex = 2;
            this.btnSetAccountSystem.Text = "Принять";
            this.btnSetAccountSystem.UseVisualStyleBackColor = true;
            this.btnSetAccountSystem.Click += new System.EventHandler(this.btnSetAccountSystem_Click);
            // 
            // tbAccountSystem_Name
            // 
            this.tbAccountSystem_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAccountSystem_Name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAccountSystem_Name.Location = new System.Drawing.Point(118, 170);
            this.tbAccountSystem_Name.MaxLength = 255;
            this.tbAccountSystem_Name.Name = "tbAccountSystem_Name";
            this.tbAccountSystem_Name.Size = new System.Drawing.Size(558, 27);
            this.tbAccountSystem_Name.TabIndex = 1;
            this.tbAccountSystem_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(798, 134);
            this.label2.TabIndex = 0;
            this.label2.Text = "Учетная система.\r\nДля начала работы необходимо определить вашу первую Учетную сис" +
    "тему, заведенную в личном кабинете на сайте честныйзнак.рф.\r\nПожалуйста, введите" +
    " название вашей учетной системы:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xtpPage_Step_3
            // 
            this.xtpPage_Step_3.Controls.Add(this.btnGetUserInfo);
            this.xtpPage_Step_3.Controls.Add(this.label4);
            this.xtpPage_Step_3.Name = "xtpPage_Step_3";
            this.xtpPage_Step_3.Size = new System.Drawing.Size(798, 339);
            this.xtpPage_Step_3.Text = "Шаг 3 - Пользователи и группы";
            // 
            // btnGetUserInfo
            // 
            this.btnGetUserInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGetUserInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnGetUserInfo.Location = new System.Drawing.Point(0, 300);
            this.btnGetUserInfo.Name = "btnGetUserInfo";
            this.btnGetUserInfo.Size = new System.Drawing.Size(798, 39);
            this.btnGetUserInfo.TabIndex = 6;
            this.btnGetUserInfo.Text = "Выполнить";
            this.btnGetUserInfo.UseVisualStyleBackColor = true;
            this.btnGetUserInfo.Click += new System.EventHandler(this.btnGetUserInfo_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(798, 134);
            this.label4.TabIndex = 4;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xtpPage_Step_4
            // 
            this.xtpPage_Step_4.Controls.Add(this.cbxStep4_IsSyncUsers);
            this.xtpPage_Step_4.Controls.Add(this.cbxStep4_IsSyncGoods);
            this.xtpPage_Step_4.Controls.Add(this.cbxStep4_IsSyncAddresses);
            this.xtpPage_Step_4.Controls.Add(this.cbxStep4_IsSyncCounteragents);
            this.xtpPage_Step_4.Controls.Add(this.lbSkip_Step_4);
            this.xtpPage_Step_4.Controls.Add(this.btnSyncTw4);
            this.xtpPage_Step_4.Controls.Add(this.label6);
            this.xtpPage_Step_4.Name = "xtpPage_Step_4";
            this.xtpPage_Step_4.Size = new System.Drawing.Size(798, 339);
            this.xtpPage_Step_4.Text = "Шаг 4 - Синхронизация с TW4";
            // 
            // cbxStep4_IsSyncUsers
            // 
            this.cbxStep4_IsSyncUsers.AutoSize = true;
            this.cbxStep4_IsSyncUsers.Enabled = false;
            this.cbxStep4_IsSyncUsers.Location = new System.Drawing.Point(126, 206);
            this.cbxStep4_IsSyncUsers.Name = "cbxStep4_IsSyncUsers";
            this.cbxStep4_IsSyncUsers.Size = new System.Drawing.Size(98, 17);
            this.cbxStep4_IsSyncUsers.TabIndex = 13;
            this.cbxStep4_IsSyncUsers.Text = "Пользователи";
            this.cbxStep4_IsSyncUsers.UseVisualStyleBackColor = true;
            // 
            // cbxStep4_IsSyncGoods
            // 
            this.cbxStep4_IsSyncGoods.AutoSize = true;
            this.cbxStep4_IsSyncGoods.Checked = true;
            this.cbxStep4_IsSyncGoods.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxStep4_IsSyncGoods.Location = new System.Drawing.Point(126, 183);
            this.cbxStep4_IsSyncGoods.Name = "cbxStep4_IsSyncGoods";
            this.cbxStep4_IsSyncGoods.Size = new System.Drawing.Size(64, 17);
            this.cbxStep4_IsSyncGoods.TabIndex = 12;
            this.cbxStep4_IsSyncGoods.Text = "Товары";
            this.cbxStep4_IsSyncGoods.UseVisualStyleBackColor = true;
            // 
            // cbxStep4_IsSyncAddresses
            // 
            this.cbxStep4_IsSyncAddresses.AutoSize = true;
            this.cbxStep4_IsSyncAddresses.Checked = true;
            this.cbxStep4_IsSyncAddresses.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxStep4_IsSyncAddresses.Location = new System.Drawing.Point(126, 160);
            this.cbxStep4_IsSyncAddresses.Name = "cbxStep4_IsSyncAddresses";
            this.cbxStep4_IsSyncAddresses.Size = new System.Drawing.Size(63, 17);
            this.cbxStep4_IsSyncAddresses.TabIndex = 11;
            this.cbxStep4_IsSyncAddresses.Text = "Адреса";
            this.cbxStep4_IsSyncAddresses.UseVisualStyleBackColor = true;
            // 
            // cbxStep4_IsSyncCounteragents
            // 
            this.cbxStep4_IsSyncCounteragents.AutoSize = true;
            this.cbxStep4_IsSyncCounteragents.Checked = true;
            this.cbxStep4_IsSyncCounteragents.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxStep4_IsSyncCounteragents.Location = new System.Drawing.Point(126, 137);
            this.cbxStep4_IsSyncCounteragents.Name = "cbxStep4_IsSyncCounteragents";
            this.cbxStep4_IsSyncCounteragents.Size = new System.Drawing.Size(94, 17);
            this.cbxStep4_IsSyncCounteragents.TabIndex = 10;
            this.cbxStep4_IsSyncCounteragents.Text = "Контрагенты";
            this.cbxStep4_IsSyncCounteragents.UseVisualStyleBackColor = true;
            // 
            // lbSkip_Step_4
            // 
            this.lbSkip_Step_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSkip_Step_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSkip_Step_4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.lbSkip_Step_4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbSkip_Step_4.Location = new System.Drawing.Point(646, 274);
            this.lbSkip_Step_4.Name = "lbSkip_Step_4";
            this.lbSkip_Step_4.Size = new System.Drawing.Size(141, 23);
            this.lbSkip_Step_4.TabIndex = 9;
            this.lbSkip_Step_4.Text = "Пропустить настройку";
            this.lbSkip_Step_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSkip_Step_4.Click += new System.EventHandler(this.SkipStep);
            // 
            // btnSyncTw4
            // 
            this.btnSyncTw4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSyncTw4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnSyncTw4.Location = new System.Drawing.Point(0, 300);
            this.btnSyncTw4.Name = "btnSyncTw4";
            this.btnSyncTw4.Size = new System.Drawing.Size(798, 39);
            this.btnSyncTw4.TabIndex = 8;
            this.btnSyncTw4.Text = "Выполнить";
            this.btnSyncTw4.UseVisualStyleBackColor = true;
            this.btnSyncTw4.Click += new System.EventHandler(this.btnSyncTw4_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(798, 134);
            this.label6.TabIndex = 7;
            this.label6.Text = "Синхронизация с TW4.\r\nСинхронизация справочников контрагентов, адресов, товаров и" +
    " пользователей.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xtpPage_Step_5
            // 
            this.xtpPage_Step_5.Controls.Add(this.cbxStep5_IsSyncCounteragents);
            this.xtpPage_Step_5.Controls.Add(this.cbxStep5_IsLinkCounteragents);
            this.xtpPage_Step_5.Controls.Add(this.cbxStep5_IsToVerify);
            this.xtpPage_Step_5.Controls.Add(this.lbSkip_Step_7);
            this.xtpPage_Step_5.Controls.Add(this.btnToVerify);
            this.xtpPage_Step_5.Controls.Add(this.label9);
            this.xtpPage_Step_5.Name = "xtpPage_Step_5";
            this.xtpPage_Step_5.Size = new System.Drawing.Size(798, 339);
            this.xtpPage_Step_5.Text = "Шаг 5 - Отправка контрагентов в доверенные";
            // 
            // cbxStep5_IsSyncCounteragents
            // 
            this.cbxStep5_IsSyncCounteragents.AutoSize = true;
            this.cbxStep5_IsSyncCounteragents.Checked = true;
            this.cbxStep5_IsSyncCounteragents.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxStep5_IsSyncCounteragents.Enabled = false;
            this.cbxStep5_IsSyncCounteragents.Location = new System.Drawing.Point(144, 160);
            this.cbxStep5_IsSyncCounteragents.Name = "cbxStep5_IsSyncCounteragents";
            this.cbxStep5_IsSyncCounteragents.Size = new System.Drawing.Size(295, 17);
            this.cbxStep5_IsSyncCounteragents.TabIndex = 18;
            this.cbxStep5_IsSyncCounteragents.Text = "Получить контрагентов без отправки в доверенные";
            this.cbxStep5_IsSyncCounteragents.UseVisualStyleBackColor = true;
            // 
            // cbxStep5_IsLinkCounteragents
            // 
            this.cbxStep5_IsLinkCounteragents.AutoSize = true;
            this.cbxStep5_IsLinkCounteragents.Checked = true;
            this.cbxStep5_IsLinkCounteragents.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxStep5_IsLinkCounteragents.Location = new System.Drawing.Point(126, 183);
            this.cbxStep5_IsLinkCounteragents.Name = "cbxStep5_IsLinkCounteragents";
            this.cbxStep5_IsLinkCounteragents.Size = new System.Drawing.Size(247, 17);
            this.cbxStep5_IsLinkCounteragents.TabIndex = 17;
            this.cbxStep5_IsLinkCounteragents.Text = "Связать контрагентов МДЛП с TW4 по ИНН";
            this.cbxStep5_IsLinkCounteragents.UseVisualStyleBackColor = true;
            // 
            // cbxStep5_IsToVerify
            // 
            this.cbxStep5_IsToVerify.AutoSize = true;
            this.cbxStep5_IsToVerify.Checked = true;
            this.cbxStep5_IsToVerify.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxStep5_IsToVerify.Location = new System.Drawing.Point(126, 137);
            this.cbxStep5_IsToVerify.Name = "cbxStep5_IsToVerify";
            this.cbxStep5_IsToVerify.Size = new System.Drawing.Size(225, 17);
            this.cbxStep5_IsToVerify.TabIndex = 16;
            this.cbxStep5_IsToVerify.Text = "Добавить контрагентов в доверенные";
            this.cbxStep5_IsToVerify.UseVisualStyleBackColor = true;
            this.cbxStep5_IsToVerify.CheckedChanged += new System.EventHandler(this.cbxStep5_IsToVerify_CheckedChanged);
            // 
            // lbSkip_Step_7
            // 
            this.lbSkip_Step_7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSkip_Step_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSkip_Step_7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.lbSkip_Step_7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbSkip_Step_7.Location = new System.Drawing.Point(646, 274);
            this.lbSkip_Step_7.Name = "lbSkip_Step_7";
            this.lbSkip_Step_7.Size = new System.Drawing.Size(141, 23);
            this.lbSkip_Step_7.TabIndex = 15;
            this.lbSkip_Step_7.Text = "Пропустить настройку";
            this.lbSkip_Step_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSkip_Step_7.Click += new System.EventHandler(this.SkipStep);
            // 
            // btnToVerify
            // 
            this.btnToVerify.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnToVerify.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnToVerify.Location = new System.Drawing.Point(0, 300);
            this.btnToVerify.Name = "btnToVerify";
            this.btnToVerify.Size = new System.Drawing.Size(798, 39);
            this.btnToVerify.TabIndex = 14;
            this.btnToVerify.Text = "Выполнить";
            this.btnToVerify.UseVisualStyleBackColor = true;
            this.btnToVerify.Click += new System.EventHandler(this.btnToVerify_Click);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(798, 134);
            this.label9.TabIndex = 13;
            this.label9.Text = resources.GetString("label9.Text");
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xtpPage_Step_6
            // 
            this.xtpPage_Step_6.Controls.Add(this.cbxStep6_IsLinkAddresses);
            this.xtpPage_Step_6.Controls.Add(this.lbSkip_Step_6);
            this.xtpPage_Step_6.Controls.Add(this.cbxStep6_IsGetFias);
            this.xtpPage_Step_6.Controls.Add(this.btnLinkAddresses);
            this.xtpPage_Step_6.Controls.Add(this.label8);
            this.xtpPage_Step_6.Name = "xtpPage_Step_6";
            this.xtpPage_Step_6.Size = new System.Drawing.Size(798, 339);
            this.xtpPage_Step_6.Text = "Шаг 6 - Связка адресов контрагентов";
            // 
            // cbxStep6_IsLinkAddresses
            // 
            this.cbxStep6_IsLinkAddresses.AutoSize = true;
            this.cbxStep6_IsLinkAddresses.Checked = true;
            this.cbxStep6_IsLinkAddresses.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxStep6_IsLinkAddresses.Location = new System.Drawing.Point(126, 160);
            this.cbxStep6_IsLinkAddresses.Name = "cbxStep6_IsLinkAddresses";
            this.cbxStep6_IsLinkAddresses.Size = new System.Drawing.Size(295, 17);
            this.cbxStep6_IsLinkAddresses.TabIndex = 17;
            this.cbxStep6_IsLinkAddresses.Text = "Связать адреса контрагентов МДЛП и TW4 по ФИАС";
            this.cbxStep6_IsLinkAddresses.UseVisualStyleBackColor = true;
            // 
            // lbSkip_Step_6
            // 
            this.lbSkip_Step_6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSkip_Step_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSkip_Step_6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.lbSkip_Step_6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbSkip_Step_6.Location = new System.Drawing.Point(646, 274);
            this.lbSkip_Step_6.Name = "lbSkip_Step_6";
            this.lbSkip_Step_6.Size = new System.Drawing.Size(141, 23);
            this.lbSkip_Step_6.TabIndex = 16;
            this.lbSkip_Step_6.Text = "Пропустить настройку";
            this.lbSkip_Step_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSkip_Step_6.Click += new System.EventHandler(this.SkipStep);
            // 
            // cbxStep6_IsGetFias
            // 
            this.cbxStep6_IsGetFias.AutoSize = true;
            this.cbxStep6_IsGetFias.Checked = true;
            this.cbxStep6_IsGetFias.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxStep6_IsGetFias.Location = new System.Drawing.Point(126, 137);
            this.cbxStep6_IsGetFias.Name = "cbxStep6_IsGetFias";
            this.cbxStep6_IsGetFias.Size = new System.Drawing.Size(266, 17);
            this.cbxStep6_IsGetFias.TabIndex = 13;
            this.cbxStep6_IsGetFias.Text = "Получить ФИАС по адресам контрагентов TW4";
            this.cbxStep6_IsGetFias.UseVisualStyleBackColor = true;
            // 
            // btnLinkAddresses
            // 
            this.btnLinkAddresses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLinkAddresses.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnLinkAddresses.Location = new System.Drawing.Point(0, 300);
            this.btnLinkAddresses.Name = "btnLinkAddresses";
            this.btnLinkAddresses.Size = new System.Drawing.Size(798, 39);
            this.btnLinkAddresses.TabIndex = 12;
            this.btnLinkAddresses.Text = "Выполнить";
            this.btnLinkAddresses.UseVisualStyleBackColor = true;
            this.btnLinkAddresses.Click += new System.EventHandler(this.btnLinkAddresses_Click);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(798, 134);
            this.label8.TabIndex = 11;
            this.label8.Text = "Связка адресов контрагентов TW4 и МДЛП.\r\nКак только контрагенты и адреса были пол" +
    "учены, их необходимо связать. Будет выполнено получение информации по адресам ФИ" +
    "АС, затем связка.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pHeader.Controls.Add(this.tlpTable);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(800, 41);
            this.pHeader.TabIndex = 2;
            // 
            // tlpTable
            // 
            this.tlpTable.ColumnCount = 3;
            this.tlpTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpTable.Controls.Add(this.btnNext, 2, 0);
            this.tlpTable.Controls.Add(this.lbHeader, 1, 0);
            this.tlpTable.Controls.Add(this.btnBack, 0, 0);
            this.tlpTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTable.Location = new System.Drawing.Point(0, 0);
            this.tlpTable.Name = "tlpTable";
            this.tlpTable.RowCount = 1;
            this.tlpTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTable.Size = new System.Drawing.Size(800, 41);
            this.tlpTable.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNext.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnNext.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnNext.Appearance.Options.UseBackColor = true;
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.Appearance.Options.UseForeColor = true;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.ImageOptions.Image")));
            this.btnNext.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(683, 3);
            this.btnNext.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNext.LookAndFeel.SkinMaskColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btnNext.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(114, 35);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Вперед";
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbHeader
            // 
            this.lbHeader.AutoEllipsis = true;
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHeader.ForeColor = System.Drawing.Color.White;
            this.lbHeader.Location = new System.Drawing.Point(123, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(554, 41);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "lbHeader";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBack.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnBack.Appearance.Options.UseBackColor = true;
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Appearance.Options.UseForeColor = true;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.ImageOptions.Image")));
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBack.LookAndFeel.SkinMaskColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btnBack.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Назад";
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ppProgress
            // 
            this.ppProgress.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ppProgress.Appearance.Options.UseBackColor = true;
            this.ppProgress.BarAnimationElementThickness = 2;
            this.ppProgress.Caption = "Ожидайте";
            this.ppProgress.Description = "Операция выполняется...";
            this.ppProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ppProgress.Location = new System.Drawing.Point(0, 405);
            this.ppProgress.Name = "ppProgress";
            this.ppProgress.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ppProgress.Size = new System.Drawing.Size(800, 45);
            this.ppProgress.TabIndex = 3;
            this.ppProgress.Text = "Подождите идет выполнение";
            this.ppProgress.Visible = false;
            // 
            // frmSetupManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xtcPages);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.ppProgress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSetupManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мастер первоначальной настройки интерфейса взаимодействия с МДЛП";
            ((System.ComponentModel.ISupportInitialize)(this.xtcPages)).EndInit();
            this.xtcPages.ResumeLayout(false);
            this.xtpPage_Step_2.ResumeLayout(false);
            this.xtpPage_Step_2.PerformLayout();
            this.xtpPage_Hello.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.xtpPage_Step_0.ResumeLayout(false);
            this.xtpPage_Step_0.PerformLayout();
            this.xtpPage_Step_1.ResumeLayout(false);
            this.xtpPage_Step_1.PerformLayout();
            this.xtpPage_Step_3.ResumeLayout(false);
            this.xtpPage_Step_4.ResumeLayout(false);
            this.xtpPage_Step_4.PerformLayout();
            this.xtpPage_Step_5.ResumeLayout(false);
            this.xtpPage_Step_5.PerformLayout();
            this.xtpPage_Step_6.ResumeLayout(false);
            this.xtpPage_Step_6.PerformLayout();
            this.pHeader.ResumeLayout(false);
            this.tlpTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtcPages;
        private DevExpress.XtraTab.XtraTabPage xtpPage_Step_1;
        private DevExpress.XtraTab.XtraTabPage xtpPage_Step_2;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.TableLayoutPanel tlpTable;
        private System.Windows.Forms.Label lbHeader;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private System.Windows.Forms.TextBox tbAccountSystem_Name;
        private System.Windows.Forms.Button btnSetAccountSystem;
        private System.Windows.Forms.Button btnSetClientSecret;
        private System.Windows.Forms.TextBox tbClientSecret;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraTab.XtraTabPage xtpPage_Step_3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraWaitForm.ProgressPanel ppProgress;
        private System.Windows.Forms.Button btnGetUserInfo;
        private DevExpress.XtraTab.XtraTabPage xtpPage_Step_0;
        private System.Windows.Forms.Button btnUSER_ID;
        private System.Windows.Forms.TextBox tbUSER_ID;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraTab.XtraTabPage xtpPage_Step_4;
        private System.Windows.Forms.Button btnSyncTw4;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraTab.XtraTabPage xtpPage_Step_6;
        private System.Windows.Forms.Button btnLinkAddresses;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraTab.XtraTabPage xtpPage_Step_5;
        private System.Windows.Forms.Button btnToVerify;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraTab.XtraTabPage xtpPage_Hello;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnToStep0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSkip_Step_4;
        private System.Windows.Forms.Label lbSkip_Step_7;
        private System.Windows.Forms.CheckBox cbxStep4_IsSyncUsers;
        private System.Windows.Forms.CheckBox cbxStep4_IsSyncGoods;
        private System.Windows.Forms.CheckBox cbxStep4_IsSyncAddresses;
        private System.Windows.Forms.CheckBox cbxStep4_IsSyncCounteragents;
        private System.Windows.Forms.CheckBox cbxStep6_IsGetFias;
        private System.Windows.Forms.Label lbSkip_Step_6;
        private System.Windows.Forms.CheckBox cbxStep6_IsLinkAddresses;
        private System.Windows.Forms.CheckBox cbxStep5_IsLinkCounteragents;
        private System.Windows.Forms.CheckBox cbxStep5_IsToVerify;
        private System.Windows.Forms.CheckBox cbxStep5_IsSyncCounteragents;
    }
}