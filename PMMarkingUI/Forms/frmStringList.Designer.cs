namespace PMMarkingUI.Forms
{
    partial class frmStringList
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
            this.btnOk = new System.Windows.Forms.Button();
            this.tbData = new System.Windows.Forms.TextBox();
            this.cbxWordWrap = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOk.Location = new System.Drawing.Point(0, 274);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(581, 35);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Закрыть";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbData
            // 
            this.tbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbData.Location = new System.Drawing.Point(0, 0);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbData.Size = new System.Drawing.Size(581, 247);
            this.tbData.TabIndex = 2;
            this.tbData.WordWrap = false;
            // 
            // cbxWordWrap
            // 
            this.cbxWordWrap.AutoSize = true;
            this.cbxWordWrap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbxWordWrap.Location = new System.Drawing.Point(0, 247);
            this.cbxWordWrap.Name = "cbxWordWrap";
            this.cbxWordWrap.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.cbxWordWrap.Size = new System.Drawing.Size(581, 27);
            this.cbxWordWrap.TabIndex = 3;
            this.cbxWordWrap.Text = "Перенос строк";
            this.cbxWordWrap.UseVisualStyleBackColor = true;
            this.cbxWordWrap.CheckedChanged += new System.EventHandler(this.cbxWordWrap_CheckedChanged);
            // 
            // frmStringList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 309);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.cbxWordWrap);
            this.Controls.Add(this.btnOk);
            this.Name = "frmStringList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список ошибок";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.CheckBox cbxWordWrap;
    }
}