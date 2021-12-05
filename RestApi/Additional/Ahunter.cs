using System;
using System.Drawing;
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

namespace RestApi.Additional
{
    public class Ahunter
    {
        const string ENDPOINT = "https://ahunter.ru/site/";
        const string TOKEN = "xxx";

        /// <summary>
        /// Отправить все не синхронизированные адреса в Api для определения Fias
        /// </summary>
        public static int GetFiasAhunter(int xec_id)
        {
            int PackLim = 20;
            int cntErrors = 0;

            DateTime TimeStartPack = DateTime.Now;
            DateTime TimeEndPack = DateTime.Now;

            try
            {
                // Получаем данные на синхронизацию
                DataTable DT_AddressesFias = DAO.GetAddressTW4ByXec(xec_id);
                if (DT_AddressesFias == null)
                    throw new Exception("Не удалось получить данные из БД");
                if (DT_AddressesFias.Rows.Count == 0)
                    throw new Exception("Адресов без кода ФИАС не найдено");

                List<ApiAddressRole> adrs = new List<ApiAddressRole>();

                // Отбираем по PackLim записей (пакет)
                foreach (DataRow row in DT_AddressesFias.Rows)
                {
                    adrs.Add(new ApiAddressRole
                    {
                        XEC_ID = xec_id,
                        VAL = row["ADR_NAME"].ToString()
                    });

                    if (adrs.Count == PackLim)
                    {
                        cntErrors += ArrayToApi(adrs);
                        adrs.Clear();
                    }
                }

                // Если в пакете еще остались данные
                if (adrs.Count != 0)
                {                  
                    cntErrors += ArrayToApi(adrs);
                }
            }
            catch (Exception ex)
            {
                cntErrors++;
                //($"Ошибка выполнения скрипта: {ex.Message}");
            }

            return cntErrors;
        }
        /// <summary>
        /// Отправить пачку адресов в API
        /// </summary>
        /// <param name="adrs"></param>
        private static int ArrayToApi(List<ApiAddressRole> adrs)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<ProcessChunkRequest>");
            for (int id = 0; id < adrs.Count; id++)
            {
                sb.Append($"<record id=\"{(id + 1)}\">");
                sb.Append($"<item type=\"address\" role=\"XEC_ID:{adrs[id].XEC_ID}\">");
                sb.Append(adrs[id].VAL.ToString().Trim().Replace("\\p{Cntrl}", "").Replace(Environment.NewLine, " "));
                sb.Append($"</item>");
                sb.Append($"</record>");
            }
            sb.Append("</ProcessChunkRequest>");

            // Перекодируем в формат строки HTML
            string query = HttpUtility.UrlEncode(sb.ToString());
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

            string ApiAction = ENDPOINT;
            string ApiUser = "user=" + TOKEN; // API-токен пользователя из личного кабинета
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
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);//, System.Text.Encoding.GetEncoding(1251));
            string strResponse = reader.ReadToEnd();
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
                }

                if (AdrDataList.Count > 0)
                {
                    foreach (ApiAddressData item in AdrDataList)
                    {
                        DataTable dtRes = DAO.TW4SetFias(
                            item.xec_id,
                            item.fias_object,
                            item.fias_object_level,
                            item.fias_region,
                            item.fias_city,
                            item.fias_place,
                            item.fias_code,
                            item.okato,
                            item.oktmo,
                            item.kladr,
                            item.fias_house,
                            item.fias_house_precise,
                            item.ifns_fl,
                            item.ifns_ul,
                            item.codes_sign,
                            item.abr_actual,
                            item.abr_detected,
                            item.geodata_mid_lat,
                            item.geodata_mid_lon,
                            item.geodata_min_lat,
                            item.geodata_min_lon,
                            item.geodata_max_lat,
                            item.geodata_max_lon,
                            item.adr_region,
                            item.adr_district,
                            item.adr_city,
                            item.adr_place,
                            item.adr_site,
                            item.adr_street,
                            item.adr_house,
                            item.adr_building,
                            item.adr_structure,
                            item.adr_flat,
                            item.adr_zip,
                            item.quality_precision,
                            item.quality_recall,
                            item.quality_canonicfields,
                            item.quality_detectedfields,
                            item.quality_verifiednumericfields
                            );

                        if (dtRes == null)
                            cntErrors++;
                        else if (dtRes.Rows.Count == 0)
                            cntErrors++;
                    }
                }
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
                        case "XEC_ID":
                            res.xec_id = Convert.ToInt32(itemRole[i][1]);
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
    }
}
