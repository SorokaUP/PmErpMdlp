namespace PMMarkingUI.Views
{
    partial class GetDocumentsFromMdlpView
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
            this.DocFilterPanel = new PMMarkingUI.Views.DocFilterMdlpView();
            this.pMain = new System.Windows.Forms.Panel();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiGetDocs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGetDocs_Income = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGetDocs_Outcome = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьОбластьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.scMain.Panel1.Controls.Add(this.DocFilterPanel);
            this.scMain.Panel1MinSize = 220;
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.pMain);
            this.scMain.Size = new System.Drawing.Size(720, 480);
            this.scMain.SplitterDistance = 220;
            this.scMain.TabIndex = 0;
            // 
            // DocFilterPanel
            // 
            this.DocFilterPanel.AutoScroll = true;
            this.DocFilterPanel.DelegateGetDocFilter = null;
            this.DocFilterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocFilterPanel.Location = new System.Drawing.Point(0, 0);
            this.DocFilterPanel.Name = "DocFilterPanel";
            this.DocFilterPanel.Size = new System.Drawing.Size(220, 480);
            this.DocFilterPanel.TabIndex = 0;
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
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(496, 456);
            this.tbLog.TabIndex = 1;
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGetDocs,
            this.очиститьОбластьToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(496, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmiGetDocs
            // 
            this.tsmiGetDocs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGetDocs_Income,
            this.tsmiGetDocs_Outcome});
            this.tsmiGetDocs.Name = "tsmiGetDocs";
            this.tsmiGetDocs.Size = new System.Drawing.Size(204, 20);
            this.tsmiGetDocs.Text = "Получить документы по фильтру";
            // 
            // tsmiGetDocs_Income
            // 
            this.tsmiGetDocs_Income.Name = "tsmiGetDocs_Income";
            this.tsmiGetDocs_Income.Size = new System.Drawing.Size(155, 22);
            this.tsmiGetDocs_Income.Text = "5.8 Входящие";
            this.tsmiGetDocs_Income.Click += new System.EventHandler(this.tsmiGetDocs_Income_Click);
            // 
            // tsmiGetDocs_Outcome
            // 
            this.tsmiGetDocs_Outcome.Name = "tsmiGetDocs_Outcome";
            this.tsmiGetDocs_Outcome.Size = new System.Drawing.Size(155, 22);
            this.tsmiGetDocs_Outcome.Text = "5.7 Исходящие";
            this.tsmiGetDocs_Outcome.Click += new System.EventHandler(this.tsmiGetDocs_Outcome_Click);
            // 
            // очиститьОбластьToolStripMenuItem
            // 
            this.очиститьОбластьToolStripMenuItem.Name = "очиститьОбластьToolStripMenuItem";
            this.очиститьОбластьToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.очиститьОбластьToolStripMenuItem.Text = "Очистить область";
            this.очиститьОбластьToolStripMenuItem.Click += new System.EventHandler(this.очиститьОбластьToolStripMenuItem_Click);
            // 
            // GetDocumentsFromMdlpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scMain);
            this.Name = "GetDocumentsFromMdlpView";
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
        private DocFilterMdlpView DocFilterPanel;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiGetDocs;
        private System.Windows.Forms.ToolStripMenuItem tsmiGetDocs_Income;
        private System.Windows.Forms.ToolStripMenuItem tsmiGetDocs_Outcome;
        private System.Windows.Forms.ToolStripMenuItem очиститьОбластьToolStripMenuItem;
    }
}
