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
    public partial class frmTextBoxDate : Form
    {
        public object[] Data { get; private set; }
        public frmTextBoxDate(string Caption, string HeaderTextBox, string HeaderDate)
        {
            InitializeComponent();
            this.Text = Caption;
            lbHeaderTextBox.Text = HeaderTextBox;
            lbHeaderDate.Text = HeaderDate;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Data = new object[2];
            Data[0] = tbData.Text;
            Data[1] = dtpDate.Value.Date;
            DialogResult = DialogResult.OK;
        }

        private void tbData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGo_Click(sender, null);
            }
        }
    }
}
