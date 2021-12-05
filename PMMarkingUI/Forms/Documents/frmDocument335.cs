using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMMarkingUI.Forms;
using PMMarkingUI.Classes;
using ProfitMed.Firebird;
using ProfitMedServiceClient;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Sys;
using ExcelDataReader;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraVerticalGrid.Rows;

namespace PMMarkingUI.Forms.Documents
{
    public partial class frmDocument335 : Form
    {
        DataTable dtData;
        public int doc_id { get; private set; }
        public frmDocument335(int doc_id)
        {
            InitializeComponent();
            this.doc_id = doc_id;

            dtData = CreateStructure();

            vData.SetDefaultGridViewOptions();
            vData.CheckBoxesPost();
            cData.DataSource = dtData;
        }

        private DataTable CreateStructure()
        {
            DataTable res = new DataTable();
            res.Columns.Add("HANDLE_SELECT", typeof(int));
            res.Columns.Add("MSG", typeof(string));
            res.Columns.Add("GTIN", typeof(string));

            res.Columns.Add("OBJECT_ID", typeof(string));
            res.Columns.Add("COST", typeof(decimal));
            res.Columns.Add("NDS", typeof(int)).DefaultValue = 10;
            res.Columns.Add("TAX", typeof(decimal)).DefaultValue = 3;

            return res;
        }
    }
}
