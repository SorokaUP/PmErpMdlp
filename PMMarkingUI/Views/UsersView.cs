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
using PMMarkingUI.Classes;
using PMMarkingUI.Forms;

namespace PMMarkingUI.Views
{
    public partial class UsersView : UserControl
    {
        DataTable data;
        public UsersView()
        {
            InitializeComponent();
            this.Text = "Справочник: Пользователи";
            Tag = true;
            Refresh();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmUsers frm = new frmUsers(0);
            frm.ShowDialog();
            Refresh();*/
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int uid = 0;
            int row_index = 0;
            GetSelectUid(out uid, out row_index);
            /*frmUsers frm = new frmUsers(uid);
            frm.ShowDialog();*/
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите удалить выбранную запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int uid = 0;
                int row_index = 0;
                GetSelectUid(out uid, out row_index);
                DAO.UsersDeleteByUID(uid);
                data.Rows.RemoveAt(row_index);
                vUsers.LayoutChanged();
            }
        }

        private void Refresh()
        {
            //
        }

        private void GetSelectUid(out int uid, out int row_index)
        {
            try
            {
                row_index = vUsers.GetDataSourceRowIndex();
                uid = Convert.ToInt32(data.Rows[row_index]["UID"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                row_index = -1;
                uid = 0;
            }
        }
    }
}
