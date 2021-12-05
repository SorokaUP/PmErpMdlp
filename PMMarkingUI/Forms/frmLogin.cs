using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProfitMed.Firebird;

namespace PMMarkingUI.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            Run();
            Application.Idle += Application_Idle;
        }

        void Application_Idle(object sender, EventArgs e)
        {
            try
            {
                tsslCapsLock.Enabled = Control.IsKeyLocked(Keys.CapsLock);
                TsslChangeEnabled(tsslCapsLock);
                tsslNumLock.Enabled = Control.IsKeyLocked(Keys.NumLock);
                TsslChangeEnabled(tsslNumLock);
                tsslScrollLock.Enabled = Control.IsKeyLocked(Keys.Scroll);
                TsslChangeEnabled(tsslScrollLock);
                tsslInsert.Enabled = Control.IsKeyLocked(Keys.Insert);
                TsslChangeEnabled(tsslInsert);
                tsslLanguage.Text = InputLanguage.CurrentInputLanguage.Culture.EnglishName?.Substring(0, 2);
                TsslChangeEnabled(tsslLanguage);
            }
            catch { }
        }

        private void TsslChangeEnabled(ToolStripStatusLabel tssl)
        {
            tssl.BorderSides = ToolStripStatusLabelBorderSides.All;
            tssl.BorderStyle = (tssl.Enabled) ? Border3DStyle.Sunken : Border3DStyle.Flat;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Application.Idle -= Application_Idle;
            base.OnFormClosed(e);
        }

        private void Run()
        {
            lbVersion.Text = "ver. " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            cbLogin.DataSource = DAO.GetLogins();
            cbLogin.DisplayMember = "LOGIN_";
            cbLogin.ValueMember = "UID";

            cbxSaveLogin.Checked = Convert.ToBoolean(Properties.Settings.Default.frmLogin_cbxSaveLogin);
            if (cbxSaveLogin.Checked)
            {
                try
                {
                    cbLogin.SelectedValue = Convert.ToInt32(Properties.Settings.Default.frmLogin_cbLogin);
                }
                catch { }
            }
            else
            {
                cbLogin.SelectedValue = 0;
            }

            ProfitMed.Firebird.Global.Connect().Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cbLogin.Text == "")
            {
                MessageBox.Show("Не указано имя пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow answer = DAO.DbUserLogin(cbLogin.Text, tbPassword.Text).Rows[0];
            ProfitMed.Firebird.Global.Connect().Close();
            if (Convert.ToInt32(answer["IS_LOGIN"]) == 1)
            {
                Sys.Global.UID = Convert.ToInt32(answer["UID"]);
                Sys.Global.USER_ID = answer["USER_ID"].ToString();
                Sys.Global.USER_LOGIN = cbLogin.Text;
                Sys.Global.SYS_OBJ_ID = answer["sys_obj_id"].ToString();
                Sys.Global.TW_UID = Convert.ToInt32(answer["TW_UID"]);
                Sys.Global.ID_OUR = Convert.ToInt32(answer["ID_OUR"]);
                ProfitMed.Firebird.Global.AliasTW = answer["ALIAS_TW"].ToString();
                Sys.Global.RefreshToken();

                Properties.Settings.Default.frmLogin_cbxSaveLogin = cbxSaveLogin.Checked;
                if (cbxSaveLogin.Checked)
                {
                    try
                    {
                        Properties.Settings.Default.frmLogin_cbLogin = Sys.Global.UID;
                    }
                    catch { }
                }
                Properties.Settings.Default.Save();

                DialogResult = DialogResult.OK;
                return;
            }
            else
            {
                MessageBox.Show("Логин или пароль не верны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            //btnOk_Click(null, null);
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOk_Click(sender, null);
        }

        private void cbLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbPassword.Text = "";
        }

        private void btnSetupManager_Click(object sender, EventArgs e)
        {
            if (new frmSetupManager().ShowDialog() == DialogResult.OK)
            {
                Run();
            }
        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {
            //
        }
    }
}
