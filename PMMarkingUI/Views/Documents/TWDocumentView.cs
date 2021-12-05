using System;
using System.IO;
using System.Xml;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using PMMarkingUI.Classes;
using ProfitMed.Firebird;
using ProfitMedServiceClient;

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraVerticalGrid.Rows;

namespace PMMarkingUI.Views
{
    public partial class TWDocumentView : UserControl
    {
        DataTable Doc;
        DataTable MDLP_Counteragent;
        DataTable MDLP_Address;
        DataTable GOODS;
        ProfitMedClient Api = new ProfitMedClient();
        public int did { get; private set; }
        public TWDocumentView(int did)
        {
            InitializeComponent();

            this.did = did;
            this.Tag = did;
        }

        public void ViewShow()
        {
            GOODS = new DataTable();
            //DocAllData = new DataTable();
            try
            {
                Doc = DAO.GetTWDocumentByDid(did);
                Text = "Документ TW4: " + Doc.Rows[0]["DCODE"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось получить данные документа. Вкладка не отобразится.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }

            object did1 = Doc.Rows[0]["DID1"];
            if (did1 != null)
            {
                try
                {
                    MDLP_Counteragent = new DataTable();//DAO.GetMDLP_CounteragentByLid(Convert.ToInt32(did1));
                    for (int i = 0; i < MDLP_Counteragent.Columns.Count; i++)
                        MDLP_Counteragent.Columns[i].ColumnName = "MDLP_" + MDLP_Counteragent.Columns[i].ColumnName.ToUpper();
                    Doc.CombineWithForOneRow(MDLP_Counteragent);
                }
                catch { }
            }

            object address_id = Doc.Rows[0]["ADDRESS_ID"];
            if (address_id != null)
            {
                try
                {
                    MDLP_Address = DAO.GetAddressInfoByTwId(Convert.ToInt32(address_id));
                    Doc.CombineWithForOneRow(MDLP_Address);
                }
                catch { }
            }

            vGridControl.Rows.SetReadOnly();
            vGridControl.DataSource = Doc;
            vGridControl.LayoutChanged();

            GetGOODS();
        }

        #region GOODS
        private void GetGOODS()
        {
            GOODS = DAO.GetTWGoodsByDid(this.did);

            gGOODS.DataSource = GOODS;
            vGOODS.LayoutChanged();
        }

        private void SelectGOODS()
        {
            try
            {
                DataRow row = vGOODS.GetDataSourceRow();
                int eid = Convert.ToInt32(row["EID"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        private void vGOODS_DoubleClick(object sender, EventArgs e)
        {
            // Окрашиваем текущую выбранную запись
            GridView view = sender as GridView;
            rowHandle = view.GetHitInfo_RowHandle(e);
            if (rowHandle >= 0)
            {
                view.LayoutChanged();
                SelectGOODS();
            }
        }
        #endregion
        //===================================================================================        
        #region Окраска строк
        int rowHandle = GridControl.InvalidRowHandle;
        Color selectRowColor1 = Color.Wheat;
        Color selectRowColor2 = Color.White;
        private void vDocs_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle == rowHandle && rowHandle >= 0)
            {
                e.Appearance.BackColor = selectRowColor1;
                //e.Appearance.BackColor2 = selectRowColor2;
                e.HighPriority = true;
            }
        }

        private void vDocs_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle == rowHandle && rowHandle >= 0)
            {
                e.Appearance.BackColor = selectRowColor1;
                //e.Appearance.BackColor2 = selectRowColor2;
            }
        }

        private void vDocs_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.RowHandle == rowHandle && rowHandle >= 0)
            {
                e.Appearance.BackColor = selectRowColor1;
                //e.Appearance.BackColor2 = selectRowColor2;
            }
        }

        private void vGTIN_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.RowHandle == rowHandle && rowHandle >= 0)
            {
                e.Appearance.BackColor = selectRowColor1;
                //e.Appearance.BackColor2 = selectRowColor2;
            }
        }

        private void vGTIN_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle == rowHandle && rowHandle >= 0)
            {
                e.Appearance.BackColor = selectRowColor1;
                //e.Appearance.BackColor2 = selectRowColor2;
            }
        }

        private void vGTIN_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle == rowHandle && rowHandle >= 0)
            {
                e.Appearance.BackColor = selectRowColor1;
                //e.Appearance.BackColor2 = selectRowColor2;
            }
        }
        #endregion
        #region Вспомогательные
        private void vGridControl_RecordCellStyle(object sender, DevExpress.XtraVerticalGrid.Events.GetCustomRowCellStyleEventArgs e)
        {
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
        }        
        #endregion
    }
}
