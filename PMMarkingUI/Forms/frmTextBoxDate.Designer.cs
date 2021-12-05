namespace PMMarkingUI.Forms
{
    partial class frmTextBoxDate
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.tbData = new System.Windows.Forms.TextBox();
            this.lbHeaderTextBox = new System.Windows.Forms.Label();
            this.lbHeaderDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(74, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(155, 90);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "ОК";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbData
            // 
            this.tbData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbData.Location = new System.Drawing.Point(12, 25);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(218, 20);
            this.tbData.TabIndex = 5;
            // 
            // lbHeaderTextBox
            // 
            this.lbHeaderTextBox.AutoSize = true;
            this.lbHeaderTextBox.Location = new System.Drawing.Point(12, 9);
            this.lbHeaderTextBox.Name = "lbHeaderTextBox";
            this.lbHeaderTextBox.Size = new System.Drawing.Size(50, 13);
            this.lbHeaderTextBox.TabIndex = 4;
            this.lbHeaderTextBox.Text = "lbHeader";
            // 
            // lbHeaderDate
            // 
            this.lbHeaderDate.AutoSize = true;
            this.lbHeaderDate.Location = new System.Drawing.Point(12, 48);
            this.lbHeaderDate.Name = "lbHeaderDate";
            this.lbHeaderDate.Size = new System.Drawing.Size(35, 13);
            this.lbHeaderDate.TabIndex = 8;
            this.lbHeaderDate.Text = "label1";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(12, 64);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(218, 20);
            this.dtpDate.TabIndex = 9;
            // 
            // frmTextBoxDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 122);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lbHeaderDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.lbHeaderTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTextBoxDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTextBoxDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Label lbHeaderTextBox;
        private System.Windows.Forms.Label lbHeaderDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}