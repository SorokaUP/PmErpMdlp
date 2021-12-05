using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProfitMed.Firebird;
using DevExpress.XtraTreeList.Nodes;

namespace PMMarkingUI.Forms
{
    public partial class frmDocumentAddSgtins : Form
    {
        TreeListNode rootSlave;
        TreeListNode rootMain;
        int doc_id;
        public frmDocumentAddSgtins()
        {
            InitializeComponent();
            this.doc_id = 170;
            DataTable doc = DAO.GetDocumentById(Sys.Global.USER_ID, this.doc_id);
            vGridControl.DataSource = doc;
            vGridControl.LayoutChanged();

            DataTable data = DAO.GetDocBodyList(this.doc_id);

            tlDataSlave.Nodes.Clear();
            rootSlave = tlDataSlave.Nodes.Add();            

            tlDataMain.Nodes.Clear();
            rootMain = tlDataMain.Nodes.Add();
            /*for (int i = 0; i < 10; i++)
            {
                string r = i.ToString().PadLeft(5, '0');
                var root = rootMain.Nodes.Add(r);
                root["SSCC_ID"] = i;
                root["SSCC"] = r;
                for (int x = 0; x < 20; x++)
                {
                    string c = r + x.ToString().PadLeft(5, '0');
                    var node = root.Nodes.Add(c);
                    node["SSCC_ID"] = i;
                    node["SSCC"] = r;
                    node["SGTIN"] = c;
                    node["SGTIN_ID"] = x;
                }
            }*/
            TreeListNode root = null;
            foreach (DataRow row in data.Rows)
            {
                // Если коробка есть, проверяем с тем что пришло, чтобы лишний раз не бегать по циклу
                if (root != null)
                {
                    if ((int)root["SSCC_ID"] != (int)row["SSCC_ID"])
                        root = null;
                }
                if (root == null)
                {
                    // Пытаемся найти существующую коробку
                    foreach (TreeListNode item in rootMain.Nodes)
                    {
                        if ((int)item["SSCC_ID"] == (int)row["SSCC_ID"])
                        {
                            root = item;
                            break;
                        }
                    }

                    // Создаем коробку
                    root = rootMain.Nodes.Add();
                    SetNodeData(root, row, true);
                }
                TreeListNode child = root.Nodes.Add();
                SetNodeData(child, row, false);
            }

            tlDataMain.ExpandAll();
            tlDataSlave.ExpandAll();

            tlDataMain.OptionsView.ShowSummaryFooter = false;
            tlDataMain.OptionsView.ShowRowFooterSummary = false;
            tlDataSlave.OptionsView.ShowSummaryFooter = false;
            tlDataSlave.OptionsView.ShowRowFooterSummary = false;

            rootMain.Visible = false;
            rootSlave.Visible = false;
        }

        private void SetNodeData(TreeListNode node, DataRow row, bool isSSCC)
        {
            int sscc_id = 0;
            if (row["SSCC_ID"] == DBNull.Value)
                sscc_id = 0;
            else
                sscc_id = Convert.ToInt32(row["SSCC_ID"]);
            node["SSCC_ID"] = sscc_id;

            string sscc = "";
            if (row["SSCC"] == DBNull.Value)
                sscc = "";
            else
                sscc = row["SSCC"].ToString();
            node["SSCC"] = sscc;

            int sgtin_id = 0;
            if (row["SGTIN_ID"] == DBNull.Value)
                sgtin_id = 0;
            else
                sgtin_id = Convert.ToInt32(row["SGTIN_ID"]);
            node["SGTIN_ID"] = (isSSCC) ? 0 : sgtin_id;

            string sgtin = "";
            if (row["SGTIN"] == DBNull.Value)
                sgtin = "";
            else
                sgtin = row["SGTIN"].ToString();
            node["SGTIN"] = (isSSCC) ? "" : sgtin;
        }

        private void vGridControl_RecordCellStyle(object sender, DevExpress.XtraVerticalGrid.Events.GetCustomRowCellStyleEventArgs e)
        {
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (TreeListNode node in tlDataMain.GetAllCheckedNodes())
            {
                if (node.Nodes.Count != 0)
                    continue;

                tlDataMain.MoveNode(node, rootSlave);
            }

            CheckEmptySSCC(rootMain);
        }

        private void CheckEmptySSCC(TreeListNode root)
        {
            for (int i = tlDataMain.Nodes.Count - 1; i >= 0; i--)
            {
                CheckEmptySSCC_Cycle(root.Nodes[i]);
            }
            tlDataMain.ExpandAll();
            tlDataMain.UncheckAll();
            tlDataSlave.ExpandAll();
            tlDataSlave.UncheckAll();

            rootMain.Visible = false;
            rootSlave.Visible = false;
        }

        private void CheckEmptySSCC_Cycle(TreeListNode root)
        {
            if (root.Nodes.Count == 0)
                if (root["SSCC_ID"] != null && root["SGTIN_ID"] == null)
                {
                    //root.Remove();
                    root.Visible = false;
                    return;
                }

            foreach (TreeListNode node in root.Nodes)
            {
                if (node.Nodes.Count == 0)
                {
                    if (node["SSCC_ID"] != null && node["SGTIN_ID"] == null)
                        root.Visible = false;
                }
                else
                    CheckEmptySSCC_Cycle(node);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (TreeListNode node in tlDataSlave.GetAllCheckedNodes())
            {
                if (node == rootSlave)
                    continue;

                TreeListNode sscc = rootMain;
                foreach (TreeListNode item in rootMain.Nodes)
                {
                    if ((int)item["SSCC_ID"] == (int)node["SSCC_ID"])
                    {
                        sscc = item;
                        sscc.Visible = true;
                        break;
                    }
                }
                
                tlDataSlave.MoveNode(node, sscc);
            }

            CheckEmptySSCC(rootSlave);
        }
    }
}
