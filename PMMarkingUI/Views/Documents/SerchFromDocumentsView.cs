using Sys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProfitMed.Firebird;
using PMMarkingUI.Classes;
using PMMarkingUI.Delegats;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace PMMarkingUI.Views
{
    public partial class SerchFromDocumentsView : UserControl
    {
        DelegateAddPage dAddPage;
        public SerchFromDocumentsView(DelegateAddPage dap)
        {
            InitializeComponent();
            this.Text = "Поиск по документам";
            this.Tag = true;
            tlData.Nodes.Clear();
            dAddPage += dap;
            tbValue.Focus();

            //Sys.Global.ScanerOpen();
            //Sys.Global.Scaner.DataReceived += DataReceived;
            //Scaner.SetSettingsAndOpen();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            string Value = tbValue.Text.Trim();
            if (string.IsNullOrEmpty(Value))
            {
                MessageBox.Show("Ничего не указано", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (Value.Length != 18 && Value.Length != 27)
                {
                    MessageBox.Show("SSCC (коробка) должна иметь длину 18 символов" + Environment.NewLine + "SGTIN (штучка) должна иметь длину 27 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            tlData.DataSource = new DataTable();
            tlData.LayoutChanged();

            int doc_type = Convert.ToInt32(beDocType.Tag ?? 0);
            DataTable res = DAO.SerchFromDocuments(Sys.Global.USER_ID, Value, (cbxIsRegister.Checked ? 1 : 0), (cbxIsSerchInDocBody.Checked ? 1 : 0), doc_type);
            if (res.Rows.Count == 0)
            {
                MessageBox.Show("Ничего найти не удалось", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Выполнено");
            }

            tlData.DataSource = res;
            tlData.ExpandAll();
        }

        private void tlData_RowCellClick(object sender, DevExpress.XtraTreeList.RowCellClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                DataRow row = e.Node.GetDataSourceRow();
                if (row != null)
                {
                    try
                    {
                        object doc_id = row["DOC_ID"];
                        if (doc_id != null)
                        {
                            dAddPage(new DocumentView(Convert.ToInt32(doc_id)));
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void tbValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSerch_Click(sender, null);
        }

        delegate void DelegateVoidString(string s);
        private void DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string barcode = Scaner.ReadLine();
                barcode = barcode.Trim().Replace("\r", "").Replace("\n", "");
                if (this.InvokeRequired)
                {
                    DelegateVoidString d = new DelegateVoidString(GetBarcode);
                    this?.Invoke(d, barcode);
                }
                else
                {
                    GetBarcode(barcode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void GetBarcode(string barcode)
        {
            tbValue.Text = barcode;
            btnSerch_Click(null, null);
        }

        private void настройкиСканераШтрихкодовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scaner.SetSettingsAndOpen();
        }

        private void beDocType_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            (sender as ButtonEdit).Ref(e, DAO.Ref_GetDocTypes(), "INT1", "NAME");
        }
    }
}
