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
    public partial class DocFilterDbView : UserControl
    {
        public event DelegateGetDocFilterDb eGetFilter;
        public event DelegateCloseFilterRuntime eCloseFilterRuntime;
        int otdel_id = 0;
        int group_id = 0;
        int manager_id = 0;
        int counteragent_id = 0;
        public DocFilterDbView() : this(null)
        { }

        public DocFilterDbView(DelegateGetDocFilterDb d)
        {
            InitializeComponent();
            SetDelegate(d);
            cbeFast.SelectedIndex = -1;
        }

        public void SetDelegate(DelegateGetDocFilterDb d)
        {
            eGetFilter = d;
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            GetFilter();
        }

        public DocFilterDb GetFilter()
        {
            DocFilterDb res = new DocFilterDb();
            res.FromDate = dtBegin.Value;//dateNavigator.SelectedRanges.Start;
            res.ToDate = dtEnd.Value;//dateNavigator.SelectedRanges.End.AddDays(-1);
            res.Direction = (rbDirectionIncoming.Checked) ? 1 : -1;
            //res.IsReturned = 0;(cbxReturned.Checked) ? 1 : 0;
            res.Counteragent = Convert.ToString(beCounteragent.Tag);
            res.DocumentType = Convert.ToInt32(beDocType.Tag);
            //res.Concept = Convert.ToInt32(beConcept.Tag);

            // Вызываем событие по делегату (frmMain)
            eGetFilter(res);
            eCloseFilterRuntime?.Invoke();
            return res;
        }

        private void GetRef_Counteragent(object sender, ButtonPressedEventArgs e)
        {
            (sender as ButtonEdit).Ref(e, DAO.Ref_GetCounteragentsSel(), "SYSTEM_SUBJ_ID", "ORG_NAME");
        }

        private void GetRef_DocType(object sender, ButtonPressedEventArgs e)
        {
            (sender as ButtonEdit).Ref(e, DAO.Ref_GetDocTypes(), "INT1", "NAME");
        }

        private void GetRef_Concept(object sender, ButtonPressedEventArgs e)
        {
            (sender as ButtonEdit).Ref(e, DAO.Ref_GetTwConceptDocs(), "KID", "KNAME");
        }

        int[] OutgoingShema = new int[] { 431, 912 };
        private void cbeFast_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbeFast.SelectedIndex > -1)
            {
                try
                {
                    string item = cbeFast.Properties.Items[cbeFast.SelectedIndex].ToString();
                    int shema = Int32.Parse(item.Substring(0, item.IndexOf(" ")));
                    rbDirectionOutgoing.Checked = OutgoingShema.Contains(shema);
                    beDocType.Tag = shema;
                    beDocType.Text = $"Быстрый фильтр {shema}";
                    GetFilter();
                }
                catch (Exception ex)
                {
                    //
                }
                finally
                {
                    cbeFast.SelectedIndex = -1;
                }
            }
        }

        private void dateNavigator_CustomDrawDayNumberCell(object sender, DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventArgs e)
        {
            if (e.Date > DateTime.Now.Date)
            {
                e.Style.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void dateNavigator_SelectionChanged(object sender, EventArgs e)
        {
            dtBegin.ValueChanged -= dtBegin_ValueChanged;
            dtEnd.ValueChanged -= dtEnd_ValueChanged;
            dtBegin.Value = dateNavigator.SelectedRanges.Start;
            dtEnd.Value = dateNavigator.SelectedRanges.End.AddDays(-1);
            dtBegin.ValueChanged += dtBegin_ValueChanged;
            dtEnd.ValueChanged += dtEnd_ValueChanged;
        }

        private void dtBegin_ValueChanged(object sender, EventArgs e)
        {
            dateNavigator.SelectionChanged -= dateNavigator_SelectionChanged;
            dateNavigator.SetSelection(dtBegin.Value, dtEnd.Value);
            dateNavigator.SelectionChanged += dateNavigator_SelectionChanged;
        }

        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {
            dateNavigator.SelectionChanged -= dateNavigator_SelectionChanged;
            dateNavigator.SetSelection(dtBegin.Value, dtEnd.Value);
            dateNavigator.SelectionChanged += dateNavigator_SelectionChanged;
        }
    }
}
