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

namespace PMMarkingUI.Views
{
    public partial class WebMethodsView : UserControl
    {
        DataTable data;
        string Table = "TBL_METHODS";
        public WebMethodsView()
        {
            InitializeComponent();
            this.Text = "Справочник: МДЛП Методы";

            RefreshData();
        }

        private void RefreshData()
        {
            data = DAO.GetWebMethods(0);
            cMethods.DataSource = data;
            vMethods.LayoutChanged();
        }

        private void UpdateRow(DataRow row)
        {
            string query = "";
            foreach (DataColumn col in row.Table.Columns)
            {
                if (col.ColumnName == "ID")
                    continue;
                string val = row[col.ColumnName].ToString();                
                if ((col.DataType == typeof(string)))
                {
                    val = "'" + val.Replace("'", "''") + "'";
                }
                if ((col.DataType == typeof(decimal) || col.DataType == typeof(double) || col.DataType == typeof(float)))
                {
                    val = val.Replace(",", ".");
                }
                query += (query == "") ? "" : ", ";
                query += col.ColumnName + " = " + val;
            }
            DAO.ExecuteQuery($"update {Table} set {query} where ID = {row["ID"]}");
        }

        private void InsertRow(DataRow row)
        {
            string columns = "";
            string datas = "";
            foreach (DataColumn col in row.Table.Columns)
            {
                if (col.ColumnName == "ID")
                    continue;
                columns += ((columns == "") ? "" : ", ") + col.ColumnName;

                string val = row[col.ColumnName].ToString();
                if ((col.DataType == typeof(string)))
                {
                    val = "'" + val.Replace("'", "''") + "'";
                }
                if ((col.DataType == typeof(decimal) || col.DataType == typeof(double) || col.DataType == typeof(float)))
                {
                    val = val.Replace(",", ".");
                }
                datas += ((datas == "") ? "" : ", ") + val;
            }
            DAO.ExecuteQuery($"insert into {Table} ({columns}) values ({datas})");
            RefreshData();
        }

        private void DeleteRow(DataRow row)
        {
            DAO.ExecuteQuery($"delete from {Table} where ID = {row["ID"]}");
        }

        private void vMethods_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DataRowView drv = (e.Row as DataRowView);
            switch (drv.Row.RowState)
            {
                case DataRowState.Added:
                    InsertRow(drv.Row);
                    break;

                case DataRowState.Modified:
                    UpdateRow(drv.Row);
                    break;
            }   
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vMethods.DeleteSelectedRows();
        }

        private void vMethods_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            DeleteRow(vMethods.GetDataRow(e.RowHandle));
        }

        private void обновитьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
