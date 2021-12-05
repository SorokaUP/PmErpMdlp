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
using PMMarkingUI.Forms;
using PMMarkingUI.Classes;
using PMMarkingUI.Delegats;
using Sys;
using ProfitMed.Firebird;

namespace PMMarkingUI.Forms
{
    public partial class frmCreateChildDocument : Form
    {
        public int doc_id { get; private set; }
        public frmCreateChildDocument()
        {
            InitializeComponent();
            this.doc_id = 0;
            SetDefaultValues();
        }

        public frmCreateChildDocument(int doc_id)
        {
            InitializeComponent();
            this.doc_id = doc_id;
            SetDefaultValues();
            DataTable data = DAO.GetDocumentsForCreateChild(this.doc_id, dtpDateFrom.Value, dtpDateTo.Value, Convert.ToInt32(beCounteragent.Tag));
            beDocumentOwner.Tag = data.Rows[0]["ID"];
            beDocumentOwner.Text = data.Rows[0]["NAME"].ToString();            
        }

        private void SetDefaultValues()
        {
            dtpDateFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDateFrom.Refresh();
        }

        private void beDocumentOwner_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GetRef_Document(sender, e);
        }

        private void GetRef_Document(object sender, ButtonPressedEventArgs e)
        {
            if (string.IsNullOrEmpty(beCounteragent.Text) && e.Button.Kind == ButtonPredefines.Ellipsis)
            {
                MessageBox.Show("Не выбран контрагент", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable res = DAO.GetDocumentsForCreateChild(this.doc_id, dtpDateFrom.Value, dtpDateTo.Value, Convert.ToInt32(beCounteragent.Tag));
            (sender as ButtonEdit).Ref(e, res, "ID", "NAME");

            this.doc_id = Convert.ToInt32((sender as ButtonEdit).Tag);
            if (this.doc_id == 0)
            {
                beDocumentType.Tag = 0;
                beDocumentType.Text = "";
            }
        }

        private void beDocumentOwner_TextChanged(object sender, EventArgs e)
        {
            bool isActive = string.IsNullOrEmpty(beDocumentOwner.Text);
            gbCounteragent.Enabled = isActive;
            gbPeriod.Enabled = isActive;
        }

        private void GetRef_DocType(object sender, ButtonPressedEventArgs e)
        {
            (sender as ButtonEdit).Ref(e, DAO.Ref_GetDocTypes(), "INT1", "NAME");
        }

        private void beDocumentType_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            GetRef_DocType(sender, e);
        }

        private void GetRef_Counteragents(object sender, ButtonPressedEventArgs e)
        {
            (sender as ButtonEdit).Ref(e, DAO.Ref_GetCounteragents(), "CID", "ORG_NAME");
        }

        private void beCounteragent_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            GetRef_Counteragents(sender, e);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (this.doc_id == 0)
            {
                MessageBox.Show("Не выбран документ!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int doc_type = 0;
            try
            {
                doc_type = Convert.ToInt32(beDocumentType.Tag);
            }
            catch { doc_type = 0; }            
            if (doc_type == 0)
            {
                MessageBox.Show("Не выбран тип дочернего документа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Sys.Global.DataProvider.CreateChildDocument(this.doc_id, doc_type);
                MessageBox.Show("Документ создан");

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка создания документа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
