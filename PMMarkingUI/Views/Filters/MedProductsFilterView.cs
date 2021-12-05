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
    public partial class MedProductsFilterView : UserControl
    {
        public event DelegateGetGtinFilter dGetFilter;
        public DelegateGetGtinFilter DelegateGetGtinFilter { get; set; }
        string defAlias = "mdlp";
        public MedProductsFilterView()
        {
            InitializeComponent();
        }

        public void SetDelegate(DelegateGetGtinFilter d)
        {
            this.DelegateGetGtinFilter = d;
            dGetFilter = DelegateGetGtinFilter;
        }

        public Filters<MedProductsFilter> GetFilter()
        {
            MedProductsFilter filter = new MedProductsFilter();
            filter.gtin = tbGtin.Text;
            filter.reg_date_from = dtpFrom.Value.ToString("yyyy-MM-dd");
            filter.reg_date_to = dtpTo.Value.ToString("yyyy-MM-dd");
            filter.drug_code = tbDrugCode.Text;
            filter.glf_name = tbGlfName.Text;
            filter.reg_holder = tbRegHolder.Text;
            filter.prod_sell_name = tbProdSellName.Text;
            filter.reg_id = tbRegId.Text;
            filter.gnvlp = cbxGnvlp.Checked;
            filter.vzn_drug = cbxVznDrug.Checked;

            /*if (beReceiverId.Tag != null)
                filter.receiver_id = Convert.ToString(beReceiverId.Tag);*/

            Filters<MedProductsFilter> gtinFilters = new Filters<MedProductsFilter>
            {
                filter = filter,
                start_from = 0,
                count = 2
            };

            // Вызываем событие по делегату
            //dGetFilter(gtinFilters);
            return gtinFilters;
        }

        private void GetRef_UploadType(object sender, ButtonPressedEventArgs e)
        {
            (sender as ButtonEdit).Ref(e, DAO.Ref_GetFileUploadTypes(), "INT1", "NAME");
        }
    }
}
