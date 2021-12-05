using System;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections.Generic;
using ProfitMed.Firebird;
using ProfitMed.DataContract;
using System.Xml.Serialization;
using System.Web;
using System.Net;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using PMMarkingUI.Delegats;

namespace PMMarkingUI.Classes
{
    public static class Additional
    {
        #region Api.Ahunter
        /// <summary>
        /// Отправить все не синхронизированные адреса в Api для определения Fias
        /// </summary>
        public static void GetFiasAhunter(Control ctrl, int lid = 0, bool isShowMessages = true)
        {
            int PackLim = 20;
            int cntErrors = 0;

            DateTime TimeStartPack = DateTime.Now;
            DateTime TimeEndPack = DateTime.Now;
            List<int> JobSecs = new List<int>();

            if (isShowMessages)
                if (MessageBox.Show("Выполнить запрос данных по адресам по API? Это займет много времени!", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;

            using (AdditionalEvent ae = new AdditionalEvent(ctrl, "Запрос данных по адресам", 0))
            {
                try
                {
                    // Получаем данные на синхронизацию
                    DataTable DT_AddressesFias = DAO.GetAddressLinksNoFias(lid);
                    if (DT_AddressesFias.Rows.Count == 0)
                        throw new Exception("Адресов без кода ФИАС не найдено");

                    int cntPackNum = 0;
                    int cntPackCnt = (int)(DT_AddressesFias.Rows.Count / PackLim);
                    cntPackCnt = (cntPackCnt == 0) ? 1 : cntPackCnt;
                    List<ApiAddressRole> adrs = new List<ApiAddressRole>();

                    ae.Maximum = cntPackCnt;
                    ae.Caption += $" ({DT_AddressesFias.Rows.Count} записей / {cntPackCnt} пакетов)";
                    string lbText = ae.Caption;

                    // Отбираем по PackLim записей (пакет)
                    for (int i = 0; i < DT_AddressesFias.Rows.Count; i++)
                    {
                        adrs.Add(new ApiAddressRole
                        {
                            ID = (int)DT_AddressesFias.Rows[i]["ID"],
                            TW_ID = (int)DT_AddressesFias.Rows[i]["TW_ID"],
                            VAL = DT_AddressesFias.Rows[i]["NORM_VAL"].ToString()
                        });

                        if (adrs.Count == PackLim)
                        {
                            cntPackNum++;
                            try { ae.Value = cntPackNum; } catch { }
                            ae.Caption = lbText + "\n" + $"Пакет: {cntPackNum} из {cntPackCnt}";
                            Console.WriteLine(ae.Caption);
                            cntErrors += ArrayToApi(adrs);
                            adrs.Clear();
                            Application.DoEvents();
                        }
                    }

                    // Если в пакете еще остались данные
                    if (adrs.Count != 0)
                    {
                        cntPackNum++;
                        try { ae.Value = cntPackNum; } catch { }
                        ae.Caption = lbText + "\n" + $"Пакет: {cntPackNum} из {cntPackCnt}";
                        Console.WriteLine(ae.Caption);
                        cntErrors += ArrayToApi(adrs);
                        Application.DoEvents();
                    }

                    if (isShowMessages)
                    {
                        if (cntErrors > 0)
                            MessageBox.Show($"Выполнено с ошибками: {cntErrors} ошибок.");
                        else
                            MessageBox.Show($"Выполнено.");
                    }
                }
                catch (Exception ex)
                {
                    if (isShowMessages)
                        MessageBox.Show($"Ошибка выполнения скрипта: {ex.Message}");
                }
            }
        }
        /// <summary>
        /// Отправить пачку адресов в API
        /// </summary>
        /// <param name="adrs"></param>
        private static int ArrayToApi(List<ApiAddressRole> adrs)
        {
            string array = "<ProcessChunkRequest>";
            for (int id = 0; id < adrs.Count; id++)
            {
                array += "<record id=\"" + (id + 1).ToString() + "\">";
                array += "<item type=\"address\" role=\"TW_ID:" + adrs[id].TW_ID.ToString() + ";ID:" + adrs[id].ID.ToString() + "\">";
                array += adrs[id].VAL.ToString().Trim().Replace("\\p{Cntrl}", "").Replace(Environment.NewLine, " ");
                array += "</item>";
                array += "</record>";
            }
            array += "</ProcessChunkRequest>";

            // Перекодируем в формат строки HTML
            string query = HttpUtility.UrlEncode(array);
            Console.WriteLine(array);
            int cntErrors = 0;
            try
            {
                cntErrors = FiasAPI(query, true);
            }
            catch (Exception ex)
            {
                cntErrors = adrs.Count;
            }
            return cntErrors;
        }
        /// <summary>
        /// Отправить в Api Ahunter адрес для связки
        /// </summary>
        /// <param name="UrlEncoding_Query"></param>
        /// <param name="isPack"></param>
        public static int FiasAPI(string UrlEncoding_Query, bool isPack, string role = "")
        {
            // Описание API:
            // https://www.ahunter.ru/site/doc/api/cleanse/address

            int cntErrors = 0;
            //UrlEncoding_Query = HttpUtility.UrlEncode("Москва, 17-й Марьиной рощи, 13С5"); isPack = false;

            string ApiAction = "https://ahunter.ru/site/";
            string ApiUser = "user=xxx"; // API-токен пользователя из личного кабинета
            string ApiInput = "input=xml"; // Формат, в котором передается пакет json|xml
            string ApiOutput = "output=xml|acover|ageo|acodes|adict|afiasall|aqual|apretty|status|ainabr|astations|utf8"; // Формат, в котором требуется вернуть результат обработки json|xml + Перечень выводимой информации
            string ApiQuery = "query=" + UrlEncoding_Query; // Строка, содержащая обрабатываемый почтовый адрес
            string ApiAddressLim = "addresslim=1"; // Лимит на число возвращаемых вариантов распознавания адреса, в случае, если адрес является многозначным

            string ApiMethod = (isPack) ? "cleanse/chunk" : "cleanse/address"; // Отправка пакета / одного адреса
            string Api = $"{ApiAction}{ApiMethod}?{ApiUser};{ApiInput};{ApiOutput};{ApiAddressLim};{ApiQuery}";

            #region Отправляем запрос и получаем ответ от API
            WebRequest request = WebRequest.Create(Api);
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //Console.WriteLine(response.StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);//, System.Text.Encoding.GetEncoding(1251));
            string strResponse = reader.ReadToEnd();
            //Console.WriteLine(strResponse);
            reader.Close();
            dataStream.Close();
            response.Close();
            #endregion

            List<ApiAddressData> AdrDataList = new List<ApiAddressData>();
            // Обработка ошибки от сервиса
            if (strResponse.Contains("<Errors>"))
                cntErrors++;
            else
            {
                // Разбираем XML
                if (isPack)
                {
                    ApiAddresses.Ahunter.ResultPack.ProcessChunkResult ApiResponse = null;
                    XmlSerializer serializer = new XmlSerializer(typeof(ApiAddresses.Ahunter.ResultPack.ProcessChunkResult));
                    using (TextReader ResponseReader = new StringReader(strResponse))
                    {
                        try
                        {
                            ApiResponse = (ApiAddresses.Ahunter.ResultPack.ProcessChunkResult)serializer.Deserialize(ResponseReader);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            ApiResponse = null;
                        }
                    }
                    if (ApiResponse == null)
                    {
                        cntErrors++;
                        return cntErrors;
                    }
                    if (ApiResponse.Record == null)
                    {
                        cntErrors++;
                        return cntErrors;
                    }

                    foreach (ApiAddresses.Ahunter.ResultPack.Record record in ApiResponse.Record)
                    {
                        if (record.Item.Address == null)
                        {
                            cntErrors++;
                            continue;
                        }
                        ApiAddressData AdrData = ResponseParse(record);
                        AdrDataList.Add(AdrData);
                        //Sys.Global.DataProvider.SaveApiAddresses(AdrData);
                    }
                }
                else
                {
                    ApiAddresses.Ahunter.ResultOne.ProcessCheckResult ApiResponse = null;
                    XmlSerializer serializer = new XmlSerializer(typeof(ApiAddresses.Ahunter.ResultOne.ProcessCheckResult));
                    using (TextReader ResponseReader = new StringReader(strResponse))
                    {
                        try
                        {
                            ApiResponse = (ApiAddresses.Ahunter.ResultOne.ProcessCheckResult)serializer.Deserialize(ResponseReader);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            ApiResponse = null;
                        }
                    }

                    if (ApiResponse == null)
                    {
                        cntErrors++;
                        return cntErrors;
                    }
                    if (ApiResponse.Address == null)
                    {
                        cntErrors++;
                        return cntErrors;
                    }
                    ApiAddressData AdrData = ResponseParse(ApiResponse, role);
                    AdrDataList.Add(AdrData);
                    //Sys.Global.DataProvider.SaveApiAddresses(AdrData);
                }

                if (AdrDataList.Count > 0)
                    Sys.Global.DataProvider.SaveApiAddresses(AdrDataList);
            }
            return cntErrors;
        }
        /// <summary>
        /// Разбираем ответ от Api
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        private static ApiAddressData ResponseParse(object obj, string role = "")
        {
            ApiAddressData res = new ApiAddressData();
            Type tObj = obj.GetType();
            Type tPack = typeof(ApiAddresses.Ahunter.ResultPack.Record);
            Type tOne = typeof(ApiAddresses.Ahunter.ResultOne.ProcessCheckResult);

            try
            {
                var Codes = (tObj == tPack) ? (obj as ApiAddresses.Ahunter.ResultPack.Record).Item.Address.Codes : (obj as ApiAddresses.Ahunter.ResultOne.ProcessCheckResult).Address.Codes;
                var Geodata = (tObj == tPack) ? (obj as ApiAddresses.Ahunter.ResultPack.Record).Item.Address.GeoData : (obj as ApiAddresses.Ahunter.ResultOne.ProcessCheckResult).Address.GeoData;
                var Quality = (tObj == tPack) ? (obj as ApiAddresses.Ahunter.ResultPack.Record).Item.Address.Quality : (obj as ApiAddresses.Ahunter.ResultOne.ProcessCheckResult).Address.Quality;
                var itemRole = GetDataFromRole(((tObj == tPack) ? (obj as ApiAddresses.Ahunter.ResultPack.Record).Item.Role : role));
                for (int i = 0; i < itemRole.Count; i++)
                {
                    switch (itemRole[i][0])
                    {
                        case "TW_ID":
                            res.tw_id = Convert.ToInt32(itemRole[i][1]);
                            break;

                        case "ID":
                            res.id = Convert.ToInt32(itemRole[i][1]);
                            break;
                    }
                }
                foreach (var item in ((tObj == tPack) ? (obj as ApiAddresses.Ahunter.ResultPack.Record).Item.Address.Field : (obj as ApiAddresses.Ahunter.ResultOne.ProcessCheckResult).Address.Field))
                {
                    switch (item.Level)
                    {
                        case "Region":
                            res.adr_region = ConcateTypeName(item);
                            break;
                        case "District":
                            res.adr_district = ConcateTypeName(item);
                            break;
                        case "City":
                            res.adr_city = ConcateTypeName(item);
                            break;
                        case "Place":
                            res.adr_place = ConcateTypeName(item);
                            break;
                        case "Site":
                            res.adr_site = ConcateTypeName(item);
                            break;
                        case "Street":
                            res.adr_street = ConcateTypeName(item);
                            break;
                        case "House":
                            res.adr_house = ConcateTypeName(item);
                            break;
                        case "Building":
                            res.adr_building = ConcateTypeName(item);
                            break;
                        case "Structure":
                            res.adr_structure = ConcateTypeName(item);
                            break;
                        case "Flat":
                            res.adr_flat = ConcateTypeName(item);
                            break;
                        case "Zip":
                            res.adr_zip = ConcateTypeName(item);
                            break;
                    }
                }

                res.fias_object = Codes.FIAS.Object;
                res.fias_object_level = Codes.FIAS.Object_level;
                res.fias_region = Codes.FIAS.Region;
                res.fias_region = Codes.FIAS.City;
                res.fias_place = Codes.FIAS.Place;
                res.fias_code = Codes.FIAS.Code;
                res.okato = Codes.OKATO.Val;
                res.oktmo = Codes.OKTMO.Val;
                res.kladr = Codes.KLADR.Val;
                res.fias_house = Codes.FIAS.House;
                res.fias_house_precise = Codes.FIAS.House_precise;
                res.ifns_fl = Codes.IFNS_FL.Val;
                res.ifns_ul = Codes.IFNS_UL.Val;
                res.codes_sign = Codes.Sign.Val;
                res.abr_actual = Codes.ABR.Actual;
                res.abr_detected = Codes.ABR.Detected;
                res.geodata_mid_lat = Geodata.Mid.Lat;
                res.geodata_mid_lon = Geodata.Mid.Lon;
                res.geodata_min_lat = Geodata.Min.Lat;
                res.geodata_min_lon = Geodata.Min.Lon;
                res.geodata_max_lat = Geodata.Max.Lat;
                res.geodata_max_lon = Geodata.Max.Lon;
                res.quality_precision = Quality.Precision.Val;
                res.quality_recall = Quality.Recall.Val;
                res.quality_canonicfields = Quality.CanonicFields.Val;
                res.quality_detectedfields = Quality.DetectedFields.Val;
                res.quality_verifiednumericfields = Quality.VerifiedNumericFields.Val;
            }
            catch { }

            return res;
        }
        /// <summary>
        /// Объединить поля type и name
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private static string ConcateTypeName(ApiAddresses.Ahunter.Universal.Field item)
        {
            string res = item.Type;
            res += ((res != "") ? " " : "") + item.Name;
            return res;
        }
        /// <summary>
        /// Получить данные по роли формата "TW_ID:266492937;ID:39"
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static List<string[]> GetDataFromRole(string s)
        {
            List<string[]> res = new List<string[]>();

            bool isNeed = false;
            string delimiter = ";";
            string data = "";
            int cntData = (s.Length - s.Replace(delimiter, "").Length) / delimiter.Length;
            do
            {
                if (cntData > 0)
                {
                    data = s.Substring(0, s.IndexOf(delimiter));
                    isNeed = true;
                }
                else
                {
                    data = s;
                    isNeed = false;
                }

                res.Add(data.Split(new char[] { ':' }));
                s = s.Substring(s.IndexOf(delimiter) + 1);
                cntData--;
            }
            while (isNeed);

            return res;
        }
        #endregion

        #region Подложка выполнения действия
        /// <summary>
        /// (НА БУДУЩЕЕ) Выполнение действия
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="action"></param>
        public static void Execute(Control ctrl, Action action)
        {
            using (AdditionalEvent ae = new AdditionalEvent(ctrl, "", 0))
            {
                try
                {
                    action?.Invoke();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка выполнения события", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Контрагенты и адреса
        /// <summary>
        /// Синхронизировать базу контрагентов с ТВ4
        /// </summary>
        /// <param name="ctrl"></param>
        /// <returns></returns>
        public static bool CounteragentsSyncWithTW4(Control ctrl, bool isShowMessages = true)
        {
            bool res = false;
            if (isShowMessages)
                if (MessageBox.Show("Синхронизировать базу контрагентов с TW4? Это займет много времени!", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return false;

            using (AdditionalEvent ae = new AdditionalEvent(ctrl, "Синхронизация базы контрагентов с TW4", 0))
            {
                DateTime startJob = DateTime.Now;
                try
                {
                    DataTable twData = DAO.GetTW_CounteragentsFromTW4();
                    ae.Maximum = twData.Rows.Count;
                    string lbText = ae.Caption;
                    int CPackLim = 500;

                    // Вариант пакетный
                    if (twData.Rows.Count > 0)
                    {
                        DAO.CounteragentIU(twData, CPackLim, () =>
                        {
                            ae.Value += CPackLim;
                            ae.Caption = lbText + Environment.NewLine + $"{ae.Value} из {ae.Maximum}";
                            Application.DoEvents();
                        });
                    }
                    res = true;
                }
                catch (Exception ex)
                {
                    if (isShowMessages)
                        MessageBox.Show($"Ошибка! {ex.Message}");
                    res = false;
                }

                TimeSpan TotalTime = DateTime.Now.Subtract(startJob);
                if (isShowMessages)
                    MessageBox.Show("Синхронизация с TW4 завершена. Затрачено времени: " + TimeFormat(TotalTime.Hours, TotalTime.Minutes, TotalTime.Seconds));
            }
            return res;
        }
        /// <summary>
        /// Синхронизировать базу адресов контрагентов с ТВ4
        /// </summary>
        /// <param name="ctrl"></param>
        /// <returns></returns>
        public static bool CounteragentsAddressesSyncWithTW4(Control ctrl, List<string> inns, bool isShowMessages = true, bool isShowFinishMessage = true)
        {
            bool res = false;
            if (isShowMessages)
            {
                if (MessageBox.Show("Синхронизировать базу адресов контрагентов с TW4? Это займет много времени!", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return false;
            }

            using (AdditionalEvent ae = new AdditionalEvent(ctrl, "Синхронизация базы адресов контрагентов c TW4", 0))
            {
                DateTime startJob = DateTime.Now;
                string lbText = ae.Caption;
                int CPackLim = 500;
                int i = 0;
                int total = inns.Count;

                try
                {
                    // Поштучный режим
                    if (total > 0)
                    {
                        ae.Maximum = total;
                        foreach (string inn in inns)
                        {
                            i++;                            
                            ae.Caption = lbText + Environment.NewLine + $"{i} из {total}";

                            DataTable twData = DAO.GetCounteragentTW_Addresses(inn);
                            if (twData.Rows.Count > 0)
                            {
                                DAO.CounteragentTWAddressIU(twData, CPackLim, null);
                                res = true;
                            }
                            ae.Value++;
                        }
                    }
                    else
                    // Все данные
                    {                        
                        DataTable twData = DAO.GetCounteragentTW_Addresses("");
                        total = twData.Rows.Count;
                        if (total > 0)
                        {
                            ae.Maximum = total;
                            ae.Caption = lbText + Environment.NewLine + $"{i} из {total}";
                            DAO.CounteragentTWAddressIU(twData, CPackLim, () =>
                            {
                                i += CPackLim;
                                ae.Caption = lbText + Environment.NewLine + $"{i} из {total}";
                                ae.Value += CPackLim;
                                Application.DoEvents();
                            });
                            res = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (isShowMessages)
                        MessageBox.Show($"Ошибка! {ex.Message}");
                    res = false;
                }

                TimeSpan TotalTime = DateTime.Now.Subtract(startJob);
                if (isShowFinishMessage)
                    MessageBox.Show("Синхронизация с TW4 завершена. Затрачено времени: " + TimeFormat(TotalTime.Hours, TotalTime.Minutes, TotalTime.Seconds));
            }
            GC.Collect();
            return res;
        }
        /// <summary>
        /// Проставить рег. номера МДЛП на карточках помеченных контрагентов TW4
        /// </summary>
        /// <param name="ctrl"></param>
        /// <returns></returns>
        public static bool CounteragentsLinkToTw4(Control ctrl, List<LidInnSysid> data, bool isShowMessages = true, bool isShowFinishMessages = true)
        {
            bool res = false;
            if (isShowMessages)
            {
                if (MessageBox.Show("Проставить рег. номера МДЛП на карточках помеченных контрагентов TW4?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return false;
            }
            int CPackLim = 500;
            int total = 0;

            DataTable dtData = new DataTable();
            dtData.Columns.Add("LID", typeof(int));
            dtData.Columns.Add("SYS_ID", typeof(string));

            using (AdditionalEvent ae = new AdditionalEvent(ctrl, "Проставление рег. номеров МДЛП на карточке контрагента", data.Count))
            {
                string lbCaption = ae.Caption;
                DateTime startJob = DateTime.Now;
                try
                {
                    // Поштучно
                    if (data.Count > 0)
                    {
                        foreach (LidInnSysid item in data)
                        {
                            DataRow row = dtData.NewRow();
                            row["LID"] = item.lid;
                            row["SYS_ID"] = item.sys_id;
                            dtData.Rows.Add(row);
                        }
                    }
                    // Пакетом
                    else
                    {
                        DataTable allData = DAO.GetTWCounteragentsLinksAll();
                        if (allData.Rows.Count > 0)
                        {
                            foreach (DataRow allRow in allData.Rows)
                            {
                                DataRow row = dtData.NewRow();
                                row["LID"] = (int)allRow["LID"];
                                row["SYS_ID"] = allRow["SYS_ID"].ToString();
                                dtData.Rows.Add(row);
                            }
                        }
                    }

                    total = dtData.Rows.Count;
                    if (total > 0)
                    {
                        DAO.SetTWCounteragentsLinks(dtData, CPackLim, () =>
                        {
                            ae.Caption = lbCaption + Environment.NewLine + $"{ae.Value} из {total}";
                            ae.Value += CPackLim;
                            Application.DoEvents();
                        });
                    }
                }
                catch (Exception ex)
                {
                    if (isShowMessages)
                        MessageBox.Show($"Ошибка! {ex.Message}");
                    res = false;
                }

                TimeSpan TotalTime = DateTime.Now.Subtract(startJob);
                if (isShowFinishMessages)
                    MessageBox.Show("Выполнено. Затрачено времени: " + TimeFormat(TotalTime.Hours, TotalTime.Minutes, TotalTime.Seconds));
            }
            GC.Collect();
            return res;
        }
        /// <summary>
        /// Проставить рег. номера МДЛП на карточках помеченных контрагентов TW4
        /// </summary>
        /// <param name="ctrl"></param>
        /// <returns></returns>
        public static bool AddressesBranchIdLinkToTw4(Control ctrl, List<LidInnSysid> data, bool isShowMessages = true, bool isShowFinalMessages = true)
        {
            bool res = false;
            if (isShowMessages)
            {
                if (MessageBox.Show("Проставить связку адресов (branch_id) на карточках помеченных контрагентов TW4?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return false;
            }

            string header = "Проставление связки адресов МДЛП на карточке контрагента";
            using (AdditionalEvent ae = new AdditionalEvent(ctrl, header, data.Count))
            {
                DateTime startJob = DateTime.Now;
                try
                {
                    DataTable query = new DataTable();
                    query.Columns.Add("LID", typeof(int));
                    query.Columns.Add("TW_ID", typeof(int));
                    query.Columns.Add("BRANCH_ID", typeof(string));

                    // Поштучно
                    if (data.Count > 0)
                    {
                        foreach (LidInnSysid item in data)
                        {
                            ae.Caption = header + Environment.NewLine + $"Сбор адресов по LID: {item.lid} / ИНН: {item.inn}";
                            Application.DoEvents();
                            DataTable adrs = adrs = DAO.GetTW_Addresses(item.lid);

                            foreach (DataRow row in adrs.Rows)
                            {
                                int tw_id = (int)row["TW_ID"];
                                object t = row["BRANCH_ID"];
                                string branch_id = "";

                                ae.Caption = header + Environment.NewLine + $"Сбор адресов по LID: {item.lid} / ИНН: {item.inn}" + Environment.NewLine + $"TW_ID: {tw_id} / BRANCH_ID = {t}";
                                Application.DoEvents();

                                if (t != null)
                                {
                                    try
                                    {
                                        DataTable mdlp_address = DAO.GetMDLP_AddressesByBID((int)t);
                                        if (mdlp_address.Rows.Count > 0)
                                        {
                                            object tt = mdlp_address.Rows[0]["BRANCH_ID"];
                                            if (tt != null)
                                                branch_id = tt.ToString();
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        branch_id = "";
                                    }
                                }

                                DataRow r = query.NewRow();
                                r["LID"] = item.lid;
                                r["TW_ID"] = tw_id;
                                r["BRANCH_ID"] = branch_id;
                                query.Rows.Add(r);
                            }
                            ae.Value++;
                        }
                    }
                    // Пакетом
                    else
                    {
                        DataTable mdlp_address = DAO.GetMDLP_AddressesAll();
                        if (mdlp_address.Rows.Count > 0)
                        {
                            DataRow r = query.NewRow();
                            r["LID"] = mdlp_address.Rows[0]["LID"];
                            r["TW_ID"] = mdlp_address.Rows[0]["TW_ID"];
                            r["BRANCH_ID"] = mdlp_address.Rows[0]["BRANCH_ID"];
                            query.Rows.Add(r);
                        }
                    }

                    ae.Caption = header + Environment.NewLine + $"Запись информации в базу данных ТВ4";
                    Application.DoEvents();
                    // Новый вариант
                    DAO.SetLinkAddressToTw4(query, 500, null);
                }
                catch (Exception ex)
                {
                    if (isShowMessages)
                        MessageBox.Show($"Ошибка! {ex.Message}");
                    res = false;
                }

                TimeSpan TotalTime = DateTime.Now.Subtract(startJob);
                if (isShowFinalMessages)
                    MessageBox.Show("Выполнено. Затрачено времени: " + TimeFormat(TotalTime.Hours, TotalTime.Minutes, TotalTime.Seconds));
            }
            GC.Collect();
            return res;
        }
        /// <summary>
        /// Синхронизация ФИАС по выбранным контрагентам
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="data"></param>
        /// <param name="isShowMessages"></param>
        /// <param name="isShowFinalMessages"></param>
        /// <returns></returns>
        public static bool FiasToTw4(Control ctrl, List<LidInnSysid> data, bool isShowMessages = true, bool isShowFinalMessages = true)
        {
            bool res = false;
            if (isShowMessages)
            {
                if (MessageBox.Show("Проставить связку ФИАС на адресах помеченных контрагентов TW4?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return false;
            }

            string header = "Синхронизация ФИАС по адресам";
            using (AdditionalEvent ae = new AdditionalEvent(ctrl, header, data.Count))
            {
                DateTime startJob = DateTime.Now;
                try
                {
                    DataTable query = new DataTable();
                    #region
                    query.Columns.Add("TW_ID", typeof(int));
                    query.Columns.Add("FIAS_OBJECT", typeof(string));
                    query.Columns.Add("FIAS_OBJECT_LEVEL", typeof(string));
                    query.Columns.Add("FIAS_REGION", typeof(string));
                    query.Columns.Add("FIAS_CITY", typeof(string));
                    query.Columns.Add("FIAS_PLACE", typeof(string));
                    query.Columns.Add("FIAS_CODE", typeof(string));
                    query.Columns.Add("OKATO", typeof(string));
                    query.Columns.Add("OKTMO", typeof(string));
                    query.Columns.Add("KLADR", typeof(string));
                    query.Columns.Add("FIAS_HOUSE", typeof(string));
                    query.Columns.Add("FIAS_HOUSE_PRECISE", typeof(string));
                    query.Columns.Add("IFNS_FL", typeof(string));
                    query.Columns.Add("IFNS_UL", typeof(string));
                    query.Columns.Add("CODE_SIGN", typeof(string));
                    query.Columns.Add("ABR_ACTUAL", typeof(string));
                    query.Columns.Add("ABR_DETECTED", typeof(string));
                    query.Columns.Add("GEODATA_MID_LAT", typeof(string));
                    query.Columns.Add("GEODATA_MID_LON", typeof(string));
                    query.Columns.Add("GEODATA_MIN_LAT", typeof(string));
                    query.Columns.Add("GEODATA_MIN_LON", typeof(string));
                    query.Columns.Add("GEODATA_MAX_LAT", typeof(string));
                    query.Columns.Add("GEODATA_MAX_LON", typeof(string));
                    query.Columns.Add("ADR_REGION", typeof(string));
                    query.Columns.Add("ADR_DISTRICT", typeof(string));
                    query.Columns.Add("ADR_CITY", typeof(string));
                    query.Columns.Add("ADR_PLACE", typeof(string));
                    query.Columns.Add("ADR_SITE", typeof(string));
                    query.Columns.Add("ADR_STREET", typeof(string));
                    query.Columns.Add("ADR_HOUSE", typeof(string));
                    query.Columns.Add("ADR_BUILDING", typeof(string));
                    query.Columns.Add("ADR_STRUCTURE", typeof(string));
                    query.Columns.Add("ADR_FLAT", typeof(string));
                    query.Columns.Add("ADR_ZIP", typeof(string));
                    query.Columns.Add("QUALITY_PRECISION", typeof(string));
                    query.Columns.Add("QUALITY_RECALL", typeof(string));
                    query.Columns.Add("QUALITY_CANONICFIELDS", typeof(string));
                    query.Columns.Add("QUALITY_DETECTEDFIELDS", typeof(string));
                    query.Columns.Add("QUALITY_VERIFIEDNUMERICFIELDS", typeof(string));
                    #endregion

                    // Поштучно
                    if (data.Count > 0)
                    {
                        foreach (LidInnSysid item in data)
                        {
                            ae.Caption = header + Environment.NewLine + $"Сбор ФИАС по LID: {item.lid}";
                            Application.DoEvents();
                            DataTable dtFias = DAO.GetFiasByLid(item.lid);

                            foreach (DataRow row in dtFias.Rows)
                            {
                                DataRow r = query.NewRow();
                                foreach (DataColumn c in query.Columns)
                                {
                                    r[c.ColumnName] = row[c.ColumnName];
                                }
                                query.Rows.Add(r);
                            }
                            ae.Value++;
                        }
                    }
                    // Пакетом
                    else
                    {
                        DataTable dtFias = DAO.GetFiasByLid(0);
                        if (dtFias.Rows.Count > 0)
                        {
                            foreach (DataRow row in dtFias.Rows)
                            {
                                DataRow r = query.NewRow();
                                foreach (DataColumn c in query.Columns)
                                {
                                    r[c.ColumnName] = row[c.ColumnName];
                                }
                                query.Rows.Add(r);
                            }
                        }
                    }

                    ae.Caption = header + Environment.NewLine + $"Запись информации в базу данных ТВ4";
                    Application.DoEvents();
                    // Новый вариант
                    DAO.SetFiasToTw4(query, 500, null);
                }
                catch (Exception ex)
                {
                    if (isShowMessages)
                        MessageBox.Show($"Ошибка! {ex.Message}");
                    res = false;
                }

                TimeSpan TotalTime = DateTime.Now.Subtract(startJob);
                if (isShowFinalMessages)
                    MessageBox.Show("Выполнено. Затрачено времени: " + TimeFormat(TotalTime.Hours, TotalTime.Minutes, TotalTime.Seconds));
            }
            GC.Collect();
            return res;
        }
        /// <summary>
        /// Синхронизировать базу адресов контрагентов с ТВ4
        /// </summary>
        /// <param name="ctrl"></param>
        /// <returns></returns>
        public static bool CounteragentsAddressesSyncWithTW4_All(Control ctrl, bool isShowMessages = true)
        {
            bool res = false;
            if (isShowMessages)
            {
                if (MessageBox.Show("Синхронизировать базу адресов контрагентов с TW4? Это займет много времени!", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return false;
            }

            using (AdditionalEvent ae = new AdditionalEvent(ctrl, "Синхронизация базы адресов контрагентов c TW4", 1))
            {
                string lbText = ae.Caption;
                int CPackCurr = 0;
                int CPackLim = 500;

                DateTime startJob = DateTime.Now;

                DataTable twData = DAO.GetCounteragentTW_Addresses("");
                ae.Maximum = twData.Rows.Count;
                Application.DoEvents();

                try
                {
                    // Вариант поштучный
                    /*foreach (DataRow row in twData.Rows)
                    {
                        if (CPackCurr == CPackLim)
                        {
                            ae.Caption = lbText + Environment.NewLine + $"{ae.Value} из {ae.Maximum}";
                            CPackCurr = 0;
                        }

                        try
                        {
                            DAO.CounteragentTWAddressIU(
                                Convert.ToInt32(row["ADDRESS_ID"]),
                                row["ADDRESS_NAME"].ToString(),
                                (int)row["ADDRESS_SHORT_CODE"],
                                Convert.ToInt32(row["OWNER"]),
                                row["INN"].ToString(),
                                0,
                                0
                            );
                            res = true;
                        }
                        catch { }

                        ae.Value++;
                        CPackCurr++;
                        Application.DoEvents();


                        ae.Value++;
                    }*/

                    // Вариант пакетный
                    if (twData.Rows.Count > 0)
                    {
                        DAO.CounteragentTWAddressIU(twData, CPackLim, () =>
                        {
                            ae.Value += CPackLim;
                            ae.Caption = lbText + Environment.NewLine + $"{ae.Value} из {ae.Maximum}";
                            Application.DoEvents();
                        });
                        res = true;
                    }
                }
                catch (Exception ex)
                {
                    if (isShowMessages)
                        MessageBox.Show($"Ошибка! {ex.Message}");
                    res = false;
                }

                TimeSpan TotalTime = DateTime.Now.Subtract(startJob);
                if (isShowMessages)
                    MessageBox.Show("Синхронизация с TW4 завершена. Затрачено времени: " + TimeFormat(TotalTime.Hours, TotalTime.Minutes, TotalTime.Seconds));
            }
            GC.Collect();
            return res;
        }
        /// <summary>
        /// Связать контрагентов
        /// </summary>
        public static bool CounteragentsSetLinks(int lid, string sys_id)
        {
            if (!string.IsNullOrEmpty(sys_id) && lid != 0)
            {
                bool res = DAO.SetCounteragentTWLink(lid, sys_id);
                return res;
            }
            else
            {
                MessageBox.Show("Данные не корректны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// Удалить связку у контрагента
        /// </summary>
        /// <param name="lid"></param>
        /// <returns></returns>
        public static bool CounteragentsTWDelLink(int lid)
        {
            if (lid == 0)
            {
                MessageBox.Show("Данные не корректны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                bool res = DAO.CounteragentsTWDelLink(lid);
                return res;
            }
        }
        /// <summary>
        /// Синхронизировать базу товаров с ТВ4
        /// </summary>
        /// <param name="ctrl"></param>
        /// <returns></returns>
        public static bool GoodsSyncWithTW4(Control ctrl, bool isShowMessages = true)
        {
            bool res = false;
            if (isShowMessages)
                if (MessageBox.Show("Синхронизировать базу товаров с TW4? Это займет много времени!", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return false;

            using (AdditionalEvent ae = new AdditionalEvent(ctrl, "Синхронизация базы товаров с TW4", 0))
            {
                DateTime startJob = DateTime.Now;
                try
                {
                    DataTable twData = DAO.GetTW_GoodsFromTW4();
                    ae.Maximum = twData.Rows.Count;
                    string lbText = ae.Caption;
                    int CPackCurr = 0;
                    int CPackLim = 500;
                    // Вариант поштучный
                    /*foreach (DataRow row in twData.Rows)
                    {
                        if (CPackCurr == CPackLim)
                        {
                            ae.Caption = lbText + Environment.NewLine + $"{ae.Value} из {ae.Maximum}";
                            CPackCurr = 0;
                        }
                        DAO.GoodIU((int)row["LID"], row["ARTICLE"].ToString(), row["LNAME"].ToString(), (int)row["GNVLP"], row["BARCODE"].ToString(), (int)row["LPARENT"], (int)row["LFLAG"]);
                        ae.Value++;
                        CPackCurr++;
                        Application.DoEvents();
                    }*/

                    // Вариант пакетный
                    if (twData.Rows.Count > 0)
                    {
                        DAO.GoodIU(twData, CPackLim, () =>
                        {
                            ae.Value += CPackLim;
                            ae.Caption = lbText + Environment.NewLine + $"{ae.Value} из {ae.Maximum}";
                            Application.DoEvents();
                        });
                    }
                    res = true;
                }
                catch (Exception ex)
                {
                    if (isShowMessages)
                        MessageBox.Show($"Ошибка! {ex.Message}");
                    res = false;
                }

                TimeSpan TotalTime = DateTime.Now.Subtract(startJob);
                if (isShowMessages)
                    MessageBox.Show("Синхронизация с TW4 завершена. Затрачено времени: " + TimeFormat(TotalTime.Hours, TotalTime.Minutes, TotalTime.Seconds));
            }
            return res;
        }
        #endregion

        public static int DocumentAction(int doc_id, int ActionId)
        {
            int doc_type = DAO.GetDocumentTypeById(doc_id);
            if (doc_type <= 0)
            {
                MessageBox.Show($"Документ не определен (возможно отсутствует тип документа). Операция прервана.", "ВНИМАНИЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            if (ActionId == -1)
            {
                MessageBox.Show($"Действия не настроены для типа документа {doc_type}. Операция прервана.", "ВНИМАНИЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            int res = 0;
            try
            {
                DataTable action = DAO.GetDocumentActions(ActionId);                
                int doc_type_to = (int)action.Rows[0]["DOC_TYPE_TO"];
                int flag = (int)action.Rows[0]["FLAG"];
                if (doc_type_to <= 0)
                {
                    throw new Exception($"Для документа типа {doc_type} не настроен тип создаваемого дочернего документа.");
                }
                //-----------------------------------------------------------------------
                //res = DAO.CreateChildDocument(doc_id, doc_type_to);
                DataTable docData = new DataTable();
                switch (doc_type_to)
                {
                    case 912:
                        try
                        {
                            docData = DAO.DocumentProcessingError(doc_id);
                            if (docData.Rows.Count > 0)
                            {
                                if (docData.Rows[0]["NEW_DOC_ID"] != null)
                                {
                                    res = (int)docData.Rows[0]["NEW_DOC_ID"];
                                }
                            }
                            /*docData = DAO.GetDocumentErrors(doc_id, "15");
                            foreach (DataRow row in docData.Rows)
                            {
                                string sscc = DAO.GetSsccFromSgtin(row["OBJECT_ID"].ToString());
                                if (!string.IsNullOrEmpty(sscc))
                                    res = DAO.CreateOutcomeDocument(doc_id, doc_type_to, null, sscc, null, null, flag);
                            }*/
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            res = -1;
                        }
                        break;

                    default:
                        res = DAO.CreateOutcomeDocument(doc_id, doc_type_to, Sys.Global.SYS_OBJ_ID, null, null, null, flag);
                        break;
                }
                if (res <= 0)
                {
                    //MessageBox.Show($"Документ не создан. Операция прервана.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                //-----------------------------------------------------------------------
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"{ex.Message}. Операция для документа № {doc_id} прервана.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            return res;
        }

        /// <summary>
        /// Вывод времени в формате
        /// </summary>
        /// <param name="hh">Часы</param>
        /// <param name="mm">Минуты</param>
        /// <param name="ss">Секунды</param>
        public static string TimeFormat(int hh, int mm, int ss)
        {
            string res = "";

            if (hh > 0)
                res += ((hh < 10) ? "0" : "") + hh.ToString() + " ч. ";
            if (mm > 0)
                res += ((mm < 10) ? "0" : "") + mm.ToString() + " мин. ";
            res += ((ss < 10) ? "0" : "") + ss.ToString() + " сек.";

            return res;
        }

        public static Control GetParentToControl(Control t)
        {
            if (t != null)
            {
                if (t is UserControl || t is Form)
                    return t;
                else
                {
                    if (t.Parent != null)
                        return GetParentToControl(t.Parent);
                    else
                        return t;
                }
            }
            else
            {
                return t;
            }
        }

        public static DelegateVoid dGetInfoByKIZ;
        public static void GetInfoByKIZ(int doc_id, List<string> ssccList, bool isExpress = true)
        {
            foreach (string sscc in ssccList)
            {
                int new_id = DAO.CreateOutcomeDocument(doc_id, 220, null, sscc, null, null, 1);
                if (isExpress)
                {
                    DataTable bodys = DAO.GetXmlDocBody(new_id);
                    if (bodys.Rows.Count > 0)
                    {
                        string xml_body = bodys.Rows[0]["DOC_BODY"].ToString();
                        WebMethods.DocumentSend(xml_body, new_id, false);
                    }
                }

                //if (dGetInfoByKIZ.Target != null)
                //    dGetInfoByKIZ();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mode">SSCC | SGTIN | Document</param>
        /// <param name="doc_id">ID документа</param>
        /// <param name="data">Таблица со столбцом OBJECT типа string</param>
        public static void MoveDocBody(string Mode, int doc_id, DataTable data, RefRes refRes = null)
        {
            if (!new string[] { "SSCC", "SGTIN", "Document" }.Contains(Mode))
            {
                MessageBox.Show("Не удалось определить режим работы MoveDocBody. Операция прервана.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (data == null)
            {
                MessageBox.Show("Не передан источник данных. Операция прервана.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (data.Columns.Count != 1)
            {
                MessageBox.Show("Источник данных должен содержать 1 колонку OBJECT типа string. Операция прервана.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (data.Columns[0].ColumnName != "OBJECT" && data.Columns[0].DataType != typeof(string))
            {
                MessageBox.Show("Источник данных должен содержать 1 колонку OBJECT типа string.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isNeedMessage = (refRes == null);
            // Передавать строго паренты коробок (верхний уровень) (самый-самый верхний)
            if (refRes == null)
            {
                DataTable dtWHS = DAO.GetWhsByBid();
                refRes = Sys.Global.GetRef(dtWHS, "Адрес склада", "ID", "NAME");
            }            
            if (refRes.DResult == DialogResult.OK)
            {
                using (Forms.frmProccess process = new Forms.frmProccess())
                {
                    process.Show();

                    string address = refRes.Value.ToString();
                    List<object> listRes = new List<object>();
                    process.progressBarControl.Properties.Maximum = 1;

                    // Если коробки в документе есть, но ничего не выбрано - перемещаем весь документ
                    if (data.Rows.Count == 0)
                    {
                        try
                        {
                            int res = DAO.CreateOutcomeDocument(doc_id, 431, address, null, null, null, 1);
                            listRes.Add(res);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    // Иначе перемещаем строго выбранные коробки (их верхние уровни)
                    else
                    {
                        try
                        {
                            // Заполняем временную таблицу данными по выбранным коробкам
                            int res = DAO.CreateOutcomeDocument_431(doc_id, address, data);
                            listRes.Add(res);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }

                    if (isNeedMessage)
                        MessageBox.Show($"Выполнено. Было создано {listRes.Count} документов.");
                    /*if (MessageBox.Show($"Выполнено. Было создано {listRes.Count} документов. Хотите посмотреть список?", "Выполнено", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Forms.frmStringList frmRes = new Forms.frmStringList(listRes, "Список созданных документов перемещения");
                    }*/
                    process.Close();
                }
            }
        }

        private static TreeListNode GetMasterParentNode(TreeListNode node)
        {
            if (node == null)
                return node;

            if (node.ParentNode == null)
                return node;
            else
                return GetMasterParentNode(node.ParentNode);
        }
        public static bool CheckInn(string inn)
        {
            return System.Text.RegularExpressions.Regex.Match(inn, @"^[\d+]{10,12}$").Success; ;
        }
    }

    /// <summary>
    /// Подложка выполнения процесса
    /// </summary>
    public class AdditionalEvent : IDisposable
    {
        private Panel p;
        private Label l;
        private Control ctrl;
        private ProgressBar pb;
        public int Maximum
        {
            get { return this.pb.Maximum; }
            set { this.pb.Value = 0; this.pb.Maximum = (value > 0) ? value : 1; }
        }
        public int Value
        {
            get { return this.pb.Value; }
            set
            {
                this.pb.Value =
                  (value >= 0 && value <= this.pb.Maximum)
                  ? value
                  : (value > this.pb.Maximum)
                      ? this.pb.Maximum
                      : 0;
            }
        }
        public string Caption
        {
            get { return this.l.Text; }
            set { this.l.Text = value; Application.DoEvents(); }
        }

        public AdditionalEvent(Control ctrl, string Text, int ProgressMax)
        {
            this.ctrl = ctrl;
            InitializeComponent();
            if (!string.IsNullOrEmpty(Text))
                this.Caption = Text;
            if (ProgressMax >= 0)
            {
                if (this.pb.Maximum == 0)
                {
                    //this.pb.Style = ProgressBarStyle.Marquee;
                    //this.pb.MarqueeAnimationSpeed = 50;
                    this.pb.Maximum = 1;
                    this.pb.Value = 0;
                }
                else
                {
                    this.pb.Maximum = ProgressMax;
                }
            }
        }

        public void Dispose()
        {
            if (this.l != null)
                this.l.Dispose();
            if (this.pb != null)
                this.pb.Dispose();
            if (this.p != null)
                this.p.Dispose();
            //this.ctrl.Enabled = true;
            this.ctrl.Focus();
            this.ctrl.UseWaitCursor = false;
        }

        private void InitializeComponent()
        {
            this.p = new Panel();
            p.Parent = this.ctrl;
            p.BringToFront();
            p.Dock = DockStyle.Fill;

            this.l = new Label();
            l.Parent = this.p;
            l.Text = "Подождите, операция выполняется...";
            l.AutoSize = false;
            //l.Dock = DockStyle.Fill;
            l.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            l.Location = new Point(ctrl.Width / 10, ctrl.Height / 10);
            l.Size = new Size((ctrl.Width - ctrl.Width / 10 * 2), (int)(ctrl.Height / 2.5));
            //l.BackColor = Color.Red;
            l.ForeColor = Color.Black;
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Font = new Font(l.Font.FontFamily, 22);

            this.pb = new ProgressBar();
            pb.Parent = this.p;
            pb.Step = 1;
            pb.Maximum = 100;
            pb.Value = 0;
            pb.Location = new Point(l.Location.X, l.Location.Y + l.Size.Height + 10);
            pb.Size = new Size(l.Size.Width, 50);

            //this.ctrl.Enabled = false;
            this.p.Focus();
            this.ctrl.UseWaitCursor = true;
            Application.DoEvents();
        }
    }


    //=========================================================================================
    //=========================================================================================
    // ВСПОМОГАТЕЛЬНЫЕ ОБЩИЕ КЛАССЫ

    /// <summary>
    /// Фильтр документов из базы TW4
    /// </summary>
    public class DocFilterTWDb
    {
        /// <summary>
        /// Начало периода
        /// </summary>
        public DateTime FromDate { get; set; }
        /// <summary>
        /// Конец периода
        /// </summary>
        public DateTime ToDate { get; set; }

        /// <summary>
        /// Направление: Входящие / Исходящие
        /// </summary>
        public int Direction { get; set; }
        /// <summary>
        /// Возвратные документы
        /// </summary>
        public int IsReturned { get; set; }
        /// <summary>
        /// Контрагент
        /// </summary>
        public int Counteragent { get; set; }
        /// <summary>
        /// Менеджер
        /// </summary>
        public int Manager { get; set; }
        /// <summary>
        /// Группа
        /// </summary>
        public int Group { get; set; }
        /// <summary>
        /// Отдел
        /// </summary>
        public int Departament { get; set; }
    }
    /// <summary>
    /// Фильтр документов из базы МДЛП
    /// </summary>
    public class DocFilterDb
    {
        /// <summary>
        /// Начало периода
        /// </summary>
        public DateTime FromDate { get; set; }
        /// <summary>
        /// Конец периода
        /// </summary>
        public DateTime ToDate { get; set; }

        /// <summary>
        /// Направление: Входящие / Исходящие
        /// </summary>
        public int Direction { get; set; }
        /// <summary>
        /// Возвратные документы
        /// </summary>
        public int IsReturned { get; set; }
        /// <summary>
        /// Контрагент (SYS_ID)
        /// </summary>
        public string Counteragent { get; set; }
        /// <summary>
        /// Тип документа
        /// </summary>
        public int DocumentType { get; set; }
        /// <summary>
        /// Концепт
        /// </summary>
        public int Concept { get; set; }
    }
    /// <summary>
    /// Фильтр Инвойсов из базы МДЛП
    /// </summary>
    public class InvoiceFilter
    {
        /// <summary>
        /// Начало периода
        /// </summary>
        public DateTime FromDate { get; set; }
        /// <summary>
        /// Конец периода
        /// </summary>
        public DateTime ToDate { get; set; }

        /// <summary>
        /// Контрагент (SYS_ID)
        /// </summary>
        public string Counteragent { get; set; }        
    }
    public class DocFilterDbAgency
    {
        /// <summary>
        /// Начало периода
        /// </summary>
        public DateTime FromDate { get; set; }
        /// <summary>
        /// Конец периода
        /// </summary>
        public DateTime ToDate { get; set; }
        /// <summary>
        /// Контрагент (LID/L4000)
        /// </summary>
        public int LID { get; set; }
        /// <summary>
        /// Концепт
        /// </summary>
        public int Concept { get; set; }
    }
    /// <summary>
    /// Модуль поиска по колонке в GridControl
    /// </summary>
    public class SerchColumn
    {
        public string Text { get; set; }
        public string Name { get; set; }
        public int AbsoluteIndex { get; set; }
    }
    /// <summary>
    /// Представление класса вида ID и NAME
    /// </summary>
    public class IdName
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    /// <summary>
    /// Фильтр поиска документов для WebMethods
    /// </summary>
    public class GetDocsParam
    {
        public DocFilters filter { get; set; }
        public string mode { get; set; }
        public int SleepMs { get; set; }

        public GetDocsParam(DocFilters filter, string mode, int SleepMs = 1000)
        {
            this.filter = filter;
            this.mode = mode;
            this.SleepMs = SleepMs;
        }
    }
    public class SelectedDataDoc
    {
        public DataRow Doc { get; set; }
        public List<SelectedDataLin> Lins { get; set; }

        public SelectedDataDoc()
        {
            this.Lins = new List<SelectedDataLin>();
        }
    }
    public class SelectedDataLin
    {
        public DataRow Lin { get; set; }
        public List<TreeListNode> SGTINs { get; set; }

        public SelectedDataLin()
        {
            this.SGTINs = new List<TreeListNode>();
        }
    }
    public class LidInnSysid
    {
        public int lid { get; set; }
        public string inn { get; set; }
        public string sys_id { get; set; }
    }
    public class ParentAndChild
    {
        public int parent { get; set; }
        public int child { get; set; }
    }
    public class RefRes
    {
        public object Value { get; set; }
        public string Name { get; set; }
        public DialogResult DResult { get; set; }
    }
}