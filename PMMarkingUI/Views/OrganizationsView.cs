using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMMarkingUI.Classes;
using PMMarkingUI.Forms;
using PMMarkingUI.Delegats;
using ProfitMed.Firebird;
using ProfitMed.DataContract;

namespace PMMarkingUI.Views
{
    public partial class OrganizationsView : UserControl
    {
        public OrganizationsView()
        {
            InitializeComponent();
            this.Tag = true;
            this.Text = "Данные об организации";

            Refresh_AccountSystem();
            Select_AccountSystem();
            Refresh_GroupsRights();
            //vgcOrganization.SetReadOnlyVGridRows();
        }

        #region РАБОТА С ТАБЛИЦАМИ
        /// <summary>
        /// Обновление списка Учетных систем
        /// </summary>
        private void Refresh_AccountSystem()
        {
            tlUnion_AccountSystem.Nodes.Clear();
            tlUnion_AccountSystem.DataSource = DAO.GetAccountSystem();
        }

        private void Select_AccountSystem()
        {
            Refresh_Organization();
            Refresh_OrganizationAddresses();
            Refresh_Users();
        }

        /// <summary>
        /// Обновление данных организации
        /// </summary>
        private void Refresh_Organization()
        {
            DataRow row = tlUnion_AccountSystem.GetDataSourceRow();
            if (row == null)
                return;

            vgcOrganization.DataSource = DAO.GetOurOrgInfo((int)row["ORGINFO_ID"]);
        }
        private void Refresh_OrganizationAddresses()
        {
            DataRow row = tlUnion_AccountSystem.GetDataSourceRow();
            if (row == null)
                return;

            tlOrganizationAddresses.DataSource = DAO.GetOurOrgAddresses((int)row["ORGINFO_ID"]);
        }

        /// <summary>
        /// Обновление списка пользователей
        /// </summary>
        private void Refresh_Users()
        {
            DataRow row = tlUnion_AccountSystem.GetDataSourceRow();
            if (row == null)
                return;
            int AS_ID = (int)row["ID"];

            tlUnion_UserRights.Nodes.Clear();
            tlUnion_UserRightRights.Nodes.Clear();
            tlUnion_LocalUsers.Nodes.Clear();

            tlUnion_Users.Nodes.Clear();
            tlUnion_Users.DataSource = DAO.GetUsers(0, AS_ID);
        }

        int UID = 0;
        private void Select_Users()
        {
            DataRow row = tlUnion_Users.GetDataSourceRow();
            if (row == null)
                return;

            UID = (int)row["UID"];
            Refresh_Certs();
            Refresh_UserRights();
            Refresh_LocalUsers();
        }

        /// <summary>
        /// Обновление списка локальных пользователей
        /// </summary>
        private void Refresh_LocalUsers()
        {
            tlUnion_LocalUsers.Nodes.Clear();
            tlUnion_LocalUsers.DataSource = DAO.GetTwUsers(0, UID); 
        }

        /// <summary>
        /// Обновление списка сертификатов
        /// </summary>
        private void Refresh_Certs()
        {
            tlUnion_Certs.Nodes.Clear();
            tlUnion_Certs.DataSource = DAO.GetUserCerts(UID);
        }

        /// <summary>
        /// Обновление списка групп прав пользователя
        /// </summary>
        private void Refresh_UserRights()
        {
            tlUnion_UserRightRights.Nodes.Clear();

            tlUnion_UserRights.Nodes.Clear();
            tlUnion_UserRights.DataSource = DAO.GetUserRights(UID, 0, 1);
        }

        private void Select_UserRights()
        {
            DataRow row = tlUnion_UserRights.GetDataSourceRow();
            if (row == null)
                return;

            Refresh_UserRightRights((int)row["GROUP_GID"]);
        }

        /// <summary>
        /// Обновление списка прав пользователя в группе прав
        /// </summary>
        private void Refresh_UserRightRights(int GID)
        {
            tlUnion_UserRightRights.Nodes.Clear();
            tlUnion_UserRightRights.DataSource = DAO.GetUserRights(0, GID, 2);
        }

        /// <summary>
        /// Обновление списка групп прав пользователей
        /// </summary>
        private void Refresh_GroupsRights()
        {
            tlUnion_GroupsRights.Nodes.Clear();
            tlUnion_GroupsRights.DataSource = DAO.GetUserRights(0, 0, 1);
        }

        private void Select_GroupsRights()
        {
            DataRow row = tlUnion_GroupsRights.GetDataSourceRow();
            if (row == null)
                return;

            Refresh_GroupRights((int)row["GROUP_GID"]);
        }

        /// <summary>
        /// Обновление списка прав в группе прав
        /// </summary>
        private void Refresh_GroupRights(int GID)
        {
            tlUnion_GroupRights.Nodes.Clear();
            tlUnion_GroupRights.DataSource = DAO.GetUserRights(0, GID, 2);
        }

        private void ClearNodes(ControlCollection cc)
        {
            foreach (Control c in cc)
            {
                if (c is DevExpress.XtraTreeList.TreeList)
                    (c as DevExpress.XtraTreeList.TreeList).Nodes.Clear();
            }
        }

        private void tlUnion_AccountSystem_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null)
                Select_AccountSystem();
        }

        private void tlUnion_Users_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null)
                Select_Users();
        }

        private void tlUnion_UserRights_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            Select_UserRights();
        }

        private void tlUnion_GroupsRights_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            Select_GroupsRights();
        }
        #endregion
        #region API
        private void Api_6_1_1(object sender, EventArgs e)
        {
            //6.1.1. Метод для регистрации учетной системы
            //WebMethods.RegistrationAccountSystem();
        }
        private void Api_6_1_11(object sender, EventArgs e)
        {
            //6.1.11. Метод для получения информации об УС
            DataRow row = tlUnion_AccountSystem.GetDataSourceRow();
            if (row == null)
                return;

            WebMethods.AccountSystemGetInfo(row["ACCOUNT_SYSTEM_ID"].ToString());
        }
        private void Api_6_3_1(object sender, EventArgs e)
        {
            //6.3.1. Метод для удаления пользователей учетной системы
            if (MessageBox.Show("Вы уверены, что хотите удалить пользователя? Отменить действия будет НЕЛЬЗЯ.", "ВНИМАНИЕ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            DataRow row = tlUnion_Users.GetDataSourceRow();
            if (row == null)
                return;

            WebMethods.AccountSystemDeleteUser(row["USER_ID"].ToString());
        }
        private void Api_6_3_2(object sender, EventArgs e)
        {
            //6.3.2. Метод для удаления учетной системы
            if (MessageBox.Show("Вы уверены, что хотите удалить УЧЕТНУЮ СИСТЕМУ? Отменить действия будет НЕЛЬЗЯ.", "ВНИМАНИЕ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            if (MessageBox.Show("Вы хорошо подумали?", "ВНИМАНИЕ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            DataRow row = tlUnion_AccountSystem.GetDataSourceRow();
            if (row == null)
                return;

            //WebMethods.DeleteAccountSystem(row["ACCOUNT_SYSTEM_ID"].ToString());
        }
        private void Api_6_8_2(object sender, EventArgs e)
        {
            //6.8.2. Метод для поиска УС по фильтру
            frmTextBox frm = new frmTextBox("6.8.2. Метод для поиска УС по фильтру", "Наименование учетной системы");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                using (frmProccess p = new frmProccess())
                {
                    p.ShowDialog();
                    WebMethods.GetAccountSystemByFilter(frm.Data);
                    p.Close();
                }
                Refresh_AccountSystem();
            }
        }

        private void Api_6_1_2(object sender, EventArgs e)
        {
            //6.1.2. Метод для регистрации пользователей (для резидентов страны)
            //WebMethods.RegistrationUser();
            DataRow rowAcs = tlUnion_AccountSystem.GetDataSourceRow();
            if (rowAcs == null)
                return;

            frmUsers frm = new frmUsers("add", (int)rowAcs["ID"]);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Refresh_Users();
            }
        }
        private void Api_6_1_4(object sender, EventArgs e)
        {
            //6.1.4. Метод для получения информации о пользователе
            DataRow row = tlUnion_Users.GetDataSourceRow();
            if (row == null)
                return;

            WebMethods.GetUserInfo(row["USER_ID"].ToString());
        }
        private void Api_6_1_5(object sender, EventArgs e)
        {
            //6.1.5. Метод для получения информации о настройках профиля текущего пользователя
            //WebMethods.GetUserSettingsProfile();
        }
        private void Api_6_1_6(object sender, EventArgs e)
        {
            //6.1.6. Метод для изменения данных профиля пользователя
            DataRow row = tlUnion_Users.GetDataSourceRow();
            if (row == null)
                return;

            //WebMethods.SetUserSettingsProfile(row["USER_ID"].ToString());
            //frmUsers frm = new frmUsers("edit", (int)row["UID"]);
            /*if (frm.ShowDialog() == DialogResult.OK)
            {
                DataRow rowAcs = tlUnion_AccountSystem.GetDataSourceRow();
                Refresh_Users();
            }*/
        }
        private void Api_6_1_7(object sender, EventArgs e)
        {
            //6.1.7. Метод для получения информации о текущем пользователе
            WebMethods.GetCurrentUserInfo();
        }
        private void Api_6_1_8(object sender, EventArgs e)
        {
            //6.1.8. Метод для изменения настроек профиля текущего пользователя
            //WebMethods.ChangeUserSettingsProfile();
        }
        private void Api_6_4_1(object sender, EventArgs e)
        {
            //6.4.1. Метод для добавления ЭП пользователя (для резидентов)
            DataRow rowUser = tlUnion_Users.GetDataSourceRow();
            if (rowUser == null)
                return;

            DataRow rowCert = tlUnion_Certs.GetDataSourceRow();
            if (rowCert == null)
                return;

            if (MessageBox.Show($"Выбран сертификат: {rowCert["PUBLIC_CERT_SERIAL_NUMBER"].ToString()}. Продолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            WebMethods.AddUserSign(rowUser["USER_ID"].ToString(), rowCert["PUBLIC_CERT_SERIAL_NUMBER"].ToString());
        }
        private void Api_6_4_2(object sender, EventArgs e)
        {
            //6.4.2. Метод для удаления ЭП пользователя (для резидентов)
            DataRow rowUser = tlUnion_Users.GetDataSourceRow();
            if (rowUser == null)
                return;

            DataRow rowCert = tlUnion_Certs.GetDataSourceRow();
            if (rowCert == null)
                return;

            if (MessageBox.Show($"Выбран сертификат: {rowCert["PUBLIC_CERT_SERIAL_NUMBER"].ToString()}. Продолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            WebMethods.DeleteUserSing(rowUser["USER_ID"].ToString(), rowCert["PUBLIC_CERT_SERIAL_NUMBER"].ToString());
        }
        private void Api_6_7_2(object sender, EventArgs e)
        {
            //6.7.2. Метод для поиска зарегистрированных пользователей по фильтру
            DataRow row = tlUnion_AccountSystem.GetDataSourceRow();
            if (row == null)
                return;
            int AS_ID = (int)row["ID"];

            WebMethods.GetUserInfoByFilter(AS_ID, null, "Кузин", null, null, null, null);
        }

        private void Api_6_6_1(object sender, EventArgs e)
        {
            //6.6.1. Метод для получения информации о существующих правах
            WebMethods.GetCurrentRights();
        }
        private void Api_6_6_2(object sender, EventArgs e)
        {
            //6.6.2. Метод для получения информации о правах текущего пользователя
            WebMethods.GetRightsCurrentUser();
        }
        private void Api_6_6_3(object sender, EventArgs e)
        {
            //6.6.3. Метод для создания группы прав пользователей
            List<string> rights = new List<string>();
            rights.Add("REESTR_SGTIN");
            rights.Add("MANAGE_MEMBER");
            rights.Add("REESTR_REFP");
            WebMethods.CreateGroupRights("ПМ Тест", rights);
        }
        private void Api_6_6_4(object sender, EventArgs e)
        {
            //6.6.4. Метод для получения информации о группе прав пользователей
            DataRow row = tlUnion_GroupsRights.GetDataSourceRow();
            if (row == null)
                return;

            WebMethods.GetGroupRightsInfo(row["GROUP_ID"].ToString());
        }
        private void Api_6_6_5(object sender, EventArgs e)
        {
            //6.6.5. Метод для получения информации о пользователях группы
            DataRow row = tlUnion_Users.GetDataSourceRow();
            if (row == null)
                return;

            //WebMethods.GetUsersByGroupRights(row["USER_ID"].ToString());
        }
        private void Api_6_6_6(object sender, EventArgs e)
        {
            //6.6.6. Метод для изменения группы прав пользователей
            //WebMethods.ChangeGroupRights();
        }
        private void Api_6_6_7(object sender, EventArgs e)
        {
            //6.6.7. Метод для удаления группы прав пользователей
            DataRow row = tlUnion_Users.GetDataSourceRow();
            if (row == null)
                return;

            //WebMethods.DeleteGroupRights();
        }
        private void Api_6_6_8(object sender, EventArgs e)
        {
            //6.6.8. Метод для добавления пользователя в группу прав пользователей
            DataRow row = tlUnion_Users.GetDataSourceRow();
            if (row == null)
                return;

            //WebMethods.AddUserInGroupRights("", row["USER_ID"].ToString());
        }
        private void Api_6_6_9(object sender, EventArgs e)
        {
            //6.6.9. Метод для удаления пользователя из группы прав пользователя
            DataRow row = tlUnion_Users.GetDataSourceRow();
            if (row == null)
                return;

            //WebMethods.DeleteUserFromGroupRights(row["USER_ID"].ToString());
        }
        private void Api_6_6_11(object sender, EventArgs e)
        {
            //6.6.11. Метод для поиска списка групп прав пользователей по фильтру
            //WebMethods.GetGroupRightsInfoByFilter();
        }
        #endregion

        private void обновитьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh_Users();
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            Refresh_LocalUsers();
        }

        private void обновитьСписокToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Refresh_GroupsRights();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers("add");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Refresh_LocalUsers();
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = tlUnion_LocalUsers.GetDataSourceRow();
            if (row == null)
                return;

            frmUsers frm = new frmUsers("edit", (int)row["ID"]);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Refresh_LocalUsers();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow row = tlUnion_LocalUsers.GetDataSourceRow();
            if (row == null)
                return;

            if (MessageBox.Show("Удалить локального пользователя?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int tw_uid = (int)row["ID"];
                if (Sys.Global.TW_UID == tw_uid)
                {
                    MessageBox.Show("Нельзя удалить пользователя, так как эта учетная запись сейчас используется системой.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DataTable dt = DAO.TwUsersDel(tw_uid);
                if (dt.Rows.Count > 0)
                {
                    object res = dt.Rows[0]["RES"];
                    if (res != null)
                    {
                        if ((int)res == 0)
                        {
                            MessageBox.Show("Выполнено. Список данных будет обновлен.");
                            Refresh_LocalUsers();
                        }
                    }
                }
            }
        }

        private void получениеИнформацииОбОрганизацииТекущегоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmProccess frm = new frmProccess())
            {
                frm.ShowDialog();

                try
                {
                    //8.9.1 Информация об организации, в которой зарегистрирован текущий пользователь
                    Sys.Global.Api.GetMembersCurrent(Sys.Global.USER_ID);
                    MessageBox.Show("Выполнено. Список данных будет обновлен.");
                    Refresh_Organization();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                frm.Dispose();
            }
        }

        private void получениеИнформацииОСертификатахТекущегоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //6.1.9 Метод для получения информации о зарегистрированных сертификатах текущего пользователя
            Classes.WebMethods.GetCurrentUserCerts();
        }

        private void получениеАдресовОрганизацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //7.8.1 - Адреса конторы
            Classes.WebMethods.GetOrgAddresses();
            Refresh_OrganizationAddresses();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Refresh_Certs();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh_Organization();
            Refresh_OrganizationAddresses();
        }
    }
}
