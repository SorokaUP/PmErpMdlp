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

namespace PMMarkingUI.Views.Documents.HandleCreateDocBody
{
    public partial class CreateDocBody415View : UserControl
    {
        DataTable dtData;
        public CreateDocBody415View()
        {
            InitializeComponent();
            this.Text = "Создание документа 415";
            this.Tag = false;

            dtData = CreateStructure();

            vData.SetDefaultGridViewOptions();
            vData.CheckBoxesPost();
            cData.DataSource = dtData;
            //vGridControl.SetReadOnlyVGridRows();
        }

        private void tsmiActionData_Add_Click(object sender, EventArgs e)
        {
            dtData.Rows.Add(dtData.NewRow());
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

        private void tsmiActionData_Clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите очистить все строки?", "ВНИМАНИЕ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtData.Rows.Clear();
            }
        }

        private void tsmiActionDoc_Create_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сформировать документ?", "ВНИМАНИЕ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                List<object> lst = new List<object>();

                lst.Add($"<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                lst.Add($"<documents session_ui=\"{System.Guid.NewGuid()}\" version=\"1.35\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">");
                lst.Add($"	<move_order action_id=\"415\">");
                lst.Add($"      <subject_id>{GetStringFromObject(subject_id.Properties.Value)}</subject_id>");
                lst.Add($"      <receiver_id>{GetStringFromObject(receiver_id.Properties.Value)}</receiver_id>");
                lst.Add($"      <operation_date>{((DateTime)(/*operation_date.Properties.Value ?? */DateTime.Now)).ToString("yyyy-MM-ddTHH:mm:ss")}+03:00</operation_date>");
                lst.Add($"      <doc_num>{doc_num.Properties.Value ?? ""}</doc_num>");
                lst.Add($"      <doc_date>{doc_date.Properties.Value ?? ""}</doc_date>");
                lst.Add($"      <turnover_type>{(turnover_type.Properties.Value ?? "1").ToString().Substring(0,1)}</turnover_type>");
                lst.Add($"      <source>{(source.Properties.Value ?? "1").ToString().Substring(0,1)}</source>");
                lst.Add($"      <contract_type>{(contract_type.Properties.Value ?? "1").ToString().Substring(0,1)}</contract_type>");
                lst.Add($"      <contract_num>{contract_num.Properties.Value ?? "1"}</contract_num>");
                lst.Add($"      <order_details>");
                foreach (DataRow row in dtData.Rows)
                {
                    string object_id = row["OBJECT_ID"].ToString();
                    if (object_id.Length == 18)
                        lst.Add($"          <union><sscc_detail><sscc>{object_id}</sscc></sscc_detail><cost>{row["COST"].ToString().Replace(",", ".").Replace(" ", "")}</cost><vat_value>{row["VAT_VALUE"].ToString().Replace(",", ".").Replace(" ", "")}</vat_value></union>");
                    if (object_id.Length == 27)
                        lst.Add($"          <union><sgtin>{object_id}</sgtin><cost>{row["COST"].ToString().Replace(",",".").Replace(" ","")}</cost><vat_value>{row["VAT_VALUE"].ToString().Replace(",", ".").Replace(" ", "")}</vat_value></union>");
                }
                lst.Add($"      </order_details>");
                lst.Add($"  </move_order>");
                lst.Add($"</documents>");

                frmStringList frm = new frmStringList(lst, "Создан документ");
                frm.ShowDialog();
                frm.Dispose();
            }
        }

        private string GetStringFromObject(object obj)
        {
            string s = obj == null ? "" : obj.ToString();
            s = s.Trim();
            if (s.IndexOf(" ") > 0)
                s = s.Substring(0, s.IndexOf(" "));

            return s;
        }

        private void tsmiActionData_LoadFromExcel_Click(object sender, EventArgs e)
        {
            frmImportExcelForCreateDocument frm = new frmImportExcelForCreateDocument(CreateStructure());
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    dtData = frm.dtData;
                    cData.DataSource = dtData;
                }
            }
        }

        private DataTable CreateStructure()
        {
            DataTable res = new DataTable();
            res.Columns.Add("HANDLE_SELECT", typeof(int));
            res.Columns.Add("IS_BALANCE", typeof(int));
            res.Columns.Add("MSG", typeof(string));

            res.Columns.Add("OBJECT_ID", typeof(string));
            res.Columns.Add("COST", typeof(decimal));
            res.Columns.Add("VAT_VALUE", typeof(decimal));

            return res;
        }
    }
}
