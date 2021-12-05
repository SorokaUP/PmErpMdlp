using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProfitMed.Firebird;
using PMMarkingUI.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ProfitMed.DataContract;
using Sys;

namespace PMMarkingUI.Forms
{
    public partial class frmUsers : Form
    {
        const string modeAdd = "add";
        const string modeEdt = "edit";
        int id = 0;
        string mode = "";
        public frmUsers(string mode) : this(mode, 0) { }
        public frmUsers(string mode, int id)
        {
            this.id = id;
            this.mode = mode;
            InitializeComponent();
            this.Text += (mode == modeEdt) ? "Изменение" : "Добавление";
            btnOk.Text = (mode == modeEdt) ? "Изменить" : "Добавить";
            if (mode == modeEdt)
            {
                GetData();
            }
        }

        DataTable data;
        private void GetData()
        {
            data = DAO.GetTwUsers(this.id);
            if (data.Rows.Count == 0)
                throw new Exception("Пользователя с таким ID не найдено");
            DataRow row = data.Rows[0];
            beUSERS_ID.Tag = Convert.ToInt32(row["USERS_ID"]);
            beUSERS_ID.Text = row["USERS_FIO"].ToString();
            tbLogin.Text = row["LOGIN_"].ToString();
            tbPass.Text = row["PASS"].ToString();
            tbFio.Text = row["FIO"].ToString();
        }

        private void GetRef_USERS_ID(object sender, ButtonPressedEventArgs e)
        {
            (sender as ButtonEdit).Ref(e, DAO.Ref_GetUsers(), "UID", "FIO");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.mode == modeEdt)
            {
                if (MessageBox.Show("Отменить все изменения?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    DialogResult = DialogResult.Cancel;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int users_id = Convert.ToInt32(beUSERS_ID.Tag);
            if (users_id <= 0)
            {
                MessageBox.Show("Не указан пользователь МДЛП", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tbFio.Text))
            {
                MessageBox.Show("Не указано ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tbLogin.Text))
            {
                MessageBox.Show("Не указан Логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tbPass.Text))
            {
                MessageBox.Show("Не указан пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DataTable res = DAO.TwUsersIU(this.id, users_id, tbFio.Text, tbLogin.Text, tbPass.Text);
            if (res.Rows.Count > 0)
            {
                if (res.Rows[0]["RES"] != null)
                {
                    MessageBox.Show("Выполнено!");
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
