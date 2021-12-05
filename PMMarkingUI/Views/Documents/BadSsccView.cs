using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PMMarkingUI.Delegats;
using PMMarkingUI.Forms;
using PMMarkingUI.Classes;
using ProfitMed.DataContract;
using ProfitMed.Firebird;

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace PMMarkingUI.Views.Documents
{
    public partial class BadSsccView : UserControl
    {
        Label background;
        public BadSsccView()
        {
            InitializeComponent();
            Text = "Коробки без содержимого";
            Tag = true;
            vUnion.SetDefaultGridViewOptions();

            /*background.Parent = cUnion;
            background.Dock = DockStyle.Fill;
            background.BringToFront();
            background.TextAlign = ContentAlignment.MiddleCenter;
            background.Font = new Font(background.Font.FontFamily, 16);
            background.Text = "Нажмите кнопку \"Обновить список\"";*/
        }

        private void tsmiRefresh_Click(object sender, EventArgs e)
        {
            //background.Visible = false;
            RefreshList();
        }

        private void RefreshList()
        {
            cUnion.DataSource = DAO.GetSsccWithoutInfo(0);
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in vUnion.GetFilteredRows())
            {
                row["HANDLE_SELECT"] = 1;
            }
        }

        private void снятьВыделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in (vUnion.DataSource as DataTable).Rows)
            {
                row["HANDLE_SELECT"] = 0;
            }
        }

        private void tsmiAction_220_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сформировать документы о получении информации о коробке SSCC (220)", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool isExpress = MessageBox.Show("Хотите отправить документ в МДЛП сразу после его создания?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                //System.Threading.Thread readThread = new System.Threading.Thread(() => { ThreadQueryKiz(isExpress); });
                //readThread.Start();
                ThreadQueryKiz(isExpress);
            }
        }

        public event OnWorkIsDoneHandler OnWorkIsDone; // Событие окна: завершение потока чтения.
        public delegate void RefreshSscc();
        public void ThreadQueryKiz(bool isExpress)
        {
            using (frmProccess process = new frmProccess())
            {
                List<DataRow> rows = vUnion.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
                int doc_id = -1;
                foreach (DataRow row in rows)
                {
                    if (doc_id == -1)
                    {
                        doc_id = (int)row["DOC_ID"];
                        continue;
                    }

                    if (doc_id != (int)row["DOC_ID"] || doc_id == 0)
                    {
                        MessageBox.Show("Выбранные SSCC должны принадлежать одному документу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                process.progressBarControl.Properties.Maximum = rows.Count();
                process.Show();
                Application.DoEvents();
                List<string> ssccList = new List<string>();
                foreach (DataRow row in rows)
                {
                    string sscc = row["SSCC"].ToString();
                    if (!ssccList.Contains(sscc))
                        ssccList.Add(sscc);
                }
                Additional.dGetInfoByKIZ += () => {
                    process.progressBarControl.Position++;
                    Application.DoEvents();
                };
                Additional.GetInfoByKIZ(doc_id, ssccList, isExpress);
                process.Close();
            }
                
            OnWorkIsDone?.Invoke(this, EventArgs.Empty);
        }
    }
}
