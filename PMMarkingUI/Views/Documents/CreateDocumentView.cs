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

namespace PMMarkingUI.Views
{
    public partial class CreateDocumentView : UserControl
    {
        DataTable dtData;
        public CreateDocumentView()
        {
            InitializeComponent();
            this.Text = "Создание документа";
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
            rowDOC_TYPE.Ref(e, DAO.Ref_GetDocTypes(), "INT1", "NAME");
        }

        private void GetRef_Receiver(object sender, ButtonPressedEventArgs e)
        {
            frmRef frm = new frmRef("Выберите контрагента", DAO.Ref_GetCounteragents(), "SYSTEM_SUBJ_ID", "ORG_NAME", true);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                string SYS_ID = frm.Value.ToString();
                rowRECEIVER.Ref(e, DAO.Ref_GetReceiver(SYS_ID), "ID", "NAME");
            }
        }

        private void GetRef_Sender(object sender, ButtonPressedEventArgs e)
        {
            rowSENDER.Ref(e, DAO.Ref_GetSender(), "ID", "NAME");
        }

        private void tsmiActionData_Add_Click(object sender, EventArgs e)
        {
            dtData.Rows.Add(dtData.NewRow());
        }

        decimal d = 0;
        private void tsmiActionData_LoadFromExcel_Click(object sender, EventArgs e)
        {
            frmImportExcelForCreateDocument frm = new frmImportExcelForCreateDocument(CreateStructure());
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    dtData = frm.dtData;
                    CheckObjectId();
                    cData.DataSource = dtData;
                }
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
                int DocType = (int)(rowDOC_TYPE.Properties.Value ?? 0);
                if (DocType == 0)
                {
                    MessageBox.Show("Не выбран тип документа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string SenderBranchId = (string)(rowSENDER.Properties.Value ?? "");
                if (string.IsNullOrEmpty(SenderBranchId))
                {
                    MessageBox.Show("Не выбран отправитель", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string ReceiverBranchId = (string)(rowRECEIVER.Properties.Value ?? "");
                if (string.IsNullOrEmpty(ReceiverBranchId))
                {
                    MessageBox.Show("Не выбран получатель", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //---------------------------------------------------------
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

                // Сформировать документ
                DataTable res = DAO.ImportExcel_ForCreateDocument(DocType, SenderBranchId, ReceiverBranchId, dtData);
                // Отправить
                if (res.Rows.Count > 0)
                {
                    List<object> lst = new List<object>();
                    lst.Add("Создан документ: " + res.Rows[0]["NEW_DOC_ID"].ToString());
                    lst.Add("");
                    lst.Add(res.Rows[0]["XML_BODY"].ToString());

                    frmStringList frm = new frmStringList(lst, "Создан документ");
                    frm.ShowDialog();
                    frm.Dispose();
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
