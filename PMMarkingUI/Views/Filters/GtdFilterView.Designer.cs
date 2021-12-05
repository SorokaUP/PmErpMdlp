namespace PMMarkingUI.Views
{
    partial class GtdFilterView
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
            this.label3 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.dateNavigator = new DevExpress.XtraScheduler.DateNavigator();
            this.gbCounteragent = new System.Windows.Forms.GroupBox();
            this.beCounteragent = new DevExpress.XtraEditors.ButtonEdit();
            this.btnSerch = new System.Windows.Forms.Button();
            this.gbDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator.CalendarTimeProperties)).BeginInit();
            this.gbCounteragent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beCounteragent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDates
            // 
            this.gbDates.Controls.Add(this.label3);
            this.gbDates.Controls.Add(this.dtEnd);
            this.gbDates.Controls.Add(this.label2);
            this.gbDates.Controls.Add(this.dtBegin);
            this.gbDates.Controls.Add(this.dateNavigator);
            this.gbDates.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbDates.Location = new System.Drawing.Point(0, 0);
            this.gbDates.Name = "gbDates";
            this.gbDates.Size = new System.Drawing.Size(221, 316);
            this.gbDates.TabIndex = 13;
            this.gbDates.TabStop = false;
            this.gbDates.Text = "Период";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Окончание";
            // 
            // dtEnd
            // 
            this.dtEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(114, 38);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(96, 20);
            this.dtEnd.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Начало";
            // 
            // dtBegin
            // 
            this.dtBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBegin.Location = new System.Drawing.Point(10, 38);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(96, 20);
            this.dtBegin.TabIndex = 17;
            // 
            // dateNavigator
            // 
            this.dateNavigator.AllowAnimatedContentChange = false;
            this.dateNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateNavigator.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dateNavigator.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dateNavigator.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dateNavigator.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNavigator.CaseMonthNames = DevExpress.XtraEditors.Controls.TextCaseMode.UpperCase;
            this.dateNavigator.CaseWeekDayAbbreviations = DevExpress.XtraEditors.Controls.TextCaseMode.SentenceCase;
            this.dateNavigator.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dateNavigator.HighlightTodayCell = DevExpress.Utils.DefaultBoolean.False;
            this.dateNavigator.HighlightTodayCellWhenSelected = false;
            this.dateNavigator.Location = new System.Drawing.Point(10, 64);
            this.dateNavigator.LookAndFeel.SkinName = "VS2010";
            this.dateNavigator.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dateNavigator.Name = "dateNavigator";
            this.dateNavigator.SelectionBehavior = DevExpress.XtraEditors.Controls.CalendarSelectionBehavior.Simple;
            this.dateNavigator.ShowHeader = false;
            this.dateNavigator.ShowWeekNumbers = false;
            this.dateNavigator.Size = new System.Drawing.Size(201, 240);
            this.dateNavigator.TabIndex = 16;
            // 
            // gbCounteragent
            // 
            this.gbCounteragent.Controls.Add(this.beCounteragent);
            this.gbCounteragent.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCounteragent.Location = new System.Drawing.Point(0, 316);
            this.gbCounteragent.Name = "gbCounteragent";
            this.gbCounteragent.Size = new System.Drawing.Size(221, 58);
            this.gbCounteragent.TabIndex = 24;
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
            this.beCounteragent.Size = new System.Drawing.Size(201, 20);
            this.beCounteragent.TabIndex = 0;
            // 
            // btnSerch
            // 
            this.btnSerch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSerch.Location = new System.Drawing.Point(0, 374);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(221, 28);
            this.btnSerch.TabIndex = 25;
            this.btnSerch.Text = "Найти";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // GtdFilterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSerch);
            this.Controls.Add(this.gbCounteragent);
            this.Controls.Add(this.gbDates);
            this.Name = "GtdFilterView";
            this.Size = new System.Drawing.Size(221, 454);
            this.gbDates.ResumeLayout(false);
            this.gbDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator)).EndInit();
            this.gbCounteragent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beCounteragent.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDates;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator;
        public System.Windows.Forms.GroupBox gbCounteragent;
        private DevExpress.XtraEditors.ButtonEdit beCounteragent;
        private System.Windows.Forms.Button btnSerch;
    }
}
