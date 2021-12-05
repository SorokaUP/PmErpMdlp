using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using PMMarkingUI.Forms;
using PMMarkingUI.Classes;
using PMMarkingUI.Delegats;
using ProfitMed.Firebird;
using ProfitMed.DataContract;
using ProfitMedServiceClient;
using DevExpress.XtraGrid.Views.Grid;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PMMarkingUI.Classes
{
    public static class WebMethods
    {
        #region ТЕСТИРОВАНИЕ
        /// <summary>
        /// ТЕСТИРОВАНИЕ ЦИКЛОВ
        /// </summary>
        public static void TestCycle()
        {
            Filters<PartnersFilter> WebFilter = new Filters<PartnersFilter>
            {
                filter = new PartnersFilter { reg_entity_type = 1 },
                start_from = 0,
                count = 10
            };

            DateTime start = DateTime.Now;
            var temp = Sys.Global.WebMethodFiltered<PartnersFilter, CountragentsList, FilteredRecords>(166, WebFilter);

            TimeSpan TotalTime = DateTime.Now.Subtract(start);
            MessageBox.Show("Выполнено за: " + Additional.TimeFormat(TotalTime.Hours, TotalTime.Minutes, TotalTime.Seconds) + Environment.NewLine + "Вернуло: " + (temp != null));
        }
        #endregion
        #region ДОКУМЕНТЫ
        /// <summary>
        /// 5.1 Отправка документа
        /// </summary>
        /// <param name="DOC_BODY"></param>
        //public static void DocumentSend(string DOC_BODY)
        public static void DocumentSend(string DOC_BODY, int doc_id, bool isShowRes = true)
        {
            try
            {
                byte[] body = null;
                XmlSerializer serializer = new XmlSerializer(typeof(Documents));
                using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(DOC_BODY)))
                {
                    Documents doc = (Documents)serializer.Deserialize(stream);
                    MemoryStream str = new MemoryStream();
                    serializer.Serialize(str, doc);
                    body = stream.ToArray();
                }

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

                if (isShowRes)
                  MessageBox.Show("Выполнено");
            }
            catch (Exception ex)
            {
                if(isShowRes)
                  MessageBox.Show("Ошибка! " + ex.Message);
            }
        }
        /// <summary>
        /// 5.2 Отправка документа большого объема
        /// </summary>
        /// <param name="DOCUMENT_ID"></param>
        public static void DocumentSendLarge(string doc_body, int doc_id)
        {
            try
            {
                byte[] body = null;
                XmlSerializer serializer = new XmlSerializer(typeof(Documents));
                using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(doc_body)))
                {
                    Documents doc = (Documents)serializer.Deserialize(stream);
                    MemoryStream str = new MemoryStream();
                    serializer.Serialize(str, doc);
                    body = stream.ToArray();
                }

                string thumbprint = Sys.Global.Api.GetPublicCertThumbprint(Sys.Global.USER_ID);
                string signature = Sys.Global.Api.SignToBase64(body, thumbprint);
                string request_id = Guid.NewGuid().ToString();
                string hashdocument = Sys.Global.Api.GetHashSum256(body);

                Dictionary<string, string> body_d = new Dictionary<string, string> {
                    { "sign", signature },
                    { "hash_sum", hashdocument },
                    { "request_id", request_id }
                };

                byte[] request_body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(body_d));

                Sys.Global.Api.SaveRequestId(doc_id, request_id);

                string response = Sys.Global.WebMethod<string>(6, request_body);

                JObject js = JObject.Parse(response);
                string document_id = (string)js["document_id"];
                string link = (string)js["link"];

                Sys.Global.Api.SaveDocumentId(doc_id, document_id);

                int code = Int16.Parse(Encoding.UTF8.GetString(Sys.Global.Api.RequestUpload(Sys.Global.USER_ID, link, body)));

                if (code == 201)
                    Sys.Global.WebMethod(8, Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(new Dictionary<string, string> { { "document_id", document_id } })));
                else
                    Sys.Global.WebMethod(10, Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(new Dictionary<string, string> { { "document_id", document_id }, { "request_id", request_id } })));
                
                MessageBox.Show("Выполнено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! " + ex.Message);
            }            
        }
        /// <summary>
        /// 5.3 Загрузка документа большого объема
        /// </summary>
        /// <param name="DOCUMENT_ID"></param>
        public static void DocumentLoadLarge(string DOCUMENT_ID)
        {
            try
            {
                MessageBox.Show("В разработке");
                //Sys.Global.WebMethod(7, null, DOCUMENT_ID);
                return;

                MessageBox.Show("Выполнено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! " + ex.Message);
            }
        }
        /// <summary>
        /// 5.9. Получение метаданных документа
        /// </summary>
        /// <param name="DOCUMENT_ID"></param>
        /// <param name="DIRECT"></param>
        public static void DocumentGetMetadata(string DOCUMENT_ID, int DIRECT, bool isShowRes = true)
        {
            try
            {
                Document doc = Sys.Global.WebMethod<Document>(13, null, DOCUMENT_ID);
                DocumentsList DocList = new DocumentsList();
                DocList.documents = new System.Collections.Generic.List<Document>();
                DocList.documents.Add(doc);
                Sys.Global.DataProvider.SaveDocuments(DocList, DIRECT);

                if(isShowRes)
                  MessageBox.Show("Выполнено");
            }
            catch (Exception ex)
            {
                if (isShowRes)
                  MessageBox.Show("Ошибка! " + ex.Message);
            }
        }
        /// <summary>
        /// 5.12 Получение квитанции по номеру исходящего документа
        /// </summary>
        /// <param name="DOCUMENT_ID"></param>
        /// <param name="DIRECT"></param>
        public static void DocumentGetTiket(string DOCUMENT_ID, int doc_id, bool isShowRes = true)
        {
            try
            {
                string response = Sys.Global.WebMethod<string>(16, null, DOCUMENT_ID);

                JObject js = JObject.Parse(response);
                if (js == null) return;
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
                            Sys.Global.DataProvider.SaveTicketErrors(errors, doc_id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                //--------------------------------------------------------------------------------------------------------

                if (isShowRes)
                  MessageBox.Show("Выполнено");
            }
            catch (Exception ex)
            {
                if (isShowRes)
                  MessageBox.Show("Ошибка! " + ex.Message);
            }
        }
        /// <summary>
        /// 5.10 Получение документа по идентификатору
        /// </summary>
        /// <param name="DOCUMENT_ID"></param>
        public static bool DocumentGetDoc(string DOCUMENT_ID, bool isShowRes = true)
        {
            try
            {
                string response = Sys.Global.WebMethod<string>(14, null, DOCUMENT_ID);

                JObject js = JObject.Parse(response);
                string link = (string)js["link"];

                string XmlBody = Encoding.UTF8.GetString(Sys.Global.Api.RequestDownload(Sys.Global.USER_ID, link));
                Sys.Global.DataProvider.SaveDocumentXMLBody(XmlBody, DOCUMENT_ID);

                if (isShowRes)
                    MessageBox.Show("Выполнено");

                return true;
            }
            catch (Exception ex)
            {
                if (isShowRes)
                    MessageBox.Show("Ошибка! " + ex.Message);
                return false;
            }
        }
        /// <summary>
        /// (!ТОЛЬКО ДЛЯ ИСХОДЯЩИХ!) 5.13 Получить электронную подпись исходящего документа
        /// </summary>
        /// <param name="DOCUMENT_ID"></param>
        public static void DocumentGetECP(string DOCUMENT_ID)
        {
            try
            {
                string st = Sys.Global.WebMethod<string>(17, null, DOCUMENT_ID);

                MessageBox.Show("Выполнено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! " + ex.Message);
            }
        }
        /// <summary>
        /// (!ТОЛЬКО ДЛЯ ИСХОДЯЩИХ!) 5.11 Получение списка документов по идентификатору запроса
        /// </summary>
        /// <param name="REQUEST_ID"></param>
        /// <param name="DIRECT"></param>
        public static void DocumentGetListByRequestId(string REQUEST_ID, int DIRECT)
        {
            try
            {
                DocumentsList DocList = Sys.Global.WebMethod<DocumentsList>(15, null, REQUEST_ID);
                if (DocList.documents != null)
                    if (DocList.documents.Count > 0)
                    {
                        Sys.Global.DataProvider.SaveDocuments(DocList, DIRECT);
                        MessageBox.Show("Выполнено");
                        return;
                    }
                MessageBox.Show("Документов не найдено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! " + ex.Message);
            }
        }
        /// <summary>
        /// 8.5.4 Метод для получения публичной информации о производимом ЛП
        /// </summary>
        public static void GetInfoByGtin(Control ctrl, string GTIN)
        {
            using (AdditionalEvent ae = new AdditionalEvent(ctrl, "8.5.4 Метод для получения публичной информации о производимом ЛП", 0))
            {
                try
                {
                    Sys.Global.WebMethod<string>(160, null, GTIN);
                    //TODO: Сохранять результаты в базу
                    MessageBox.Show("Информация получена. Список данных будет обновлен.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }
        /// <summary>
        /// 8.4.2 Получить информацию по выбранным коробкам
        /// </summary>
        public static bool GetSsccInfo(Control ctrl, int doc_id, List<IdName> data)
        {
            bool res = false;
            using (AdditionalEvent ae = new AdditionalEvent(ctrl, "8.4.2 Получить информацию по выбранным коробкам", 0))
            {
                try
                {
                    bool isExist = false;
                    foreach (IdName sscc in data)
                    {
                        /*if (!sscc.Checked)
                            continue;*/

                        Filters<SsccSgtinsFilter> filter = new Filters<SsccSgtinsFilter>();
                        filter.filter = new SsccSgtinsFilter();

                        SgtinsListFromSscc resWeb = new SgtinsListFromSscc();
                        resWeb.entries = new List<Sgtin>();
                        int StartFromApi = 0;
                        int FixLimitApi = 100;
                        bool isNeedIteration;
                        int SleepMs = 5000;

                        do
                        {
                            filter.start_from = StartFromApi;
                            filter.count = FixLimitApi;
                            SgtinsListFromSscc temp = Sys.Global.WebMethod<SgtinsListFromSscc>(156, filter, sscc.Name);

                            // Переливаем временные данные в общую кучу
                            //for (int x = 0; x < temp.entries.Count; x++)
                            resWeb.entries.AddRange(temp.entries);

                            // Необходимость следующей итерации (всего по фильтру в API - всего перелитых в кучу)
                            isNeedIteration = (temp.total - resWeb.entries.Count > 0);

                            // Наращиваем индексы поиска
                            StartFromApi += FixLimitApi;

                            // Пауза между вызовами методов
                            if (isNeedIteration)
                                System.Threading.Thread.Sleep(SleepMs);
                        }
                        while (isNeedIteration);
                        if (resWeb.entries.Count > 0)
                            Sys.Global.DataProvider.SaveSgtins(resWeb.entries, sscc.Id, doc_id);

                        if (isExist)
                            System.Threading.Thread.Sleep(500);
                        isExist = true;
                    }

                    if (isExist)
                    {
                        res = true;
                        MessageBox.Show("Информация получена. Список данных будет обновлен.");
                    }
                    else
                    {
                        res = false;
                        MessageBox.Show("Информация отсутствует");
                    }
                }
                catch (Exception ex)
                {
                    res = false;
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
            return res;
        }
        /// <summary>
        /// 8.4.1 Получить иерархию вложенности третичных упаковок (коробок)
        /// </summary>
        /// <param name="sscc"></param>
        public static bool GetSsccHierarhy(Control ctrl, int doc_id, List<IdName> data)
        {
            bool res = false;
            using (AdditionalEvent ae = new AdditionalEvent(ctrl, "8.4.1 Получить иерархию вложенности третичных упаковок (коробок)", 0))
            {
                try
                {
                    bool isExist = false;
                    foreach (IdName sscc in data)
                    {

                        SsccHierarchy resWeb = Sys.Global.WebMethod<SsccHierarchy>(155, null, sscc.Name);
                        Sys.Global.DataProvider.SaveSsccInfoForDoc(resWeb, doc_id, sscc.Name);
                        if (isExist)
                            System.Threading.Thread.Sleep(5000);
                        isExist = true;
                    }

                    if (isExist)
                    {
                        res = true;
                        MessageBox.Show("Информация получена. Список данных будет обновлен.");
                    }
                }
                catch (Exception ex)
                {
                    res = false;
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
            return res;
        }
        /// <summary>
        /// Получение документов из МДЛП
        /// </summary>
        /// <param name="LogAdd"></param>
        /// <param name="Param"></param>
        /// <param name="Send210DocDown"></param>
        public static void GetDocumentsFromMdlp(DelegateLogAdd LogAdd, GetDocsParam Param, DelegateVoidString Send210DocDown)
        {
            LogAdd("Начато");

            int FixLimitApi = 100; // Количество документов в пакете, приинмаемое от МДЛП
            int StartFromApi = 0; // Поиск с первого
            int TotalDocuments = 0; // Общее кол-во документов
            int Iteration = 0; // Номер обращения к серверу
            bool isNeedIteration = false;
            //ProfitMed.Firebird.DataProvider dp = new ProfitMed.Firebird.DataProvider();
            try
            {
                int direction = 0;
                int MethodId = 0;
                switch (Param.mode)
                {
                    case "income":
                        direction = 1;
                        MethodId = 12;
                        break;

                    case "outcome":
                        direction = -1;
                        MethodId = 11;
                        break;

                    default:
                        throw new Exception($"Вызов неизвестного значения \"{Param.mode}\"");
                }

                do
                {
                    Iteration++;
                    LogAdd($"Запрос: {Iteration}");

                    Param.filter.start_from = StartFromApi;
                    Param.filter.count = FixLimitApi;

                    //-------------------------------------------------------------------------------------                        
                    DocumentsList DocList = Sys.Global.WebMethod<DocumentsList>(MethodId, Param.filter);
                    Sys.Global.DataProvider.SaveDocuments(DocList, direction);

                   /* if (DocList.documents.Count > 0 && direction == 1)
                    {
                        LogAdd($"Получаем содержиемое xml для {DocList.documents.Count} документа(ов)!");
                        Application.DoEvents();
                        // Сразу получаем содержимое xml
                        foreach (Document doc in DocList.documents)
                        {
                            bool res = Classes.WebMethods.DocumentGetDoc(doc.document_id, false);
                            LogAdd(String.Concat($"Содержимое для [{doc.document_id}] - ", res ? "получено" : "ошибка"));
                            Application.DoEvents();
                        }

                        LogAdd("Обрабатываем Xml содержимое документов!");
                        Application.DoEvents();
                        Sys.Global.Api.ProcessedXmlBody();
                        LogAdd("Xml содержимое обработано!");
                        Application.DoEvents();

                        //TODO: при наличие коробок создать и отправить документы 210 для каждой
                        foreach (Document doc in DocList.documents)
                            Send210DocDown(doc.document_id);
                    }*/
                    //-------------------------------------------------------------------------------------

                    // Переливаем временные данные в общую кучу
                    TotalDocuments += DocList.documents.Count;
                    LogAdd($" - итого: {TotalDocuments} документов");
                    Application.DoEvents();
                    // Необходимость следующей итерации (всего по фильтру в API - всего перелитых в кучу)
                    isNeedIteration = (DocList.total - TotalDocuments > 0);

                    // Наращиваем индексы поиска
                    StartFromApi += FixLimitApi;

                    // Пауза между вызовами методов
                    if (isNeedIteration)
                        Thread.Sleep(Param.SleepMs);
                }
                while (isNeedIteration);
            }
            catch (Exception ex)
            {
                LogAdd("");
                LogAdd($"ОШИБКА: {ex.Message}");
            }
            LogAdd($"Документов всего получено: {TotalDocuments}");
            LogAdd("Окончено");
            LogAdd("-------------------------------------");
        }
        #endregion
        #region КОНТРАГЕНТЫ
        /// <summary>
        /// Добавить/удалить из доверенных
        /// </summary>
        /// <param name="mode"></param>
        public static bool CounteragentsToVerify(string mode, List<string> inns, Control ctrl, bool isNeedGetCounteragentInfo = true, bool isNeedResultMessage = true)
        {
			if (!new string[] { "add", "del", "info" }.Contains(mode))
            {
                MessageBox.Show("Не удалось определить режим работы");
                return false;
            }
			if (inns.Count == 0 && mode != "info")
            {
                MessageBox.Show("ИНН не переданы");
                return false;
            }
            bool res = true;
            DataTable FinalDataTable = new DataTable();
            FinalDataTable.Columns.Add("INN", typeof(string));
            FinalDataTable.Columns.Add("IS_RESPONSE", typeof(int));
            FinalDataTable.Columns.Add("PACK_NUM", typeof(int));
            string header = "Метод работы с доверенными контрагентами";
            using (AdditionalEvent ae = new AdditionalEvent(ctrl, header, 0))
            {
                try
                {
                    int SleepMs = 1000;

                    //------------------------------------------------------------------------------------
                    // ШАГ 1. Получаем список выбранных контрагентов (их ИНН) и отправляем запрос в МДЛП

                    int PackNum = 0;
                    int PackLim = 100;
                    bool isNeedPause = false;                
                    string strErrors = "";
                    int CurrIndex = 0;
                    if (mode != "info")
                    {
                        ae.Maximum = inns.Count / PackLim + 1;
                        do
                        {
                            PackNum++;
                            if (PackNum == 1)
                                CurrIndex = 0;
                            if (isNeedPause)
                                Thread.Sleep(SleepMs); // В случае, если пакет не один, устанавливаем паузу между запросами
                            else
                                isNeedPause = true;

                            int LastInns = inns.Count - PackNum * PackLim;
                            int NeedInns = ((LastInns >= 0) ? PackLim : LastInns + PackLim);
                            List<string> pack = new List<string>();
                            for (int i = 0; i < NeedInns; i++)
                            {
                                pack.Add(inns[CurrIndex]);
                                DataRow row = FinalDataTable.NewRow();
                                row["INN"] = inns[CurrIndex];
                                row["IS_RESPONSE"] = 0;
                                row["PACK_NUM"] = PackNum;
                                FinalDataTable.Rows.Add(row);
                                CurrIndex++;
                            }

                            ae.Caption = header + Environment.NewLine + $"Пакет {PackNum} из {inns.Count / PackLim} (записей в пакете: {pack.Count} / {PackLim}. Всего {inns.Count})";
                            Application.DoEvents();

                            // Отправляем запрос в МДЛП                    
                            string responseApi = "";
                            try
                            {
                                TrustedPartnersArray WebData = new TrustedPartnersArray();
                                WebData.trusted_partners = pack.ToArray();

                                switch (mode)
                                {
                                    case "add":
                                        responseApi = Sys.Global.WebMethod<string>(163, WebData);
                                        break;

                                    case "del":
                                        responseApi = Sys.Global.WebMethod<string>(164, WebData);
                                        break;
                                }
                            }
                            catch (Exception ex)
                            {
                                responseApi = ex.Message;
                            }
                            finally
                            {
                                strErrors += (responseApi == "") ? "" : responseApi + ";"; // "200 (OK)"
                            }

                            ae.Value++;
                        }
                        while (inns.Count - CurrIndex > 0);
                    }

                    //------------------------------------------------------------------------------------
                    // ШАГ 2. Запрашиваем у МДЛП данные обо всех (или одном конкретном) доверенных контрагентах

                    ae.Caption = header + Environment.NewLine + "Запрашиваем у МДЛП данные обо всех доверенных контрагентах";

                    // 8.7.3 Метод фильтрации доверенных контрагентов
                    TrustedPartnersFilter filter = new TrustedPartnersFilter();
                    // Если был выбран 1 контрагент, то заполняем фильтр
                    if (inns.Count == 1)
                        filter.trusted_inn = inns[0];

                    // Запрашиваем список доверенных контрагентов
                    ListTrustedPartners tplResponse = CounteragentsGetVerifyList(filter, ctrl, false);

                    //------------------------------------------------------------------------------------
                    // ШАГ 3. Сравниваем отправленные и полученные данные (ИНН)
                    
                    if (mode == "add" || mode == "del")
                    {
                        ae.Caption = header + Environment.NewLine + "Сравниваем отправленные и полученные данные (ИНН)";
                        int flag = (mode == "add") ? 1 : 0;
                        isNeedPause = false;
                        bool isFind = false;
                        string sys_id = "";
                        foreach (DataRow row in FinalDataTable.Rows)
                        {
                            string inn = row["INN"].ToString();

                            isFind = false;
                            sys_id = "";
                            // Ищем среди полученных доверенных контрагентов ИНН из списка переданных в МДЛП из шага 1
                            foreach (TrustedPartners tp in tplResponse.entries)
                            {
                                if (tp.inn == inn)
                                {
                                    isFind = true;
                                    sys_id = tp.sys_id ?? "";
                                    break;
                                }
                            }
                            // ИНН был найден и выбран режим добавления в доверенные
                            // ИНН не был найден и выбран режим удаления из доверенных
                            if ((isFind && mode == "add") || (!isFind && mode == "del"))
                            {
                                if (!String.IsNullOrEmpty(inn))
                                {
                                    // Пишем полученные sys_id по ИНН
                                    DAO.ToVerify(inn, sys_id, flag);
                                    row["IS_RESPONSE"] = 1;
                                    // Получаем информацию по контрагенту
                                    if (mode == "add")
                                    {
                                        if (isNeedGetCounteragentInfo)
                                        {
                                            if (isNeedPause)
                                                Thread.Sleep(SleepMs);
                                            else
                                                isNeedPause = true;

                                            GetCounteragentInfoByInn(ctrl, false, inn, false);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (mode == "info")
                    {
                        ae.Caption = header + Environment.NewLine + "Стирание всех ссылок на контрагентов";

                        // Чистим список доверенных
                        DAO.AllNoneVerify();                        

                        // Ищем среди полученных доверенных контрагентов ИНН из списка переданных в МДЛП из шага 1
                        DataTable data = new DataTable();
                        data.Columns.Add("INN", typeof(string));
                        data.Columns.Add("SYS_ID", typeof(string));
                        data.Columns.Add("FLAG", typeof(int));

                        foreach (TrustedPartners tp in tplResponse.entries)
                        {
                            DataRow row = data.NewRow();
                            row["INN"] = tp.inn;
                            row["SYS_ID"] = tp.sys_id ?? "";
                            row["FLAG"] = 1;
                            data.Rows.Add(row);
                        }
                        if (data.Rows.Count > 0)
                        {
                            int CPackLim = 100;
                            int total = data.Rows.Count;
                            ae.Value = 0;
                            ae.Maximum = total;

                            DAO.ToVerify(data, CPackLim, () => 
                            {
                                ae.Caption = header + Environment.NewLine + $"Синхронизация данных {ae.Value} из {total}";
                                ae.Value += CPackLim;
                                Application.DoEvents();
                            });
                        }
                    }
                    

                    //------------------------------------------------------------------------------------
                    // Подведение итогов

                    ae.Caption = header + Environment.NewLine + "Подведение итогов";
                    string FinishMessage = "";
                    if (strErrors.Length > 0)
                        FinishMessage = $"Выполнено с ошибками: {strErrors}";
                    else
                        FinishMessage = "Выполнено успешно";

                    // Вывод итоговой формы
                    if (isNeedResultMessage && mode != "info")
                    {
                        frmCounteragentVerifyFinish frm = new frmCounteragentVerifyFinish(FinalDataTable, FinishMessage);
                        frm.ShowDialog();
                    }
                    FinalDataTable.Dispose();
                    res = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                    res = false;
                }
            }
            return res;
        }
        /// <summary>
        /// 8.7.3 Метод фильтрации доверенных контрагентов
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="SleepMs"></param>
        /// <returns></returns>
        public static ListTrustedPartners CounteragentsGetVerifyList(TrustedPartnersFilter filter, Control ctrl, bool isNeedLockLayer = true)
        {
            int iCycle = 0;
            int limitReCycle = 5;
            int total = 0;
            int SleepMs = 500;
            ListTrustedPartners tplResponse = new ListTrustedPartners();
            tplResponse.entries = new List<TrustedPartners>();
            int FixLimitApi = 100;
            int StartFromApi = 0;
            bool isNeedIteration = false;
            AdditionalEvent ae = null;
            if (isNeedLockLayer)
                ae = new AdditionalEvent(ctrl, "8.7.3 Метод фильтрации доверенных контрагентов", 0);

            Console.WriteLine($">> Метод получения списка доверенных контрагентов: НАЧАЛО");
            Console.WriteLine($"Лимит на пакет: {FixLimitApi}");
            Console.WriteLine($"Попыток на пакет: {limitReCycle}");
            Console.WriteLine($"");
            do
            {
                iCycle++;
                TrustedPartnerFilters WebFilter = new TrustedPartnerFilters
                {
                    filter = filter,
                    start_from = StartFromApi,
                    count = FixLimitApi
                };

                ListTrustedPartners temp = new ListTrustedPartners();
                bool isNeedReCycle = false;
                int iReCycle = 0;
                do
                {
                    try
                    {
                        isNeedReCycle = false;                        
                        Console.Write($"Пакет: {iCycle}");
                        temp = Sys.Global.WebMethod<ListTrustedPartners>(165, WebFilter);
                        if (total == 0)
                            total = temp.total;
                        Console.WriteLine($"   успешно");
                    }
                    catch
                    {
                        Console.WriteLine($"   не удачно");
                        temp = new ListTrustedPartners();
                        temp.entries = new List<TrustedPartners>();
                        temp.total = -1;
                    }

                    // Ловим ошибки
                    if (temp == null)
                    {
                        isNeedReCycle = true;

                        temp = new ListTrustedPartners();
                        temp.entries = new List<TrustedPartners>();
                        temp.total = -1;
                    }
                    else
                    {
                        if (temp.entries == null)
                        {
                            isNeedReCycle = true;

                            temp.entries = new List<TrustedPartners>();
                            temp.total = -1;
                        }
                    }

                    // Если не вернулись данные, перезапускаем итерацию цикла
                    if (isNeedReCycle)
                    {
                        iReCycle++;
                        Console.WriteLine($"   повтор цикла ({iReCycle}), данные не вернулись");
                        Thread.Sleep(1000);
                    }
                }
                while (isNeedReCycle && iReCycle <= limitReCycle);

                #region Переливаем временные данные в общую кучу и определяем необходимость следующей итерации
                // Переливаем временные данные в общую кучу
                tplResponse.entries.AddRange(temp.entries);

                // Необходимость следующей итерации (всего по фильтру в API - всего перелитых в кучу)
                isNeedIteration = (total - tplResponse.entries.Count > 0);

                // Наращиваем индексы поиска
                StartFromApi += FixLimitApi;

                // Пауза между вызовами методов
                if (isNeedIteration)
                    Thread.Sleep(SleepMs);
                #endregion
            }
            while (isNeedIteration && StartFromApi <= total);
            tplResponse.total = tplResponse.entries.Count;

            if (StartFromApi > total)
                Console.WriteLine($"Индекс начала поиска больше общего количества! Что-то пошло не так! (total = {total})");
            if (isNeedLockLayer)
                ae.Dispose();
            Console.WriteLine($">> Метод получения списка доверенных контрагентов: КОНЕЦ");
            return tplResponse;
        }
        /// <summary>
        /// 8.8.1. Метод фильтрации по субъектам обращения
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="isNeedBlockLayer"></param>
        /// <param name="i_INN"></param>
        /// <param name="isNeedResultMessage"></param>
        public static bool GetCounteragentInfoByInn(Control ctrl, bool isNeedBlockLayer, string inn, bool isNeedResultMessage = true)
        {
            bool res = false;
            bool isCycle = string.IsNullOrEmpty(inn);
            int FixLimitApi = 15; // Максимум 46 как показал тест
            int StartFromApi = 0;
            bool isNeedIteration = false;
            int SleepMs = 1000;
            int limitReCycle = 5;
            AdditionalEvent ae = null;
            if (isNeedBlockLayer)
                ae = new AdditionalEvent(ctrl, "8.8.1. Метод фильтрации по субъектам обращения", 0);
            try
            {
                CountragentsList result = new CountragentsList();
                result.filtered_records = new List<FilteredRecords>();
                do
                {
                    PartnersFilters WebFilter = new PartnersFilters
                    {
                        filter = new PartnersFilter { reg_entity_type = 1 },
                        start_from = StartFromApi,
                        count = FixLimitApi
                    };
                    if (!string.IsNullOrEmpty(inn))
                        WebFilter.filter.inn = inn;

                    CountragentsList temp = new CountragentsList();
                    bool isNeedReCycle = false;
                    int iReCycle = 0;
                    do
                    {
                        try
                        {
                            isNeedReCycle = false;
                            // 8.8.1. Метод фильтрации по субъектам обращения
                            temp = Sys.Global.WebMethod<CountragentsList>(166, WebFilter);
                            isNeedReCycle = (temp == null);
                        }
                        catch (Exception ex)
                        {
                            isNeedReCycle = true;
                        }

                        // Если не вернулись данные, перезапускаем итерацию цикла
                        if (isNeedReCycle)
                        {
                            iReCycle++;
                            Console.WriteLine($"   повтор запроса контрагента ({iReCycle}), данные не вернулись");
                            Thread.Sleep(5000);
                        }
                    }
                    while (isNeedReCycle && iReCycle <= limitReCycle);


                    /*try
                    {
                        // 8.8.1. Метод фильтрации по субъектам обращения
                        temp = Sys.Global.WebMethod<CountragentsList>(166, WebFilter);
                    }
                    catch
                    {
                        temp = new CountragentsList();
                    }*/

                    // Переливаем временные данные в общую кучу
                    for (int x = 0; x < temp.filtered_records.Count; x++)
                        result.filtered_records.Add(temp.filtered_records[x]);

                    // Необходимость следующей итерации (всего по фильтру в API - всего перелитых в кучу)
                    isNeedIteration = (temp.filtered_records_count - result.filtered_records.Count > 0);

                    // Наращиваем индексы поиска
                    StartFromApi += FixLimitApi;

                    // Пауза между вызовами методов
                    if (isNeedIteration)
                        Thread.Sleep(SleepMs);
                }
                while (isNeedIteration);

                if (result.filtered_records.Count > 0)
                {
                    result.session_id = Sys.Global.DataProvider.GetSessionID();
                    Sys.Global.DataProvider.SaveCountragentsList(result);
                    DAO.CounteragentParsing(result.session_id);
                }
                else
                {
                    if (isCycle)
                        throw new Exception($"Не удалось получить данные о контрагентах");
                    else
                        throw new Exception($"Не удалось получить данные о контрагенте по ИНН {inn}");
                }

                res = true;
                if (isNeedResultMessage)
                    MessageBox.Show($"Информация о контрагенте с ИНН {inn} получена");
            }
            catch (Exception ex)
            {
                if (isNeedResultMessage)
                    MessageBox.Show(ex.Message);
                res = false;
            }
            finally
            {
                if (isNeedBlockLayer)
                    ae.Dispose();
            }
            return res;
        }
        /// <summary>
        /// 8.8.1. Метод фильтрации по субъектам обращения
        /// </summary>
        public static void GetCounteragentInfoBySysId(string system_subj_id)
        {
            PartnersFilters WebFilter = new PartnersFilters
            {
                filter = new PartnersFilter { reg_entity_type = 1 },
                start_from = 0,
                count = 1
            };
            WebFilter.filter.system_subj_id = system_subj_id.ToLower();
            try
            {
                CountragentsList temp = Sys.Global.WebMethod<CountragentsList>(166, WebFilter);

                if (temp.filtered_records.Count > 0)
                {
                    temp.session_id = Sys.Global.DataProvider.GetSessionID();
                    Sys.Global.DataProvider.SaveCountragentsList(temp);
                    DAO.CounteragentParsing(temp.session_id);
                }
                else
                    MessageBox.Show($"Нет информации о контрагенте {WebFilter.filter.system_subj_id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}, контрагент {WebFilter.filter.system_subj_id}");
            }
        }
        /// <summary>
        /// 8.8.1. Метод фильтрации по субъектам обращения
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="isNeedBlockLayer"></param>
        /// <param name="i_INN"></param>
        /// <param name="isNeedResultMessage"></param>
        public static string GetCounteragentSysId(Control ctrl, bool isNeedBlockLayer, string inn, bool isNeedResultMessage = true)
        {
            if (string.IsNullOrEmpty(inn))
                throw new Exception("Не указан ИНН");

            string res = "";
            int FixLimitApi = 40; // Максимум 46 как показал тест
            int StartFromApi = 0;
            AdditionalEvent ae = null;
            if (isNeedBlockLayer)
                ae = new AdditionalEvent(ctrl, "8.8.1. Метод фильтрации по субъектам обращения", 0);
            try
            {
                PartnersFilters WebFilter = new PartnersFilters
                {
                    filter = new PartnersFilter { reg_entity_type = 1, inn = inn },
                    start_from = StartFromApi,
                    count = FixLimitApi
                };

                CountragentsList result = new CountragentsList();
                try
                {
                    // 8.8.1. Метод фильтрации по субъектам обращения
                    result = Sys.Global.WebMethod<CountragentsList>(166, WebFilter);
                }
                catch
                {
                    result = new CountragentsList();
                }

                if (result.filtered_records.Count > 0)
                {
                    res = result.filtered_records[0].system_subj_id;

                    result.session_id = Sys.Global.DataProvider.GetSessionID();
                    Sys.Global.DataProvider.SaveCountragentsList(result);
                    DAO.CounteragentParsing(result.session_id);
                }
                else
                {
                    throw new Exception($"Не удалось получить данные о контрагенте по ИНН {inn}");
                }

                if (isNeedResultMessage)
                    MessageBox.Show($"Информация о контрагенте с ИНН {inn} получена");
            }
            catch (Exception ex)
            {
                if (isNeedResultMessage)
                    MessageBox.Show(ex.Message);
                res = "";
            }
            finally
            {
                if (isNeedBlockLayer)
                    ae.Dispose();
            }
            return res;
        }
        /// <summary>
        /// Синхронизировать базу данных контрагентов с МДЛП
        /// </summary>
        /// <param name="isMessage"></param>
        public static bool CounteragentsSyncWithMdlp(Control ctrl, bool isMessage = true)
        {
            bool res = false;
            if (isMessage)
                if (MessageBox.Show("Синхронизировать базу доверенных контрагентов с МДЛП?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                    return false;

            using (AdditionalEvent ae = new AdditionalEvent(ctrl, "Синхронизация базы контрагентов с МДЛП", 0))
            {
                try
                {
                    // ШАГ 1. Актуализируем список всех участников МДЛП
                    GetCounteragentInfoByInn(ctrl, false, "", false);

                    // ШАГ 2. Актуализируем список ВСЕХ доверенных контрагентов
                    ListTrustedPartners lst = CounteragentsGetVerifyList(new TrustedPartnersFilter(), ctrl, false);
                    DAO.AllNoneVerifyTW();
                    DAO.AllNoneVerify();
                    foreach (TrustedPartners item in lst.entries)
                        DAO.ToVerify(item.inn, item.sys_id, 1);

                    res = true;
                    MessageBox.Show("Выполнено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
            return res;
        }
        #endregion
        #region Реестр КИЗ
        /// <summary>
        /// 8.3.4 Метод для получения детальной информации о КИЗ и связанным с ним ЛП
        /// </summary>
        /// <param name="REQUEST_ID"></param>
        /// <param name="DIRECT"></param>
        public static bool KizGetInfo(string sgtin)
        {
            try
            {
                DetailInfoFromSgtin data = Sys.Global.WebMethod<DetailInfoFromSgtin>(151, null, sgtin);
                if (data != null)
                    if (data.gtin_info != null)
                    {
                        List<Gtin> gtins = new List<Gtin>();
                        gtins.Add(data.gtin_info);
                        Sys.Global.DataProvider.SaveGtin(gtins);
                        MessageBox.Show("Выполнено");
                        return true;
                    }
                MessageBox.Show("Информация о GTIN не получена");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! " + ex.Message);                
            }
            return false;
        }
        /// <summary>
        /// 8.3.2. Метод поиска по реестру КИЗ по списку значений
        /// </summary>
        public static bool KizSerchBySgtin(Control ctrl, int doc_id, List<string> SGTINs)
        {
            bool res = false;
            using (AdditionalEvent ae = new AdditionalEvent(ctrl, "8.3.2. Метод поиска по реестру КИЗ по списку значений", 0))
            {
                try
                {
                    int PackLim = 500;
                    int PackNum = 0;
                    bool isNeedCycle = SGTINs.Count > PackLim;
                    SSFilter sgtin_filter = new SSFilter();
                    sgtin_filter.filter = new Sfilter();
                    ae.Maximum = SGTINs.Count / PackLim;

                    do
                    {
                        // Расчет отбора данных для цикла
                        int factLim = SGTINs.Count - PackLim * PackNum;
                        int forTo = (factLim > PackLim) ? (PackLim * (PackNum + 1)) : SGTINs.Count;
                        List<string> SGTINs_pack = new List<string>();

                        for (int i = PackNum * PackLim; i < forTo; i++)
                            SGTINs_pack.Add(SGTINs[i]);
                        if (SGTINs_pack.Count > 0)
                        {
                            sgtin_filter.filter.sgtins = SGTINs_pack;
                            SgtinByList resWeb = Sys.Global.WebMethod<SgtinByList>(149, sgtin_filter);
                            Sys.Global.DataProvider.SaveSgtins(resWeb.entries, 0, doc_id);

                            res = true;
                            //MessageBox.Show("Информация получена. Список данных будет обновлен.");
                        }
                        else
                        {
                            res = false;
                            //MessageBox.Show("SGTIN не выбраны!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        // Расчет необходимости следующего цикла
                        PackNum++;
                        ae.Value++;
                        isNeedCycle = SGTINs.Count - PackLim * PackNum > 0;
                        if (isNeedCycle)
                            Thread.Sleep(1000);
                    }
                    while (isNeedCycle);

                    
                    if (res)
                        MessageBox.Show("Информация получена. Список данных будет обновлен.");
                    else
                        MessageBox.Show("SGTIN не выбраны!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    res = false;
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
            return res;
        }
        #endregion
        #region УЧЕТНЫЕ СИСТЕМЫ
        /// <summary>
        /// 6.1.1. Метод для регистрации учетной системы
        /// </summary>
        public static void RegistrationAccountSystem(string sys_id, string name)
        {
            AccountSystemRegisterRequest body = new AccountSystemRegisterRequest();
            body.sys_id = sys_id;
            body.name = name;
            var res = Sys.Global.WebMethod<AccountSystemRegisterResponse>(27, body);
            // TODO: 6.1.1. Save
        }
        /// <summary>
        /// 6.1.10. Метод для получения информации о зарегистрированных сертификатах пользователя
        /// </summary>
        public static void GetUserCerts(string USER_ID)
        {
            UserCertFilter body = new UserCertFilter();
            body.start_from = 0;
            body.count = 100;

            var res = Sys.Global.WebMethod<UserCertResponse>(36, body, USER_ID);
            Sys.Global.DataProvider.SaveCertificates(res.certs, USER_ID);
        }
        /// <summary>
        /// 6.1.11. Метод для получения информации об УС
        /// </summary>
        public static void AccountSystemGetInfo(string ACCOUNT_SYSTEM_ID)
        {
            var res = Sys.Global.WebMethod<AccountSystemResponse>(37, null, ACCOUNT_SYSTEM_ID);
            if (res != null)
            {
                DAO.ACCOUNTSYSTEM_IU(res.account_system.account_system_id, res.account_system.name, res.account_system.client_id);
                WebMethods.GetCounteragentInfoBySysId(res.account_system.client_id);
            }
            else
            {
                MessageBox.Show("Учетная система не найдена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 6.3.1. Метод для удаления пользователей учетной системы
        /// </summary>
        public static void AccountSystemDeleteUser(string USER_ID)
        {
            var res = Sys.Global.WebMethod<string>(41, null, USER_ID);
            res = (res.IndexOf("200") > 0) ? "Успешно" : "Ошибка";
            MessageBox.Show(res);
        }
        /// <summary>
        /// 6.3.2. Метод для удаления учетной системы
        /// </summary>
        public static void DeleteAccountSystem(string ACCOUNT_SYSTEM_ID)
        {
            var res = Sys.Global.WebMethod<string>(42, null, ACCOUNT_SYSTEM_ID);
            res = (res.IndexOf("200") > 0) ? "Успешно" : "Ошибка";
            MessageBox.Show(res);
        }
        /// <summary>
        /// 6.8.2. Метод для поиска УС по фильтру
        /// </summary>
        public static void GetAccountSystemByFilter(string name)
        {
            Filters<AccountSystemFilter> WebFilter = new Filters<AccountSystemFilter>();
            WebFilter.start_from = 0;
            WebFilter.count = 10;
            WebFilter.filter = new AccountSystemFilter { name = name };

            bool isExist = false;
            //var res = Sys.Global.WebMethodFiltered<AccountSystemFilter, AccountSystemsList, AccountSystem>(60, WebFilter);
            var res = Sys.Global.WebMethod<AccountSystemFilteredResponse>(60, WebFilter);
            if (res != null)
            {
                foreach (AccountSystem acs in res.account_systems) 
                {
                    isExist = true;
                    DAO.ACCOUNTSYSTEM_IU(acs.account_system_id, acs.name, acs.client_id);
                }
            }
            
            if (!isExist)
            {
                MessageBox.Show("Учетная система не найдена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region ПОЛЬЗОВАТЕЛИ
        /// <summary>
        /// 6.1.2. Метод для регистрации пользователей (для резидентов страны)
        /// </summary>
        public static void RegistrationUser(UserRequest body)
        {
            var res = Sys.Global.WebMethod<User>(28, body);
            // TODO: по полученному res.sys_id получить информацию и записать в базу
        }
        /// <summary>
        /// 6.1.4. Метод для получения информации о пользователе
        /// </summary>
        public static void GetUserInfo(string USER_ID, bool isOnlyRights = false)
        {
            if (!isOnlyRights)
            {
                var res = Sys.Global.WebMethod<UserResponse>(30, null, USER_ID);
                DAO.UsersIU(res.user.user_id, res.user.first_name, res.user.last_name, res.user.middle_name, res.user.sys_id, res.user.position, res.user.is_admin, null, null);
            }            
            // Сохраняем группы и права пользователя
            WebMethods.GetGroupRightsInfoByFilter("", USER_ID);
        }
        /// <summary>
        /// 6.1.5. Метод для получения информации о настройках профиля текущего пользователя
        /// </summary>
        public static void GetUserSettingsProfile()
        {
            var res = Sys.Global.WebMethod<string>(31, null);
            // TODO: 6.1.5. возвращается ru | en
        }
        /// <summary>
        /// 6.1.6. Метод для изменения данных профиля пользователя
        /// </summary>
        public static void SetUserSettingsProfile(string USER_ID, string first_name, string last_name, string middle_name, string email, string position)
        {
            UserEditProfileEntry body = new UserEditProfileEntry();
            body.first_name = first_name;
            body.last_name = last_name;
            body.middle_name = middle_name;
            body.email = email;
            body.position = position;

            var res = Sys.Global.WebMethod<string>(32, body, USER_ID);
            res = (res.IndexOf("200") > 0) ? "Успешно" : "Ошибка";
            MessageBox.Show(res);
        }
        /// <summary>
        /// 6.1.7. Метод для получения информации о текущем пользователе
        /// </summary>
        public static void GetCurrentUserInfo()
        {
            var res = Sys.Global.WebMethod<UserResponse>(33, null);
            DAO.UsersIU(res.user.user_id, res.user.first_name, res.user.last_name, res.user.middle_name, res.user.sys_id, res.user.position, res.user.is_admin, res.user.email, null);
        }
        /// <summary>
        /// 6.1.8. Метод для изменения настроек профиля текущего пользователя
        /// </summary>
        public static void ChangeUserSettingsProfile(string language)
        {
            string[] arr = new string[] { "ru", "en" };
            if (!arr.Contains(language))
                return;
            string body = language;
            var res = Sys.Global.WebMethod<string>(34, body);
            res = (res.IndexOf("200") > 0) ? "Успешно" : "Ошибка";
            MessageBox.Show(res);
        }
        /// <summary>
        /// 6.1.9. Метод для получения информации о зарегистрированных сертификатов текущего пользователя
        /// </summary>
        public static void GetCurrentUserCerts()
        {
            UserCertFilter body = new UserCertFilter();
            body.start_from = 0;
            body.count = 100;

            var res = Sys.Global.WebMethod<UserCertResponse>(35, body);
            Sys.Global.DataProvider.SaveCertificates(res.certs, Sys.Global.USER_ID);
        }
        /// <summary>
        /// 6.4.1. Метод для добавления ЭП пользователя (для резидентов)
        /// </summary>
        public static void AddUserSign(string USER_ID, string public_cert)
        {
            UserPublicCert body = new UserPublicCert();
            body.public_cert = public_cert;

            var res = Sys.Global.WebMethod<string>(43, body, USER_ID);
            res = (res.IndexOf("200") > 0) ? "Успешно" : "Ошибка";
            MessageBox.Show(res);
        }
        /// <summary>
        /// 6.4.2. Метод для удаления ЭП пользователя (для резидентов)
        /// </summary>
        public static void DeleteUserSing(string USER_ID, string public_cert)
        {
            UserPublicCert body = new UserPublicCert();
            body.public_cert = public_cert;

            var res = Sys.Global.WebMethod<string>(44, null, USER_ID);
            res = (res.IndexOf("200") > 0) ? "Успешно" : "Ошибка";
            MessageBox.Show(res);
        }
        /// <summary>
        /// 6.7.2. Метод для поиска зарегистрированных пользователей по фильтру
        /// </summary>
        public static void GetUserInfoByFilter(int AS_ID, string first_name, string last_name, string middle_name, string login, string is_admin, List<string> statuses)
        {
            Filters<UserFilter> WebFilter = new Filters<UserFilter>
            {
                filter = new UserFilter {
                    first_name = first_name,
                    last_name = last_name,
                    middle_name = middle_name,
                    login = login,
                    is_admin = is_admin,
                    statuses = statuses
                },
                start_from = 0,
                count = 20
            };

            var res = Sys.Global.WebMethodFiltered<UserFilter, UserFilterResponse, GroupedUser>(58, WebFilter);
            foreach (GroupedUser u in res)
            {
                DAO.UsersIU(u.user_id, u.first_name, u.last_name, u.middle_name, u.sys_id, u.position, u.is_admin, u.email, AS_ID);
            }
        }
        /// <summary>
        /// 7.8.1. Метод для получения информации о всех местах осуществления деятельности и местах ответственного хранения участника
        /// </summary>
        public static void GetOrgAddresses()
        {
            var res = Sys.Global.WebMethod<AddressEntryResponse>(85, null);
            foreach (AddressEntry ae in res.entries)
            {
                DAO.OurAddressesIU(Sys.Global.ID_OUR, ae.address_id, ae.address.houseguid, 0);
            }
        }
        #endregion
        #region ГРУППЫ ПРАВ ПОЛЬЗОВАТЕЛЕЙ
        /// <summary>
        /// 6.6.1. Метод для получения информации о существующих правах
        /// </summary>
        public static void GetCurrentRights()
        {
            var res = Sys.Global.WebMethod<RightsInfoList>(46, null);
            Sys.Global.DataProvider.SaveRightsAbout(res);
        }
        /// <summary>
        /// 6.6.2. Метод для получения информации о правах текущего пользователя
        /// </summary>
        public static void GetRightsCurrentUser()
        {
            var res = Sys.Global.WebMethod<RightsCurrentUser>(47, null);
            // TODO: 6.6.2. save
            foreach (string right in res.rights)
            {
                //WebMethods.GetRi
            }
        }
        /// <summary>
        /// 6.6.3. Метод для создания группы прав пользователей
        /// </summary>
        public static void CreateGroupRights(string group_name, List<string> rights)
        {
            GroupInfo body = new GroupInfo();
            body.group_name = group_name;
            body.rights = rights;

            var res = Sys.Global.WebMethod<string>(49, body);
            WebMethods.GetGroupRightsInfo(res);
        }
        /// <summary>
        /// 6.6.4. Метод для получения информации о группе прав пользователей
        /// </summary>
        public static void GetGroupRightsInfo(string GROUP_ID)
        {
            var res = Sys.Global.WebMethod<Group>(49, null, GROUP_ID);
            
            // Сохраняем группу
            int gid = DAO.GROUP_IU(res.group_name, res.group_id, (res.is_admin ? 1 : 0));
            // Пишем связку ПОЛЬЗОВАТЕЛИ <-> ГРУППЫ ПРАВ
            //DAO.GROUP_USERS_IU(gid, uid);

            // Сохраняем права группы
            foreach (string right in res.rights)
            {
                bool isRepeated = false;
                ToRepeatIteration:

                // Получаем rid существующих прав (справочник не изменный)
                int rid = DAO.GetRightRidByName(right);
                if (rid > 0)
                {
                    // Пишем связку ГРУППА ПРАВ <-> ПРАВА
                    DAO.GROUP_RIGHTS_IU(gid, rid);
                }
                else
                {
                    WebMethods.GetCurrentRights();
                    if (!isRepeated)
                    {
                        isRepeated = true;
                        goto ToRepeatIteration;
                    }
                }
            }
        }
        /// <summary>
        /// 6.6.5. Метод для получения информации о пользователях группы
        /// </summary>
        public static void GetUsersByGroupRights(string USER_ID)
        {
            var res = Sys.Global.WebMethod<UserList>(50, null, USER_ID);
            // TODO: 6.6.5. save
        }
        /// <summary>
        /// 6.6.6. Метод для изменения группы прав пользователей
        /// </summary>
        public static void ChangeGroupRights(string GROUP_ID, string group_name, List<string> rights)
        {
            GroupInfo body = new GroupInfo();
            body.group_name = group_name;
            body.rights = rights;

            var res = Sys.Global.WebMethod<string>(51, body, GROUP_ID);
            // TODO: 6.6.6. save
        }
        /// <summary>
        /// 6.6.7. Метод для удаления группы прав пользователей
        /// </summary>
        public static void DeleteGroupRights(string GROUP_ID)
        {
            var res = Sys.Global.WebMethod<string>(52, null, GROUP_ID);
            res = (res.IndexOf("200") > 0) ? "Успешно" : "Ошибка";
            MessageBox.Show(res);
        }
        /// <summary>
        /// 6.6.8. Метод для добавления пользователя в группу прав пользователей
        /// </summary>
        public static void AddUserInGroupRights(string GROUP_ID, string USER_ID)
        {
            User body = new User();
            body.user_id = USER_ID;

            var res = Sys.Global.WebMethod<string>(53, body, GROUP_ID);
            res = (res.IndexOf("200") > 0) ? "Успешно" : "Ошибка";
        }
        /// <summary>
        /// 6.6.9. Метод для удаления пользователя из группы прав пользователя
        /// </summary>
        public static void DeleteUserFromGroupRights(string GROUP_ID, string USER_ID)
        {
            var res = Sys.Global.WebMethod<string>(54, null, GROUP_ID, USER_ID);
            res = (res.IndexOf("200") > 0) ? "Успешно" : "Ошибка";
            MessageBox.Show(res);
        }
        /// <summary>
        /// 6.6.11. Метод для поиска списка групп прав пользователей по фильтру
        /// </summary>
        public static void GetGroupRightsInfoByFilter(string group_name, string user_id)
        {
            GroupFilter filter = new GroupFilter();
            filter.user_id = user_id;
            if (!string.IsNullOrEmpty(group_name))
                filter.group_name = group_name;

            Filters<GroupFilter> WebFilter = new Filters<GroupFilter>
            {
                filter = filter,
                start_from = 0,
                count = 20
            };

            // Определяем пользователя
            int uid = 0;
            DataTable dt = DAO.GetUserInfoByUserId(user_id);
            if (dt.Rows.Count > 0)
            {
                try
                {
                    uid = (int)dt.Rows[0]["USER_UID"];
                }
                catch { }
            }
            if (uid == 0)
            {
                MessageBox.Show("Не удалось определить пользователя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Получаем данные о его группах
            var temp = Sys.Global.WebMethodFiltered<GroupFilter, GroupFilterResponse, Group>(56, WebFilter);
            if (temp == null)
                return;

            foreach (Group g in temp)
            {
                // Сохраняем группу
                int gid = DAO.GROUP_IU(g.group_name, g.group_id, (g.is_admin ? 1 : 0));
                // Пишем связку ПОЛЬЗОВАТЕЛИ <-> ГРУППЫ ПРАВ
                DAO.GROUP_USERS_IU(gid, uid);

                // Сохраняем права группы
                foreach (string right in g.rights)
                {
                    bool isRepeated = false;
                    ToRepeatIteration:

                    // Получаем rid существующих прав (справочник не изменный)
                    int rid = DAO.GetRightRidByName(right);
                    if (rid > 0)
                    {
                        // Пишем связку ГРУППА ПРАВ <-> ПРАВА
                        DAO.GROUP_RIGHTS_IU(gid, rid);
                    }
                    else
                    {
                        WebMethods.GetCurrentRights();
                        if (!isRepeated)
                        {
                            isRepeated = true;
                            goto ToRepeatIteration;
                        }
                    }
                }
            }
        }
        #endregion

        /// <summary>
        /// 8.9.1. Метод для получения информации об организации, в которой зарегистрирован текущий пользователь
        /// </summary>
        public static void GetMembersCurrentUser()
        {
            var res = Sys.Global.WebMethod<Members>(167, null);
            Sys.Global.DataProvider.SaveMembersCurrent(res, Sys.Global.USER_ID);
        }
    }
}
