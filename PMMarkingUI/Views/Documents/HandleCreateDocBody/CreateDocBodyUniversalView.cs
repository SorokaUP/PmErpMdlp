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
    public partial class CreateDocBodyUniversalView : UserControl
    {
        DataTable dtData;
        public int ShemaNum { get; private set; }
        Label background = new Label();
        public CreateDocBodyUniversalView()
        {
            InitializeComponent();
            this.Text = $"Создание документа по схеме";
            this.Tag = false;

            ActionChangeDocType(null, null);
        }

        #region СТРУКТУРА
        private void SetStructure(int ShemaNum)
        {
            this.Text = $"Создание документа по схеме {ShemaNum}";
            this.ShemaNum = ShemaNum;

            // Шапка
            CreateStructureHeader();

            // Строки
            CreateStructureLines();
        }

        private void CreateStructureLines()
        {
            dtData = new DataTable();
            dtData.Columns.Add(new DataColumn { ColumnName = "HANDLE_SELECT", DataType = typeof(int), Caption = "Выбрать", DefaultValue = 0 });
            dtData.Columns.Add(new DataColumn { ColumnName = "OBJECT_ID", DataType = typeof(string), Caption = "Код SSCC/SGTIN" });

            // Согласно схеме
            switch (ShemaNum)
            {
                case 415:
                    dtData.Columns.Add(new DataColumn { ColumnName = "COST", DataType = typeof(decimal), Caption = "Цена с НДС", DefaultValue = 0 });
                    dtData.Columns.Add(new DataColumn { ColumnName = "VAT_VALUE", DataType = typeof(decimal), Caption = "НДС", DefaultValue = 0 });
                    break;
            }

            vData.SetDefaultGridViewOptions();
            vData.Columns.Clear();
            cData.DataSource = dtData;
            vData.LayoutChanged();
            vData.Columns["HANDLE_SELECT"].ColumnEdit = riCheckBox;
            vData.Columns["OBJECT_ID"].Width = 300;
            vData.CheckBoxesPost();

            GC.Collect();
        }

        private void CreateStructureHeader()
        {
            vGridControl.Rows.Clear();

            switch (this.ShemaNum)
            {
                case 415:
                    vGridControl.Rows.Add(CreateVGCRow("subject_id", "Отправитель (subject_id)", riComboBox_MD));
                    vGridControl.Rows.Add(CreateVGCRow("receiver_id", "Получатель (receiver_id)", riComboBox_MD));
                    vGridControl.Rows.Add(CreateVGCRow("operation_date", "Дата совершения операции (operation_date)", riDateTimeEdit, false));
                    vGridControl.Rows.Add(CreateVGCRow("doc_num", "Номер документа (doc_num)", null));
                    vGridControl.Rows.Add(CreateVGCRow("doc_date", "Дата документа (doc_date)", riDateEdit));
                    vGridControl.Rows.Add(CreateVGCRow("turnover_type", "Вид операции отгрузки (turnover_type)", riComboBox_turnover_type));
                    vGridControl.Rows.Add(CreateVGCRow("source", "Источник финансирования (source)", riComboBox_source));
                    vGridControl.Rows.Add(CreateVGCRow("contract_type", "Тип договора (contract_type)", riComboBox_contract_type));
                    vGridControl.Rows.Add(CreateVGCRow("contract_num", "Номер договора (contract_num)", null));
                    break;

                case 701:
                    vGridControl.Rows.Add(CreateVGCRow("subject_id", "Отправитель (subject_id)", riComboBox_MD));
                    vGridControl.Rows.Add(CreateVGCRow("counterparty_id", "Получатель (counterparty_id)", riComboBox_MD));
                    vGridControl.Rows.Add(CreateVGCRow("operation_date", "Дата совершения операции (operation_date)", riDateTimeEdit, false));
                    break;

                case 472:
                    vGridControl.Rows.Add(CreateVGCRow("subject_id", "Отправитель (subject_id)", riComboBox_MD));
                    vGridControl.Rows.Add(CreateVGCRow("receiver_id", "Получатель (receiver_id)", riComboBox_MD));
                    vGridControl.Rows.Add(CreateVGCRow("operation_date", "Дата совершения операции (operation_date)", riDateTimeEdit, false));
                    vGridControl.Rows.Add(CreateVGCRow("doc_num", "Номер документа (doc_num)", null));
                    vGridControl.Rows.Add(CreateVGCRow("doc_date", "Дата документа (doc_date)", riDateEdit));
                    break;

                case 702:
                    vGridControl.Rows.Add(CreateVGCRow("subject_id", "Отправитель (subject_id)", riComboBox_MD));
                    vGridControl.Rows.Add(CreateVGCRow("inn", "ИНН грузоотправителя (inn)", null));
                    vGridControl.Rows.Add(CreateVGCRow("kpp", "КПП грузоотправителя (kpp)", null));
                    vGridControl.Rows.Add(CreateVGCRow("operation_date", "Дата совершения операции (operation_date)", riDateTimeEdit, false));
                    vGridControl.Rows.Add(CreateVGCRow("doc_num", "Номер документа (doc_num)", null));
                    vGridControl.Rows.Add(CreateVGCRow("doc_date", "Дата документа (doc_date)", riDateEdit));
                    vGridControl.Rows.Add(CreateVGCRow("contract_type", "Тип договора (contract_type)", riComboBox_contract_type));
                    vGridControl.Rows.Add(CreateVGCRow("source", "Источник финансирования (source)", riComboBox_source));
                    vGridControl.Rows.Add(CreateVGCRow("contract_num", "Номер договора (contract_num)", null));
                    break;
            }
        }

        private DevExpress.XtraVerticalGrid.Rows.EditorRow CreateVGCRow(string Name, string Caption, RepositoryItem RowEdit, bool Visible = true)
        {
            DevExpress.XtraVerticalGrid.Rows.EditorRow res = new DevExpress.XtraVerticalGrid.Rows.EditorRow { Name = Name };
            res.Properties.Caption = Caption;
            res.Properties.RowEdit = RowEdit;
            res.Visible = Visible;

            return res;
        }
        #endregion
        #region ДЕЙСТВИЯ
        private void ActionChangeDocType(object sender, EventArgs e)
        {
            frmRef frm = new frmRef("", DAO.Ref_GetDocTypes(), "INT1", "NAME", true);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                SetStructure((int)frm.Value);
            }
        }

        private void ActionAdd(object sender, EventArgs e)
        {
            dtData.Rows.Add(dtData.NewRow());
        }

        private void ActionDel(object sender, EventArgs e)
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

        private void ActionClear(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите очистить все строки?", "ВНИМАНИЕ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtData.Rows.Clear();
            }
        }

        private void ActionLoadFromExcel(object sender, EventArgs e)
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
        #endregion
        #region ВСПОМОГАТЕЛЬНЫЕ
        /// <summary>
        /// Получить строковое значение из строки vGridControl
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="isOnlyOneWord"></param>
        /// <returns></returns>
        private string GetStringFromObject(object obj, bool isOnlyOneWord)
        {
            string s = obj == null ? "" : obj.ToString();
            s = s.Trim();
            if (isOnlyOneWord)
                if (s.IndexOf(" ") > 0)
                    s = s.Substring(0, s.IndexOf(" "));

            return s;
        }

        /// <summary>
        /// Сформировать формат строки для шапки документа
        /// </summary>
        /// <param name="obj_name">XML-Tag</param>
        /// <param name="isOnlyOneWord"></param>
        /// <returns></returns>
        private string CreateDocLine(string obj_name, bool isOnlyOneWord = true)
        {
            if (obj_name == "operation_date")
            {
                if (vGridControl.Rows[obj_name].Properties.Value == null)
                    vGridControl.Rows[obj_name].Properties.Value = DateTime.Now;
                return $"<{obj_name}>{((DateTime)(cbxOperationDate_CurrentTimestamp.Checked ? DateTime.Now : vGridControl.Rows[obj_name].Properties.Value)).ToString("yyyy-MM-ddTHH:mm:ss")}+03:00</{obj_name}>";
            }
            else
                return $"<{obj_name}>{GetStringFromObject(vGridControl.Rows[obj_name].Properties.Value, isOnlyOneWord)}</{obj_name}>";
        }

        /// <summary>
        /// Показ строки с датой операции для ручной правки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxOperationDate_CurrentTimestamp_CheckedChanged(object sender, EventArgs e)
        {
            if (vGridControl.Rows["operation_date"] != null)
                vGridControl.Rows["operation_date"].Visible = !cbxOperationDate_CurrentTimestamp.Checked;
        }

        /// <summary>
        /// Сформировать формат строки для Табличной части
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private string CreateOrderLine(DataRow row)
        {
            string res = "";
            try
            {
                string object_id = row["OBJECT_ID"].ToString();

                if (arrDetail_CostVat.Contains(this.ShemaNum))
                {
                    if (object_id.Length == 18)
                        res = $"<union><sscc_detail><sscc>{object_id}</sscc></sscc_detail><cost>{row["COST"].ToString().Replace(",", ".").Replace(" ", "")}</cost><vat_value>{row["VAT_VALUE"].ToString().Replace(",", ".").Replace(" ", "")}</vat_value></union>";
                    if (object_id.Length == 27)
                        res = $"<union><sgtin>{object_id}</sgtin><cost>{FormatDecimal(row["COST"].ToString())}</cost><vat_value>{FormatDecimal(row["VAT_VALUE"].ToString())}</vat_value></union>";
                }

                if (arrDetail.Contains(this.ShemaNum))
                {
                    if (object_id.Length == 18)
                        res = $"<sscc>{object_id}</sscc>";
                    if (object_id.Length == 27)
                        res = $"<sgtin>{object_id}</sgtin>";
                }
            }
            catch
            {
                res = "";
            }
            return res;
        }
        int[] arrDetail_CostVat = new int[] { 415, 702 };
        int[] arrDetail = new int[] { 701, 472 };

        /// <summary>
        /// Форматировать строку под Decimal тип
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private string FormatDecimal(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "0.00";
            }
            s = s.Replace(",", ".").Replace(" ", "");
            if (string.IsNullOrEmpty(s))
                s = "0.00";
            return s;
        }
        #endregion

        private void ActionCreateDocument(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сформировать документ?", "ВНИМАНИЕ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string docTag = "";
                switch (this.ShemaNum)
                {
                    case 415:
                        docTag = "move_order";
                        break;

                    case 701:
                        docTag = "accept";
                        break;

                    case 472:
                        docTag = "agent_dispatch";
                        break;

                    case 702:
                        docTag = "posting";
                        break;
                }

                List<object> lst = new List<object>();

                lst.Add($"<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                lst.Add($"<documents session_ui=\"{System.Guid.NewGuid()}\" version=\"1.35\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">");
                lst.Add($"	<{docTag} action_id=\"{this.ShemaNum}\">");
                switch (this.ShemaNum)
                {
                    case 415:
                        lst.Add($"      {CreateDocLine("subject_id")}");
                        lst.Add($"      {CreateDocLine("receiver_id")}");
                        lst.Add($"      {CreateDocLine("operation_date")}");
                        lst.Add($"      {CreateDocLine("doc_num")}");
                        lst.Add($"      {CreateDocLine("doc_date")}");
                        lst.Add($"      {CreateDocLine("turnover_type")}");
                        lst.Add($"      {CreateDocLine("source")}");
                        lst.Add($"      {CreateDocLine("contract_type")}");
                        lst.Add($"      {CreateDocLine("contract_num", false)}");
                        break;

                    case 701:
                        lst.Add($"      {CreateDocLine("subject_id")}");
                        lst.Add($"      {CreateDocLine("counterparty_id")}");
                        lst.Add($"      {CreateDocLine("operation_date")}");
                        break;

                    case 472:
                        lst.Add($"      {CreateDocLine("subject_id")}");
                        lst.Add($"      {CreateDocLine("receiver_id")}");
                        lst.Add($"      {CreateDocLine("operation_date")}");
                        lst.Add($"      {CreateDocLine("doc_num")}");
                        lst.Add($"      {CreateDocLine("doc_date")}");
                        break;

                    case 702:
                        lst.Add($"      {CreateDocLine("subject_id")}");
                        lst.Add($"      <shipper_info>");
                        lst.Add($"      	{CreateDocLine("inn")}");
                        lst.Add($"      	{CreateDocLine("kpp")}");
                        lst.Add($"      </shipper_info>");
                        lst.Add($"      {CreateDocLine("operation_date")}");
                        lst.Add($"      {CreateDocLine("doc_num")}");
                        lst.Add($"      {CreateDocLine("doc_date")}");
                        lst.Add($"      {CreateDocLine("contract_type")}");
                        lst.Add($"      {CreateDocLine("source")}");
                        lst.Add($"      {CreateDocLine("contract_num", false)}");
                        break;
                }
                lst.Add($"      <order_details>");
                foreach (DataRow row in dtData.Rows)
                {
                    lst.Add($"          {CreateOrderLine(row)}");
                }
                lst.Add($"      </order_details>");
                lst.Add($"  </{docTag}>");
                lst.Add($"</documents>");

                Forms.Documents.frmCreateDocumentHandle frm = new Forms.Documents.frmCreateDocumentHandle(lst);
                frm.ShowDialog();
                frm.Dispose();
            }
        }

        // This event is generated by Data Source Configuration Wizard
        void unboundSource1_ValueNeeded(object sender, DevExpress.Data.UnboundSourceValueNeededEventArgs e)
        {

            // Handle this event to obtain data from your data source
            // e.Value = something /* TODO: Assign the real data here.*/
        }

        // This event is generated by Data Source Configuration Wizard
        void unboundSource1_ValuePushed(object sender, DevExpress.Data.UnboundSourceValuePushedEventArgs e)
        {

            // Handle this event to save modified data back to your data source
            // something = e.Value; /* TODO: Propagate the value into the storage.*/
        }
    }
}
