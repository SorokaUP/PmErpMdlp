using System;
using System.Data;
using System.Windows.Forms;
using PMMarkingUI.Classes;

namespace PMMarkingUI.Forms
{
    public partial class frmRef : Form
    {
        public string ValueName { get; private set; }
        public object Value { get; private set; }
        string FieldValue;
        string FieldName;
        public frmRef(string caption, DataTable data, string FieldValue, string FieldName, bool isDeleteClearButton = false)
        {
            InitializeComponent();
            this.Text = "Выбор параметра: " + caption;
            this.FieldValue = FieldValue;
            this.FieldName = FieldName;
            cData.DataSource = data;
            vData.LayoutChanged();
            vData.BestFitColumns();
            if (vData.Columns.Count > 0)
            {
                vData.Columns[0].SummaryItem.FieldName = vData.Columns[0].FieldName;
                vData.Columns[0].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            }

            if (isDeleteClearButton)
            {
                btnClear.Dispose();
                tableLayoutPanel1.ColumnCount = tableLayoutPanel1.ColumnCount - 2;
            }
        }

        /// <summary>
        /// Выбрать выделенное значение
        /// </summary>
        private void SelectValue()
        {
            try
            {
                DataRow row = vData.GetDataSourceRow();
                ValueName = row[FieldName].ToString();
                Value = row[FieldValue];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ValueName = "";
                Value = null;
            }
            DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// Очистить ранее установленное значение
        /// </summary>
        private void ClearValue()
        {
            ValueName = "";
            Value = null;
            DialogResult = DialogResult.Retry;
        }

        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectValue();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearValue();
        }

        private void vData_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
                SelectValue();
        }

        private void vData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSelect_Click(sender, null);
        }

        private void vData_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
        }
    }
}
