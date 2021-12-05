namespace PMMarkingUI.Views
{
    partial class DocFilterDbAgencyContractView
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
            this.btnSerch = new System.Windows.Forms.Button();
            this.gbConcept = new System.Windows.Forms.GroupBox();
            this.beConcept = new DevExpress.XtraEditors.ButtonEdit();
            this.gbCounteragent = new System.Windows.Forms.GroupBox();
            this.beCounteragent = new DevExpress.XtraEditors.ButtonEdit();
            this.gbDates.SuspendLayout();
            this.gbConcept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beConcept.Properties)).BeginInit();
            this.gbCounteragent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beCounteragent.Properties)).BeginInit();
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
            // btnSerch
            // 
            this.btnSerch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSerch.Location = new System.Drawing.Point(0, 238);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(194, 28);
            this.btnSerch.TabIndex = 16;
            this.btnSerch.Text = "Найти";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // gbConcept
            // 
            this.gbConcept.Controls.Add(this.beConcept);
            this.gbConcept.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbConcept.Location = new System.Drawing.Point(0, 180);
            this.gbConcept.Name = "gbConcept";
            this.gbConcept.Size = new System.Drawing.Size(194, 58);
            this.gbConcept.TabIndex = 25;
            this.gbConcept.TabStop = false;
            this.gbConcept.Text = "Концепт";
            this.gbConcept.Visible = false;
            // 
            // beConcept
            // 
            this.beConcept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beConcept.EditValue = "";
            this.beConcept.Location = new System.Drawing.Point(10, 22);
            this.beConcept.Name = "beConcept";
            this.beConcept.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.beConcept.Properties.ReadOnly = true;
            this.beConcept.Properties.UseReadOnlyAppearance = false;
            this.beConcept.Size = new System.Drawing.Size(174, 20);
            this.beConcept.TabIndex = 0;
            this.beConcept.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.GetRef_Concept);
            // 
            // gbCounteragent
            // 
            this.gbCounteragent.Controls.Add(this.beCounteragent);
            this.gbCounteragent.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCounteragent.Location = new System.Drawing.Point(0, 122);
            this.gbCounteragent.Name = "gbCounteragent";
            this.gbCounteragent.Size = new System.Drawing.Size(194, 58);
            this.gbCounteragent.TabIndex = 23;
            this.gbCounteragent.TabStop = false;
            this.gbCounteragent.Text = "Контрагент";
            this.gbCounteragent.Visible = false;
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
            this.beCounteragent.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.GetRef_Counteragent);
            // 
            // DocFilterDbAgencyContractView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSerch);
            this.Controls.Add(this.gbConcept);
            this.Controls.Add(this.gbCounteragent);
            this.Controls.Add(this.gbDates);
            this.Name = "DocFilterDbAgencyContractView";
            this.Size = new System.Drawing.Size(194, 293);
            this.gbDates.ResumeLayout(false);
            this.gbDates.PerformLayout();
            this.gbConcept.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beConcept.Properties)).EndInit();
            this.gbCounteragent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beCounteragent.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDates;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lbDateFrom;
        private System.Windows.Forms.Label lbDateTo;
        private System.Windows.Forms.Button btnSerch;
        private DevExpress.XtraEditors.ButtonEdit beConcept;
        private DevExpress.XtraEditors.ButtonEdit beCounteragent;
        public System.Windows.Forms.GroupBox gbConcept;
        public System.Windows.Forms.GroupBox gbCounteragent;
    }
}
