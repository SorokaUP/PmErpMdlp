using System;
using System.Threading.Tasks;
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
    public partial class GTDView : UserControl
    {
        public event DelegateAddPage dapDocument;

        InvoiceFilter gtdFilter;
        public GTDView(DelegateAddPage ntp)
        {
            InitializeComponent();
            this.Tag = true;
            this.Text = "Таможенные документы";

            vInvoices.SetDefaultGridViewOptions();
            vDocs.SetDefaultGridViewOptions();

            // Передаем значение делегата в событие (frmMain)
            dapDocument = ntp;
            gtdFilterPanel.SetDelegate(GetFilter);
        }

        private void GetFilter(InvoiceFilter gtdFilter)
        {
            this.gtdFilter = gtdFilter;
            Refresh_Invoices();
        }

        private void Refresh_Invoices()
        {
            cInvoices.DataSource = DAO.GetInvoices(0, gtdFilter.FromDate, gtdFilter.ToDate, gtdFilter.Counteragent);
            vInvoices.LayoutChanged();
        }

        private void Refresh_Docs()
        {
            //cDocs.DataSource = DAO.GetInvoiceDocs(InvoiceId);
            //vDocs.LayoutChanged();
        }

        private void tsmiSelect_All_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in vInvoices.GetFilteredRows())
            {
                row["HANDLE_SELECT"] = 1;
            }
        }

        private void tsmiSelect_Unselect_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in (cInvoices.DataSource as DataTable).Rows)
            {
                row["HANDLE_SELECT"] = 0;
            }
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in vDocs.GetFilteredRows())
            {
                row["HANDLE_SELECT"] = 1;
            }
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in (cDocs.DataSource as DataTable).Rows)
            {
                row["HANDLE_SELECT"] = 0;
            }
        }
    }
}
