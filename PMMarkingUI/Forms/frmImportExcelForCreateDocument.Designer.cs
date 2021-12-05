namespace PMMarkingUI.Forms
{
    partial class frmImportExcelForCreateDocument
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudOBJECT_ID = new System.Windows.Forms.NumericUpDown();
            this.nudCOST = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudVAT_VALUE = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudOBJECT_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCOST)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVAT_VALUE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер колонки SSCC / SGTIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер колонки ЦЕНА";
            // 
            // nudOBJECT_ID
            // 
            this.nudOBJECT_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudOBJECT_ID.Location = new System.Drawing.Point(183, 3);
            this.nudOBJECT_ID.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudOBJECT_ID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOBJECT_ID.Name = "nudOBJECT_ID";
            this.nudOBJECT_ID.Size = new System.Drawing.Size(58, 20);
            this.nudOBJECT_ID.TabIndex = 5;
            this.nudOBJECT_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudOBJECT_ID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCOST
            // 
            this.nudCOST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudCOST.Location = new System.Drawing.Point(183, 29);
            this.nudCOST.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudCOST.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCOST.Name = "nudCOST";
            this.nudCOST.Size = new System.Drawing.Size(58, 20);
            this.nudCOST.TabIndex = 6;
            this.nudCOST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCOST.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nudVAT_VALUE, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nudOBJECT_ID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nudCOST, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnOk, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 105);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Location = new System.Drawing.Point(183, 81);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Начать со строки";
            // 
            // nudVAT_VALUE
            // 
            this.nudVAT_VALUE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudVAT_VALUE.Location = new System.Drawing.Point(183, 55);
            this.nudVAT_VALUE.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudVAT_VALUE.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVAT_VALUE.Name = "nudVAT_VALUE";
            this.nudVAT_VALUE.Size = new System.Drawing.Size(58, 20);
            this.nudVAT_VALUE.TabIndex = 7;
            this.nudVAT_VALUE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudVAT_VALUE.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Номер колонки НДС";
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.Location = new System.Drawing.Point(244, 0);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnOk.Name = "btnOk";
            this.tableLayoutPanel1.SetRowSpan(this.btnOk, 3);
            this.btnOk.Size = new System.Drawing.Size(120, 75);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Выбрать файл и загрузить...";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(244, 78);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmImportExcelForCreateDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 129);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmImportExcelForCreateDocument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Импорт Excel для создания документа";
            ((System.ComponentModel.ISupportInitialize)(this.nudOBJECT_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCOST)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVAT_VALUE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudOBJECT_ID;
        private System.Windows.Forms.NumericUpDown nudCOST;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudVAT_VALUE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
    }
}