using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProfitMed.Firebird;
using PMMarkingUI.Forms;
using PMMarkingUI.Classes;
using PMMarkingUI.Delegats;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraGrid.Columns;

namespace PMMarkingUI.Views
{
    public partial class GoodsView : UserControl
    {
        public event DelegateAddPage dAddPage;
        Sys.SelectRow sysRow = new Sys.SelectRow();
        int IndexColID;
        int IndexColNAME;

        public GoodsView(DelegateAddPage ntp) // Добавить id товара на вход
        {
            InitializeComponent();
            this.Text = "Товары";
            this.Tag = true;
            dAddPage = ntp;
            vGoods.SetDefaultGridViewOptions();
            gridFilterView.SetGridView(vGoods);

            DataTable Folders = DAO.GetGoodsTW4Parents();
            tlFolders.CreateGroupFolders(Folders, 800);
            Refresh_Goods();
        }

        private void Refresh_Goods()
        {
            DataTable Goods = DAO.GetGoods();
            gGoods.DataSource = Goods;
            vGoods.LayoutChanged();
            try { vGoods.FocusedRowHandle = 0; } catch { }
            if (Goods.Rows.Count > 0)
                SelectGood();
            else
                Clear_GTIN_Info();
        }

        private void SelectGood()
        {
            try
            {
                DataRow row = vGoods.GetDataSourceRow();
                Refresh_GTIN_Info(Convert.ToInt32(row["GTIN_ID"]));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Refresh_GTIN_Info(int GTIN_ID)
        {
            DataTable GTIN_Info = DAO.GetGtinInfoByID(GTIN_ID);
            gGTIN_Info.DataSource = GTIN_Info;
            vGTIN_Info.LayoutChanged();
        }

        private void Clear_GTIN_Info()
        {
            gGTIN_Info.DataSource = new DataTable();
            vGTIN_Info.LayoutChanged();
        }

        #region Выделение
        /// <summary>
        /// Выбрать всех контрагентов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAll(object sender, EventArgs e)
        {
            gGoods.GridSelectAll("HANDLE_SELECT", 1);
        }

        /// <summary>
        /// Снять выделение со всех
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnselectAll(object sender, EventArgs e)
        {
            gGoods.GridSelectAll("HANDLE_SELECT", 0);
        }
        #endregion

        private void vGoods_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            sysRow.CustomDrawCell(sender, e);
        }

        private void vGoods_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            sysRow.ColorRow(sender, e);
            SelectGood();
        }

        private void vGoods_KeyPress(object sender, KeyPressEventArgs e)
        {
            sysRow.ColorRow(sender, e);
            SelectGood();
        }

        private void vGoods_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            sysRow.ColorRow(sender, e);
        }

        private void vGoods_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            sysRow.RowCellStyle(sender, e);
        }

        private void vGoods_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            sysRow.RowStyle(sender, e);
        }

        private void обновитьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh_Goods();
        }

        private void синхронизироватьСTW4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool res = Additional.GoodsSyncWithTW4(this);
            if (res)
            {
                Refresh_Goods();
            }
        }

        private void tlFolders_RowClick(object sender, DevExpress.XtraTreeList.RowClickEventArgs e)
        {
            string FieldName = "LPARENT";
            if (e.Clicks == 2)
            {
                int PARENT_LID = 0;
                try
                {
                    PARENT_LID = (int)e.Node.GetValue(IndexColID);
                    if (PARENT_LID == 0)
                    {
                        vGoods.Columns[FieldName].FilterInfo = new ColumnFilterInfo();
                        return;
                    }

                    vGoods.Columns[FieldName].FilterInfo =
                        new ColumnFilterInfo($"[{FieldName}] LIKE '{PARENT_LID}'");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                    vGoods.Columns[FieldName].FilterInfo = new ColumnFilterInfo();
                }
            }
        }

        private void синхронизироватьТоварыСTW4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool res = Additional.GoodsSyncWithTW4(this);
            if (res)
            {
                Refresh_Goods();
            }
        }

        private void прописатьGTINавтоматическиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = 0;
            try
            {
                count = (int)DAO.SyncGtinLib().Rows[0][0];
                if (count > 0)
                {
                    MessageBox.Show($"Обновлено {count} записей.");
                    Refresh_Goods();
                }
                else
                {
                    MessageBox.Show($"Данные не обновлены.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void прописатьGTINпоВыбраннымТоварамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<DataRow> SelectedRows = vGoods.GetDataSourceRowsByFilter("HANDLE_SELECT", 1);
            if (SelectedRows.Count == 0)
            {
                MessageBox.Show("Ничего не выбрано. Необходимо поставить галочку на товаре!");
                return;
            }
            foreach (DataRow row in SelectedRows)
            {
                try
                {
                    object LID = (int)row["LID"];
                    object GTIN = row["BARCODE"].ToString();
                    if (LID != null || (uint?)LID != (uint?)0)
                    {
                        DataTable gtininfo = DAO.GetGtinInfoByGtin(GTIN.ToString().PadLeft(14, '0'));
                        if (gtininfo != null)
                        {
                            if (gtininfo.Rows.Count > 0)
                            {
                                DAO.SetGtinToLibTW4((int)LID, gtininfo.Rows[0]["GTIN"].ToString());
                                DAO.SetGtinIdToGoods((int)LID, (int)gtininfo.Rows[0]["GID"]);
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            MessageBox.Show("Выполнено");
        }
    }
}
