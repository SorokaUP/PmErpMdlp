namespace PMMarkingUI.Forms
{
    partial class frmSerchByObjectList
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.gcOBJECT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cData = new DevExpress.XtraGrid.GridControl();
            this.vData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riCheckBox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.riCalc = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.msData = new System.Windows.Forms.MenuStrip();
            this.tsmiActionData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActionData_LoadFromExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiActionData_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiActionData_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActionData_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCalc)).BeginInit();
            this.msData.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcOBJECT_ID
            // 
            this.gcOBJECT_ID.Caption = "Код SSCC/SGTIN";
            this.gcOBJECT_ID.FieldName = "OBJECT_ID";
            this.gcOBJECT_ID.Name = "gcOBJECT_ID";
            this.gcOBJECT_ID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "OBJECT_ID", "{0}")});
            this.gcOBJECT_ID.Visible = true;
            this.gcOBJECT_ID.VisibleIndex = 1;
            this.gcOBJECT_ID.Width = 261;
            // 
            // cData
            // 
            this.cData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cData.Location = new System.Drawing.Point(0, 24);
            this.cData.MainView = this.vData;
            this.cData.Name = "cData";
            this.cData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riCheckBox,
            this.riCalc});
            this.cData.Size = new System.Drawing.Size(488, 387);
            this.cData.TabIndex = 6;
            this.cData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vData});
            // 
            // vData
            // 
            this.vData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcHS,
            this.gcOBJECT_ID});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.gcOBJECT_ID;
            gridFormatRule1.Name = "FormatRed";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            formatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression1.Expression = "Len([OBJECT_ID]) > 1 And Len([OBJECT_ID]) <> 18 And Len([OBJECT_ID]) <> 27";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.vData.FormatRules.Add(gridFormatRule1);
            this.vData.GridControl = this.cData;
            this.vData.Name = "vData";
            this.vData.OptionsBehavior.AllowIncrementalSearch = true;
            this.vData.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.vData.OptionsView.ColumnAutoWidth = false;
            this.vData.OptionsView.ShowFooter = true;
            this.vData.OptionsView.ShowGroupPanel = false;
            this.vData.OptionsView.ShowViewCaption = true;
            this.vData.ViewCaption = "Список объектов поиска";
            // 
            // gcHS
            // 
            this.gcHS.AppearanceHeader.Options.UseTextOptions = true;
            this.gcHS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcHS.Caption = "✔";
            this.gcHS.ColumnEdit = this.riCheckBox;
            this.gcHS.FieldName = "HANDLE_SELECT";
            this.gcHS.Name = "gcHS";
            this.gcHS.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gcHS.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HANDLE_SELECT", "{0}")});
            this.gcHS.Visible = true;
            this.gcHS.VisibleIndex = 0;
            this.gcHS.Width = 62;
            // 
            // riCheckBox
            // 
            this.riCheckBox.AutoHeight = false;
            this.riCheckBox.Name = "riCheckBox";
            this.riCheckBox.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.riCheckBox.ValueChecked = 1;
            this.riCheckBox.ValueUnchecked = 0;
            // 
            // riCalc
            // 
            this.riCalc.AutoHeight = false;
            this.riCalc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riCalc.Name = "riCalc";
            // 
            // msData
            // 
            this.msData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiActionData,
            this.tsmiActionData_Add});
            this.msData.Location = new System.Drawing.Point(0, 0);
            this.msData.Name = "msData";
            this.msData.Size = new System.Drawing.Size(488, 24);
            this.msData.TabIndex = 7;
            this.msData.Text = "menuStrip1";
            // 
            // tsmiActionData
            // 
            this.tsmiActionData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiActionData_LoadFromExcel,
            this.toolStripMenuItem1,
            this.tsmiActionData_Del,
            this.toolStripMenuItem2,
            this.tsmiActionData_Clear});
            this.tsmiActionData.Image = global::PMMarkingUI.Properties.Resources.action;
            this.tsmiActionData.Name = "tsmiActionData";
            this.tsmiActionData.Size = new System.Drawing.Size(86, 20);
            this.tsmiActionData.Text = "Действия";
            // 
            // tsmiActionData_LoadFromExcel
            // 
            this.tsmiActionData_LoadFromExcel.Image = global::PMMarkingUI.Properties.Resources.icon_file2;
            this.tsmiActionData_LoadFromExcel.Name = "tsmiActionData_LoadFromExcel";
            this.tsmiActionData_LoadFromExcel.Size = new System.Drawing.Size(162, 22);
            this.tsmiActionData_LoadFromExcel.Text = "Импорт из Excel";
            this.tsmiActionData_LoadFromExcel.Click += new System.EventHandler(this.tsmiActionData_LoadFromExcel_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 6);
            // 
            // tsmiActionData_Del
            // 
            this.tsmiActionData_Del.Image = global::PMMarkingUI.Properties.Resources.icon_cancel_color;
            this.tsmiActionData_Del.Name = "tsmiActionData_Del";
            this.tsmiActionData_Del.Size = new System.Drawing.Size(162, 22);
            this.tsmiActionData_Del.Text = "Удалить";
            this.tsmiActionData_Del.Click += new System.EventHandler(this.tsmiActionData_Del_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(159, 6);
            // 
            // tsmiActionData_Clear
            // 
            this.tsmiActionData_Clear.Image = global::PMMarkingUI.Properties.Resources.icon_delete;
            this.tsmiActionData_Clear.Name = "tsmiActionData_Clear";
            this.tsmiActionData_Clear.Size = new System.Drawing.Size(162, 22);
            this.tsmiActionData_Clear.Text = "Очистить все";
            this.tsmiActionData_Clear.Click += new System.EventHandler(this.tsmiActionData_Clear_Click);
            // 
            // tsmiActionData_Add
            // 
            this.tsmiActionData_Add.Image = global::PMMarkingUI.Properties.Resources.icon_add;
            this.tsmiActionData_Add.Name = "tsmiActionData_Add";
            this.tsmiActionData_Add.Size = new System.Drawing.Size(87, 20);
            this.tsmiActionData_Add.Text = "Добавить";
            this.tsmiActionData_Add.Click += new System.EventHandler(this.tsmiActionData_Add_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnGo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 411);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 39);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnGo
            // 
            this.btnGo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGo.Location = new System.Drawing.Point(3, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(228, 33);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Найти";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(257, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(228, 33);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSerchByObjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.cData);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.msData);
            this.Name = "frmSerchByObjectList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск по списку объектов";
            ((System.ComponentModel.ISupportInitialize)(this.cData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCheckBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCalc)).EndInit();
            this.msData.ResumeLayout(false);
            this.msData.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl cData;
        private DevExpress.XtraGrid.Views.Grid.GridView vData;
        private DevExpress.XtraGrid.Columns.GridColumn gcHS;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riCheckBox;
        private DevExpress.XtraGrid.Columns.GridColumn gcOBJECT_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit riCalc;
        private System.Windows.Forms.MenuStrip msData;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionData;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionData_LoadFromExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionData_Del;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionData_Clear;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionData_Add;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnClose;
    }
}