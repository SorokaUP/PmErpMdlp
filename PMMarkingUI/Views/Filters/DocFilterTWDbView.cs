using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using PMMarkingUI.Forms;
using PMMarkingUI.Classes;
using PMMarkingUI.Delegats;
using Sys;
using ProfitMed.Firebird;

namespace PMMarkingUI.Views
{
    public partial class DocFilterTWDbView : UserControl
    {
        public event DelegateGetDocFilterTWDb dGetFilter;
        public DelegateGetDocFilterTWDb DelegateGetDocFilterTW { get; set; }
        int otdel_id = 0;
        int group_id = 0;
        int manager_id = 0;
        int counteragent_id = 0;
        public DocFilterTWDbView()
        {
            InitializeComponent();
            dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        }

        public void SetDelegate(DelegateGetDocFilterTWDb d)
        {
            this.DelegateGetDocFilterTW = d;
            dGetFilter = DelegateGetDocFilterTW;
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            GetFilter();
        }

        private void GetFilter()
        {
            DocFilterTWDb res = new DocFilterTWDb();
            res.FromDate = dtpFrom.Value;
            res.ToDate = dtpTo.Value;
            res.Direction = (rbDirectionIncoming.Checked) ? 1 : -1;
            res.IsReturned = (cbxReturned.Checked) ? 1 : 0;
            res.Counteragent = Convert.ToInt32(beCounteragent.Tag);
            res.Manager = Convert.ToInt32(beManager.Tag); ;
            res.Group = Convert.ToInt32(beGroup.Tag); ;
            res.Departament = Convert.ToInt32(beDepartament.Tag);

            // Вызываем событие по делегату (frmMain)
            dGetFilter(res);
        }

        public void DeactivateDirection()
        {
            gbDirection.Visible = false;
        }

        public void DeactivateManager()
        {
            gbManager.Visible = false;
        }

        public void DeactivateDepartament()
        {
            gbDepartament.Visible = false;
        }

        public void DeactivateGroup()
        {
            gbGroup.Visible = false;
        }

        #region Кнопки
        private void beCounteragent_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GetRef_Counteragent(sender, e);
        }

        private void beManager_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GetRef_Manager(sender, e);
        }

        private void beDepartament_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GetRef_Departament(sender, e);
        }

        private void beGroup_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GetRef_Group(sender, e);
        }
        #endregion

        private void GetRef_Counteragent(object sender, ButtonPressedEventArgs e)
        {
            (sender as ButtonEdit).Ref(e, DAO.Ref_GetTwMP3_Counteragent(otdel_id, group_id, manager_id), "ID", "NAME");
            counteragent_id = Convert.ToInt32((sender as ButtonEdit).Tag);
        }

        private void GetRef_Manager(object sender, ButtonPressedEventArgs e)
        {
            (sender as ButtonEdit).Ref(e, DAO.Ref_GetTwMP3_Manager(otdel_id, group_id, manager_id), "ID", "NAME");
            manager_id = Convert.ToInt32((sender as ButtonEdit).Tag);
        }

        private void GetRef_Departament(object sender, ButtonPressedEventArgs e)
        {
            (sender as ButtonEdit).Ref(e, DAO.Ref_GetTwMP3_Departament(otdel_id), "ID", "NAME");
            otdel_id = Convert.ToInt32((sender as ButtonEdit).Tag);
        }

        private void GetRef_Group(object sender, ButtonPressedEventArgs e)
        {
            (sender as ButtonEdit).Ref(e, DAO.Ref_GetTwMP3_Group(otdel_id, group_id), "ID", "NAME");
            group_id = Convert.ToInt32((sender as ButtonEdit).Tag);
        }
    }
}
