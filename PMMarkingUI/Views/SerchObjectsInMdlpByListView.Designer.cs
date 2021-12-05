namespace PMMarkingUI.Views
{
    partial class SerchObjectsInMdlpByListView
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleContains formatConditionRuleContains1 = new DevExpress.XtraEditors.FormatConditionRuleContains();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerchObjectsInMdlpByListView));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleContains formatConditionRuleContains2 = new DevExpress.XtraEditors.FormatConditionRuleContains();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleContains formatConditionRuleContains3 = new DevExpress.XtraEditors.FormatConditionRuleContains();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleContains formatConditionRuleContains4 = new DevExpress.XtraEditors.FormatConditionRuleContains();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule5 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleContains formatConditionRuleContains5 = new DevExpress.XtraEditors.FormatConditionRuleContains();
            this.cBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cData = new DevExpress.XtraGrid.GridControl();
            this.vData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cOBJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cSC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cSTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.ricbxIS_NOT_RECEIVER_GENERAL = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.tbSsccList = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPasteFromClipboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricbxIS_NOT_RECEIVER_GENERAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBID
            // 
            this.cBID.Caption = "branch_id";
            this.cBID.FieldName = "BRANCH_ID";
            this.cBID.Name = "cBID";
            this.cBID.Visible = true;
            this.cBID.VisibleIndex = 2;
            this.cBID.Width = 100;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(360, 565);
            this.textBox1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1082, 600);
            this.splitContainer1.SplitterDistance = 360;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPasteFromClipboard);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 35);
            this.panel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 35);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.cData);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Panel1MinSize = 100;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tbSsccList);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(718, 565);
            this.splitContainer2.SplitterDistance = 500;
            this.splitContainer2.TabIndex = 17;
            // 
            // cData
            // 
            this.cData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cData.Location = new System.Drawing.Point(0, 0);
            this.cData.MainView = this.vData;
            this.cData.Name = "cData";
            this.cData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2,
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageComboBox2,
            this.ricbxIS_NOT_RECEIVER_GENERAL,
            this.repositoryItemImageComboBox3});
            this.cData.Size = new System.Drawing.Size(500, 565);
            this.cData.TabIndex = 16;
            this.cData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vData});
            // 
            // vData
            // 
            this.vData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cOBJ,
            this.cSC,
            this.cBID,
            this.cSTA,
            this.cN});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.cBID;
            gridFormatRule1.Name = "FormatRule146887";
            formatConditionRuleContains1.Appearance.BackColor = System.Drawing.Color.Honeydew;
            formatConditionRuleContains1.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            formatConditionRuleContains1.Appearance.Options.UseBackColor = true;
            formatConditionRuleContains1.Appearance.Options.UseForeColor = true;
            formatConditionRuleContains1.Values = ((System.Collections.IList)(resources.GetObject("formatConditionRuleContains1.Values")));
            gridFormatRule1.Rule = formatConditionRuleContains1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Column = this.cBID;
            gridFormatRule2.Name = "FormatRule279052";
            formatConditionRuleContains2.Appearance.BackColor = System.Drawing.Color.Beige;
            formatConditionRuleContains2.Appearance.ForeColor = System.Drawing.Color.SaddleBrown;
            formatConditionRuleContains2.Appearance.Options.UseBackColor = true;
            formatConditionRuleContains2.Appearance.Options.UseForeColor = true;
            formatConditionRuleContains2.Values = ((System.Collections.IList)(resources.GetObject("formatConditionRuleContains2.Values")));
            gridFormatRule2.Rule = formatConditionRuleContains2;
            gridFormatRule3.ApplyToRow = true;
            gridFormatRule3.Column = this.cBID;
            gridFormatRule3.Name = "FormatRuleRed";
            formatConditionRuleContains3.Appearance.BackColor = System.Drawing.Color.MistyRose;
            formatConditionRuleContains3.Appearance.ForeColor = System.Drawing.Color.Maroon;
            formatConditionRuleContains3.Appearance.Options.UseBackColor = true;
            formatConditionRuleContains3.Appearance.Options.UseForeColor = true;
            formatConditionRuleContains3.Values = ((System.Collections.IList)(resources.GetObject("formatConditionRuleContains3.Values")));
            gridFormatRule3.Rule = formatConditionRuleContains3;
            gridFormatRule4.ApplyToRow = true;
            gridFormatRule4.Name = "FormatRuleGrayed";
            formatConditionRuleContains4.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            formatConditionRuleContains4.Appearance.ForeColor = System.Drawing.Color.Gray;
            formatConditionRuleContains4.Appearance.Options.UseBackColor = true;
            formatConditionRuleContains4.Appearance.Options.UseForeColor = true;
            formatConditionRuleContains4.Values = ((System.Collections.IList)(resources.GetObject("formatConditionRuleContains4.Values")));
            gridFormatRule4.Rule = formatConditionRuleContains4;
            gridFormatRule5.ApplyToRow = true;
            gridFormatRule5.Column = this.cBID;
            gridFormatRule5.Name = "FormatRule172389";
            formatConditionRuleContains5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(180)))));
            formatConditionRuleContains5.Appearance.ForeColor = System.Drawing.Color.SaddleBrown;
            formatConditionRuleContains5.Appearance.Options.UseBackColor = true;
            formatConditionRuleContains5.Appearance.Options.UseForeColor = true;
            formatConditionRuleContains5.Values = ((System.Collections.IList)(resources.GetObject("formatConditionRuleContains5.Values")));
            gridFormatRule5.Rule = formatConditionRuleContains5;
            this.vData.FormatRules.Add(gridFormatRule1);
            this.vData.FormatRules.Add(gridFormatRule2);
            this.vData.FormatRules.Add(gridFormatRule3);
            this.vData.FormatRules.Add(gridFormatRule4);
            this.vData.FormatRules.Add(gridFormatRule5);
            this.vData.GridControl = this.cData;
            this.vData.Name = "vData";
            this.vData.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.vData.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.vData.OptionsBehavior.AllowIncrementalSearch = true;
            this.vData.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.vData.OptionsSelection.CheckBoxSelectorColumnWidth = 40;
            this.vData.OptionsSelection.MultiSelect = true;
            this.vData.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.vData.OptionsView.ColumnAutoWidth = false;
            this.vData.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vData.OptionsView.ShowFooter = true;
            this.vData.OptionsView.ShowViewCaption = true;
            this.vData.ViewCaption = "Анализ";
            // 
            // cOBJ
            // 
            this.cOBJ.Caption = "ObjectId";
            this.cOBJ.FieldName = "OBJECT_ID";
            this.cOBJ.Name = "cOBJ";
            this.cOBJ.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "OBJECT_ID", "{0}")});
            this.cOBJ.Visible = true;
            this.cOBJ.VisibleIndex = 0;
            this.cOBJ.Width = 228;
            // 
            // cSC
            // 
            this.cSC.Caption = "SSCC";
            this.cSC.FieldName = "SSCC";
            this.cSC.Name = "cSC";
            this.cSC.Visible = true;
            this.cSC.VisibleIndex = 1;
            this.cSC.Width = 129;
            // 
            // cSTA
            // 
            this.cSTA.Caption = "Статус";
            this.cSTA.FieldName = "STATUS";
            this.cSTA.Name = "cSTA";
            this.cSTA.Visible = true;
            this.cSTA.VisibleIndex = 3;
            this.cSTA.Width = 124;
            // 
            // cN
            // 
            this.cN.Caption = "Наименование";
            this.cN.FieldName = "NAME";
            this.cN.Name = "cN";
            this.cN.Visible = true;
            this.cN.VisibleIndex = 4;
            this.cN.Width = 409;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit2.ValueChecked = 1;
            this.repositoryItemCheckEdit2.ValueUnchecked = 0;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AccessibleDescription = "Статус документа";
            this.repositoryItemImageComboBox1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemImageComboBox1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 2, 0)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Приход", 1, 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Возврат", 2, 4),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Суррогат: ОХ", 3, 9),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Суррогат", 4, 8)});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            this.repositoryItemImageComboBox2.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            // 
            // ricbxIS_NOT_RECEIVER_GENERAL
            // 
            this.ricbxIS_NOT_RECEIVER_GENERAL.AccessibleDescription = "Необходимость сделать перемещение";
            this.ricbxIS_NOT_RECEIVER_GENERAL.AutoHeight = false;
            this.ricbxIS_NOT_RECEIVER_GENERAL.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 5),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 2, 6)});
            this.ricbxIS_NOT_RECEIVER_GENERAL.Name = "ricbxIS_NOT_RECEIVER_GENERAL";
            this.ricbxIS_NOT_RECEIVER_GENERAL.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            // 
            // repositoryItemImageComboBox3
            // 
            this.repositoryItemImageComboBox3.AccessibleDescription = "Наличие вложенных коробок";
            this.repositoryItemImageComboBox3.AutoHeight = false;
            this.repositoryItemImageComboBox3.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 9)});
            this.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3";
            this.repositoryItemImageComboBox3.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            // 
            // tbSsccList
            // 
            this.tbSsccList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSsccList.Location = new System.Drawing.Point(0, 0);
            this.tbSsccList.Multiline = true;
            this.tbSsccList.Name = "tbSsccList";
            this.tbSsccList.ReadOnly = true;
            this.tbSsccList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSsccList.Size = new System.Drawing.Size(214, 565);
            this.tbSsccList.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 35);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPasteFromClipboard
            // 
            this.btnPasteFromClipboard.Location = new System.Drawing.Point(84, 3);
            this.btnPasteFromClipboard.Name = "btnPasteFromClipboard";
            this.btnPasteFromClipboard.Size = new System.Drawing.Size(75, 23);
            this.btnPasteFromClipboard.TabIndex = 1;
            this.btnPasteFromClipboard.Text = "Вставить";
            this.btnPasteFromClipboard.UseVisualStyleBackColor = true;
            this.btnPasteFromClipboard.Click += new System.EventHandler(this.btnPasteFromClipboard_Click);
            // 
            // SerchObjectsInMdlpByListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "SerchObjectsInMdlpByListView";
            this.Size = new System.Drawing.Size(1082, 600);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricbxIS_NOT_RECEIVER_GENERAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraGrid.GridControl cData;
        private DevExpress.XtraGrid.Views.Grid.GridView vData;
        private DevExpress.XtraGrid.Columns.GridColumn cOBJ;
        private DevExpress.XtraGrid.Columns.GridColumn cSC;
        private DevExpress.XtraGrid.Columns.GridColumn cBID;
        private DevExpress.XtraGrid.Columns.GridColumn cSTA;
        private DevExpress.XtraGrid.Columns.GridColumn cN;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox ricbxIS_NOT_RECEIVER_GENERAL;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
        private System.Windows.Forms.TextBox tbSsccList;
        private System.Windows.Forms.Button btnPasteFromClipboard;
    }
}
