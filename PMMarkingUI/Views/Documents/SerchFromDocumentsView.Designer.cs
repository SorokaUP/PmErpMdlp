namespace PMMarkingUI.Views
{
    partial class SerchFromDocumentsView
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
            this.components = new System.ComponentModel.Container();
            this.tlData = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn10 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn8 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn9 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.beDocType = new DevExpress.XtraEditors.ButtonEdit();
            this.cbxIsSerchInDocBody = new System.Windows.Forms.CheckBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.btnSerch = new System.Windows.Forms.Button();
            this.cbxIsRegister = new System.Windows.Forms.CheckBox();
            this.Scaner = new System.IO.Ports.SerialPort(this.components);
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.сканерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиСканераШтрихкодовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beDocType.Properties)).BeginInit();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlData
            // 
            this.tlData.Caption = "Результаты поиска по документам";
            this.tlData.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn10,
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn6,
            this.treeListColumn7,
            this.treeListColumn3,
            this.treeListColumn4,
            this.treeListColumn5,
            this.treeListColumn8,
            this.treeListColumn9});
            this.tlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlData.KeyFieldName = "DOC_ID";
            this.tlData.Location = new System.Drawing.Point(0, 101);
            this.tlData.Name = "tlData";
            this.tlData.BeginUnboundLoad();
            this.tlData.AppendNode(new object[] {
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            null,
            null}, -1);
            this.tlData.EndUnboundLoad();
            this.tlData.OptionsBehavior.EditorShowMode = DevExpress.XtraTreeList.TreeListEditorShowMode.MouseDownFocused;
            this.tlData.OptionsBehavior.PopulateServiceColumns = true;
            this.tlData.OptionsBehavior.ReadOnly = true;
            this.tlData.OptionsView.AutoWidth = false;
            this.tlData.OptionsView.BestFitMode = DevExpress.XtraTreeList.TreeListBestFitMode.Full;
            this.tlData.OptionsView.ShowCaption = true;
            this.tlData.ParentFieldName = "DOC_PARENT";
            this.tlData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.tlData.Size = new System.Drawing.Size(1024, 667);
            this.tlData.TabIndex = 13;
            this.tlData.RowCellClick += new DevExpress.XtraTreeList.RowCellClickEventHandler(this.tlData_RowCellClick);
            // 
            // treeListColumn10
            // 
            this.treeListColumn10.Caption = "DOC_PARENT";
            this.treeListColumn10.FieldName = "DOC_PARENT";
            this.treeListColumn10.Name = "treeListColumn10";
            this.treeListColumn10.Width = 162;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "ID";
            this.treeListColumn1.FieldName = "DOC_ID";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 104;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Тип документа";
            this.treeListColumn2.FieldName = "DOC_TYPE";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 97;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "Дата документа";
            this.treeListColumn6.FieldName = "DOC_DATE";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 2;
            this.treeListColumn6.Width = 105;
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "Статус документа";
            this.treeListColumn7.FieldName = "DOC_STATUS";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.Visible = true;
            this.treeListColumn7.VisibleIndex = 3;
            this.treeListColumn7.Width = 115;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Контрагент";
            this.treeListColumn3.FieldName = "DOC_SENDER_NAME";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 4;
            this.treeListColumn3.Width = 210;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Адрес контрагента";
            this.treeListColumn4.FieldName = "DOC_SENDER_ADDRESS";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 5;
            this.treeListColumn4.Width = 208;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Адрес склада";
            this.treeListColumn5.FieldName = "DOC_RECEIVER_ADDRESS";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 6;
            this.treeListColumn5.Width = 207;
            // 
            // treeListColumn8
            // 
            this.treeListColumn8.Caption = "OBJECT_ID";
            this.treeListColumn8.FieldName = "OBJECT_ID";
            this.treeListColumn8.Name = "treeListColumn8";
            this.treeListColumn8.Width = 206;
            // 
            // treeListColumn9
            // 
            this.treeListColumn9.Caption = "OBJECT_STATUS";
            this.treeListColumn9.FieldName = "OBJECT_STATUS";
            this.treeListColumn9.Name = "treeListColumn9";
            this.treeListColumn9.Width = 205;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.Controls.Add(this.beDocType, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbxIsSerchInDocBody, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbValue, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSerch, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxIsRegister, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 77);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // beDocType
            // 
            this.beDocType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beDocType.EditValue = "";
            this.beDocType.Location = new System.Drawing.Point(203, 55);
            this.beDocType.Name = "beDocType";
            this.beDocType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.beDocType.Properties.ReadOnly = true;
            this.beDocType.Properties.UseReadOnlyAppearance = false;
            this.beDocType.Size = new System.Drawing.Size(353, 20);
            this.beDocType.TabIndex = 20;
            this.beDocType.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beDocType_ButtonClick);
            // 
            // cbxIsSerchInDocBody
            // 
            this.cbxIsSerchInDocBody.AutoSize = true;
            this.cbxIsSerchInDocBody.Location = new System.Drawing.Point(210, 30);
            this.cbxIsSerchInDocBody.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbxIsSerchInDocBody.Name = "cbxIsSerchInDocBody";
            this.cbxIsSerchInDocBody.Size = new System.Drawing.Size(210, 17);
            this.cbxIsSerchInDocBody.TabIndex = 19;
            this.cbxIsSerchInDocBody.Text = "Поиск по содержимому документов";
            this.cbxIsSerchInDocBody.UseVisualStyleBackColor = true;
            // 
            // tbValue
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbValue, 3);
            this.tbValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbValue.Location = new System.Drawing.Point(0, 0);
            this.tbValue.Margin = new System.Windows.Forms.Padding(0);
            this.tbValue.MaxLength = 27;
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(918, 26);
            this.tbValue.TabIndex = 16;
            this.tbValue.WordWrap = false;
            this.tbValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbValue_KeyDown);
            // 
            // btnSerch
            // 
            this.btnSerch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSerch.Location = new System.Drawing.Point(918, 0);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(106, 27);
            this.btnSerch.TabIndex = 17;
            this.btnSerch.Text = "Искать";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // cbxIsRegister
            // 
            this.cbxIsRegister.AutoSize = true;
            this.cbxIsRegister.Checked = true;
            this.cbxIsRegister.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxIsRegister.Location = new System.Drawing.Point(10, 30);
            this.cbxIsRegister.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbxIsRegister.Name = "cbxIsRegister";
            this.cbxIsRegister.Size = new System.Drawing.Size(124, 17);
            this.cbxIsRegister.TabIndex = 18;
            this.cbxIsRegister.Text = "Учитывать регистр";
            this.cbxIsRegister.UseVisualStyleBackColor = true;
            // 
            // Scaner
            // 
            this.Scaner.PortName = "COM3";
            this.Scaner.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DataReceived);
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сканерToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1024, 24);
            this.msMain.TabIndex = 15;
            this.msMain.Text = "menuStrip1";
            // 
            // сканерToolStripMenuItem
            // 
            this.сканерToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиСканераШтрихкодовToolStripMenuItem});
            this.сканерToolStripMenuItem.Name = "сканерToolStripMenuItem";
            this.сканерToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сканерToolStripMenuItem.Text = "Сканер";
            // 
            // настройкиСканераШтрихкодовToolStripMenuItem
            // 
            this.настройкиСканераШтрихкодовToolStripMenuItem.Name = "настройкиСканераШтрихкодовToolStripMenuItem";
            this.настройкиСканераШтрихкодовToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.настройкиСканераШтрихкодовToolStripMenuItem.Text = "Настройки сканера штрих-кодов";
            this.настройкиСканераШтрихкодовToolStripMenuItem.Click += new System.EventHandler(this.настройкиСканераШтрихкодовToolStripMenuItem_Click);
            // 
            // SerchFromDocumentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlData);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.msMain);
            this.Name = "SerchFromDocumentsView";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.tlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beDocType.Properties)).EndInit();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList tlData;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn10;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn8;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Button btnSerch;
        private System.IO.Ports.SerialPort Scaner;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem сканерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиСканераШтрихкодовToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbxIsRegister;
        private System.Windows.Forms.CheckBox cbxIsSerchInDocBody;
        private DevExpress.XtraEditors.ButtonEdit beDocType;
    }
}
