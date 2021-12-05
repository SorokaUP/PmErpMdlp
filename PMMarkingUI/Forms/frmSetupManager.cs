using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PMMarkingUI.Classes;
using PMMarkingUI.Delegats;
using ProfitMed.Firebird;
using ProfitMed.DataContract;

namespace PMMarkingUI.Forms
{
    public partial class frmSetupManager : Form
    {
        List<int> StepsHistory = new List<int>();
        int AccountSystem_ID = 0;
        string AccountSystem_SYS_ID = "";
        string AccountSystem_Name = "";

        public frmSetupManager()
        {
            InitializeComponent();
            xtcPages.SelectedTabPageIndex = 0;
            //xtcPages.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
        }

        #region Шаг 0 - Присвоение SYS_ID
        private void btnUSER_ID_Click(object sender, EventArgs e)
        {
            Sys.Global.USER_ID = tbUSER_ID.Text;
            NextStep();
        }
        #endregion
        #region Шаг 1 - Учетная система
        private void btnSetAccountSystem_Click(object sender, EventArgs e)
        {
            ppProgress.Visible = true;            
            try
            {
                ppProgress.Description = "Получение информации об учетной системе...";
                Application.DoEvents();
                AccountSystem_Name = tbAccountSystem_Name.Text;
                WebMethods.GetAccountSystemByFilter(AccountSystem_Name);
                DataRow row = DAO.GetAccountSystem(0, AccountSystem_Name).Rows[0];
                AccountSystem_ID = (int)row["ID"];
                AccountSystem_SYS_ID = row["ACCOUNT_SYSTEM_ID"].ToString();

                NextStep();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}, повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ppProgress.Visible = false;
            }
        }
        #endregion
        #region Шаг 2 - Присвоение CLIENT_SECRET
        private void btnSetClientSecret_Click(object sender, EventArgs e)
        {
            ppProgress.Visible = true;
            try
            {
                ppProgress.Description = "Обновление информации по CLIENT_SECRET...";
                Application.DoEvents();
                DAO.ExecuteQuery($"update tbl_ACCOUNTSYSTEM set CLIENT_SECRET = char_to_uuid('{tbClientSecret.Text}') where ID = {AccountSystem_ID}");

                NextStep();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}, повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ppProgress.Visible = false;
            }
        }
        #endregion
        #region Шаг 3 - Пользователи, Группы прав, Сертификаты, Организация
        private void btnGetUserInfo_Click(object sender, EventArgs e)
        {
            ppProgress.Visible = true;
            try
            {
                ppProgress.Description = "Получение пользователей учетной системы...";
                Application.DoEvents();
                WebMethods.GetUserInfoByFilter(AccountSystem_ID, null, null, null, null, null, null);

                ppProgress.Description = "Получение прав пользователей и сертификатов...";
                Application.DoEvents();
                DataTable users = DAO.GetUsers(0, AccountSystem_ID);
                foreach (DataRow user in users.Rows)
                {
                    string USER_ID = user["USER_ID"].ToString();                    
                    // Пользователи и права
                    WebMethods.GetUserInfo(USER_ID, true);
                    // Серитфикаты
                    WebMethods.GetUserCerts(USER_ID);
                }
                // Без получения информации о пользователях связать УС и Организацию автоматически не возможно
                ppProgress.Description = "Получение информации об организации пользователя...";
                Application.DoEvents();
                WebMethods.GetMembersCurrentUser();

                NextStep();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}, повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ppProgress.Visible = false;
            }
        }
        #endregion
        #region Шаг 4 - Синхронизация с TW4: Контрагенты, Адреса, Товары
        private void btnSyncTw4_Click(object sender, EventArgs e)
        {
            ppProgress.Visible = true;
            try
            {
                if (cbxStep4_IsSyncCounteragents.Checked)
                {
                    ppProgress.Description = "Синхронизация контрагентов с TW4...";
                    Application.DoEvents();
                    bool isCounteragents = Additional.CounteragentsSyncWithTW4(this, false);
                }

                if (cbxStep4_IsSyncAddresses.Checked)
                {
                    ppProgress.Description = "Синхронизация адресов с TW4...";
                    Application.DoEvents();
                    //bool isAddresses = Additional.CounteragentsAddressesSyncWithTW4(this, GetInns(), false);
                    bool isAddresses = Additional.CounteragentsAddressesSyncWithTW4_All(this, false);
                }

                if (cbxStep4_IsSyncGoods.Checked)
                {
                    ppProgress.Description = "Синхронизация товаров с TW4...";
                    Application.DoEvents();
                    bool isGoods = Additional.GoodsSyncWithTW4(this, false);
                }

                if (cbxStep4_IsSyncUsers.Checked)
                {
                    // TODO: Добавить синхронизацию пользователей
                }

                NextStep();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}, повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ppProgress.Visible = false;
            }
        }
        #endregion
        #region Шаг 5 - Отправка контрагентов в доверенные, Связка контрагентов
        private void btnToVerify_Click(object sender, EventArgs e)
        {
            ppProgress.Visible = true;
            try
            {
                if (cbxStep5_IsToVerify.Checked)
                {
                    ppProgress.Description = "Отправка контрагентов в доверенные и получение информации по ним...";
                    Application.DoEvents();
                    bool res = WebMethods.CounteragentsToVerify("add", GetInns(), this, false, true);
                }
                else
                {
                    if (cbxStep5_IsSyncCounteragents.Checked)
                    {
                        ppProgress.Description = "Получение контрагентов из МДЛП...";
                        Application.DoEvents();
                        List<string> inns = GetInns();
                        foreach (string inn in inns)
                        {
                            bool res = WebMethods.GetCounteragentInfoByInn(this, false, inn, false);
                        }
                    }
                }

                if (cbxStep5_IsLinkCounteragents.Checked)
                {
                    ppProgress.Description = "Связка контрагентов МДЛП и TW4 по ИНН...";
                    Application.DoEvents();
                    DAO.SetCounteragentsLinks();
                }
                
                NextStep();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}, повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ppProgress.Visible = false;
            }
        }
        #endregion
        #region Шаг 6 - Получение ФИАС по адресам, Связка адресов по ФИАС
        private void btnLinkAddresses_Click(object sender, EventArgs e)
        {
            ppProgress.Visible = true;
            try
            {
                if (cbxStep6_IsGetFias.Checked)
                {
                    ppProgress.Description = "Получение ФИАС адресов контрагентов...";
                    Application.DoEvents();
                    Additional.GetFiasAhunter(this, 0, false);
                }

                if (cbxStep6_IsLinkAddresses.Checked)
                {
                    ppProgress.Description = "Связка адресов по ФИАС...";
                    Application.DoEvents();
                    DAO.LinkedAddressesTW4WithMDLP(0, "");
                }

                NextStep();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}, повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ppProgress.Visible = false;
            }
        }
        #endregion        

        #region ВСПОМОГАТЕЛЬНЫЕ
        private void xtcPages_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            lbHeader.Text = xtcPages.TabPages[xtcPages.SelectedTabPageIndex].Text;
            btnBack.Visible = xtcPages.SelectedTabPageIndex > 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PrevStep();
        }

        private void PrevStep()
        {
            SetStepsHistory();
            if (xtcPages.SelectedTabPageIndex > 0)
                xtcPages.SelectedTabPageIndex = xtcPages.SelectedTabPageIndex - 1;
            btnNext.Visible = StepsHistory.Contains(xtcPages.SelectedTabPageIndex + 1);
        }

        private void NextStep()
        {
            SetStepsHistory();
            if (xtcPages.SelectedTabPageIndex + 1 < xtcPages.TabPages.Count)
            {
                xtcPages.SelectedTabPageIndex = xtcPages.SelectedTabPageIndex + 1;
                btnNext.Visible = StepsHistory.Contains(xtcPages.SelectedTabPageIndex + 1);
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void SetStepsHistory()
        {
            if (!StepsHistory.Contains(xtcPages.SelectedTabPageIndex))
                StepsHistory.Add(xtcPages.SelectedTabPageIndex);
        }

        private List<string> GetInns()
        {
            List<string> inns = new List<string>();
            DataTable c = DAO.GetTW_Counteragents();
            foreach (DataRow row in c.Rows)
            {
                string inn = row["INN"].ToString();
                if (Additional.CheckInn(inn))
                {
                    if (!inns.ToArray().Contains(inn))
                        inns.Add(inn);
                }
            }
            return inns;            
        }

        private void SkipStep(object sender, EventArgs e)
        {
            NextStep();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextStep();
        }

        private void btnToStep0_Click(object sender, EventArgs e)
        {
            NextStep();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите пропустить первоначальную настройку?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cbxStep5_IsToVerify_CheckedChanged(object sender, EventArgs e)
        {
            cbxStep5_IsSyncCounteragents.Enabled = !(sender as CheckBox).Checked;
        }
        #endregion
    }
}
