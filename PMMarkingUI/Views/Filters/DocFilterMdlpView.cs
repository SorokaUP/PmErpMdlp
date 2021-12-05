using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ProfitMed.DataContract;
using PMMarkingUI.Forms;
using PMMarkingUI.Delegats;
using Sys;
using ProfitMed.Firebird;

namespace PMMarkingUI.Views
{
    public partial class DocFilterMdlpView : UserControl
    {
        public event DelegateGetDocFilter dGetFilter;
        public DelegateGetDocFilter DelegateGetDocFilter { get; set; }
        string defAlias = "mdlp";
        public DocFilterMdlpView()
        {
            InitializeComponent();
            dtpTo.Value = DateTime.Now;
            dtpFrom.Value = DateTime.Now.AddDays(-1);
            dtpProcessedDateFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        }

        public void SetDelegate(DelegateGetDocFilter d)
        {
            this.DelegateGetDocFilter = d;
            dGetFilter = DelegateGetDocFilter;
        }

        public DocFilters GetFilter()
        {
            DocFilter filter = new DocFilter();
            filter.start_date = dtpFrom.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
            filter.end_date = dtpTo.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
            if (beDocType.Tag != null)
                filter.doc_type = Convert.ToInt32(beDocType.Tag);
            if (beDocStatus.Tag != null)
                filter.doc_status = Convert.ToString(beDocStatus.Tag);
            if (beUploadType.Tag != null)
                filter.file_uploadtype = Convert.ToInt32(beUploadType.Tag);
            if (dtpProcessedDateFrom.Checked)
                filter.processed_date_from = dtpProcessedDateFrom.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
            if (dtpProcessedDateTo.Checked)
                filter.processed_date_to = dtpProcessedDateTo.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
            if (beSenderId.Tag != null)
                filter.sender_id = Convert.ToString(beSenderId.Tag);
            if (beReceiverId.Tag != null)
                filter.receiver_id = Convert.ToString(beReceiverId.Tag);

            DocFilters docFilters = new DocFilters
            {
                filter = filter,
                start_from = 0,
                count = 2
            };

            // Вызываем событие по делегату
            //dGetFilter(docFilters);
            return docFilters;
        }

        private void GetRef_UploadType(object sender, ButtonPressedEventArgs e)
        {
            (sender as ButtonEdit).Ref(e, DAO.Ref_GetFileUploadTypes(), "INT1", "NAME");
        }

        private void GetRef_DocType(object sender, ButtonPressedEventArgs e)
        {
            (sender as ButtonEdit).Ref(e, DAO.Ref_GetDocTypes(), "INT1", "NAME");
        }

        private void GetRef_DocStatus(object sender, ButtonPressedEventArgs e)
        {
            (sender as ButtonEdit).Ref(e, DAO.Ref_GetDocStatuses(), "NAME", "STR1");
        }

        private void GetRef_ReceiverId(object sender, ButtonPressedEventArgs e)
        {
            (sender as ButtonEdit).Ref(e, DAO.Ref_GetCounteragentsSel(), "SYSTEM_SUBJ_ID", "ORG_NAME");
        }
    }
}
