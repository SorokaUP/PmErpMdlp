using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMMarkingUI.Views
{
    public partial class SerchObjectsInMdlpByListView : UserControl
    {
        public SerchObjectsInMdlpByListView()
        {
            InitializeComponent();
            this.Text = "Множественный поиск SGTIN";
            this.Tag = false;
        }

        bool isNeedSleep = false;
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data.Columns.Add("OBJECT_ID", typeof(string));
            data.Columns.Add("SSCC", typeof(string));
            data.Columns.Add("BRANCH_ID", typeof(string));
            data.Columns.Add("STATUS", typeof(string));
            data.Columns.Add("NAME", typeof(string));
                        
            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------

            ProfitMed.DataContract.SSFilter WebFilterSgtin = new ProfitMed.DataContract.SSFilter();
            WebFilterSgtin.filter = new ProfitMed.DataContract.Sfilter();
            WebFilterSgtin.filter.sgtins = new List<string>();

            foreach (string line in textBox1.Lines)
            {
                string object_id = ClearTags(line);

                if (String.IsNullOrEmpty(object_id) || object_id.Length != 27)
                    continue;
                WebFilterSgtin.filter.sgtins.Add(object_id);

                if (WebFilterSgtin.filter.sgtins.Count == 400)
                {
                    GoSgtin(WebFilterSgtin, data);
                    WebFilterSgtin.filter.sgtins.Clear();
                }                    
            }
            GoSgtin(WebFilterSgtin, data);

            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------

            ProfitMed.DataContract.SsccList WebFilterSscc = new ProfitMed.DataContract.SsccList();
            WebFilterSscc.sscc = new List<string>();

            foreach (string line in textBox1.Lines)
            {
                string object_id = ClearTags(line);

                if (String.IsNullOrEmpty(object_id) || object_id.Length != 18)
                    continue;
                WebFilterSscc.sscc.Add(object_id);

                if (WebFilterSscc.sscc.Count == 30)
                {
                    GoSscc(WebFilterSscc, data);
                    WebFilterSscc.sscc.Clear();
                }
            }
            GoSscc(WebFilterSscc, data);

            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------

            cData.DataSource = data;
            vData.LayoutChanged();

            tbSsccList.Text = "";
            List<string> ssccList = new List<string>();
            foreach (DataRow row in data.Rows)
            {
                if (!ssccList.Contains(row["SSCC"].ToString()))
                {
                    ssccList.Add(row["SSCC"].ToString());
                }
            }
            foreach (string item in ssccList)
            {
                if (!String.IsNullOrEmpty(item))
                    tbSsccList.Text += item + System.Environment.NewLine;
            }

            isNeedSleep = false;
        }

        protected string ClearTags(string s)
        {
            return s
                    .Replace("object_id", "")
                    .Replace("sgtin", "")
                    .Replace("'", "")
                    .Replace(" ", "")
                    .Replace(",", "")
                    .Replace("<", "")
                    .Replace(">", "")
                    .Trim();
        }

        private void GoSgtin(ProfitMed.DataContract.SSFilter WebFilter, DataTable data)
        {
            if (WebFilter.filter.sgtins.Count == 0)
                return;

            try
            {
                if (isNeedSleep)
                    System.Threading.Thread.Sleep(1000);

                //ProfitMed.DataContract.SgtinByList res = Sys.Global.WebMethod<ProfitMed.DataContract.SgtinByList>(149, WebFilter);
                ProfitMed.DataContract.PublicSgtinByList2 res = Sys.Global.WebMethod<ProfitMed.DataContract.PublicSgtinByList2>(150, WebFilter);
                isNeedSleep = true;

                if (res == null)
                {
                    MessageBox.Show("Ошибка");
                }

                foreach (var item in res.entries)
                {
                    //textBox2.Text += $"{item.sgtin} ({((string.IsNullOrEmpty(res.entries[0].pack3_id)) ? " < НЕ В КОРОБКЕ > " : res.entries[0].pack3_id)}) : {item.sys_id} : {item.status} от {item.status_date} : {item.federal_subject_name} :: {item.prod_name}" + Environment.NewLine;
                    //textBox2.Text += $"{item.sgtin} ({((string.IsNullOrEmpty(res.entries[0].sscc)) ? " < НЕ В КОРОБКЕ > " : res.entries[0].sscc)}) : {item.branch_id} : {item.status} :: {item.prod_name}" + Environment.NewLine;
                    DataRow row = data.Rows.Add();
                    row["OBJECT_ID"] = item.sgtin;
                    row["SSCC"] = ((string.IsNullOrEmpty(item.sscc)) ? "" : item.sscc);
                    row["BRANCH_ID"] = item.branch_id;
                    row["STATUS"] = item.status;
                    row["NAME"] = item.prod_name;
                }
                foreach (var item in res.failed_entries)
                {
                    //textBox2.Text += $"{item.sgtin} : ошибка {item.error_code.ToString().PadLeft(4, ' ')} : {item.error_desc}" + Environment.NewLine;
                    DataRow row = data.Rows.Add();
                    row["OBJECT_ID"] = item;
                    row["SSCC"] = "";
                    row["BRANCH_ID"] = "";
                    row["STATUS"] = "";
                    row["NAME"] = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GoSscc(ProfitMed.DataContract.SsccList WebFilter, DataTable data)
        {
            if (WebFilter.sscc.Count == 0)
                return;

            try
            {
                if (isNeedSleep)
                    System.Threading.Thread.Sleep(1000);

                ProfitMed.DataContract.SsccResponse res = Sys.Global.WebMethod<ProfitMed.DataContract.SsccResponse>(179, WebFilter);
                isNeedSleep = true;

                if (res == null)
                {
                    MessageBox.Show("Ошибка");
                }

                foreach (var item in res.entries)
                {
                    DataRow row = data.Rows.Add();
                    row["OBJECT_ID"] = item.sscc;
                    row["SSCC"] = "";
                    row["BRANCH_ID"] = item.owner_id;
                    row["STATUS"] = item.status;
                    row["NAME"] = "";
                }
                foreach (var item in res.failed_entries)
                {
                    DataRow row = data.Rows.Add();
                    row["OBJECT_ID"] = item.sscc;
                    row["SSCC"] = "";
                    row["BRANCH_ID"] = "";
                    row["STATUS"] = item.error_code.ToString();
                    row["NAME"] = item.error_desc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnPasteFromClipboard_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text += Clipboard.GetText();
            }
            catch { }
        }
    }
}
