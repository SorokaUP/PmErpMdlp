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
    public partial class SerchSsccInMdlpByListView : UserControl
    {
        public SerchSsccInMdlpByListView()
        {
            InitializeComponent();
            this.Text = "ТЕСТ. Поиск коробок";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            //data.Columns.Add("OBJECT_ID", typeof(string));
            data.Columns.Add("SSCC", typeof(string));
            data.Columns.Add("BRANCH_ID", typeof(string));
            data.Columns.Add("STATUS", typeof(string));
            data.Columns.Add("NAME", typeof(string));

            data.Rows.Clear();

            foreach (string sscc in textBox1.Text.Split(','))
            {
                DataRow row = data.NewRow();
                row["SSCC"] = sscc;

                try
                {
                    System.Threading.Thread.Sleep(500);

                    ProfitMed.DataContract.Filters<ProfitMed.DataContract.SsccSgtinsFilter> filter = new ProfitMed.DataContract.Filters<ProfitMed.DataContract.SsccSgtinsFilter>();
                    filter.filter = new ProfitMed.DataContract.SsccSgtinsFilter();
                    filter.start_from = 0;
                    filter.count = 10;
                    ProfitMed.DataContract.SgtinsListFromSscc resSSCC = WebMethod<ProfitMed.DataContract.SgtinsListFromSscc>(156, filter, sscc);
                    if (resSSCC.total > 0)
                    {
                        row["BRANCH_ID"] = resSSCC.entries[0].owner + " " + (resSSCC.entries[0].Sscc ?? resSSCC.entries[0].pack3_id ?? "");
                        row["STATUS"] = resSSCC.entries[0].status;
                        row["NAME"] = resSSCC.entries[0].full_prod_name;
                    }
                }
                catch (Exception ex)
                {

                }

                data.Rows.Add(row);
            }

            cData.DataSource = data;
            vData.LayoutChanged();
        }



        private T WebMethod<T>(int MethodId, object Body, params string[] QueryParam)
        {
            try
            {
                ProfitMedServiceClient.ProfitMedClient Api = new ProfitMedServiceClient.ProfitMedClient();

                if (QueryParam != null)
                    if (QueryParam.Length == 0)
                        QueryParam = null;
                DataTable MethodsTable = ProfitMed.Firebird.DAO.GetWebMethods(MethodId);
                DataRow MethodInfo = MethodsTable.Rows[0];
                string RequestType = MethodInfo["REQUEST_TYPE"].ToString();
                string ResponseType = MethodInfo["RESPONSE_TYPE"].ToString();
                byte[] RequestBody = null;
                if (Body != null)
                {
                    if (MethodId == 5)
                        RequestBody = (byte[])Body;
                    else
                        if (RequestType == "application/json")
                        RequestBody = Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(Body));
                    else
                        RequestBody = Encoding.UTF8.GetBytes(Body.ToString());
                }

                byte[] ApiRes = Api.RequestManager(MethodId, Sys.Global.USER_ID, RequestBody, QueryParam);
                string ApiResString = Encoding.UTF8.GetString(ApiRes);
                if (typeof(T) == typeof(string) || ResponseType != "application/json")
                    return (T)Convert.ChangeType(ApiResString, typeof(T));
                try
                {
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(ApiResString);
                }
                catch (Exception ex)
                {
                    return (T)Convert.ChangeType(ApiResString, typeof(T));
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Console.WriteLine("Ошибка! " + ex.Message);
                return (T)Convert.ChangeType(null, typeof(T));
            }
        }
    }
}
