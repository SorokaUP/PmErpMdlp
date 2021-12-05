using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMMarkingUI.Views
{
    public partial class WhatWithDocView : UserControl
    {
        public WhatWithDocView()
        {
            InitializeComponent();
            this.Text = "Анализ документа";
            this.Tag = false;
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Введите номер документа");
                return;
            }
            if (textBox1.Text.Length > 80)
            {
                MessageBox.Show("Введите номер документа");
                return;
            }

            richTextBox1.Text = "";
            DataTable res = new DataTable();
            if (comboBox1.SelectedIndex == 0)
            {
                res = ProfitMed.Firebird.DAO.WhatWithDocTW(textBox1.Text.Trim());
            }
            if (comboBox1.SelectedIndex == 1)
            {
                res = ProfitMed.Firebird.DAO.WhatWithDocMdlp(textBox1.Text.Trim());
            }
            if (res != null)
            {
                foreach (DataRow row in res.Rows)
                {
                    AppendText(richTextBox1, row["RES"].ToString(), (row["COLOR"].ToString() == "red" ? Color.Red : Color.Black), richTextBox1.Font);
                }
            }
        }

        public void AppendText(RichTextBox box, string text, Color color, Font font)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.SelectionFont = font;
            box.AppendText(text + Environment.NewLine);
            box.SelectionColor = box.ForeColor;
        }
    }
}
