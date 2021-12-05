using System;
using System.Data;
using System.Windows.Forms;
using ProfitMed.Firebird;

namespace PMMarkingUI.Forms
{
    public partial class frmCounteragentAddressesLinks : Form
    {
        const string modeAdd = "add";
        const string modeDel = "del";
        string mode = "";
        int bid = 0;
        int link_id = 0;
        int lid = 0;
        int tw_id = 0;
        string sys_id = "";
        string branch_id = "";

        private bool CheckMode()
        {
            switch (mode)
            {
                case modeAdd:
                    return true;
                case modeDel:
                    return true;
                default: return false;
            }
        }

        public frmCounteragentAddressesLinks(int branch_id, int link_id, string mode)
        {
            InitializeComponent();
            this.Text = "Связка адресов контрагента";
            this.bid = branch_id;
            this.link_id = link_id;
            this.mode = mode;

            if (!CheckMode())
            {
                MessageBox.Show("Не указан режим работы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DialogResult = DialogResult.Abort;
                Close();
                return;
            }
            if (branch_id == 0 || link_id == 0)
            {
                string s1 = (branch_id == 0) ? "Не выбран адрес МДЛП. " : "";
                string s2 = (link_id == 0) ? "Не передан адрес из нашей базы (tbl_address_link.id), либо он отсутствует в связке!" : "";
                MessageBox.Show((s1 + s2), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DialogResult = DialogResult.Abort;
                Close();
                return;
            }

            string addrMDLP = "";
            string addrTW = "";
            try
            {
                DataTable dtMdlp = DAO.GetMDLP_AddressesByBID(branch_id);
                addrMDLP = dtMdlp.Rows[0]["ADDRESS"].ToString();
                this.sys_id = dtMdlp.Rows[0]["SYS_ID"].ToString();
                this.branch_id = dtMdlp.Rows[0]["BRANCH_ID"].ToString();
            }
            catch
            {
                MessageBox.Show("Адрес МДЛП не найден! Возможно был удален!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
                Close();
                return;
            }
            try
            {
                DataTable dtTW = DAO.GetTW_AddressesByLinkId(link_id);
                addrTW = dtTW.Rows[0]["VAL"].ToString();
                object t = dtTW.Rows[0]["LID"];
                lid = (t != null) ? (int)t : 0;
                this.tw_id = (int)dtTW.Rows[0]["TW_ID"];
            }
            catch
            {
                addrTW = $"Адрес не найден! Возможно был удален! ({link_id})";
                if (mode == modeAdd)
                    btnOk.Enabled = false;
            }
            tbMDLP.Text = (String.IsNullOrEmpty(addrMDLP)) ? $"<Текстовое обозначение адреса не заполнено в базе МДЛП. ({branch_id})>" : addrMDLP;
            tbTW.Text = (String.IsNullOrEmpty(addrTW)) ? $"<Текстовое обозначение адреса не заполнено в нашей базе. ({link_id})>" : addrTW;

            switch (mode)
            {
                case modeAdd:
                    lbHeader.Text = "Создать связку между МДЛП и нашей базой";
                    break;
                case modeDel:
                    lbHeader.Text = "Удалить связку адресов из МДЛП";
                    break;
                default:
                    lbHeader.Text = "";
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены? Отменить действие будет нельзя!", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int val = (mode == modeDel) ? -1 : bid;
                bool res = DAO.UpdateTW_Addresses(val, link_id, lid, tw_id, branch_id);
                MessageBox.Show("Выполнено " + ((res) ? "успешно" : "с ошибками"));
                DialogResult = DialogResult.OK;
            }
        }
    }
}
