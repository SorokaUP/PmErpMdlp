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
    public partial class MedProductView : UserControl
    {
        public event DelegateGetGtinFilter dGetFilter;
        public DelegateGetGtinFilter DelegateGetGtinFilter { get; set; }
        string defAlias = "mdlp";
        public MedProductView()
        {
            InitializeComponent();
        }

        public void SetDelegate(DelegateGetGtinFilter d)
        {
            this.DelegateGetGtinFilter = d;
            dGetFilter = DelegateGetGtinFilter;
        }

        public Filters<MedProduct> GetFilter()
        {
            MedProduct filter = new MedProduct();
            filter.id = tbId.Text;
            filter.gtin = tbGtin.Text;
            filter.reg_status = tbRegStatus.Text;
            filter.reg_number = tbRegNumber.Text;
            filter.reg_date = dtpRegDate.Value.ToString("yyyy-MM-dd");
            filter.prod_sell_name = tbProdSellName.Text;
            filter.type_form = tbTypeForm.Text;
            filter.prod_pack_1_name = tbProdPack1Name.Text;
            filter.prod_pack_1_ed = tbProdPack1Ed.Text;
            filter.prod_pack_1_ed_name = tbProdPack1EdName.Text;
            filter.packer_address = tbPackerAdddress.Text;
            filter.min_zdrav = cbxMinZdrav.Checked;
            filter.gs1 = tbGs1.Text;
            filter.cost_limit = tbCostLim.Text;
            filter.reg_inn = tbRegInn.Text;
            //filter.pack_1 = ;
            //filter.pack_2_3 = ;
            //filter.pack_qa = ;
            filter.prod_form_name = tbProdFormName.Text;
            filter.glf_name = tbGlfName.Text;
            filter.glf_country = tbGlfCountry.Text;
            filter.vzn_drug = cbxVznDrug.Checked;
            filter.gnvlp = cbxGnvlp.Checked;
            filter.drug_code = tbDrugCode.Text;
            filter.drug_code_version = tbDrugCodeVersion.Text;
            filter.prod_d_name = tbProdDName.Text;
            filter.reg_holder = tbRegHolder.Text;
            filter.prod_name = tbProdName.Text;
            

            /*if (beReceiverId.Tag != null)
                filter.receiver_id = Convert.ToString(beReceiverId.Tag);*/

            Filters<MedProduct> gtinFilters = new Filters<MedProduct>
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
