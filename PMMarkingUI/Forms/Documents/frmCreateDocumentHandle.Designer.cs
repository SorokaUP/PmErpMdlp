namespace PMMarkingUI.Forms.Documents
{
    partial class frmCreateDocumentHandle
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
            this.tbData = new System.Windows.Forms.TextBox();
            this.cbxWordWrap = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btsSaveToFile = new System.Windows.Forms.Button();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbData
            // 
            this.tbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbData.Location = new System.Drawing.Point(0, 0);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbData.Size = new System.Drawing.Size(800, 385);
            this.tbData.TabIndex = 5;
            this.tbData.WordWrap = false;
            // 
            // cbxWordWrap
            // 
            this.cbxWordWrap.AutoSize = true;
            this.cbxWordWrap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbxWordWrap.Location = new System.Drawing.Point(0, 385);
            this.cbxWordWrap.Name = "cbxWordWrap";
            this.cbxWordWrap.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.cbxWordWrap.Size = new System.Drawing.Size(800, 27);
            this.cbxWordWrap.TabIndex = 6;
            this.cbxWordWrap.Text = "Перенос строк";
            this.cbxWordWrap.UseVisualStyleBackColor = true;
            this.cbxWordWrap.CheckedChanged += new System.EventHandler(this.cbxWordWrap_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btsSaveToFile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCopyToClipboard, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 412);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 38);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btsSaveToFile
            // 
            this.btsSaveToFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btsSaveToFile.Location = new System.Drawing.Point(3, 3);
            this.btsSaveToFile.Name = "btsSaveToFile";
            this.btsSaveToFile.Size = new System.Drawing.Size(247, 32);
            this.btsSaveToFile.TabIndex = 0;
            this.btsSaveToFile.Text = "Сохранить в файл";
            this.btsSaveToFile.UseVisualStyleBackColor = true;
            this.btsSaveToFile.Click += new System.EventHandler(this.btsSaveToFile_Click);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyToClipboard.Location = new System.Drawing.Point(276, 3);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(247, 32);
            this.btnCopyToClipboard.TabIndex = 1;
            this.btnCopyToClipboard.Text = "Копировать в буфер обмена";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(549, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(248, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML|*.xml|TXT|*.txt";
            this.saveFileDialog1.Title = "Сохранение файла";
            // 
            // frmCreateDocumentHandle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.cbxWordWrap);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmCreateDocumentHandle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML-документ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.CheckBox cbxWordWrap;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btsSaveToFile;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}