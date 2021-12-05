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
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;

namespace PMMarkingUI.Forms
{
    public partial class frmCreateDocumentOutcome_ShowSelected : Form
    {
        private List<SelectedDataDoc> Selected;
        int IndexDID = 0;
        int IndexEID = 0;
        int IndexSGTIN = 0;
        int IndexSGTIN2 = 0;
        public frmCreateDocumentOutcome_ShowSelected(List<SelectedDataDoc> Selected)
        {
            InitializeComponent();
            this.Selected = Selected;
        }

        private void frmCreateDocumentOutcome_ShowSelected_Shown(object sender, EventArgs e)
        {
            IndexDID = tlData.Columns["DID"].AbsoluteIndex;
            IndexEID = tlData.Columns["EID"].AbsoluteIndex;
            IndexSGTIN = tlData.Columns["SGTIN"].AbsoluteIndex;

            tlData.Nodes.Clear();

            foreach (SelectedDataDoc selDoc in Selected)
            {
                if (selDoc.Doc == null)
                    continue;

                foreach (SelectedDataLin selLin in selDoc.Lins)
                {
                    if (selLin.Lin == null)
                        continue;

                    foreach (TreeListNode sgtin in selLin.SGTINs)
                    {
                        if (IndexSGTIN2 == 0)
                            IndexSGTIN2 = sgtin.TreeList.Columns["SGTIN"].AbsoluteIndex;

                        TreeListNode node = tlData.Nodes.Add();
                        node.SetValue(IndexDID, (int)selDoc.Doc["DID"]);
                        node.SetValue(IndexEID, (int)selLin.Lin["EID"]);
                        node.SetValue(IndexSGTIN, sgtin.GetValue(IndexSGTIN2));
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
