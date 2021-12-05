using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using PMMarkingUI.Forms;
using PMMarkingUI.Classes;
using PMMarkingUI.Delegats;
using Sys;
using ProfitMed.Firebird;

namespace PMMarkingUI.Views
{
    public partial class DocFilterDbAgencyContractView : UserControl
    {
        public event DelegateGetDocFilterDbAgency eGetFilter;
        public event DelegateCloseFilterRuntime eCloseFilterRuntime;
        public DocFilterDbAgencyContractView() : this(null)
        { }

        public DocFilterDbAgencyContractView(DelegateGetDocFilterDbAgency d)
        {
            InitializeComponent();
            dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            SetDelegate(d);
        }

        public void SetDelegate(DelegateGetDocFilterDbAgency d)
        {
            eGetFilter = d;
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            GetFilter();
        }

        public DocFilterDbAgency GetFilter()
        {
            DocFilterDbAgency res = new DocFilterDbAgency();
            res.FromDate = dtpFrom.Value;
            res.ToDate = dtpTo.Value;
            res.LID = Convert.ToInt32(beCounteragent.Tag);
            res.Concept = Convert.ToInt32(beConcept.Tag);

            // Вызываем событие по делегату (frmMain)
            eGetFilter(res);
            eCloseFilterRuntime?.Invoke();
            return res;
        }

        private void GetRef_Counteragent(object sender, ButtonPressedEventArgs e)
        {
            (sender as ButtonEdit).Ref(e, DAO.Ref_GetCounteragentsTwAgencySel(), "LID", "NAME");
        }

        private void GetRef_Concept(object sender, ButtonPressedEventArgs e)
        {
            (sender as ButtonEdit).Ref(e, DAO.Ref_GetTwConceptDocs(), "KID", "KNAME");
        }
    }
}
