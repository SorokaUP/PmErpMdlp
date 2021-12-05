namespace PMMarkingUI.Views
{
    partial class DocumentSSCCView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentSSCCView));
            this.Parent = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlSSCC = new DevExpress.XtraTreeList.TreeList();
            this.tlIcon = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.ilIcons = new System.Windows.Forms.ImageList(this.components);
            this.tlcID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcSSCC = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcIsScan = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcIsDisband = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.tlcDoc912Id = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlcInfoId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.msSSCC = new System.Windows.Forms.MenuStrip();
            this.действиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGetSsccInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGetSscc = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiSendQueryKiz = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiUnPackingBox = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExtractBoxFromBox = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMovedSSCC = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAction_List = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_List_ExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_List_CollapseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAction_List_ClearFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.выделениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.снятьВыделениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.выделитьПоФильтрамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSerchSscc = new System.Windows.Forms.ToolStripMenuItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnOutbox = new System.Windows.Forms.Button();
            this.tsslCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.tlSSCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.msSSCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Parent
            // 
            this.Parent.Caption = "PARENT_ID";
            this.Parent.FieldName = "PARENT_ID";
            this.Parent.Name = "Parent";
            // 
            // tlSSCC
            // 
            this.tlSSCC.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlIcon,
            this.tlcID,
            this.Parent,
            this.tlcSSCC,
            this.tlcIsScan,
            this.tlcIsDisband,
            this.tlcDoc912Id,
            this.tlcInfoId});
            this.tlSSCC.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlSSCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlSSCC.KeyFieldName = "INFO_ID";
            this.tlSSCC.Location = new System.Drawing.Point(0, 54);
            this.tlSSCC.Name = "tlSSCC";
            this.tlSSCC.BeginUnboundLoad();
            this.tlSSCC.AppendNode(new object[] {
            "Все коробки",
            "Все коробки",
            null,
            null,
            null,
            null,
            null,
            null}, -1);
            this.tlSSCC.EndUnboundLoad();
            this.tlSSCC.OptionsBehavior.EditorShowMode = DevExpress.XtraTreeList.TreeListEditorShowMode.MouseDownFocused;
            this.tlSSCC.OptionsBehavior.PopulateServiceColumns = true;
            this.tlSSCC.OptionsBehavior.ReadOnly = true;
            this.tlSSCC.OptionsFind.AllowIncrementalSearch = true;
            this.tlSSCC.OptionsView.AutoWidth = false;
            this.tlSSCC.OptionsView.CheckBoxStyle = DevExpress.XtraTreeList.DefaultNodeCheckBoxStyle.Check;
            this.tlSSCC.OptionsView.RootCheckBoxStyle = DevExpress.XtraTreeList.NodeCheckBoxStyle.Check;
            this.tlSSCC.OptionsView.ShowCaption = true;
            this.tlSSCC.OptionsView.ShowSummaryFooter = true;
            this.tlSSCC.ParentFieldName = "PARENT_ID";
            this.tlSSCC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemImageComboBox1});
            this.tlSSCC.Size = new System.Drawing.Size(290, 274);
            this.tlSSCC.TabIndex = 12;
            this.tlSSCC.RowClick += new DevExpress.XtraTreeList.RowClickEventHandler(this.tlSSCC_RowClick);
            this.tlSSCC.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.tlSSCC_AfterCheckNode);
            this.tlSSCC.NodeChanged += new DevExpress.XtraTreeList.NodeChangedEventHandler(this.tlSSCC_NodeChanged);
            // 
            // tlIcon
            // 
            this.tlIcon.Caption = " ";
            this.tlIcon.ColumnEdit = this.repositoryItemImageComboBox1;
            this.tlIcon.FieldName = "IS_CHILDREN";
            this.tlIcon.Name = "tlIcon";
            this.tlIcon.OptionsColumn.AllowEdit = false;
            this.tlIcon.OptionsColumn.ReadOnly = true;
            this.tlIcon.Visible = true;
            this.tlIcon.VisibleIndex = 0;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 4),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, 2)});
            this.repositoryItemImageComboBox1.LargeImages = this.ilIcons;
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            // 
            // ilIcons
            // 
            this.ilIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIcons.ImageStream")));
            this.ilIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilIcons.Images.SetKeyName(0, "warning.png");
            this.ilIcons.Images.SetKeyName(1, "box2.png");
            this.ilIcons.Images.SetKeyName(2, "box5.png");
            this.ilIcons.Images.SetKeyName(3, "box6.png");
            this.ilIcons.Images.SetKeyName(4, "warning2.png");
            // 
            // tlcID
            // 
            this.tlcID.Caption = "ID";
            this.tlcID.FieldName = "ID";
            this.tlcID.Name = "tlcID";
            // 
            // tlcSSCC
            // 
            this.tlcSSCC.Caption = "Коробка";
            this.tlcSSCC.FieldName = "SSCC";
            this.tlcSSCC.Name = "tlcSSCC";
            this.tlcSSCC.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Count;
            this.tlcSSCC.Visible = true;
            this.tlcSSCC.VisibleIndex = 1;
            this.tlcSSCC.Width = 192;
            // 
            // tlcIsScan
            // 
            this.tlcIsScan.Caption = "Скан.";
            this.tlcIsScan.FieldName = "IS_SCAN";
            this.tlcIsScan.Name = "tlcIsScan";
            this.tlcIsScan.OptionsColumn.AllowEdit = false;
            this.tlcIsScan.OptionsColumn.ReadOnly = true;
            this.tlcIsScan.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.tlcIsScan.Visible = true;
            this.tlcIsScan.VisibleIndex = 2;
            this.tlcIsScan.Width = 51;
            // 
            // tlcIsDisband
            // 
            this.tlcIsDisband.Caption = "Расф.";
            this.tlcIsDisband.ColumnEdit = this.repositoryItemCheckEdit2;
            this.tlcIsDisband.FieldName = "IS_DISBAND";
            this.tlcIsDisband.Name = "tlcIsDisband";
            this.tlcIsDisband.OptionsColumn.ReadOnly = true;
            this.tlcIsDisband.Visible = true;
            this.tlcIsDisband.VisibleIndex = 3;
            this.tlcIsDisband.Width = 39;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.ValueChecked = 1;
            this.repositoryItemCheckEdit2.ValueUnchecked = 0;
            // 
            // tlcDoc912Id
            // 
            this.tlcDoc912Id.Caption = "Номер док. расф.";
            this.tlcDoc912Id.FieldName = "DOC912_ID";
            this.tlcDoc912Id.Name = "tlcDoc912Id";
            this.tlcDoc912Id.Width = 60;
            // 
            // tlcInfoId
            // 
            this.tlcInfoId.Caption = "INFO_ID";
            this.tlcInfoId.FieldName = "INFO_ID";
            this.tlcInfoId.Name = "tlcInfoId";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // msSSCC
            // 
            this.msSSCC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действиеToolStripMenuItem,
            this.выделениеToolStripMenuItem,
            this.tsmiSerchSscc});
            this.msSSCC.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.msSSCC.Location = new System.Drawing.Point(0, 0);
            this.msSSCC.Name = "msSSCC";
            this.msSSCC.Size = new System.Drawing.Size(290, 23);
            this.msSSCC.TabIndex = 13;
            this.msSSCC.Text = "menuStrip1";
            // 
            // действиеToolStripMenuItem
            // 
            this.действиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGetSsccInfo,
            this.tsmiGetSscc,
            this.tmsiSendQueryKiz,
            this.toolStripSeparator1,
            this.tsmiUnPackingBox,
            this.tsmiExtractBoxFromBox,
            this.tsmiMovedSSCC,
            this.toolStripMenuItem1,
            this.tsmiAction_List});
            this.действиеToolStripMenuItem.Name = "действиеToolStripMenuItem";
            this.действиеToolStripMenuItem.Size = new System.Drawing.Size(70, 19);
            this.действиеToolStripMenuItem.Text = "Действие";
            // 
            // tsmiGetSsccInfo
            // 
            this.tsmiGetSsccInfo.Name = "tsmiGetSsccInfo";
            this.tsmiGetSsccInfo.Size = new System.Drawing.Size(436, 22);
            this.tsmiGetSsccInfo.Text = "Получить информацию по выбранным коробкам";
            this.tsmiGetSsccInfo.Visible = false;
            this.tsmiGetSsccInfo.Click += new System.EventHandler(this.tsmiGetSsccInfo_Click);
            // 
            // tsmiGetSscc
            // 
            this.tsmiGetSscc.Name = "tsmiGetSscc";
            this.tsmiGetSscc.Size = new System.Drawing.Size(436, 22);
            this.tsmiGetSscc.Text = "Получить иерархию вложенности третичных упаковок (коробок)";
            this.tsmiGetSscc.Visible = false;
            this.tsmiGetSscc.Click += new System.EventHandler(this.tsmiGetSscc_Click);
            // 
            // tmsiSendQueryKiz
            // 
            this.tmsiSendQueryKiz.Name = "tmsiSendQueryKiz";
            this.tmsiSendQueryKiz.Size = new System.Drawing.Size(436, 22);
            this.tmsiSendQueryKiz.Text = "Запрос информации по SSCC";
            this.tmsiSendQueryKiz.Click += new System.EventHandler(this.tmsiSendQueryKiz_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(433, 6);
            // 
            // tsmiUnPackingBox
            // 
            this.tsmiUnPackingBox.Image = global::PMMarkingUI.Properties.Resources.box2;
            this.tsmiUnPackingBox.Name = "tsmiUnPackingBox";
            this.tsmiUnPackingBox.Size = new System.Drawing.Size(436, 22);
            this.tsmiUnPackingBox.Text = "Расформировать коробки";
            this.tsmiUnPackingBox.Click += new System.EventHandler(this.tsmiUnPackingBox_Click);
            // 
            // tsmiExtractBoxFromBox
            // 
            this.tsmiExtractBoxFromBox.Image = global::PMMarkingUI.Properties.Resources.arrow_right_down;
            this.tsmiExtractBoxFromBox.Name = "tsmiExtractBoxFromBox";
            this.tsmiExtractBoxFromBox.Size = new System.Drawing.Size(436, 22);
            this.tsmiExtractBoxFromBox.Text = "Изъять коробки из вложения";
            this.tsmiExtractBoxFromBox.Click += new System.EventHandler(this.tsmiExtractBoxFromBox_Click);
            // 
            // tsmiMovedSSCC
            // 
            this.tsmiMovedSSCC.Image = global::PMMarkingUI.Properties.Resources.truck1;
            this.tsmiMovedSSCC.Name = "tsmiMovedSSCC";
            this.tsmiMovedSSCC.Size = new System.Drawing.Size(436, 22);
            this.tsmiMovedSSCC.Text = "Переместить коробки";
            this.tsmiMovedSSCC.Click += new System.EventHandler(this.tsmiMovedSSCC_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(433, 6);
            // 
            // tsmiAction_List
            // 
            this.tsmiAction_List.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAction_List_ExpandAll,
            this.tsmiAction_List_CollapseAll,
            this.tsmiAction_List_ClearFilter});
            this.tsmiAction_List.Name = "tsmiAction_List";
            this.tsmiAction_List.Size = new System.Drawing.Size(436, 22);
            this.tsmiAction_List.Text = "Список";
            // 
            // tsmiAction_List_ExpandAll
            // 
            this.tsmiAction_List_ExpandAll.Name = "tsmiAction_List_ExpandAll";
            this.tsmiAction_List_ExpandAll.Size = new System.Drawing.Size(171, 22);
            this.tsmiAction_List_ExpandAll.Text = "Развернуть все";
            this.tsmiAction_List_ExpandAll.Click += new System.EventHandler(this.tsmiAction_List_ExpandAll_Click);
            // 
            // tsmiAction_List_CollapseAll
            // 
            this.tsmiAction_List_CollapseAll.Name = "tsmiAction_List_CollapseAll";
            this.tsmiAction_List_CollapseAll.Size = new System.Drawing.Size(171, 22);
            this.tsmiAction_List_CollapseAll.Text = "Свернуть все";
            this.tsmiAction_List_CollapseAll.Click += new System.EventHandler(this.tsmiAction_List_CollapseAll_Click);
            // 
            // tsmiAction_List_ClearFilter
            // 
            this.tsmiAction_List_ClearFilter.Name = "tsmiAction_List_ClearFilter";
            this.tsmiAction_List_ClearFilter.Size = new System.Drawing.Size(171, 22);
            this.tsmiAction_List_ClearFilter.Text = "Сбросить фильтр";
            this.tsmiAction_List_ClearFilter.Click += new System.EventHandler(this.tsmiAction_List_ClearFilter_Click);
            // 
            // выделениеToolStripMenuItem
            // 
            this.выделениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выделитьВсеToolStripMenuItem,
            this.снятьВыделениеToolStripMenuItem,
            this.toolStripMenuItem2,
            this.выделитьПоФильтрамToolStripMenuItem});
            this.выделениеToolStripMenuItem.Name = "выделениеToolStripMenuItem";
            this.выделениеToolStripMenuItem.Size = new System.Drawing.Size(80, 19);
            this.выделениеToolStripMenuItem.Text = "Выделение";
            // 
            // выделитьВсеToolStripMenuItem
            // 
            this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.выделитьВсеToolStripMenuItem.Text = "Выделить все";
            this.выделитьВсеToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem_Click);
            // 
            // снятьВыделениеToolStripMenuItem
            // 
            this.снятьВыделениеToolStripMenuItem.Name = "снятьВыделениеToolStripMenuItem";
            this.снятьВыделениеToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.снятьВыделениеToolStripMenuItem.Text = "Снять выделение";
            this.снятьВыделениеToolStripMenuItem.Click += new System.EventHandler(this.снятьВыделениеToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(200, 6);
            // 
            // выделитьПоФильтрамToolStripMenuItem
            // 
            this.выделитьПоФильтрамToolStripMenuItem.Name = "выделитьПоФильтрамToolStripMenuItem";
            this.выделитьПоФильтрамToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.выделитьПоФильтрамToolStripMenuItem.Text = "Выделить по фильтрам";
            this.выделитьПоФильтрамToolStripMenuItem.Click += new System.EventHandler(this.выделитьПоФильтрамToolStripMenuItem_Click);
            // 
            // tsmiSerchSscc
            // 
            this.tsmiSerchSscc.Name = "tsmiSerchSscc";
            this.tsmiSerchSscc.Size = new System.Drawing.Size(53, 19);
            this.tsmiSerchSscc.Text = "Найти";
            this.tsmiSerchSscc.Click += new System.EventHandler(this.tsmiSerchSscc_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAll, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOutbox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(290, 31);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btnAll
            // 
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAll.Location = new System.Drawing.Point(148, 3);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(139, 25);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "Показать все";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnOutbox
            // 
            this.btnOutbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOutbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOutbox.Location = new System.Drawing.Point(3, 3);
            this.btnOutbox.Name = "btnOutbox";
            this.btnOutbox.Size = new System.Drawing.Size(139, 25);
            this.btnOutbox.TabIndex = 0;
            this.btnOutbox.Text = "РОССЫПЬ";
            this.btnOutbox.UseVisualStyleBackColor = true;
            this.btnOutbox.Click += new System.EventHandler(this.btnOutbox_Click);
            // 
            // tsslCount
            // 
            this.tsslCount.Name = "tsslCount";
            this.tsslCount.Size = new System.Drawing.Size(16, 17);
            this.tsslCount.Text = "   ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 328);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(290, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // DocumentSSCCView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlSSCC);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.msSSCC);
            this.Name = "DocumentSSCCView";
            this.Size = new System.Drawing.Size(290, 350);
            ((System.ComponentModel.ISupportInitialize)(this.tlSSCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.msSSCC.ResumeLayout(false);
            this.msSSCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList tlSSCC;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcSSCC;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcID;
        private System.Windows.Forms.MenuStrip msSSCC;
        private System.Windows.Forms.ToolStripMenuItem действиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiGetSsccInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmiGetSscc;
        private System.Windows.Forms.ToolStripMenuItem выделениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem снятьВыделениеToolStripMenuItem;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcIsScan;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.ToolStripMenuItem tmsiSendQueryKiz;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Parent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiUnPackingBox;
        private System.Windows.Forms.ToolStripMenuItem tsmiExtractBoxFromBox;
        private System.Windows.Forms.ToolStripMenuItem tsmiMovedSSCC;
        private System.Windows.Forms.ToolStripMenuItem tsmiSerchSscc;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_List;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_List_ExpandAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_List_CollapseAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiAction_List_ClearFilter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcIsDisband;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlIcon;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private System.Windows.Forms.ImageList ilIcons;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcDoc912Id;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnOutbox;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcInfoId;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem выделитьПоФильтрамToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsslCount;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}
