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
    public partial class CouteragentsAddressesLinksView : UserControl
    {
        const string modeAdd = "add";
        const string modeDel = "del";

        private DataProvider provider = new DataProvider();
        Sys.SelectRow sysRow = new Sys.SelectRow();
        
        public CouteragentsAddressesLinksView(string system_subj_id)
        {
            InitializeComponent();
            Text = "Контрагенты: Адресные данные";

            #region Источники данных
            MDLP_Counteragents = new DataTable();
            gMDLP_Counteragents.DataSource = MDLP_Counteragents;
            #endregion

            vMDLP_Counteragents.SetDefaultGridViewOptions();

            // Если был передан контрагент снаружи, сразу выделяем его
            if (!String.IsNullOrEmpty(system_subj_id))
            {
                for (int i = 0; i < MDLP_Counteragents.Rows.Count; i++)
                {
                    if (MDLP_Counteragents.Rows[i]["SYSTEM_SUBJ_ID"].ToString() == system_subj_id)
                    {
                        vMDLP_Counteragents.SelectRow(i);
                        vMDLP_Counteragents.FocusedRowHandle = i;
                        SelectCounteragent();

                        break;
                    }
                }
            }
            else
            {
                Refresh_MDLP_Counteragents();
                SelectCounteragent();
            }
        }

        public CouteragentsAddressesLinksView() : this("")
        {
        }

        //=====================================================================
        #region МДЛП. Контрагенты
        DataTable MDLP_Counteragents;
        /// <summary>
        /// Обновить список контрагентов
        /// </summary>
        private void Refresh_MDLP_Counteragents()
        {
            MDLP_Counteragents = DAO.GetTW_Counteragents();//DAO.GetMdlp_Counteragents();
            gMDLP_Counteragents.DataSource = MDLP_Counteragents;
         
            try { vMDLP_Counteragents.FocusedRowHandle = 0; } catch { }
        }

        /// <summary>
        /// Выбор контрагента из списка
        /// </summary>
        private void SelectCounteragent()
        {
            string sys_id = "";

            try
            {
                DataRow row = vMDLP_Counteragents.GetDataSourceRow();
                sys_id = row["SYS_ID"].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                sys_id = "";
            }

            counteragentsAddresses.SetCounteragents(sys_id);
        }

        private void vMDLP_Counteragents_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SelectCounteragent();
            }
        }

        private void vMDLP_Counteragents_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            SelectCounteragent();
        }
        #endregion
        //=====================================================================
        #region Меню и кнопки

        private void tsmiRefreshCounteragentList_Click(object sender, EventArgs e)
        {
            Refresh_MDLP_Counteragents();
        }

        private void tsmiSelectCounteragent_Click(object sender, EventArgs e)
        {
            SelectCounteragent();
        }

        private void tsmiMsRefreshCounteragentList_Click(object sender, EventArgs e)
        {
            Refresh_MDLP_Counteragents();
        }
        #endregion
    }
}
