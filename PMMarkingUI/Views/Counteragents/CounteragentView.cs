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

using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;

namespace PMMarkingUI.Views
{
    public partial class CounteragentView : UserControl
    {
        DataTable CounteragentData;
        DataTable TWCounteragentData;
        string sys_id = "";
        int tw_id = 0;

        public CounteragentView(int id, string CounteragentType)
        {
            InitializeComponent();
            this.Text = "Карточка контрагента ";
            this.Tag = id;
            vgcTWCounteragent.SetReadOnlyVGridRows();
            TWCounteragentData = DAO.GetTW_Counteragents(id);
            vgcTWCounteragent.DataSource = TWCounteragentData;

            try
            {
                tw_id = Convert.ToInt32(TWCounteragentData.Rows[0]["ID"]);
                sys_id = TWCounteragentData.Rows[0]["SYS_ID"].ToString();
            }
            catch (Exception ex)
            {
                // Сообщение об ошибках присутствует в counteragentsAddresses.SetCounteragents
                //MessageBox.Show("Не определен контрагент TW4", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tw_id = 0;
                sys_id = "";
            }

            // Формируем список адресов
            counteragentsAddresses.SetCounteragents(tw_id, sys_id);
        }

        #region Вспомогательные
        private void vGridControl_RecordCellStyle(object sender, DevExpress.XtraVerticalGrid.Events.GetCustomRowCellStyleEventArgs e)
        {
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
        }
        /// <summary>
        /// Установить строки VGridControl в ReadOnly
        /// </summary>
        /// <param name="ctrl"></param>
        private void SetReadOnlyVGridRows(VGridControl ctrl)
        {
            foreach (BaseRow row in ctrl.Rows)
            {
                SetReadOnlyVGridRows_Child(row);
            }
        }
        /// <summary>
        /// Установить дочерние строки VGridControl в ReadOnly
        /// </summary>
        /// <param name="row"></param>
        private void SetReadOnlyVGridRows_Child(BaseRow row)
        {
            if (row.ChildRows.Count == 0)
            {
                row.Properties.AllowEdit = true;
                row.Properties.ReadOnly = true;
            }
            else
            {
                foreach (BaseRow ChildRow in row.ChildRows)
                {
                    SetReadOnlyVGridRows_Child(ChildRow);
                    ChildRow.Properties.AllowEdit = true;
                    ChildRow.Properties.ReadOnly = true;
                }
            }
        }
        #endregion
    }
}
