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

namespace PMMarkingUI.Views
{
    public partial class GenerateXmlOrderDetailView : UserControl
    {
        DataTable dtData;
        public GenerateXmlOrderDetailView()
        {
            InitializeComponent();
            this.Text = "Генерация order_detail части XML документа";
            this.Tag = false;

            dtData = CreateStructure();

            vData.SetDefaultGridViewOptions();
            vData.CheckBoxesPost();
            cData.DataSource = dtData;
            //vGridControl.SetReadOnlyVGridRows();

            rilueDocType.ButtonClick += GetRef_DocType;
            rilueSender.ButtonClick += GetRef_Sender;
            rilueReceiver.ButtonClick += GetRef_Receiver;
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

        private void GetRef_DocType(object sender, ButtonPressedEventArgs e)
        {
            (sender as LookUpEdit).Ref(e, DAO.Ref_GetDocTypes(), "INT1", "NAME");
        }

        private void GetRef_Receiver(object sender, ButtonPressedEventArgs e)
        {
            frmRef frm = new frmRef("Выберите контрагента", DAO.Ref_GetCounteragents(), "SYSTEM_SUBJ_ID", "ORG_NAME", true);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                string SYS_ID = frm.Value.ToString();
                (sender as LookUpEdit).Ref(e, DAO.Ref_GetReceiver(SYS_ID), "ID", "NAME");
            }
        }

        private void GetRef_Sender(object sender, ButtonPressedEventArgs e)
        {
            (sender as LookUpEdit).Ref(e, DAO.Ref_GetSender(), "ID", "NAME");
        }

        private void tsmiActionData_Add_Click(object sender, EventArgs e)
        {
            dtData.Rows.Add(dtData.NewRow());
        }

        decimal d = 0;
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
            if (MessageBox.Show("Сгенерировать order_detail часть XML документа?", "ВНИМАНИЕ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CheckObjectId();
                foreach (DataRow row in dtData.Rows)
                {
                    if ((int)row["IS_BALANCE"] != 1)
                    {
                        MessageBox.Show("Данные документа заполнены с ошибками", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //---------------------------------------------------------

                decimal cost = Convert.ToDecimal(rowCOST.Properties.Value ?? 0);
                decimal vat_value = Convert.ToDecimal(rowVAT_VALUE.Properties.Value ?? 0);

                // Сформировать документ
                DataTable res = DAO.GenerateOrderDetailXml(cost, vat_value, dtData);
                if (res.Rows.Count > 0)
                {
                    List<object> lst = new List<object>();
                    foreach (DataRow row in res.Rows)
                    {
                        lst.Add(row["RES"]);
                    }
                    using (frmStringList frm = new frmStringList(lst, "order_detail часть XML документа"))
                    {
                        frm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Данных не получено", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CheckObjectId()
        {
            foreach (DataRow row in dtData.Rows)
            {
                row["OBJECT_ID"] = row["OBJECT_ID"].ToString().Trim();
                object[] res = DAO.CheckObjectIdByBalance(row["OBJECT_ID"].ToString());
                if (res.Length > 0)
                {
                    row["IS_BALANCE"] = (int)res[0];
                    if ((int)res[0] != 1)
                        row["MSG"] = res[1];
                }
            }
        }

        private void tsmiActionData_Check_Click(object sender, EventArgs e)
        {
            CheckObjectId();
            MessageBox.Show("Проверка окончена");
        }
    }
}
