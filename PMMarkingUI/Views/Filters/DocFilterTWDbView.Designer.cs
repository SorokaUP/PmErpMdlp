namespace PMMarkingUI.Views
{
    partial class DocFilterTWDbView
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
            this.gbDates = new System.Windows.Forms.GroupBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lbDateFrom = new System.Windows.Forms.Label();
            this.lbDateTo = new System.Windows.Forms.Label();
            this.gbDirection = new System.Windows.Forms.GroupBox();
            this.cbxReturned = new System.Windows.Forms.CheckBox();
            this.rbDirectionOutgoing = new System.Windows.Forms.RadioButton();
            this.rbDirectionIncoming = new System.Windows.Forms.RadioButton();
            this.gbCounteragent = new System.Windows.Forms.GroupBox();
            this.beCounteragent = new DevExpress.XtraEditors.ButtonEdit();
            this.gbManager = new System.Windows.Forms.GroupBox();
            this.beManager = new DevExpress.XtraEditors.ButtonEdit();
            this.gbDepartament = new System.Windows.Forms.GroupBox();
            this.beDepartament = new DevExpress.XtraEditors.ButtonEdit();
            this.btnSerch = new System.Windows.Forms.Button();
            this.gbGroup = new System.Windows.Forms.GroupBox();
            this.beGroup = new DevExpress.XtraEditors.ButtonEdit();
            this.gbDates.SuspendLayout();
            this.gbDirection.SuspendLayout();
            this.gbCounteragent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beCounteragent.Properties)).BeginInit();
            this.gbManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beManager.Properties)).BeginInit();
            this.gbDepartament.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beDepartament.Properties)).BeginInit();
            this.gbGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beGroup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDates
            // 
            this.gbDates.Controls.Add(this.dtpFrom);
            this.gbDates.Controls.Add(this.dtpTo);
            this.gbDates.Controls.Add(this.lbDateFrom);
            this.gbDates.Controls.Add(this.lbDateTo);
            this.gbDates.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDates.Location = new System.Drawing.Point(0, 0);
            this.gbDates.Name = "gbDates";
            this.gbDates.Size = new System.Drawing.Size(194, 122);
            this.gbDates.TabIndex = 12;
            this.gbDates.TabStop = false;
            this.gbDates.Text = "Период";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(11, 40);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(173, 20);
            this.dtpFrom.TabIndex = 0;
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(11, 86);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(173, 20);
            this.dtpTo.TabIndex = 2;
            // 
            // lbDateFrom
            // 
            this.lbDateFrom.AutoSize = true;
            this.lbDateFrom.Location = new System.Drawing.Point(8, 24);
            this.lbDateFrom.Name = "lbDateFrom";
            this.lbDateFrom.Size = new System.Drawing.Size(89, 13);
            this.lbDateFrom.TabIndex = 1;
            this.lbDateFrom.Text = "Начало периода";
            // 
            // lbDateTo
            // 
            this.lbDateTo.AutoSize = true;
            this.lbDateTo.Location = new System.Drawing.Point(8, 70);
            this.lbDateTo.Name = "lbDateTo";
            this.lbDateTo.Size = new System.Drawing.Size(107, 13);
            this.lbDateTo.TabIndex = 3;
            this.lbDateTo.Text = "Окончание периода";
            // 
            // gbDirection
            // 
            this.gbDirection.Controls.Add(this.cbxReturned);
            this.gbDirection.Controls.Add(this.rbDirectionOutgoing);
            this.gbDirection.Controls.Add(this.rbDirectionIncoming);
            this.gbDirection.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDirection.Location = new System.Drawing.Point(0, 122);
            this.gbDirection.Name = "gbDirection";
            this.gbDirection.Size = new System.Drawing.Size(194, 116);
            this.gbDirection.TabIndex = 11;
            this.gbDirection.TabStop = false;
            this.gbDirection.Text = "Направление документа";
            // 
            // cbxReturned
            // 
            this.cbxReturned.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxReturned.Location = new System.Drawing.Point(10, 79);
            this.cbxReturned.Name = "cbxReturned";
            this.cbxReturned.Size = new System.Drawing.Size(173, 24);
            this.cbxReturned.TabIndex = 9;
            this.cbxReturned.Text = "Возвратные";
            this.cbxReturned.UseVisualStyleBackColor = true;
            // 
            // rbDirectionOutgoing
            // 
            this.rbDirectionOutgoing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDirectionOutgoing.Location = new System.Drawing.Point(10, 49);
            this.rbDirectionOutgoing.Name = "rbDirectionOutgoing";
            this.rbDirectionOutgoing.Size = new System.Drawing.Size(173, 24);
            this.rbDirectionOutgoing.TabIndex = 8;
            this.rbDirectionOutgoing.TabStop = true;
            this.rbDirectionOutgoing.Text = "Исходящие";
            this.rbDirectionOutgoing.UseVisualStyleBackColor = true;
            // 
            // rbDirectionIncoming
            // 
            this.rbDirectionIncoming.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDirectionIncoming.Checked = true;
            this.rbDirectionIncoming.Location = new System.Drawing.Point(10, 19);
            this.rbDirectionIncoming.Name = "rbDirectionIncoming";
            this.rbDirectionIncoming.Size = new System.Drawing.Size(173, 24);
            this.rbDirectionIncoming.TabIndex = 7;
            this.rbDirectionIncoming.TabStop = true;
            this.rbDirectionIncoming.Text = "Входящие";
            this.rbDirectionIncoming.UseVisualStyleBackColor = true;
            // 
            // gbCounteragent
            // 
            this.gbCounteragent.Controls.Add(this.beCounteragent);
            this.gbCounteragent.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCounteragent.Location = new System.Drawing.Point(0, 238);
            this.gbCounteragent.Name = "gbCounteragent";
            this.gbCounteragent.Size = new System.Drawing.Size(194, 58);
            this.gbCounteragent.TabIndex = 13;
            this.gbCounteragent.TabStop = false;
            this.gbCounteragent.Text = "Контрагент";
            // 
            // beCounteragent
            // 
            this.beCounteragent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beCounteragent.EditValue = "";
            this.beCounteragent.Location = new System.Drawing.Point(10, 22);
            this.beCounteragent.Name = "beCounteragent";
            this.beCounteragent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.beCounteragent.Properties.ReadOnly = true;
            this.beCounteragent.Properties.UseReadOnlyAppearance = false;
            this.beCounteragent.Size = new System.Drawing.Size(174, 20);
            this.beCounteragent.TabIndex = 0;
            this.beCounteragent.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beCounteragent_ButtonClick);
            // 
            // gbManager
            // 
            this.gbManager.Controls.Add(this.beManager);
            this.gbManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbManager.Location = new System.Drawing.Point(0, 296);
            this.gbManager.Name = "gbManager";
            this.gbManager.Size = new System.Drawing.Size(194, 58);
            this.gbManager.TabIndex = 14;
            this.gbManager.TabStop = false;
            this.gbManager.Text = "Менеджер";
            // 
            // beManager
            // 
            this.beManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beManager.Location = new System.Drawing.Point(10, 22);
            this.beManager.Name = "beManager";
            this.beManager.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.beManager.Properties.ReadOnly = true;
            this.beManager.Properties.UseReadOnlyAppearance = false;
            this.beManager.Size = new System.Drawing.Size(174, 20);
            this.beManager.TabIndex = 1;
            this.beManager.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beManager_ButtonClick);
            // 
            // gbDepartament
            // 
            this.gbDepartament.Controls.Add(this.beDepartament);
            this.gbDepartament.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDepartament.Location = new System.Drawing.Point(0, 354);
            this.gbDepartament.Name = "gbDepartament";
            this.gbDepartament.Size = new System.Drawing.Size(194, 58);
            this.gbDepartament.TabIndex = 15;
            this.gbDepartament.TabStop = false;
            this.gbDepartament.Text = "Отдел";
            // 
            // beDepartament
            // 
            this.beDepartament.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beDepartament.Location = new System.Drawing.Point(10, 22);
            this.beDepartament.Name = "beDepartament";
            this.beDepartament.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.beDepartament.Properties.ReadOnly = true;
            this.beDepartament.Properties.UseReadOnlyAppearance = false;
            this.beDepartament.Size = new System.Drawing.Size(174, 20);
            this.beDepartament.TabIndex = 1;
            this.beDepartament.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beDepartament_ButtonClick);
            // 
            // btnSerch
            // 
            this.btnSerch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSerch.Location = new System.Drawing.Point(0, 470);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(194, 28);
            this.btnSerch.TabIndex = 16;
            this.btnSerch.Text = "Найти";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // gbGroup
            // 
            this.gbGroup.Controls.Add(this.beGroup);
            this.gbGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbGroup.Location = new System.Drawing.Point(0, 412);
            this.gbGroup.Name = "gbGroup";
            this.gbGroup.Size = new System.Drawing.Size(194, 58);
            this.gbGroup.TabIndex = 17;
            this.gbGroup.TabStop = false;
            this.gbGroup.Text = "Группа";
            // 
            // beGroup
            // 
            this.beGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beGroup.Location = new System.Drawing.Point(10, 22);
            this.beGroup.Name = "beGroup";
            this.beGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.beGroup.Properties.ReadOnly = true;
            this.beGroup.Properties.UseReadOnlyAppearance = false;
            this.beGroup.Size = new System.Drawing.Size(174, 20);
            this.beGroup.TabIndex = 1;
            this.beGroup.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beGroup_ButtonClick);
            // 
            // DocFilterTWDbView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSerch);
            this.Controls.Add(this.gbGroup);
            this.Controls.Add(this.gbDepartament);
            this.Controls.Add(this.gbManager);
            this.Controls.Add(this.gbCounteragent);
            this.Controls.Add(this.gbDirection);
            this.Controls.Add(this.gbDates);
            this.Name = "DocFilterTWDbView";
            this.Size = new System.Drawing.Size(194, 561);
            this.gbDates.ResumeLayout(false);
            this.gbDates.PerformLayout();
            this.gbDirection.ResumeLayout(false);
            this.gbCounteragent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beCounteragent.Properties)).EndInit();
            this.gbManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beManager.Properties)).EndInit();
            this.gbDepartament.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beDepartament.Properties)).EndInit();
            this.gbGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beGroup.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDates;
        private System.Windows.Forms.Label lbDateFrom;
        private System.Windows.Forms.Label lbDateTo;
        private System.Windows.Forms.GroupBox gbDirection;
        private System.Windows.Forms.RadioButton rbDirectionOutgoing;
        private System.Windows.Forms.RadioButton rbDirectionIncoming;
        private System.Windows.Forms.GroupBox gbCounteragent;
        private System.Windows.Forms.GroupBox gbManager;
        private System.Windows.Forms.GroupBox gbDepartament;
        private System.Windows.Forms.Button btnSerch;
        private DevExpress.XtraEditors.ButtonEdit beCounteragent;
        private DevExpress.XtraEditors.ButtonEdit beManager;
        private DevExpress.XtraEditors.ButtonEdit beDepartament;
        private System.Windows.Forms.CheckBox cbxReturned;
        private System.Windows.Forms.GroupBox gbGroup;
        private DevExpress.XtraEditors.ButtonEdit beGroup;
        public System.Windows.Forms.DateTimePicker dtpFrom;
        public System.Windows.Forms.DateTimePicker dtpTo;
    }
}
