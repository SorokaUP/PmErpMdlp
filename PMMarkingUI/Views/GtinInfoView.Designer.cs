namespace PMMarkingUI.Views
{
    partial class GtinInfoView
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
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.FilterPanel = new PMMarkingUI.Views.MedProductsFilterView();
            this.pMain = new System.Windows.Forms.Panel();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.получитьИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi851 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi852 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi853 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.pMain.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.FilterPanel);
            this.scMain.Panel1MinSize = 220;
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.pMain);
            this.scMain.Size = new System.Drawing.Size(720, 480);
            this.scMain.SplitterDistance = 220;
            this.scMain.TabIndex = 1;
            // 
            // FilterPanel
            // 
            this.FilterPanel.AutoScroll = true;
            this.FilterPanel.DelegateGetGtinFilter = null;
            this.FilterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterPanel.Location = new System.Drawing.Point(0, 0);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(220, 480);
            this.FilterPanel.TabIndex = 0;
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.tbLog);
            this.pMain.Controls.Add(this.msMenu);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(496, 480);
            this.pMain.TabIndex = 0;
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Location = new System.Drawing.Point(0, 24);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(496, 456);
            this.tbLog.TabIndex = 1;
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.получитьИнформациюToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(496, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // получитьИнформациюToolStripMenuItem
            // 
            this.получитьИнформациюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi851,
            this.tsmi852,
            this.tsmi853});
            this.получитьИнформациюToolStripMenuItem.Name = "получитьИнформациюToolStripMenuItem";
            this.получитьИнформациюToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.получитьИнформациюToolStripMenuItem.Text = "Получить информацию";
            // 
            // tsmi851
            // 
            this.tsmi851.Name = "tsmi851";
            this.tsmi851.Size = new System.Drawing.Size(344, 22);
            this.tsmi851.Text = "8.5.1 Получить информацию по фильтру";
            this.tsmi851.Click += new System.EventHandler(this.tsmi851_Click);
            // 
            // tsmi852
            // 
            this.tsmi852.Name = "tsmi852";
            this.tsmi852.Size = new System.Drawing.Size(344, 22);
            this.tsmi852.Text = "8.5.2 Получить информацию по товару (GTIN)";
            this.tsmi852.Click += new System.EventHandler(this.tsmi852_Click);
            // 
            // tsmi853
            // 
            this.tsmi853.Name = "tsmi853";
            this.tsmi853.Size = new System.Drawing.Size(344, 22);
            this.tsmi853.Text = "8.5.3 Поиск публичной информации по фильтру";
            this.tsmi853.Click += new System.EventHandler(this.tsmi853_Click);
            // 
            // GtinInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scMain);
            this.Name = "GtinInfoView";
            this.Size = new System.Drawing.Size(720, 480);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem получитьИнформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi851;
        private System.Windows.Forms.ToolStripMenuItem tsmi852;
        private System.Windows.Forms.ToolStripMenuItem tsmi853;
        private MedProductsFilterView FilterPanel;
    }
}
