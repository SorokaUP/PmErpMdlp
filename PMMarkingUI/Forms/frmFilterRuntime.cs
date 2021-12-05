using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMMarkingUI.Delegats;

namespace PMMarkingUI.Forms
{
    public partial class frmFilterRuntime : Form
    {
        public frmFilterRuntime(string Caption, UserControl c)//, DelegateCloseFilterRuntime d)
        {
            InitializeComponent();
            this.Text = Caption;
            c.Parent = this;
            c.Dock = DockStyle.Fill;
        }
    }
}
