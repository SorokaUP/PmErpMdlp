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
using PMMarkingUI.Forms;
using PMMarkingUI.Classes;
using PMMarkingUI.Delegats;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace PMMarkingUI.Views.Filters
{
    public partial class GridFilterView : UserControl
    {
        private GridView View;
        public GridFilterView()
        {
            InitializeComponent();
        }

        public void SetGridView(GridView View)
        {
            this.View = View;

            List<SerchColumn> Cols = new List<SerchColumn>();
            foreach (GridColumn gc in View.Columns)
            {
                if (!gc.Visible || gc.ColumnEdit != null)
                    continue;

                SerchColumn col = new SerchColumn();
                col.Name = gc.FieldName;
                col.Text = gc.Caption;
                col.AbsoluteIndex = gc.AbsoluteIndex;
                Cols.Add(col);
            }

            cbSerchColumn.DataSource = Cols;
            cbSerchColumn.ValueMember = "Name";
            cbSerchColumn.DisplayMember = "Text";
        }

        public void SetColumn(string FieldName)
        {
            for (int i = 0; i < cbSerchColumn.Items.Count; i++)
            {
                if (((SerchColumn)cbSerchColumn.Items[i]).Name == FieldName)
                {
                    cbSerchColumn.SelectedIndex = i;
                    return;
                }
            }
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            string ColName = cbSerchColumn.SelectedValue.ToString();
            string SerchText = (cbxSerch_Like.Checked) ? $"%{tbSerchText.Text}%" : tbSerchText.Text;
            List<SerchColumn> Cols = cbSerchColumn.DataSource as List<SerchColumn>;
            View.SetFilter(Cols, ColName, SerchText);
        }

        private void tbSerchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSerch_Click(sender, null);
            }
        }
    }
}
