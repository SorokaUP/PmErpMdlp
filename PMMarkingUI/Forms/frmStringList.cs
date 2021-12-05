using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMMarkingUI.Forms
{
    public partial class frmStringList : Form
    {
        public frmStringList(List<object> data, string Caption)
        {
            InitializeComponent();
            this.Text = string.IsNullOrEmpty(Caption) ? "Список ошибок" : Caption;

            foreach (string item in data)
            {
                tbData.Text += (string.IsNullOrEmpty(tbData.Text)) ? item.ToString() : Environment.NewLine + item.ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cbxWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            tbData.WordWrap = cbxWordWrap.Checked;
        }
    }
}
