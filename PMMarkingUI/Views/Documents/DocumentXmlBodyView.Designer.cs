namespace PMMarkingUI.Views
{
    partial class DocumentXmlBodyView
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
            this.scXmlBody = new System.Windows.Forms.SplitContainer();
            this.rtbXmlBody = new System.Windows.Forms.RichTextBox();
            this.tbXmlBody = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxFormatXml = new System.Windows.Forms.CheckBox();
            this.cbxWordWrap = new System.Windows.Forms.CheckBox();
            this.twXmlBody = new System.Windows.Forms.TreeView();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiShowAdditional = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyXmlToBoof = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveXmlToFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.scXmlBody)).BeginInit();
            this.scXmlBody.Panel1.SuspendLayout();
            this.scXmlBody.Panel2.SuspendLayout();
            this.scXmlBody.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // scXmlBody
            // 
            this.scXmlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scXmlBody.Location = new System.Drawing.Point(0, 24);
            this.scXmlBody.Name = "scXmlBody";
            // 
            // scXmlBody.Panel1
            // 
            this.scXmlBody.Panel1.Controls.Add(this.rtbXmlBody);
            this.scXmlBody.Panel1.Controls.Add(this.tbXmlBody);
            this.scXmlBody.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.scXmlBody.Panel1MinSize = 0;
            // 
            // scXmlBody.Panel2
            // 
            this.scXmlBody.Panel2.Controls.Add(this.twXmlBody);
            this.scXmlBody.Size = new System.Drawing.Size(720, 456);
            this.scXmlBody.SplitterDistance = 328;
            this.scXmlBody.TabIndex = 2;
            // 
            // rtbXmlBody
            // 
            this.rtbXmlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbXmlBody.Location = new System.Drawing.Point(0, 0);
            this.rtbXmlBody.Name = "rtbXmlBody";
            this.rtbXmlBody.ReadOnly = true;
            this.rtbXmlBody.Size = new System.Drawing.Size(328, 425);
            this.rtbXmlBody.TabIndex = 4;
            this.rtbXmlBody.Text = "";
            this.rtbXmlBody.WordWrap = false;
            // 
            // tbXmlBody
            // 
            this.tbXmlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbXmlBody.Location = new System.Drawing.Point(0, 0);
            this.tbXmlBody.Multiline = true;
            this.tbXmlBody.Name = "tbXmlBody";
            this.tbXmlBody.ReadOnly = true;
            this.tbXmlBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbXmlBody.Size = new System.Drawing.Size(328, 425);
            this.tbXmlBody.TabIndex = 2;
            this.tbXmlBody.WordWrap = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cbxFormatXml, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxWordWrap, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 425);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 31);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // cbxFormatXml
            // 
            this.cbxFormatXml.Checked = true;
            this.cbxFormatXml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxFormatXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxFormatXml.Location = new System.Drawing.Point(118, 3);
            this.cbxFormatXml.Name = "cbxFormatXml";
            this.cbxFormatXml.Size = new System.Drawing.Size(207, 25);
            this.cbxFormatXml.TabIndex = 4;
            this.cbxFormatXml.Text = "Форматированный текст";
            this.cbxFormatXml.UseVisualStyleBackColor = true;
            this.cbxFormatXml.CheckedChanged += new System.EventHandler(this.cbxFormatXml_CheckedChanged);
            // 
            // cbxWordWrap
            // 
            this.cbxWordWrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxWordWrap.Location = new System.Drawing.Point(3, 3);
            this.cbxWordWrap.Name = "cbxWordWrap";
            this.cbxWordWrap.Size = new System.Drawing.Size(109, 25);
            this.cbxWordWrap.TabIndex = 3;
            this.cbxWordWrap.Text = " Перенос строк";
            this.cbxWordWrap.UseVisualStyleBackColor = true;
            this.cbxWordWrap.CheckedChanged += new System.EventHandler(this.cbxWordWrap_CheckedChanged);
            // 
            // twXmlBody
            // 
            this.twXmlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twXmlBody.HotTracking = true;
            this.twXmlBody.LabelEdit = true;
            this.twXmlBody.Location = new System.Drawing.Point(0, 0);
            this.twXmlBody.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.twXmlBody.Name = "twXmlBody";
            this.twXmlBody.Size = new System.Drawing.Size(388, 456);
            this.twXmlBody.TabIndex = 1;
            this.twXmlBody.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.twXmlBody_AfterLabelEdit);
            this.twXmlBody.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.twXmlBody_NodeMouseDoubleClick);
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowAdditional,
            this.tsmiCopyXmlToBoof,
            this.tsmiSaveXmlToFile});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(720, 24);
            this.msMain.TabIndex = 2;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiShowAdditional
            // 
            this.tsmiShowAdditional.Name = "tsmiShowAdditional";
            this.tsmiShowAdditional.Size = new System.Drawing.Size(127, 20);
            this.tsmiShowAdditional.Text = "Показать XML текст";
            this.tsmiShowAdditional.Click += new System.EventHandler(this.tsmiShowAdditional_Click);
            // 
            // tsmiCopyXmlToBoof
            // 
            this.tsmiCopyXmlToBoof.Name = "tsmiCopyXmlToBoof";
            this.tsmiCopyXmlToBoof.Size = new System.Drawing.Size(203, 20);
            this.tsmiCopyXmlToBoof.Text = "Копировать XML в буфер обмена";
            this.tsmiCopyXmlToBoof.Click += new System.EventHandler(this.tsmiCopyXmlToBoof_Click);
            // 
            // tsmiSaveXmlToFile
            // 
            this.tsmiSaveXmlToFile.Name = "tsmiSaveXmlToFile";
            this.tsmiSaveXmlToFile.Size = new System.Drawing.Size(145, 20);
            this.tsmiSaveXmlToFile.Text = "Сохранить XML в файл";
            this.tsmiSaveXmlToFile.Click += new System.EventHandler(this.tsmiSaveXmlToFile_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML|*.xml|TXT|*.txt";
            this.saveFileDialog1.Title = "Сохранение файла";
            // 
            // DocumentXmlBodyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scXmlBody);
            this.Controls.Add(this.msMain);
            this.Name = "DocumentXmlBodyView";
            this.Size = new System.Drawing.Size(720, 480);
            this.scXmlBody.Panel1.ResumeLayout(false);
            this.scXmlBody.Panel1.PerformLayout();
            this.scXmlBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scXmlBody)).EndInit();
            this.scXmlBody.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer scXmlBody;
        private System.Windows.Forms.TreeView twXmlBody;
        private System.Windows.Forms.TextBox tbXmlBody;
        private System.Windows.Forms.CheckBox cbxWordWrap;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowAdditional;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyXmlToBoof;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveXmlToFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox rtbXmlBody;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox cbxFormatXml;
    }
}
