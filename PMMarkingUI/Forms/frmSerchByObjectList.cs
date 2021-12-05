using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMMarkingUI.Forms;
using PMMarkingUI.Classes;
using ProfitMed.Firebird;
using ProfitMedServiceClient;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Sys;
using ExcelDataReader;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraVerticalGrid.Rows;

namespace PMMarkingUI.Forms
{
    public partial class frmSerchByObjectList : Form
    {
        DataTable dtData;
        public frmSerchByObjectList()
        {
            InitializeComponent();
            CreateStructureLines();
        }

        private void CreateStructureLines()
        {
            dtData = new DataTable();
            dtData.Columns.Add(new DataColumn { ColumnName = "HANDLE_SELECT", DataType = typeof(int), Caption = "Выбрать", DefaultValue = 0 });
            dtData.Columns.Add(new DataColumn { ColumnName = "OBJECT_ID", DataType = typeof(string), Caption = "Код SSCC/SGTIN" });

            vData.SetDefaultGridViewOptions();
            vData.Columns.Clear();
            cData.DataSource = dtData;
            vData.LayoutChanged();
            vData.Columns["HANDLE_SELECT"].ColumnEdit = riCheckBox;
            vData.Columns["OBJECT_ID"].Width = 300;
            vData.CheckBoxesPost();

            GC.Collect();
        }

        private void tsmiActionData_Clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите очистить все строки?", "ВНИМАНИЕ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtData.Rows.Clear();
            }
        }

        private void tsmiActionData_Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите удалить выделенные строки?", "ВНИМАНИЕ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                List<DataRow> SelectedRows = vData.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
                foreach (DataRow row in SelectedRows)
                {
                    dtData.Rows.Remove(row);
                }
            }
        }

        private void tsmiActionData_LoadFromExcel_Click(object sender, EventArgs e)
        {
            frmImportExcelForCreateDocument frm = new frmImportExcelForCreateDocument(dtData);
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    dtData = frm.dtData;
                    cData.DataSource = dtData;
                }
            }
        }

        private void tsmiActionData_Add_Click(object sender, EventArgs e)
        {
            dtData.Rows.Add(dtData.NewRow());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int objectLen = -1;
            int[] lim = new int[] { 18, 27 };
            List<string> objectList = new List<string>();
            foreach (DataRow row in dtData.Rows)
            {
                string object_id = row["OBJECT_ID"].ToString().Trim();
                if (objectLen < 0)
                {
                    objectLen = object_id.Length;
                    if (!lim.Contains(objectLen))
                    {
                        MessageBox.Show("Список объектов должен содержать только SSCC или SGTIN.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    if (objectLen != object_id.Length || !lim.Contains(object_id.Length))
                    {
                        MessageBox.Show("Список объектов должен содержать только SSCC или SGTIN. Одновременно нельзя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                objectList.Add(object_id);
            }
            string mode = objectLen == 18 // Обратная логика
                ? "SGTIN" // По списку КОРОБОК найти СОДЕРЖИМОЕ
                : "SSCC"; // По списку СОДЕРЖИМОГО найти КОРОБКИ
            try
            {
                DataTable res = DAO.SerchByObjectList(mode, objectList);
                if (res.Rows.Count > 0)
                {
                    if (mode == "SSCC")
                    {
                        frmSerchByObjectListResult frmResSscc = new frmSerchByObjectListResult(res);
                        frmResSscc.ShowDialog();
                    }
                    if (mode == "SGTIN")
                    {
                        List<object> resList = new List<object>();
                        foreach (DataRow row in res.Rows)
                        {
                            resList.Add(row["OBJECT_ID"].ToString());
                        }
                        frmStringList frmResSgtin = new frmStringList(resList, "Результат");
                        frmResSgtin.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Данные не получены.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
