namespace PMMarkingUI.Forms
{
    partial class frmProccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProccess));
            this.progressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            this.progressBarControl = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // progressPanel
            // 
            this.progressPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel.Appearance.Options.UseBackColor = true;
            this.progressPanel.BarAnimationElementThickness = 2;
            this.progressPanel.Caption = "Ждите";
            this.progressPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.progressPanel.Description = "Идет обработка...";
            this.progressPanel.Location = new System.Drawing.Point(111, 4);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(246, 57);
            this.progressPanel.TabIndex = 0;
            this.progressPanel.Text = "progressPanel1";
            // 
            // progressBarControl
            // 
            this.progressBarControl.Location = new System.Drawing.Point(12, 65);
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.progressBarControl.Size = new System.Drawing.Size(446, 18);
            this.progressBarControl.TabIndex = 1;
            this.progressBarControl.UseWaitCursor = true;
            // 
            // frmProccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 97);
            this.Controls.Add(this.progressBarControl);
            this.Controls.Add(this.progressPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выполнение";
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraWaitForm.ProgressPanel progressPanel;
        public DevExpress.XtraEditors.ProgressBarControl progressBarControl;
    }
}