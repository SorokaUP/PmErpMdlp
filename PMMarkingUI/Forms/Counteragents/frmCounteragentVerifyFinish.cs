using System;
using System.Data;
using System.Windows.Forms;

namespace PMMarkingUI.Forms
{
    public partial class frmCounteragentVerifyFinish : Form
    {
        public frmCounteragentVerifyFinish(DataTable data, string msg)
        {
            InitializeComponent();
            gData.DataSource = data;
            vData.LayoutChanged();
            int NonResponseRowCount = 0;
            for (int i = 0; i < data.Rows.Count; i++)
                if ((int)data.Rows[i]["IS_RESPONSE"] == 0)
                    NonResponseRowCount++;

            Sys.GridColumns.CreateFormatRules(vData, "IS_RESPONSE", "IS_RESPONSE", "ToInt([IS_RESPONSE]) == 1", true);
            Sys.GridColumns.CreateFormatRules(vData, "NON_RESPONSE", "IS_RESPONSE", "ToInt([IS_RESPONSE]) == 0", false);

            tbMessage.Text = msg;
            if (NonResponseRowCount > 0)
                tbMessage.Text += Environment.NewLine + "Записей не обработано: " + NonResponseRowCount.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
