using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using PMMarkingUI.Forms;
using PMMarkingUI.Classes;
using PMMarkingUI.Delegats;
using ProfitMed.Firebird;
using Sys;

namespace PMMarkingUI.Forms
{
    public partial class frmCounteragentsLinks : Form
    {
        public frmCounteragentsLinks(int id, string SYS_ID = "")
        {
            InitializeComponent();
            DataTable data = DAO.GetTW_Counteragents(id);
            beCounteragentTW.Tag = Convert.ToInt32(data.Rows[0]["LID"]);
            beCounteragentTW.Text = data.Rows[0]["NAME"].ToString();

            tbSYS_ID.Text = SYS_ID;
        }       

        private void beCounteragentTW_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            GetRef_CounteragentTW(sender, e);
        }

        private void GetRef_CounteragentTW(object sender, ButtonPressedEventArgs e)
        {
            (sender as ButtonEdit).Ref(e, DAO.Ref_GetTwCounteragents(), "LID", "NAME");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int lid = 0;
            string sys_id = tbSYS_ID.Text;

            try
            {
                lid = Convert.ToInt32(beCounteragentTW.Tag);
            }
            catch
            {
                MessageBox.Show("Не указан контрагент TW4", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lid = 0;
            }

            if (!Regex.Match(sys_id, @"[0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}").Success)
            {
                MessageBox.Show("SYSTEM_SUBJ_ID контрагента МДЛП должен иметь формат UUID!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lid != 0 && !string.IsNullOrEmpty(sys_id))
            {
                bool res = Additional.CounteragentsSetLinks(lid, sys_id);
                MessageBox.Show(((res) ? "Контрагенты успешно связаны." : "Ошибка связки контрагентов."));
                DialogResult = DialogResult.OK;
                return;
            }
            else
                MessageBox.Show("Не верно заполнены данные. Контрагент / SYSTEM_SUBJ_ID не указан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
