namespace PMMarkingUI.Views
{
    partial class DocFilterMdlpView
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
            this.beDocType = new DevExpress.XtraEditors.ButtonEdit();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lbDateFrom = new System.Windows.Forms.Label();
            this.lbDateTo = new System.Windows.Forms.Label();
            this.gbDocType = new System.Windows.Forms.GroupBox();
            this.gbDates = new System.Windows.Forms.GroupBox();
            this.gbDocStatus = new System.Windows.Forms.GroupBox();
            this.beDocStatus = new DevExpress.XtraEditors.ButtonEdit();
            this.gbUploadType = new System.Windows.Forms.GroupBox();
            this.beUploadType = new DevExpress.XtraEditors.ButtonEdit();
            this.gbProcessedDate = new System.Windows.Forms.GroupBox();
            this.dtpProcessedDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpProcessedDateTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbReceiverId = new System.Windows.Forms.GroupBox();
            this.beReceiverId = new DevExpress.XtraEditors.ButtonEdit();
            this.gbSenderId = new System.Windows.Forms.GroupBox();
            this.beSenderId = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.beDocType.Properties)).BeginInit();
            this.gbDocType.SuspendLayout();
            this.gbDates.SuspendLayout();
            this.gbDocStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beDocStatus.Properties)).BeginInit();
            this.gbUploadType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beUploadType.Properties)).BeginInit();
            this.gbProcessedDate.SuspendLayout();
            this.gbReceiverId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beReceiverId.Properties)).BeginInit();
            this.gbSenderId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beSenderId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // beDocType
            // 
            this.beDocType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beDocType.EditValue = "";
            this.beDocType.Location = new System.Drawing.Point(10, 22);
            this.beDocType.Name = "beDocType";
            this.beDocType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.beDocType.Properties.ReadOnly = true;
            this.beDocType.Properties.UseReadOnlyAppearance = false;
            this.beDocType.Size = new System.Drawing.Size(174, 20);
            this.beDocType.TabIndex = 0;
            this.beDocType.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.GetRef_DocType);
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
            // gbDocType
            // 
            this.gbDocType.Controls.Add(this.beDocType);
            this.gbDocType.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDocType.Location = new System.Drawing.Point(0, 122);
            this.gbDocType.Name = "gbDocType";
            this.gbDocType.Size = new System.Drawing.Size(194, 58);
            this.gbDocType.TabIndex = 20;
            this.gbDocType.TabStop = false;
            this.gbDocType.Text = "Тип документа";
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
            this.gbDates.TabIndex = 19;
            this.gbDates.TabStop = false;
            this.gbDates.Text = "Период";
            // 
            // gbDocStatus
            // 
            this.gbDocStatus.Controls.Add(this.beDocStatus);
            this.gbDocStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDocStatus.Location = new System.Drawing.Point(0, 180);
            this.gbDocStatus.Name = "gbDocStatus";
            this.gbDocStatus.Size = new System.Drawing.Size(194, 58);
            this.gbDocStatus.TabIndex = 25;
            this.gbDocStatus.TabStop = false;
            this.gbDocStatus.Text = "Статус документа";
            // 
            // beDocStatus
            // 
            this.beDocStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beDocStatus.EditValue = "";
            this.beDocStatus.Location = new System.Drawing.Point(10, 22);
            this.beDocStatus.Name = "beDocStatus";
            this.beDocStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.beDocStatus.Properties.ReadOnly = true;
            this.beDocStatus.Properties.UseReadOnlyAppearance = false;
            this.beDocStatus.Size = new System.Drawing.Size(174, 20);
            this.beDocStatus.TabIndex = 0;
            this.beDocStatus.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.GetRef_DocStatus);
            // 
            // gbUploadType
            // 
            this.gbUploadType.Controls.Add(this.beUploadType);
            this.gbUploadType.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbUploadType.Location = new System.Drawing.Point(0, 238);
            this.gbUploadType.Name = "gbUploadType";
            this.gbUploadType.Size = new System.Drawing.Size(194, 58);
            this.gbUploadType.TabIndex = 26;
            this.gbUploadType.TabStop = false;
            this.gbUploadType.Text = "Тип загрузки";
            // 
            // beUploadType
            // 
            this.beUploadType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beUploadType.EditValue = "";
            this.beUploadType.Location = new System.Drawing.Point(10, 22);
            this.beUploadType.Name = "beUploadType";
            this.beUploadType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.beUploadType.Properties.ReadOnly = true;
            this.beUploadType.Properties.UseReadOnlyAppearance = false;
            this.beUploadType.Size = new System.Drawing.Size(174, 20);
            this.beUploadType.TabIndex = 0;
            this.beUploadType.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.GetRef_UploadType);
            // 
            // gbProcessedDate
            // 
            this.gbProcessedDate.Controls.Add(this.dtpProcessedDateFrom);
            this.gbProcessedDate.Controls.Add(this.dtpProcessedDateTo);
            this.gbProcessedDate.Controls.Add(this.label1);
            this.gbProcessedDate.Controls.Add(this.label2);
            this.gbProcessedDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbProcessedDate.Location = new System.Drawing.Point(0, 296);
            this.gbProcessedDate.Name = "gbProcessedDate";
            this.gbProcessedDate.Size = new System.Drawing.Size(194, 122);
            this.gbProcessedDate.TabIndex = 27;
            this.gbProcessedDate.TabStop = false;
            this.gbProcessedDate.Text = "Период обработки";
            // 
            // dtpProcessedDateFrom
            // 
            this.dtpProcessedDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpProcessedDateFrom.Checked = false;
            this.dtpProcessedDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProcessedDateFrom.Location = new System.Drawing.Point(11, 40);
            this.dtpProcessedDateFrom.Name = "dtpProcessedDateFrom";
            this.dtpProcessedDateFrom.ShowCheckBox = true;
            this.dtpProcessedDateFrom.Size = new System.Drawing.Size(173, 20);
            this.dtpProcessedDateFrom.TabIndex = 0;
            // 
            // dtpProcessedDateTo
            // 
            this.dtpProcessedDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpProcessedDateTo.Checked = false;
            this.dtpProcessedDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProcessedDateTo.Location = new System.Drawing.Point(11, 86);
            this.dtpProcessedDateTo.Name = "dtpProcessedDateTo";
            this.dtpProcessedDateTo.ShowCheckBox = true;
            this.dtpProcessedDateTo.Size = new System.Drawing.Size(173, 20);
            this.dtpProcessedDateTo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Начало периода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Окончание периода";
            // 
            // gbReceiverId
            // 
            this.gbReceiverId.Controls.Add(this.beReceiverId);
            this.gbReceiverId.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbReceiverId.Location = new System.Drawing.Point(0, 476);
            this.gbReceiverId.Name = "gbReceiverId";
            this.gbReceiverId.Size = new System.Drawing.Size(194, 58);
            this.gbReceiverId.TabIndex = 28;
            this.gbReceiverId.TabStop = false;
            this.gbReceiverId.Text = "Получатель";
            // 
            // beReceiverId
            // 
            this.beReceiverId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beReceiverId.EditValue = "";
            this.beReceiverId.Location = new System.Drawing.Point(10, 22);
            this.beReceiverId.Name = "beReceiverId";
            this.beReceiverId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.beReceiverId.Properties.ReadOnly = true;
            this.beReceiverId.Properties.UseReadOnlyAppearance = false;
            this.beReceiverId.Size = new System.Drawing.Size(174, 20);
            this.beReceiverId.TabIndex = 0;
            this.beReceiverId.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.GetRef_ReceiverId);
            // 
            // gbSenderId
            // 
            this.gbSenderId.Controls.Add(this.beSenderId);
            this.gbSenderId.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSenderId.Location = new System.Drawing.Point(0, 418);
            this.gbSenderId.Name = "gbSenderId";
            this.gbSenderId.Size = new System.Drawing.Size(194, 58);
            this.gbSenderId.TabIndex = 29;
            this.gbSenderId.TabStop = false;
            this.gbSenderId.Text = "Отправитель";
            // 
            // beSenderId
            // 
            this.beSenderId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beSenderId.EditValue = "";
            this.beSenderId.Location = new System.Drawing.Point(10, 22);
            this.beSenderId.Name = "beSenderId";
            this.beSenderId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.beSenderId.Properties.ReadOnly = true;
            this.beSenderId.Properties.UseReadOnlyAppearance = false;
            this.beSenderId.Size = new System.Drawing.Size(174, 20);
            this.beSenderId.TabIndex = 0;
            // 
            // DocFilterMdlpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbReceiverId);
            this.Controls.Add(this.gbSenderId);
            this.Controls.Add(this.gbProcessedDate);
            this.Controls.Add(this.gbUploadType);
            this.Controls.Add(this.gbDocStatus);
            this.Controls.Add(this.gbDocType);
            this.Controls.Add(this.gbDates);
            this.Name = "DocFilterMdlpView";
            this.Size = new System.Drawing.Size(194, 552);
            ((System.ComponentModel.ISupportInitialize)(this.beDocType.Properties)).EndInit();
            this.gbDocType.ResumeLayout(false);
            this.gbDates.ResumeLayout(false);
            this.gbDates.PerformLayout();
            this.gbDocStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beDocStatus.Properties)).EndInit();
            this.gbUploadType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beUploadType.Properties)).EndInit();
            this.gbProcessedDate.ResumeLayout(false);
            this.gbProcessedDate.PerformLayout();
            this.gbReceiverId.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beReceiverId.Properties)).EndInit();
            this.gbSenderId.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beSenderId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.ButtonEdit beDocType;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lbDateFrom;
        private System.Windows.Forms.Label lbDateTo;
        private System.Windows.Forms.GroupBox gbDocType;
        private System.Windows.Forms.GroupBox gbDates;
        private System.Windows.Forms.GroupBox gbDocStatus;
        private DevExpress.XtraEditors.ButtonEdit beDocStatus;
        private System.Windows.Forms.GroupBox gbUploadType;
        private DevExpress.XtraEditors.ButtonEdit beUploadType;
        private System.Windows.Forms.GroupBox gbProcessedDate;
        private System.Windows.Forms.DateTimePicker dtpProcessedDateFrom;
        private System.Windows.Forms.DateTimePicker dtpProcessedDateTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbReceiverId;
        private DevExpress.XtraEditors.ButtonEdit beReceiverId;
        private System.Windows.Forms.GroupBox gbSenderId;
        private DevExpress.XtraEditors.ButtonEdit beSenderId;
    }
}
