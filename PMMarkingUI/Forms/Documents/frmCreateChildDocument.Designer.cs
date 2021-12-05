namespace PMMarkingUI.Forms
{
    partial class frmCreateChildDocument
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
            this.gbDocumentOwner = new System.Windows.Forms.GroupBox();
            this.beDocumentOwner = new DevExpress.XtraEditors.ButtonEdit();
            this.gbDocumentType = new System.Windows.Forms.GroupBox();
            this.beDocumentType = new DevExpress.XtraEditors.ButtonEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbCounteragent = new System.Windows.Forms.GroupBox();
            this.beCounteragent = new DevExpress.XtraEditors.ButtonEdit();
            this.gbPeriod = new System.Windows.Forms.GroupBox();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDocumentOwner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beDocumentOwner.Properties)).BeginInit();
            this.gbDocumentType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beDocumentType.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbCounteragent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beCounteragent.Properties)).BeginInit();
            this.gbPeriod.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDocumentOwner
            // 
            this.gbDocumentOwner.Controls.Add(this.beDocumentOwner);
            this.gbDocumentOwner.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDocumentOwner.Location = new System.Drawing.Point(0, 116);
            this.gbDocumentOwner.Name = "gbDocumentOwner";
            this.gbDocumentOwner.Size = new System.Drawing.Size(372, 58);
            this.gbDocumentOwner.TabIndex = 15;
            this.gbDocumentOwner.TabStop = false;
            this.gbDocumentOwner.Text = "Документ родитель";
            // 
            // beDocumentOwner
            // 
            this.beDocumentOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beDocumentOwner.Location = new System.Drawing.Point(10, 22);
            this.beDocumentOwner.Name = "beDocumentOwner";
            this.beDocumentOwner.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.beDocumentOwner.Properties.ReadOnly = true;
            this.beDocumentOwner.Properties.UseReadOnlyAppearance = false;
            this.beDocumentOwner.Size = new System.Drawing.Size(352, 20);
            this.beDocumentOwner.TabIndex = 1;
            this.beDocumentOwner.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beDocumentOwner_ButtonClick);
            this.beDocumentOwner.TextChanged += new System.EventHandler(this.beDocumentOwner_TextChanged);
            // 
            // gbDocumentType
            // 
            this.gbDocumentType.Controls.Add(this.beDocumentType);
            this.gbDocumentType.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDocumentType.Location = new System.Drawing.Point(0, 174);
            this.gbDocumentType.Name = "gbDocumentType";
            this.gbDocumentType.Size = new System.Drawing.Size(372, 58);
            this.gbDocumentType.TabIndex = 16;
            this.gbDocumentType.TabStop = false;
            this.gbDocumentType.Text = "Тип дочернего документа";
            // 
            // beDocumentType
            // 
            this.beDocumentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beDocumentType.Location = new System.Drawing.Point(10, 22);
            this.beDocumentType.Name = "beDocumentType";
            this.beDocumentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.beDocumentType.Properties.ReadOnly = true;
            this.beDocumentType.Properties.UseReadOnlyAppearance = false;
            this.beDocumentType.Size = new System.Drawing.Size(352, 20);
            this.beDocumentType.TabIndex = 1;
            this.beDocumentType.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beDocumentType_ButtonClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnGo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 283);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 38);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // btnGo
            // 
            this.btnGo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGo.Location = new System.Drawing.Point(3, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(170, 32);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Создать";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(199, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbCounteragent
            // 
            this.gbCounteragent.Controls.Add(this.beCounteragent);
            this.gbCounteragent.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCounteragent.Location = new System.Drawing.Point(0, 0);
            this.gbCounteragent.Name = "gbCounteragent";
            this.gbCounteragent.Size = new System.Drawing.Size(372, 58);
            this.gbCounteragent.TabIndex = 18;
            this.gbCounteragent.TabStop = false;
            this.gbCounteragent.Text = "Контрагент";
            // 
            // beCounteragent
            // 
            this.beCounteragent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beCounteragent.Location = new System.Drawing.Point(10, 22);
            this.beCounteragent.Name = "beCounteragent";
            this.beCounteragent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.beCounteragent.Properties.ReadOnly = true;
            this.beCounteragent.Properties.UseReadOnlyAppearance = false;
            this.beCounteragent.Size = new System.Drawing.Size(352, 20);
            this.beCounteragent.TabIndex = 1;
            this.beCounteragent.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beCounteragent_ButtonClick);
            // 
            // gbPeriod
            // 
            this.gbPeriod.Controls.Add(this.dtpDateFrom);
            this.gbPeriod.Controls.Add(this.dtpDateTo);
            this.gbPeriod.Controls.Add(this.label1);
            this.gbPeriod.Controls.Add(this.label2);
            this.gbPeriod.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPeriod.Location = new System.Drawing.Point(0, 58);
            this.gbPeriod.Name = "gbPeriod";
            this.gbPeriod.Size = new System.Drawing.Size(372, 58);
            this.gbPeriod.TabIndex = 19;
            this.gbPeriod.TabStop = false;
            this.gbPeriod.Text = "Период поиска родительского документа";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Checked = false;
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(10, 32);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(173, 20);
            this.dtpDateFrom.TabIndex = 4;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateTo.Checked = false;
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(189, 32);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(173, 20);
            this.dtpDateTo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Начало периода";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Окончание периода";
            // 
            // frmCreateChildDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 321);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gbDocumentType);
            this.Controls.Add(this.gbDocumentOwner);
            this.Controls.Add(this.gbPeriod);
            this.Controls.Add(this.gbCounteragent);
            this.Name = "frmCreateChildDocument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание дочернего документа";
            this.gbDocumentOwner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beDocumentOwner.Properties)).EndInit();
            this.gbDocumentType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beDocumentType.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbCounteragent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beCounteragent.Properties)).EndInit();
            this.gbPeriod.ResumeLayout(false);
            this.gbPeriod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDocumentOwner;
        private DevExpress.XtraEditors.ButtonEdit beDocumentOwner;
        private System.Windows.Forms.GroupBox gbDocumentType;
        private DevExpress.XtraEditors.ButtonEdit beDocumentType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbCounteragent;
        private DevExpress.XtraEditors.ButtonEdit beCounteragent;
        private System.Windows.Forms.GroupBox gbPeriod;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}