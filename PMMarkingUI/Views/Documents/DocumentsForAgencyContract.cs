using System;
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

namespace PMMarkingUI.Views
{
    public partial class DocumentsForAgencyContract : UserControl
    {
        DocFilterDbAgency docFilter;
        public DocumentsForAgencyContract()
        {
            InitializeComponent();
            this.Text = "Документы по агентскому договору";
            docFilterDbPanel.SetDelegate(GetFilter);
            docFilterDbPanel.gbConcept.Visible = true;
            docFilterDbPanel.gbCounteragent.Visible = true;
            vDocs.SetDefaultGridViewOptions();
        }

        private void GetFilter(DocFilterDbAgency docFilter)
        {
            this.docFilter = docFilter;
            Refresh_Docs();
        }

        public void Refresh_Docs()
        {
            try
            {
                cDocs.DataSource = DAO.GetTWDocumentsForAgencyContract(
                    Sys.Global.USER_ID,
                    docFilter.FromDate,
                    docFilter.ToDate,
                    docFilter.LID,
                    docFilter.Concept);
            }
            catch (Exception ex) { cDocs.DataSource = new DataTable(); }
            vDocs.LayoutChanged();
        }

        int currDid = 0;
        public void Refresh_Lines()
        {
            try
            {
                DataRow row = vDocs.GetDataSourceRow();
                int doc_id = (row != null) ? (int)row["SGD_DID"] : 0;

                if (currDid != doc_id)
                    cLines.DataSource = DAO.GetTWDocumentLinesForAgencyContract(doc_id);
            }
            catch (Exception ex) { cLines.DataSource = new DataTable(); }
            vLines.LayoutChanged();
        }

        private void vDocs_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Refresh_Lines();
        }
    }
}
