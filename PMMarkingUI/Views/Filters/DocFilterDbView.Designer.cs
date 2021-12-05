namespace PMMarkingUI.Views
{
    partial class DocFilterDbView
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
            this.gbDirection = new System.Windows.Forms.GroupBox();
            this.rbDirectionOutgoing = new System.Windows.Forms.RadioButton();
            this.rbDirectionIncoming = new System.Windows.Forms.RadioButton();
            this.btnSerch = new System.Windows.Forms.Button();
            this.gbDocType = new System.Windows.Forms.GroupBox();
            this.beDocType = new DevExpress.XtraEditors.ButtonEdit();
            this.gbCounteragent = new System.Windows.Forms.GroupBox();
            this.beCounteragent = new DevExpress.XtraEditors.ButtonEdit();
            this.cbeFast = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator.CalendarTimeProperties)).BeginInit();
            this.gbDirection.SuspendLayout();
            this.gbDocType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beDocType.Properties)).BeginInit();
            this.gbCounteragent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beCounteragent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeFast.Properties)).BeginInit();
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
            this.gbDates.Location = new System.Drawing.Point(0, 32);
            this.gbDates.Name = "gbDates";
            this.gbDates.Size = new System.Drawing.Size(221, 316);
            this.gbDates.TabIndex = 12;
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
            this.dtEnd.ValueChanged += new System.EventHandler(this.dtEnd_ValueChanged);
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
            this.dtBegin.ValueChanged += new System.EventHandler(this.dtBegin_ValueChanged);
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
            this.dateNavigator.SelectionChanged += new System.EventHandler(this.dateNavigator_SelectionChanged);
            this.dateNavigator.CustomDrawDayNumberCell += new DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventHandler(this.dateNavigator_CustomDrawDayNumberCell);
            // 
            // gbDirection
            // 
            this.gbDirection.Controls.Add(this.rbDirectionOutgoing);
            this.gbDirection.Controls.Add(this.rbDirectionIncoming);
            this.gbDirection.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDirection.Location = new System.Drawing.Point(0, 348);
            this.gbDirection.Name = "gbDirection";
            this.gbDirection.Size = new System.Drawing.Size(221, 82);
            this.gbDirection.TabIndex = 11;
            this.gbDirection.TabStop = false;
            this.gbDirection.Text = "Направление документа";
            // 
            // rbDirectionOutgoing
            // 
            this.rbDirectionOutgoing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDirectionOutgoing.Location = new System.Drawing.Point(10, 49);
            this.rbDirectionOutgoing.Name = "rbDirectionOutgoing";
            this.rbDirectionOutgoing.Size = new System.Drawing.Size(200, 24);
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
            this.rbDirectionIncoming.Size = new System.Drawing.Size(200, 24);
            this.rbDirectionIncoming.TabIndex = 7;
            this.rbDirectionIncoming.TabStop = true;
            this.rbDirectionIncoming.Text = "Входящие";
            this.rbDirectionIncoming.UseVisualStyleBackColor = true;
            // 
            // btnSerch
            // 
            this.btnSerch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSerch.Location = new System.Drawing.Point(0, 546);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(221, 28);
            this.btnSerch.TabIndex = 16;
            this.btnSerch.Text = "Найти";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // gbDocType
            // 
            this.gbDocType.Controls.Add(this.beDocType);
            this.gbDocType.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDocType.Location = new System.Drawing.Point(0, 488);
            this.gbDocType.Name = "gbDocType";
            this.gbDocType.Size = new System.Drawing.Size(221, 58);
            this.gbDocType.TabIndex = 24;
            this.gbDocType.TabStop = false;
            this.gbDocType.Text = "Тип документа";
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
            this.beDocType.Size = new System.Drawing.Size(201, 20);
            this.beDocType.TabIndex = 0;
            this.beDocType.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.GetRef_DocType);
            // 
            // gbCounteragent
            // 
            this.gbCounteragent.Controls.Add(this.beCounteragent);
            this.gbCounteragent.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCounteragent.Location = new System.Drawing.Point(0, 430);
            this.gbCounteragent.Name = "gbCounteragent";
            this.gbCounteragent.Size = new System.Drawing.Size(221, 58);
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
            this.beCounteragent.Size = new System.Drawing.Size(201, 20);
            this.beCounteragent.TabIndex = 0;
            this.beCounteragent.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.GetRef_Counteragent);
            // 
            // cbeFast
            // 
            this.cbeFast.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbeFast.EditValue = "Быстрый фильтр";
            this.cbeFast.Location = new System.Drawing.Point(0, 0);
            this.cbeFast.Name = "cbeFast";
            this.cbeFast.Properties.Appearance.BackColor = System.Drawing.Color.Khaki;
            this.cbeFast.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbeFast.Properties.Appearance.Options.UseBackColor = true;
            this.cbeFast.Properties.Appearance.Options.UseFont = true;
            this.cbeFast.Properties.Appearance.Options.UseTextOptions = true;
            this.cbeFast.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbeFast.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeFast.Properties.Items.AddRange(new object[] {
            "601 - Приход (Прямой акцепт)",
            "602 - Приход (Обратный акцепт)",
            "431 - Перемещения",
            "912 - Расформирования",
            "613 - Приход (Таможня)"});
            this.cbeFast.Properties.NullText = "Быстрый фильтр";
            this.cbeFast.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeFast.Size = new System.Drawing.Size(221, 22);
            this.cbeFast.TabIndex = 27;
            this.cbeFast.SelectedIndexChanged += new System.EventHandler(this.cbeFast_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 10);
            this.label1.TabIndex = 28;
            // 
            // DocFilterDbView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSerch);
            this.Controls.Add(this.gbDocType);
            this.Controls.Add(this.gbCounteragent);
            this.Controls.Add(this.gbDirection);
            this.Controls.Add(this.gbDates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbeFast);
            this.Name = "DocFilterDbView";
            this.Size = new System.Drawing.Size(221, 655);
            this.gbDates.ResumeLayout(false);
            this.gbDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator)).EndInit();
            this.gbDirection.ResumeLayout(false);
            this.gbDocType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beDocType.Properties)).EndInit();
            this.gbCounteragent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beCounteragent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeFast.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDates;
        private System.Windows.Forms.RadioButton rbDirectionOutgoing;
        private System.Windows.Forms.RadioButton rbDirectionIncoming;
        private System.Windows.Forms.Button btnSerch;
        private DevExpress.XtraEditors.ButtonEdit beDocType;
        private DevExpress.XtraEditors.ButtonEdit beCounteragent;
        public System.Windows.Forms.GroupBox gbDocType;
        public System.Windows.Forms.GroupBox gbCounteragent;
        public System.Windows.Forms.GroupBox gbDirection;
        private DevExpress.XtraEditors.ComboBoxEdit cbeFast;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtBegin;
    }
}
