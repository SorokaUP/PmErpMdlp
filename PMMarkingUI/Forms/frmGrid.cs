using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMMarkingUI.Classes;

namespace PMMarkingUI.Forms
{
    public partial class frmGrid : Form
    {
        public frmGrid(string Caption, DataTable res)
        {
            InitializeComponent();
            this.Text = Caption;
            cData.DataSource = res;
            vData.LayoutChanged();
            vData.SetDefaultGridViewOptions();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
