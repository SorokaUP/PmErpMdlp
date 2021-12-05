using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMMarkingUI.Forms.Documents
{
    public partial class frmCreateDocumentHandle : Form
    {
        public frmCreateDocumentHandle(List<object> data)
        {
            InitializeComponent();
            foreach (string item in data)
            {
                tbData.Text += (string.IsNullOrEmpty(tbData.Text)) ? item.ToString() : Environment.NewLine + item.ToString();
            }
        }

        private void cbxWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            tbData.WordWrap = cbxWordWrap.Checked;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(tbData.Text);
                MessageBox.Show("Текст скопирован");
            }
            catch { }
        }

        private void btsSaveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, tbData.Text);
                    MessageBox.Show("Файл сохранен");
                }
            }
            catch { }
        }
    }
}
