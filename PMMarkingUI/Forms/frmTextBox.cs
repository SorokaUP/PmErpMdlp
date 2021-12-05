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
    public partial class frmTextBox : Form
    {
        public string Data { get; private set; }
        public frmTextBox(string FormCaption, string EditorCaption, string Value = "", bool isPassword = false)
        {
            InitializeComponent();
            this.Text = FormCaption;
            lbHeader.Text = EditorCaption;
            tbData.Text = Value;
            tbData.PasswordChar = isPassword ? '*' : tbData.PasswordChar;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Data = tbData.Text;
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
