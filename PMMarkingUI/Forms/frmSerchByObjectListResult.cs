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
    public partial class frmSerchByObjectListResult : Form
    {
        public DataTable source { get; private set; }
        public frmSerchByObjectListResult(DataTable source)
        {
            InitializeComponent();
            this.source = source;

            cData.DataSource = this.source;
            vData.LayoutChanged();
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in vData.GetFilteredRows())
            {
                row["HANDLE_SELECT"] = 1;
            }
        }

        private void снятьВыделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in (cData.DataSource as DataTable).Rows)
            {
                row["HANDLE_SELECT"] = 0;
            }
        }

        private class SsccInfoData
        {
            public int doc_id { get; set; }
            public string sscc { get; set; }
        }

        private void разагрегироватьВыбранныеКоробкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Разагрегировать выбранные коробки? Действие отменить будет нельзя!", "ВНИМАНИЕ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            List<SsccInfoData> data = new List<SsccInfoData>();
            List<DataRow> SelectedRows = vData.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
            foreach (DataRow row in SelectedRows)
            {
                try
                {
                    data.Add(new SsccInfoData { doc_id = (int)row["DOC_ID"], sscc = row["OBJECT_ID"].ToString() });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (data.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одного документа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmProccess process = new frmProccess();
            process.progressBarControl.Properties.Maximum = data.Count;
            process.Show();
            Application.DoEvents();

            string err = "";
            try
            {
                // В случае, если небыло выбрано ни одной коробки, передаем все
                foreach (SsccInfoData item in data)
                {
                    int doc_id = ProfitMed.Firebird.DAO.CreateOutcomeDocument(item.doc_id, 912, null, item.sscc, null, null, 1);
                    WebMethods.DocumentSend(Sys.Global.DataProvider.GetDocBody(doc_id), doc_id, false);
                    process.progressBarControl.Position++;
                    Application.DoEvents();
                }
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            process.Close();
            MessageBox.Show(string.IsNullOrEmpty(err) ? "Выполнено успешно." : "Ошибка: " + err);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
