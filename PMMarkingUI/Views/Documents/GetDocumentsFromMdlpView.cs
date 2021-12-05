using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using ProfitMed.DataContract;
using ProfitMedServiceClient;
using Newtonsoft.Json;
using PMMarkingUI.Classes;

namespace PMMarkingUI.Views
{
    public partial class GetDocumentsFromMdlpView : UserControl
    {
        ProfitMedClient Api = new ProfitMedClient();
        static object locker = new object();
        GetDocsParam Param = null;

        public GetDocumentsFromMdlpView()
        {
            InitializeComponent();
            this.Text = "Получить документы";
            Tag = true;
        }

        private void GetDocsIncome(object sender)
        {
            DocFilters filter = DocFilterPanel.GetFilter();
            LogAdd("Получение входящих документов");            

            Param = new GetDocsParam(filter, "income", 1000);
            /*Thread myThread = new Thread(new ThreadStart(*/
            Execute();//));
            //myThread.Name = "GetDocsIncome";
            //myThread.Start();
        }

        private void GetDocsOutcome(object sender)
        {
            DocFilters filter = DocFilterPanel.GetFilter();
            LogAdd("Получение исходящих документов");

            Param = new GetDocsParam(filter, "outcome", 1000);
            Thread myThread = new Thread(new ThreadStart(Execute));
            myThread.Name = "GetDocsOutcome";
            myThread.Start();
        }

        delegate void dLogAdd(string text);

        private void LogAdd(string s, bool isNeedNewLine = true)
        {
            if (tbLog.InvokeRequired)
                tbLog.Invoke(new Action<string>((ns) => tbLog.AppendText(ns)), GetLogLine(s, isNeedNewLine));
            else
                tbLog.AppendText(GetLogLine(s, isNeedNewLine));
        }

        private string GetLogLine(string s, bool isNeedNewLine)
        {
            return $"[{DateTime.Now.ToLongTimeString()}] {s}" + ((isNeedNewLine) ? Environment.NewLine : "");
        }

        private void Log_PrintFilter(DocFilters filter)
        {
            LogAdd("Применен фильтр:");
            LogAdd($"* Период: {filter.filter.start_date} - {filter.filter.end_date}");
            LogAdd($"* Тип документа: {filter.filter.doc_type}");
            LogAdd($"* Статус документа: {filter.filter.doc_status}");
            LogAdd($"* Тип загрузки: {filter.filter.file_uploadtype}");
            LogAdd($"* Период обработки: {filter.filter.processed_date_from} - {filter.filter.processed_date_to}");
            LogAdd($"* Отправитель: {filter.filter.sender_id}");
            LogAdd($"* Получатель: {filter.filter.receiver_id}");
            LogAdd("");
        }

        private void Send210DocDown(string document_id)
        {
            //ProfitMed.Firebird.DataProvider dp = new ProfitMed.Firebird.DataProvider();
            int doc_id = 0;
            doc_id = Sys.Global.DataProvider.GetDocumentId(document_id);
            LogAdd($"Получаем список коробок за документом [{document_id}]");
            Application.DoEvents();
            if (doc_id == 0) return;
            DataTable table = Sys.Global.DataProvider.GetSsccDocDown(doc_id);
            if (table.Rows.Count == 0)
            {
                LogAdd("Коробок на документе - нет!");
                Application.DoEvents();
                return;
            }
            LogAdd($"* Получено коробок: {table.Rows.Count}");
            Application.DoEvents();

            foreach(DataRow row in table.Rows)
            {
                string body = Create220DocDown(row["out_sscc"].ToString());
                int new_doc_id = Sys.Global.DataProvider.CreateChildDocument(doc_id, 220);
                Sys.Global.DataProvider.SaveDocBodyById(body, doc_id);
                Classes.WebMethods.DocumentSend(body, new_doc_id);
                LogAdd($"** [{row["out_sscc"].ToString()}] - отправлена **");
                Application.DoEvents();
            }
        }

        private string Create220DocDown(string sscc)
        {
            string session_ui = Guid.NewGuid().ToString().ToLower();
            StringBuilder xml_body = new StringBuilder();
            xml_body.Append($"<documents session_ui = \"{session_ui}\" version = \"{Sys.Global.VERSION}\">");
            xml_body.Append("<query_hierarchy_info action_id = \"220\">");
            xml_body.Append($"<subject_id>{Sys.Global.SYS_OBJ_ID}</subject_id>");
            xml_body.Append($"<sscc>{sscc}</sscc>");
            xml_body.Append("</query_hierarchy_info>");
            xml_body.Append("</documents>");

            return xml_body.ToString();
        }

        public void Execute()
        {
            lock (locker)
            {
                Log_PrintFilter(Param.filter);
                Classes.WebMethods.GetDocumentsFromMdlp(LogAdd, Param, Send210DocDown);
            }
        }

        #region Пункты меню
        private void tsmiGetDocs_Income_Click(object sender, EventArgs e)
        {
            GetDocsIncome(sender);
        }
        private void tsmiGetDocs_Outcome_Click(object sender, EventArgs e)
        {
            GetDocsOutcome(sender);
        }
        private void очиститьОбластьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbLog.Text = "";
        }
        #endregion
    }
}
