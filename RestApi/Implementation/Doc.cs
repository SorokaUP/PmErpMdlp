using System;
using System.Threading;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestApi.ResponseClasses;
using ProfitMed.DataContract;
using ProfitMed.Firebird;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RestApi.Implementation
{
    public static class Doc
    {
        /// <summary>
        /// Получить метаданные
        /// </summary>
        public static RestApi.ResponseClasses.ResMsg GetMetadata(string idoc_id)
        {
            var res = new RestApi.ResponseClasses.ResMsg();
            try
            {
                int doc_id = Int32.Parse(idoc_id);
                DataTable data = DAO.GetDocumentById(Sys.Global.USER_ID, doc_id);
                if (data == null)
                    throw new Exception("Не удалось получить данные из БД Firebird");
                if (data.Rows.Count == 0)
                    throw new Exception("Документ не найден");

                DataRow d = data.Rows[0];

                // 5.9. Получение метаданных документа
                Document doc = Sys.Global.WebMethod<Document>(13, null, d["DOCUMENT_ID"].ToString());
                DocumentsList DocList = new DocumentsList();
                DocList.documents = new List<Document>();
                DocList.documents.Add(doc);
                if (Sys.Global.DataProvider == null)
                    Sys.Global.DataProvider = new ProfitMed.Firebird.DataProvider();

                Sys.Global.DataProvider.SaveDocuments(DocList, (int)d["DIRECT"]);

                res.res = 1;
                res.msg = "Выполнено";
            }
            catch (Exception ex)
            {
                res.res = -1;
                res.msg = ex.Message;
                Console.WriteLine(ex.Message);
            }
            return res;
        }

        /// <summary>
        /// Получить XML тело документа
        /// </summary>
        public static RestApi.ResponseClasses.ResMsg GetBody(string idoc_id)
        {
            var res = new RestApi.ResponseClasses.ResMsg();
            try
            {
                int doc_id = Int32.Parse(idoc_id);
                DataTable data = DAO.GetDocumentById(Sys.Global.USER_ID, doc_id);
                if (data == null)
                    throw new Exception("Не удалось получить данные из БД Firebird");
                if (data.Rows.Count == 0)
                    throw new Exception("Документ не найден");

                DataRow d = data.Rows[0];

                string response = Sys.Global.WebMethod<string>(14, null, d["DOCUMENT_ID"].ToString());

                JObject js = JObject.Parse(response);
                string link = (string)js["link"];

                string XmlBody = Encoding.UTF8.GetString(Sys.Global.Api.RequestDownload(Sys.Global.USER_ID, link));
                if (Sys.Global.DataProvider == null)
                    Sys.Global.DataProvider = new ProfitMed.Firebird.DataProvider();

                Sys.Global.DataProvider.SaveDocumentXMLBody(XmlBody, d["DOCUMENT_ID"].ToString());

                res.res = 1;
                res.msg = "Выполнено";
            }
            catch (Exception ex)
            {
                res.res = -1;
                res.msg = ex.Message;
                Console.WriteLine(ex.Message);
            }
            return res;
        }

        /// <summary>
        /// Получить Квитанцию
        /// </summary>
        public static RestApi.ResponseClasses.ResMsg GetTicket(string idoc_id)
        {
            var res = new RestApi.ResponseClasses.ResMsg();
            try
            {
                int doc_id = Int32.Parse(idoc_id);
                DataTable data = DAO.GetDocumentById(Sys.Global.USER_ID, doc_id);
                if (data == null)
                    throw new Exception("Не удалось получить данные из БД Firebird");
                if (data.Rows.Count == 0)
                    throw new Exception("Документ не найден");

                DataRow d = data.Rows[0];

                string response = Sys.Global.WebMethod<string>(16, null, d["DOCUMENT_ID"].ToString());

                JObject js = JObject.Parse(response);
                if (js == null)
                    throw new Exception("Не удалось обработать ответ от МДЛП.");
                string link = (string)js["link"];

                string XmlBody = Encoding.UTF8.GetString(Sys.Global.Api.RequestDownload(Sys.Global.USER_ID, link));
                string TicketResult = "";
                try
                {
                    string opres_begin = "<operation_result>";
                    string opres_end = "</operation_result>";

                    int idxStart = XmlBody.IndexOf(opres_begin);
                    if (idxStart > 0)
                    {
                        idxStart += opres_begin.Length;
                        TicketResult = XmlBody.Substring(idxStart, XmlBody.IndexOf(opres_end) - idxStart);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    TicketResult = "";
                }

                if (Sys.Global.DataProvider == null)
                    Sys.Global.DataProvider = new ProfitMed.Firebird.DataProvider();
                Sys.Global.DataProvider.SaveTicketBodyById(XmlBody, doc_id, TicketResult);

                //--------------------------------------------------------------------------------------------------------

                if (!string.IsNullOrEmpty(XmlBody))
                {
                    XmlDocument xdoc = new XmlDocument();
                    try
                    {
                        xdoc.LoadXml(XmlBody);

                        XmlNodeList errors_nodes = xdoc.SelectNodes("//documents//result//errors");
                        List<Errors_service> errors = new List<Errors_service>();
                        foreach (XmlNode node in errors_nodes)
                        {
                            errors.Add(new Errors_service
                            {
                                error_code = node.SelectSingleNode("error_code").InnerText,
                                error_desc = node.SelectSingleNode("error_desc").InnerText,
                                object_id = node.SelectSingleNode("object_id").InnerText
                            });
                        }
                        if (errors.Count > 0)
                        {
                            if (Sys.Global.DataProvider == null)
                                Sys.Global.DataProvider = new ProfitMed.Firebird.DataProvider();

                            Sys.Global.DataProvider.SaveTicketErrors(errors, doc_id);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Ошибка записи ошибок: " + ex.Message);
                    }
                }

                res.res = 1;
                res.msg = "Выполнено";
            }
            catch (Exception ex)
            {
                res.res = -1;
                res.msg = ex.Message;
                Console.WriteLine(ex.Message);
            }
            return res;
        }

        /// <summary>
        /// Отправить документ
        /// </summary>
        public static RestApi.ResponseClasses.ResMsg Send(string idoc_id)
        {
            var res = new RestApi.ResponseClasses.ResMsg();
            try
            {
                int doc_id = Int32.Parse(idoc_id);
                DataTable data = DAO.GetXmlDocBody(doc_id);
                if (data == null)
                    throw new Exception("Не удалось получить данные из БД Firebird");
                if (data.Rows.Count == 0)
                    throw new Exception("Документ не найден");

                DataRow d = data.Rows[0];

                byte[] body = null;
                XmlSerializer serializer = new XmlSerializer(typeof(Documents));
                using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(d["DOC_BODY"].ToString())))
                {
                    Documents doc = (Documents)serializer.Deserialize(stream);
                    MemoryStream str = new MemoryStream();
                    serializer.Serialize(str, doc);
                    body = stream.ToArray();
                }

                if (Sys.Global.Api == null)
                    Sys.Global.Api = new ProfitMedServiceClient.ProfitMedClient();

                string thumbprint = Sys.Global.Api.GetPublicCertThumbprint(Sys.Global.USER_ID);
                //var sing = Sys.Global.Api.Sign(body, thumbprint);
                string signature = Sys.Global.Api.SignToBase64(body, thumbprint);
                string document = Sys.Global.Api.ConvertBase64String(body);
                string request_id = Guid.NewGuid().ToString();
                Dictionary<string, string> dict = new Dictionary<string, string>
                    {
                        {"document", document },
                        {"sign", signature },
                        {"request_id", request_id }
                    };
                byte[] request_body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(dict));
                int doc_size = Encoding.UTF8.GetByteCount(JsonConvert.SerializeObject(dict));

                if (doc_size > 1048576)
                    throw new Exception("Документ слишком большой! Отправте его методом 5.2.'Отправка документов большого объема'");

                Sys.Global.Api.SaveRequestId(doc_id, request_id);

                string document_id = Sys.Global.WebMethod<string>(5, request_body);
                JObject js = JObject.Parse(document_id);
                document_id = (string)js["document_id"];

                Sys.Global.Api.SaveDocumentId(doc_id, document_id);

                res.res = 1;
                res.msg = "Выполнено";
            }
            catch (Exception ex)
            {
                res.res = -1;
                res.msg = ex.Message;
                Console.WriteLine(ex.Message);
            }
            return res;
        }

        /// <summary>
        /// Обработать тело документа
        /// </summary>
        public static RestApi.ResponseClasses.ResMsg ProcessBody(string idoc_id)
        {
            var res = new RestApi.ResponseClasses.ResMsg();
            try
            {
                int doc_id = Int32.Parse(idoc_id);
                DataTable data = DAO.GetDocumentById(Sys.Global.USER_ID, doc_id);
                if (data == null)
                    throw new Exception("Не удалось получить данные из БД Firebird");
                if (data.Rows.Count == 0)
                    throw new Exception("Документ не найден");

                DataRow d = data.Rows[0];
                if ((int)d["DIRECT"] != 1)
                    throw new Exception("Обработка XML тела документа возможна только для Входящих документов.");

                string doc_body = Sys.Global.DataProvider.GetDocBody(doc_id);
                if (string.IsNullOrEmpty(doc_body))
                    throw new Exception("Отсутствует тело документа.");

                bool resDel = DAO.DelParseDoc(doc_id);    // Собрать документ по разобранному XML

                ProfitMedService.ParseXML parser = new ProfitMedService.ParseXML();
                DataTable parseTable = parser.CreateEDGETable();

                DataTable table = parser.ParseXmlToTable(doc_body);
                foreach (DataRow r in table.Rows)
                {
                    r["doc_id"] = doc_id;
                    r["doc_type"] = (int)d["DOC_TYPE"];
                    parseTable.ImportRow(r);
                }
                Sys.Global.DataProvider.SaveXMLToTable(parseTable);
                bool resPrs = DAO.ParseXml(doc_id);    // Собрать документ по разобранному XML

                res.res = 1;
                res.msg = "Выполнено";
            }
            catch (Exception ex)
            {
                res.res = -1;
                res.msg = ex.Message;
                Console.WriteLine(ex.Message);
            }
            return res;
        }

        /// <summary>
        /// Обработать коробки
        /// </summary>
        public static RestApi.ResponseClasses.ResMsg ProcessSscc(string idoc_id)
        {
            var res = new RestApi.ResponseClasses.ResMsg();
            string tableIndexes = "TBL_SGTIN_INFO_TMP";
            try
            {
                int doc_id = Int32.Parse(idoc_id);
                DataTable data = DAO.GetDocumentById(Sys.Global.USER_ID, doc_id);
                if (data == null)
                    throw new Exception("Не удалось получить данные из БД Firebird");
                if (data.Rows.Count == 0)
                    throw new Exception("Документ не найден");

                DataRow d = data.Rows[0];
                int doc_parent = (int)d["parent"];
                string sender_sys_id = d["sender_sys_id"].ToString();
                bool isError = false;
                string errorMessage = "";

                if ((int)d["doc_type"] != 220)
                    throw new Exception("Метод доступен исключительно для документов типа 220");

                if (Sys.Global.DataProvider == null)
                    Sys.Global.DataProvider = new ProfitMed.Firebird.DataProvider();

                Sys.Global.DataProvider.DeleteTempSgtin(doc_parent);
                Sys.Global.DataProvider.ChangeIndexStatus(tableIndexes, 0);

                try
                {
                    #region Подготовка
                    string xmlTicketBody = "";
                    DataTable bodys = DAO.GetXmlDocBody(doc_id);
                    if (bodys.Rows.Count > 0)
                        xmlTicketBody = bodys.Rows[0]["TICKET_BODY"].ToString();

                    if (string.IsNullOrEmpty(xmlTicketBody))
                    {
                        isError = true;
                        errorMessage = "Ошибка обработки коробок: не получен ticket_body";
                        Console.WriteLine(errorMessage);
                        goto TEnd;
                    }
                    #endregion
                    #region Сохраняем коробки
                    List<SsccInfo> sscc_info = new List<SsccInfo>();
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.LoadXml(xmlTicketBody);
                    try
                    {
                        // Сначала вставляем коробки, коробка верхнего уровня вставлена при обработке основного документа
                        XmlNode parent = xdoc.SelectSingleNode("//documents//hierarchy_info//sscc_down//sscc_info//childs");
                        GetChildsSscc(ref sscc_info, parent, 1, sender_sys_id);
                        if (sscc_info.Count > 0)
                            Sys.Global.DataProvider.SaveSsccInfo(sscc_info, doc_parent);
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            string warningTagOpen = "<operation_warning>";
                            string warningTagClose = "</operation_warning>";
                            if (xmlTicketBody.Contains(warningTagOpen))
                            {
                                int iSubsStart = xmlTicketBody.IndexOf(warningTagOpen) + warningTagOpen.Length;
                                int iSubsEnd = xmlTicketBody.IndexOf(warningTagClose) - iSubsStart;
                                throw new Exception("ОШИБКА от МДЛП: " + xmlTicketBody.Substring(iSubsStart, iSubsEnd));
                            }
                            else
                                throw ex;
                        }
                        catch (Exception exx)
                        {
                            isError = true;
                            errorMessage = "Сохранение SSCC :: " + exx.Message;
                            Console.WriteLine(errorMessage);
                            goto TEnd;
                        }
                    }
                    #endregion
                    #region Сохраняем SGTIN
                    // Вставляем Sgtins
                    try
                    {
                        XmlNodeList sgtinInfo = xdoc.SelectNodes("//sgtin_info");
                        List<InfoSgtin> info_sgtin = new List<InfoSgtin>();
                        foreach (XmlNode node in sgtinInfo)
                        {
                            InfoSgtin sgtin = new InfoSgtin();
                            sgtin.sgtin = node.SelectSingleNode("sgtin").InnerText;
                            sgtin.gtin = node.SelectSingleNode("gtin").InnerText;
                            sgtin.sscc = node.SelectSingleNode("sscc").InnerText;
                            sgtin.series_number = node.SelectSingleNode("series_number").InnerText;
                            sgtin.status = node.SelectSingleNode("status").InnerText;
                            sgtin.expiration_date = node.SelectSingleNode("expiration_date").InnerText;
                            info_sgtin.Add(sgtin);
                        }
                        if (info_sgtin.Count > 0)
                            Sys.Global.DataProvider.SaveSgtinInfoTmp(info_sgtin, doc_parent);
                    }
                    catch (Exception ex)
                    {
                        isError = true;
                        errorMessage = "Сохранение SGTIN :: " + ex.Message;
                        Console.WriteLine(errorMessage);
                        goto TEnd;
                    }
                    #endregion

                    // Меняем статус документа на "Ответ обработан"
                    Sys.Global.DataProvider.ChangeDocResult(doc_id, 2005);
                    // Сохраняем информацию об SGTIN (с очисткой временной таблицы)
                    Sys.Global.DataProvider.SaveSgtinInfo();
                }
                catch { }

                TEnd:
                Sys.Global.DataProvider.ChangeIndexStatus(tableIndexes, 1);
                Sys.Global.DataProvider.SetIndexStatistic(tableIndexes);

                if (!isError)
                {
                    res.res = 1;
                    res.msg = "Выполнено";
                }
                else
                {
                    res.res = -1;
                    res.msg = errorMessage;
                }
            }
            catch (Exception ex)
            {
                res.res = -1;
                res.msg = ex.Message;
                Console.WriteLine(ex.Message);

                try
                {
                    if (Sys.Global.DataProvider == null)
                        Sys.Global.DataProvider = new ProfitMed.Firebird.DataProvider();

                    Sys.Global.DataProvider.ChangeIndexStatus(tableIndexes, 1);
                    Sys.Global.DataProvider.SetIndexStatistic(tableIndexes);
                }
                catch { }
            }
            return res;
        }
        private static void GetChildsSscc(ref List<SsccInfo> sscc_info, XmlNode parent_node, int level, string sender_sys_id)
        {
            XmlNodeList childs_node = parent_node.SelectNodes("//sscc_info");
            string parent_value = parent_node.ParentNode.SelectSingleNode("sscc").InnerText ?? String.Empty;
            int i = level++;
            foreach (XmlNode node in childs_node)
            {
                if (node.ParentNode == parent_node)
                {
                    SsccInfo ssccInfo = new SsccInfo();
                    ssccInfo.sscc = node.SelectSingleNode("sscc").InnerText;
                    ssccInfo.level = level;
                    ssccInfo.release_date = node.SelectSingleNode("packing_date").InnerText;
                    ssccInfo.parent_sscc = parent_value;
                    ssccInfo.system_subj_id = sender_sys_id;
                    ssccInfo.status = 1;
                    sscc_info.Add(ssccInfo);

                    GetChildsSscc(ref sscc_info, node.SelectSingleNode("childs"), i, sender_sys_id);
                }
            }

        }
    }
}
