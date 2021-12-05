using System;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Web;
using System.Net;
using System.Windows.Forms;
using PMMarkingUI.Forms;
using ProfitMed.Firebird;
using PMMarkingUI.Classes;
using ProfitMed.DataContract;

using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace PMMarkingUI.Views
{
    public partial class CounteragentsAddresses : UserControl
    {
        const string modeAdd = "add";
        const string modeDel = "del";

        Sys.SelectRow sysRow = new Sys.SelectRow();
        private DataProvider provider = new DataProvider();

        private string strHeaderMDLP_Addresses = "Адресные данные из МДЛП";
        private string strHeaderTW_Addresses = "Адресные данные из TW4";

        private string sys_id = "";
        private string inn = "";
        private int lid = 0;
        private int CurrBID = 0;
        Label errMdlpCounteragent = new Label();

        public CounteragentsAddresses()
        {
            InitializeComponent();
            Text = "Контрагенты: Адресные данные";
        }

        public void SetCounteragents(string system_subj_id)
        {
            string v_inn = "";
            try
            {
                errMdlpCounteragent.Visible = false;

                DataTable tblCounteragent = DAO.GetMdlp_CounteragentsBySysId(system_subj_id);
                this.sys_id = tblCounteragent.Rows[0]["SYSTEM_SUBJ_ID"].ToString();
                v_inn = tblCounteragent.Rows[0]["INN"].ToString();
            }
            catch
            {
                Clear_MDLP_Addresses();
                Clear_TW_Addresses();

                errMdlpCounteragent.Visible = true;
                errMdlpCounteragent.Parent = gMDLP_Addresses;
                errMdlpCounteragent.Dock = DockStyle.Fill;
                errMdlpCounteragent.TextAlign = ContentAlignment.MiddleCenter;
                errMdlpCounteragent.Text = "Ошибка." + Environment.NewLine + "Не удалось определить контрагента МДЛП";
                errMdlpCounteragent.BackColor = Color.Khaki;
                errMdlpCounteragent.Font = new Font(errMdlpCounteragent.Font, FontStyle.Bold);
                errMdlpCounteragent.ForeColor = Color.Black;
                return;
            }

            try
            {
                DataTable tblTWCounteragent = DAO.GetTW_Counteragents(0, v_inn);
                this.inn = tblTWCounteragent.Rows[0]["INN"].ToString();
                this.lid = (int)tblTWCounteragent.Rows[0]["LID"];
            }
            catch
            {
                try
                {
                    Refresh_MDLP_Addresses();
                    Clear_TW_Addresses();
                }
                catch
                {
                    Clear_MDLP_Addresses();
                    Clear_TW_Addresses();
                }
                
                //throw new Exception("Не удалось определить контрагента");
                MessageBox.Show("Не удалось определить контрагента TW4", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Start();
        }

        public void SetCounteragents(int TW_ID, string system_subj_id)
        {
            try
            {
                if (string.IsNullOrEmpty(system_subj_id))
                    throw new Exception("Не передан контрагент МДЛП");
                this.sys_id = system_subj_id;
            }
            catch
            {
                Clear_MDLP_Addresses();
                Clear_TW_Addresses();

                //MessageBox.Show("Не удалось определить контрагента МДЛП", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }

            try
            {
                if (TW_ID == 0)
                    throw new Exception("Не передан контрагент TW4");
                DataTable tblTWCounteragent = DAO.GetTW_Counteragents(TW_ID);
                this.inn = tblTWCounteragent.Rows[0]["INN"].ToString();
                this.lid = (int)tblTWCounteragent.Rows[0]["LID"];
            }
            catch
            {
                try
                {
                    Refresh_MDLP_Addresses();
                    Clear_TW_Addresses();
                }
                catch
                {
                    Clear_MDLP_Addresses();
                    Clear_TW_Addresses();
                }

                MessageBox.Show("Не удалось определить контрагента TW4", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Start();
        }

        private void Start()
        {
            // Создаем фильтр для выделения строк (информативно)
            vMDLP_Addresses.Appearance.FocusedRow.Options.UseBackColor = false;
            Sys.GridColumns.CreateFormatRules(vMDLP_Addresses, "Link", "BID", $"ToInt([BID]) == -1", true);
            Sys.GridColumns.CreateFormatRules(vMDLP_Addresses, "NonLink", "FLAG", $"ToInt([FLAG]) == 0", false);
            Sys.GridColumns.CreateFormatRules(vTW_Addresses, "Link", "BRANCH_ID", $"ToInt([BRANCH_ID]) == -1", true);
            Sys.GridColumns.CreateFormatRules(vTW_Addresses, "Id", "ID", $"ToInt([ID]) == -1", true);

            RefreshAddresses();
        }

        private void RefreshAddresses()
        {
            Refresh_MDLP_Addresses();
            Refresh_TW_Addresses();
        }

        //=====================================================================
        #region МДЛП. Адресы
        DataTable MDLP_Addresses = new DataTable();
        /// <summary>
        /// Обновить список адресов контрагента из системы МДЛП
        /// </summary>
        private void Refresh_MDLP_Addresses()
        {
            if (sys_id != "")
                MDLP_Addresses = DAO.GetMDLP_Addresses(sys_id);
            else
                MDLP_Addresses.Rows.Clear();
            gMDLP_Addresses.DataSource = MDLP_Addresses;

            try { vMDLP_Addresses.FocusedRowHandle = 0; } catch { }
            lbMDLP_Addresses_Text_Refresh();
        }

        private void Clear_MDLP_Addresses()
        {
            gMDLP_Addresses.DataSource = new DataTable();
            vMDLP_Addresses.LayoutChanged();
            lbMDLP_Addresses_Text_Refresh();
        }

        private void lbMDLP_Addresses_Text_Refresh()
        {
            int CountLinked = 0;
            for (int i = 0; i < MDLP_Addresses.Rows.Count; i++)
            {
                int x = 0;
                try
                {
                    x = (int)MDLP_Addresses.Rows[i]["FLAG"];
                }
                catch
                {
                    x = 0;
                }

                if (x != 0)
                    CountLinked++;
            }
            int cntAll = 0;
            DataTable t = (gMDLP_Addresses.DataSource as DataTable);
            if (t != null)
            {
                cntAll = t.Rows.Count;
            }
            vMDLP_Addresses.ViewCaption = $"{strHeaderMDLP_Addresses} ({cntAll}/{CountLinked})";
        }

        /// <summary>
        /// Поиск и выделение строки TW_Address по значению ID_TW из MDLP_Address
        /// </summary>
        private void SerchLinkMdlpToTw()
        {
            CurrBID = 0;
            try
            {
                DataRow row = vMDLP_Addresses.GetDataSourceRow();
                CurrBID = (int)row["BID"];
            }
            catch
            {
                CurrBID = -1;
            }
            (vMDLP_Addresses.FormatRules["Link"].Rule as FormatConditionRuleExpression).Expression = $"ToInt([BID]) == {CurrBID}";
            (vTW_Addresses.FormatRules["Link"].Rule as FormatConditionRuleExpression).Expression = $"ToInt([BRANCH_ID]) == {CurrBID}";
        }

        private void vMDLP_Addresses_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SerchLinkMdlpToTw();
        }
        #endregion
        //=====================================================================
        #region ТВ4. Адресы
        DataTable TW_Addresses = new DataTable();
        /// <summary>
        /// Обновить список адресов контрагентов по ИНН из нашей базы
        /// </summary>
        /// <param name="inn"></param>
        private void Refresh_TW_Addresses(int branch_id = 0)
        {
            if (!String.IsNullOrEmpty(inn))
                TW_Addresses = DAO.GetTW_Addresses(inn, branch_id);
            else
                TW_Addresses.Rows.Clear();
            gTW_Addresses.DataSource = TW_Addresses;

            try { vTW_Addresses.FocusedRowHandle = 0; } catch { }
            lbTW_Addresses_Text_Refresh();
            SerchLinkMdlpToTw();
        }

        private void Clear_TW_Addresses(int branch_id = 0)
        {
            gTW_Addresses.DataSource = new DataTable();
            vTW_Addresses.LayoutChanged();
            lbTW_Addresses_Text_Refresh();
        }

        private void lbTW_Addresses_Text_Refresh()
        {
            int cntAll = 0;
            DataTable t = (gTW_Addresses.DataSource as DataTable);
            if (t != null)
            {
                cntAll = t.Rows.Count;
            }
            vTW_Addresses.ViewCaption = $"{strHeaderTW_Addresses} ({cntAll})";
        }

        /// <summary>
        /// Попытка автоматически определить и связать адрес по ФИАC через API
        /// </summary>
        private void LinkForApi()
        {
            try
            {
                DataRow row = vTW_Addresses.GetDataSourceRow();
                string adr = row["NORMALIZED_VAL"].ToString();
                if (String.IsNullOrEmpty(adr) || String.IsNullOrWhiteSpace(adr))
                    throw new Exception();

                string role = $"TW_ID:{row["TW_ID"].ToString()};ID:{row["ID"].ToString()}";
                Additional.FiasAPI(HttpUtility.UrlEncode(adr), false, role);
                MessageBox.Show("Выполнено!");
                RefreshAddresses();
            }
            catch
            {
                throw new Exception("Не удалось определить адрес TW");
            }
        }

        /// <summary>
        /// Поиск и выделение строки TW_Address по значению ID_TW из MDLP_Address
        /// </summary>
        private void SerchLinkTwToMdlp()
        {
            CurrBID = 0;
            int id = 0;
            try
            {
                DataRow row = vTW_Addresses.GetDataSourceRow();
                CurrBID = (int)row["BRANCH_ID"];
                id = (int)row["ID"];
            }
            catch
            {
                CurrBID = -1;
                id = -1;
            }
            (vMDLP_Addresses.FormatRules["Link"].Rule as FormatConditionRuleExpression).Expression = $"ToInt([BID]) == {CurrBID}";
            (vTW_Addresses.FormatRules["Link"].Rule as FormatConditionRuleExpression).Expression = $"ToInt([BRANCH_ID]) == -1";
            (vTW_Addresses.FormatRules["Id"].Rule as FormatConditionRuleExpression).Expression = $"ToInt([ID]) == {id}";
        }

        private void vTW_Addresses_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SerchLinkTwToMdlp();
        }
        #endregion
        //=====================================================================

        #region Добавление и обновление данных
        /// <summary>
        /// Изменение связки
        /// </summary>
        /// <param name="mode">add | del</param>
        private void LinkChange(string mode)
        {
            switch (mode)
            {
                case modeAdd:
                    break;
                case modeDel:
                    break;
                default:
                    return;
            }

            int branch_id = 0;
            int link_id = 0;
                       
            try
            {
                DataRow row = vMDLP_Addresses.GetDataSourceRow();
                branch_id = (int)row["BID"];
            }
            catch
            {
                throw new Exception("Не удалось определить адрес МДЛП");
            }
            try
            {
                DataRow row = vTW_Addresses.GetDataSourceRow();
                link_id = (int)row["ID"];
            }
            catch
            {
                throw new Exception("Не удалось определить адрес по нашей базе");
            }

            DialogResult dres = DialogResult.Abort;
            try
            {
                dres = new frmCounteragentAddressesLinks(branch_id, link_id, mode).ShowDialog();
            }
            catch
            {
                dres = DialogResult.Abort;
            }
            if (dres == DialogResult.OK)
            {
                RefreshAddresses();
            }
        }
        #endregion

        #region Окраска строк
        private void sys_RowStyle(object sender, RowStyleEventArgs e)
        {
            sysRow.RowStyle(sender, e);
        }

        private void sys_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            sysRow.RowCellStyle(sender, e);
        }

        private void sys_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            sysRow.CustomDrawCell(sender, e);
        }

        private void sys_SelectRow(object sender, int iRowHandle)
        {
            sysRow.ColorRow(sender, iRowHandle);
        }

        private void sys_SelectRow(object sender, EventArgs e)
        {
            sysRow.ColorRow(sender, e);
        }
        #endregion
        #region Действия
        private void picLinkAdd_Click(object sender, EventArgs e)
        {
            LinkChange(modeAdd);
        }

        private void picLinkDel_Click(object sender, EventArgs e)
        {
            LinkChange(modeDel);
        }

        private void tsmiCmsTWA_LinkAdd_Click(object sender, EventArgs e)
        {
            LinkChange(modeAdd);
        }

        private void tsmiCmsTWA_LinkDel_Click(object sender, EventArgs e)
        {
            LinkChange(modeDel);
        }

        private void tsmiCmsTWA_LinkForApi_Click(object sender, EventArgs e)
        {
            LinkForApi();
        }

        private void обновитьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshAddresses();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выделите (нажмите или переместите фокус на строку) адрес контрагента из TW4, затем выполните то же самое для адреса контрагента из МДЛП. Затем выполните привязку или на оборот - удалите ее.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmiAction_GetAddressesFromMdlp_Click(object sender, EventArgs e)
        {
            GetAddressesFromMdlp();
        }

        private void tsmiAction_GetAddressesFromTw4_Click(object sender, EventArgs e)
        {
            GetAddressesFromTw4();
        }

        private void GetAddressesFromMdlp()
        {
            WebMethods.GetCounteragentInfoBySysId(this.sys_id);
            Refresh_MDLP_Addresses();
        }

        private void GetAddressesFromTw4()
        {
            List<string> inns = new List<string>();
            inns.Add(this.inn);
            Additional.CounteragentsAddressesSyncWithTW4(this, inns, false);
            Refresh_TW_Addresses();
        }

        private void tsmiAction_LinkAllForFIAS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Автоматическая связка адресов по ФИАС может стереть ранее проставленные ручные привязки. Продолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DAO.LinkedCounteragentAddressesByFias(this.lid, ""/*this.inn*/);
                    MessageBox.Show("Выполнено");
                    RefreshAddresses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Что-то пошло не так: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}
