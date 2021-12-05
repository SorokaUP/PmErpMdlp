using System;
using System.Linq;
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
    public partial class GtdFilterView : UserControl
    {
        public event DelegateGetGtdFilter eGetFilter;
        public event DelegateCloseFilterRuntime eCloseFilterRuntime;

        public GtdFilterView() : this(null)
        { }

        public GtdFilterView(DelegateGetGtdFilter d)
        {
            InitializeComponent();
            SetDelegate(d);
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            GetFilter();
        }

        public void SetDelegate(DelegateGetGtdFilter d)
        {
            eGetFilter = d;
        }

        public InvoiceFilter GetFilter()
        {
            InvoiceFilter res = new InvoiceFilter();
            res.FromDate = dtBegin.Value;//dateNavigator.SelectedRanges.Start;
            res.ToDate = dtEnd.Value;//dateNavigator.SelectedRanges.End.AddDays(-1);
            res.Counteragent = Convert.ToString(beCounteragent.Tag);

            // Вызываем событие по делегату (frmMain)
            eGetFilter(res);
            eCloseFilterRuntime?.Invoke();
            return res;
        }

        private void GetRef_Counteragent(object sender, ButtonPressedEventArgs e)
        {
            (sender as ButtonEdit).Ref(e, DAO.Ref_GetCounteragentsSel(), "SYSTEM_SUBJ_ID", "ORG_NAME");
        }
    }
}
