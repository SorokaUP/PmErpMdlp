namespace PMMarkingUI.Views.Documents
{
    partial class BadSsccView
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule6 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleContains formatConditionRuleContains6 = new DevExpress.XtraEditors.FormatConditionRuleContains();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BadSsccView));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule7 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleContains formatConditionRuleContains7 = new DevExpress.XtraEditors.FormatConditionRuleContains();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule8 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleContains formatConditionRuleContains8 = new DevExpress.XtraEditors.FormatConditionRuleContains();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule9 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleContains formatConditionRuleContains9 = new DevExpress.XtraEditors.FormatConditionRuleContains();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule10 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleContains formatConditionRuleContains10 = new DevExpress.XtraEditors.FormatConditionRuleContains();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiActions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_220 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.cUnion = new DevExpress.XtraGrid.GridControl();
            this.vUnion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.ricbxIS_NOT_RECEIVER_GENERAL = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.выделениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.снятьВыделениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vUnion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricbxIS_NOT_RECEIVER_GENERAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiActions,
            this.tsmiRefresh,
            this.выделениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(720, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiActions
            // 
            this.tsmiActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAction_220});
            this.tsmiActions.Name = "tsmiActions";
            this.tsmiActions.Size = new System.Drawing.Size(70, 20);
            this.tsmiActions.Text = "Действия";
            // 
            // tsmiAction_220
            // 
            this.tsmiAction_220.Name = "tsmiAction_220";
            this.tsmiAction_220.Size = new System.Drawing.Size(238, 22);
            this.tsmiAction_220.Text = "Запрос информации по SSCC";
            this.tsmiAction_220.Click += new System.EventHandler(this.tsmiAction_220_Click);
            // 
            // tsmiRefresh
            // 
            this.tsmiRefresh.Name = "tsmiRefresh";
            this.tsmiRefresh.Size = new System.Drawing.Size(115, 20);
            this.tsmiRefresh.Text = "Обновить список";
            this.tsmiRefresh.Click += new System.EventHandler(this.tsmiRefresh_Click);
            // 
            // cUnion
            // 
            this.cUnion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cUnion.Location = new System.Drawing.Point(0, 24);
            this.cUnion.MainView = this.vUnion;
            this.cUnion.Name = "cUnion";
            this.cUnion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2,
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageComboBox2,
            this.ricbxIS_NOT_RECEIVER_GENERAL,
            this.repositoryItemImageComboBox3});
            this.cUnion.Size = new System.Drawing.Size(720, 456);
            this.cUnion.TabIndex = 15;
            this.cUnion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vUnion});
            // 
            // vUnion
            // 
            this.vUnion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn7,
            this.gridColumn3,
            this.gridColumn5});
            gridFormatRule6.ApplyToRow = true;
            gridFormatRule6.Name = "FormatRuleGreen";
            formatConditionRuleContains6.Appearance.BackColor = System.Drawing.Color.Honeydew;
            formatConditionRuleContains6.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            formatConditionRuleContains6.Appearance.Options.UseBackColor = true;
            formatConditionRuleContains6.Appearance.Options.UseForeColor = true;
            formatConditionRuleContains6.Values = ((System.Collections.IList)(resources.GetObject("formatConditionRuleContains6.Values")));
            gridFormatRule6.Rule = formatConditionRuleContains6;
            gridFormatRule7.ApplyToRow = true;
            gridFormatRule7.Name = "FormatRuleSand";
            formatConditionRuleContains7.Appearance.BackColor = System.Drawing.Color.Beige;
            formatConditionRuleContains7.Appearance.ForeColor = System.Drawing.Color.SaddleBrown;
            formatConditionRuleContains7.Appearance.Options.UseBackColor = true;
            formatConditionRuleContains7.Appearance.Options.UseForeColor = true;
            formatConditionRuleContains7.Values = ((System.Collections.IList)(resources.GetObject("formatConditionRuleContains7.Values")));
            gridFormatRule7.Rule = formatConditionRuleContains7;
            gridFormatRule8.ApplyToRow = true;
            gridFormatRule8.Name = "FormatRuleRed";
            formatConditionRuleContains8.Appearance.BackColor = System.Drawing.Color.MistyRose;
            formatConditionRuleContains8.Appearance.ForeColor = System.Drawing.Color.Maroon;
            formatConditionRuleContains8.Appearance.Options.UseBackColor = true;
            formatConditionRuleContains8.Appearance.Options.UseForeColor = true;
            formatConditionRuleContains8.Values = ((System.Collections.IList)(resources.GetObject("formatConditionRuleContains8.Values")));
            gridFormatRule8.Rule = formatConditionRuleContains8;
            gridFormatRule9.ApplyToRow = true;
            gridFormatRule9.Name = "FormatRuleGrayed";
            formatConditionRuleContains9.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            formatConditionRuleContains9.Appearance.ForeColor = System.Drawing.Color.Gray;
            formatConditionRuleContains9.Appearance.Options.UseBackColor = true;
            formatConditionRuleContains9.Appearance.Options.UseForeColor = true;
            formatConditionRuleContains9.Values = ((System.Collections.IList)(resources.GetObject("formatConditionRuleContains9.Values")));
            gridFormatRule9.Rule = formatConditionRuleContains9;
            gridFormatRule10.Name = "FormatRuleSandGreen";
            formatConditionRuleContains10.Appearance.BackColor = System.Drawing.Color.LemonChiffon;
            formatConditionRuleContains10.Appearance.BackColor2 = System.Drawing.Color.Honeydew;
            formatConditionRuleContains10.Appearance.ForeColor = System.Drawing.Color.SaddleBrown;
            formatConditionRuleContains10.Appearance.Options.UseBackColor = true;
            formatConditionRuleContains10.Appearance.Options.UseForeColor = true;
            formatConditionRuleContains10.Values = ((System.Collections.IList)(resources.GetObject("formatConditionRuleContains10.Values")));
            gridFormatRule10.Rule = formatConditionRuleContains10;
            this.vUnion.FormatRules.Add(gridFormatRule6);
            this.vUnion.FormatRules.Add(gridFormatRule7);
            this.vUnion.FormatRules.Add(gridFormatRule8);
            this.vUnion.FormatRules.Add(gridFormatRule9);
            this.vUnion.FormatRules.Add(gridFormatRule10);
            this.vUnion.GridControl = this.cUnion;
            this.vUnion.GroupCount = 2;
            this.vUnion.Name = "vUnion";
            this.vUnion.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.vUnion.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.vUnion.OptionsBehavior.AllowIncrementalSearch = true;
            this.vUnion.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.vUnion.OptionsView.ColumnAutoWidth = false;
            this.vUnion.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vUnion.OptionsView.ShowFooter = true;
            this.vUnion.OptionsView.ShowViewCaption = true;
            this.vUnion.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn7, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.vUnion.ViewCaption = "Коробки без информации";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "✔";
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEdit2;
            this.gridColumn1.FieldName = "HANDLE_SELECT";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HANDLE_SELECT", "{0}")});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 62;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit2.ValueChecked = 1;
            this.repositoryItemCheckEdit2.ValueUnchecked = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "DOC_ID";
            this.gridColumn2.FieldName = "DOC_ID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID", "{0}")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 81;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Номер документа";
            this.gridColumn4.FieldName = "DOC_NUM";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 143;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Дата документа";
            this.gridColumn7.FieldName = "DOC_DATE";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 100;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "SSCC";
            this.gridColumn3.FieldName = "SSCC";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 214;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "BOX_SSCC";
            this.gridColumn5.FieldName = "BOX_SSCC";
            this.gridColumn5.Name = "gridColumn5";
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
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Возврат", 2, 4)});
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
            // выделениеToolStripMenuItem
            // 
            this.выделениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выделитьВсеToolStripMenuItem,
            this.снятьВыделениеToolStripMenuItem});
            this.выделениеToolStripMenuItem.Name = "выделениеToolStripMenuItem";
            this.выделениеToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.выделениеToolStripMenuItem.Text = "Выделение";
            // 
            // выделитьВсеToolStripMenuItem
            // 
            this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выделитьВсеToolStripMenuItem.Text = "Выделить все";
            this.выделитьВсеToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem_Click);
            // 
            // снятьВыделениеToolStripMenuItem
            // 
            this.снятьВыделениеToolStripMenuItem.Name = "снятьВыделениеToolStripMenuItem";
            this.снятьВыделениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.снятьВыделениеToolStripMenuItem.Text = "Снять выделение";
            this.снятьВыделениеToolStripMenuItem.Click += new System.EventHandler(this.снятьВыделениеToolStripMenuItem_Click);
            // 
            // BadSsccView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cUnion);
            this.Controls.Add(this.menuStrip1);
            this.Name = "BadSsccView";
            this.Size = new System.Drawing.Size(720, 480);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vUnion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricbxIS_NOT_RECEIVER_GENERAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiActions;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_220;
        private DevExpress.XtraGrid.GridControl cUnion;
        private DevExpress.XtraGrid.Views.Grid.GridView vUnion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox ricbxIS_NOT_RECEIVER_GENERAL;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefresh;
        private System.Windows.Forms.ToolStripMenuItem выделениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem снятьВыделениеToolStripMenuItem;
    }
}
