using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web;
using System.Net;
using System.Runtime.Serialization;


/*
 * https://www.ahunter.ru/site/doc/api/cleanse/address#XML-Address
 */

namespace ApiAddresses.Ahunter.ResultOne
{
    [XmlRoot(ElementName = "Address")]
    public class Address
    {
        [XmlElement(ElementName = "Field")]
        public List<Universal.Field> Field { get; set; }
        [XmlElement(ElementName = "Cover")]
        public string Cover { get; set; }
        [XmlElement(ElementName = "Pretty")]
        public string Pretty { get; set; }
        [XmlElement(ElementName = "GeoData")]
        public Universal.GeoData GeoData { get; set; }
        [XmlElement(ElementName = "Areas")]
        public Universal.Areas Areas { get; set; }
        [XmlElement(ElementName = "Stations")]
        public Universal.Stations Stations { get; set; }
        [XmlElement(ElementName = "PostOffice")]
        public Universal.PostOffice PostOffice { get; set; }
        [XmlElement(ElementName = "TimeZone")]
        public Universal.TimeZone TimeZone { get; set; }
        [XmlElement(ElementName = "Codes")]
        public Universal.Codes Codes { get; set; }
        [XmlElement(ElementName = "Quality")]
        public Universal.Quality Quality { get; set; }
    }

    [XmlRoot(ElementName = "ProcessCheckResult")]
    public class ProcessCheckResult : IAhunterData, IAhunterResponse
    {
        [XmlElement(ElementName = "Address")]
        public Address Address { get; set; }
        [XmlElement(ElementName = "CheckInfo")]
        public Universal.CheckInfo CheckInfo { get; set; }
        [XmlIgnore]
        public bool isData { get { return !(Address == null); } }
    }

}

namespace ApiAddresses.Ahunter.ResultPack
{
    [XmlRoot(ElementName = "Address")]
    public class Address
    {
        [XmlElement(ElementName = "Field")]
        public List<Universal.Field> Field { get; set; }
        [XmlElement(ElementName = "Cover")]
        public string Cover { get; set; }
        [XmlElement(ElementName = "Pretty")]
        public string Pretty { get; set; }
        [XmlElement(ElementName = "GeoData")]
        public Universal.GeoData GeoData { get; set; }
        [XmlElement(ElementName = "PostOffice")]
        public Universal.PostOffice PostOffice { get; set; }
        [XmlElement(ElementName = "TimeZone")]
        public Universal.TimeZone TimeZone { get; set; }
        [XmlElement(ElementName = "Codes")]
        public Universal.Codes Codes { get; set; }
        [XmlElement(ElementName = "Quality")]
        public Universal.Quality Quality { get; set; }
        [XmlElement(ElementName = "Areas")]
        public Universal.Areas Areas { get; set; }
        [XmlElement(ElementName = "Stations")]
        public Universal.Stations Stations { get; set; }
    }

    [XmlRoot(ElementName = "item")]
    public class Item
    {
        [XmlElement(ElementName = "Address")]
        public Address Address { get; set; }
        [XmlElement(ElementName = "CheckInfo")]
        public Universal.CheckInfo CheckInfo { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "role")]
        public string Role { get; set; }
    }

    [XmlRoot(ElementName = "record")]
    public class Record : IAhunterResponse
    {
        [XmlElement(ElementName = "item")]
        public Item Item { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    

    [XmlRoot(ElementName = "ProcessChunkResult")]
    public class ProcessChunkResult : IAhunterData
    {
        [XmlElement(ElementName = "record")]
        public List<Record> Record { get; set; }
        [XmlIgnore]
        public bool isData { get { return !(Record == null); } }
    }

}

namespace ApiAddresses.Ahunter.Universal
{
    #region Codes
    [XmlRoot(ElementName = "Codes")]
    public class Codes
    {
        [XmlElement(ElementName = "ABR")]
        public ABR ABR { get; set; }
        [XmlElement(ElementName = "Sign")]
        public Sign Sign { get; set; }
        [XmlElement(ElementName = "KLADR")]
        public KLADR KLADR { get; set; }
        [XmlElement(ElementName = "FIAS")]
        public FIAS FIAS { get; set; }
        [XmlElement(ElementName = "OKATO")]
        public OKATO OKATO { get; set; }
        [XmlElement(ElementName = "OKTMO")]
        public OKTMO OKTMO { get; set; }
        [XmlElement(ElementName = "IFNS_FL")]
        public IFNS_FL IFNS_FL { get; set; }
        [XmlElement(ElementName = "IFNS_UL")]
        public IFNS_UL IFNS_UL { get; set; }
    }

    [XmlRoot(ElementName = "ABR")]
    public class ABR
    {
        [XmlAttribute(AttributeName = "actual")]
        public string Actual { get; set; }
        [XmlAttribute(AttributeName = "detected")]
        public string Detected { get; set; }
    }

    [XmlRoot(ElementName = "Sign")]
    public class Sign
    {
        [XmlAttribute(AttributeName = "val")]
        public string Val { get; set; }
    }

    [XmlRoot(ElementName = "KLADR")]
    public class KLADR
    {
        [XmlAttribute(AttributeName = "val")]
        public string Val { get; set; }
    }

    [XmlRoot(ElementName = "FIAS")]
    public class FIAS
    {
        [XmlAttribute(AttributeName = "object")]
        public string Object { get; set; }
        [XmlAttribute(AttributeName = "object_level")]
        public string Object_level { get; set; }
        [XmlAttribute(AttributeName = "house")]
        public string House { get; set; }
        [XmlAttribute(AttributeName = "house_precise")]
        public string House_precise { get; set; }
        [XmlAttribute(AttributeName = "Region")]
        public string Region { get; set; }
        [XmlAttribute(AttributeName = "District")]
        public string District { get; set; }
        [XmlAttribute(AttributeName = "code")]
        public string Code { get; set; }
        [XmlAttribute(AttributeName = "Place")]
        public string Place { get; set; }
        [XmlAttribute(AttributeName = "City")]
        public string City { get; set; }
    }

    [XmlRoot(ElementName = "OKATO")]
    public class OKATO
    {
        [XmlAttribute(AttributeName = "val")]
        public string Val { get; set; }
    }

    [XmlRoot(ElementName = "OKTMO")]
    public class OKTMO
    {
        [XmlAttribute(AttributeName = "val")]
        public string Val { get; set; }
    }

    [XmlRoot(ElementName = "IFNS_FL")]
    public class IFNS_FL
    {
        [XmlAttribute(AttributeName = "val")]
        public string Val { get; set; }
    }

    [XmlRoot(ElementName = "IFNS_UL")]
    public class IFNS_UL
    {
        [XmlAttribute(AttributeName = "val")]
        public string Val { get; set; }
    }
    #endregion
    #region GeoData
    [XmlRoot(ElementName = "Mid")]
    public class Mid
    {
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }
    }

    [XmlRoot(ElementName = "Min")]
    public class Min
    {
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }
    }

    [XmlRoot(ElementName = "Max")]
    public class Max
    {
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }
    }

    [XmlRoot(ElementName = "GeoData")]
    public class GeoData
    {
        [XmlElement(ElementName = "Mid")]
        public Mid Mid { get; set; }
        [XmlElement(ElementName = "Min")]
        public Min Min { get; set; }
        [XmlElement(ElementName = "Max")]
        public Max Max { get; set; }
        [XmlAttribute(AttributeName = "rel")]
        public string Rel { get; set; }
        [XmlAttribute(AttributeName = "object_level")]
        public string Object_level { get; set; }
    }
    #endregion
    #region Field
    [XmlRoot(ElementName = "Quality")]
    public class Quality
    {
        [XmlElement(ElementName = "Precision")]
        public Precision Precision { get; set; }
        [XmlElement(ElementName = "Recall")]
        public Recall Recall { get; set; }
        [XmlElement(ElementName = "CanonicFields")]
        public CanonicFields CanonicFields { get; set; }
        [XmlElement(ElementName = "DetectedFields")]
        public DetectedFields DetectedFields { get; set; }
        [XmlElement(ElementName = "VerifiedNumericFields")]
        public VerifiedNumericFields VerifiedNumericFields { get; set; }
        [XmlElement(ElementName = "Warnings")]
        public Warnings Warnings { get; set; }
    }

    [XmlRoot(ElementName = "Precision")]
    public class Precision
    {
        [XmlAttribute(AttributeName = "val")]
        public string Val { get; set; }
    }

    [XmlRoot(ElementName = "Recall")]
    public class Recall
    {
        [XmlAttribute(AttributeName = "val")]
        public string Val { get; set; }
    }

    [XmlRoot(ElementName = "CanonicFields")]
    public class CanonicFields
    {
        [XmlAttribute(AttributeName = "val")]
        public string Val { get; set; }
    }

    [XmlRoot(ElementName = "DetectedFields")]
    public class DetectedFields
    {
        [XmlAttribute(AttributeName = "val")]
        public string Val { get; set; }
    }

    [XmlRoot(ElementName = "VerifiedNumericFields")]
    public class VerifiedNumericFields
    {
        [XmlAttribute(AttributeName = "val")]
        public string Val { get; set; }
    }

    [XmlRoot(ElementName = "Warnings")]
    public class Warnings
    {
        [XmlAttribute(AttributeName = "val")]
        public string Val { get; set; }
    }

    [XmlRoot(ElementName = "Field")]
    public class Field
    {
        [XmlAttribute(AttributeName = "level")]
        public string Level { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "c")]
        public string C { get; set; }
        [XmlAttribute(AttributeName = "ns")]
        public string Ns { get; set; }
        [XmlAttribute(AttributeName = "ts")]
        public string Ts { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
    #endregion
    #region TimeZone
    [XmlRoot(ElementName = "TimeZone")]
    public class TimeZone
    {
        [XmlAttribute(AttributeName = "utc_zone")]
        public string Utc_zone { get; set; }
        [XmlAttribute(AttributeName = "msk_zone")]
        public string Msk_zone { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }
    #endregion
    #region PostOffice
    [XmlRoot(ElementName = "PostOffice")]
    public class PostOffice
    {
        [XmlAttribute(AttributeName = "sign")]
        public string Sign { get; set; }
        [XmlAttribute(AttributeName = "pretty")]
        public string Pretty { get; set; }
        [XmlAttribute(AttributeName = "dist")]
        public string Dist { get; set; }
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }
    }
    #endregion
    #region Areas
    [XmlRoot(ElementName = "AdminOkrug")]
    public class AdminOkrug
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "AdminArea")]
    public class AdminArea
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "RingRoad")]
    public class RingRoad
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "short")]
        public string Short { get; set; }
        [XmlAttribute(AttributeName = "in_ring")]
        public string In_ring { get; set; }
    }

    [XmlRoot(ElementName = "Areas")]
    public class Areas
    {
        [XmlElement(ElementName = "AdminOkrug")]
        public AdminOkrug AdminOkrug { get; set; }
        [XmlElement(ElementName = "AdminArea")]
        public AdminArea AdminArea { get; set; }
        [XmlElement(ElementName = "RingRoad")]
        public RingRoad RingRoad { get; set; }
    }
    #endregion
    #region Stations
    [XmlRoot(ElementName = "Subway")]
    public class Subway
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "line")]
        public string Line { get; set; }
        [XmlAttribute(AttributeName = "net")]
        public string Net { get; set; }
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }
        [XmlAttribute(AttributeName = "dist")]
        public string Dist { get; set; }
    }

    [XmlRoot(ElementName = "LightRail")]
    public class LightRail
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "line")]
        public string Line { get; set; }
        [XmlAttribute(AttributeName = "net")]
        public string Net { get; set; }
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }
        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }
        [XmlAttribute(AttributeName = "dist")]
        public string Dist { get; set; }
    }

    [XmlRoot(ElementName = "Stations")]
    public class Stations
    {
        [XmlElement(ElementName = "Subway")]
        public List<Subway> Subway { get; set; }
        [XmlElement(ElementName = "LightRail")]
        public List<LightRail> LightRail { get; set; }
    }
    #endregion
    #region CheckInfo
    [XmlRoot(ElementName = "CheckInfo")]
    public class CheckInfo
    {
        [XmlElement(ElementName = "Number")]
        public string Number { get; set; }
        [XmlElement(ElementName = "String")]
        public string String { get; set; }
        [XmlElement(ElementName = "Time")]
        public string Time { get; set; }
        [XmlElement(ElementName = "Alts")]
        public string Alts { get; set; }
        [XmlElement(ElementName = "Status")]
        public Status Status { get; set; }
    }

    [XmlRoot(ElementName = "Status")]
    public class Status
    {
        [XmlAttribute(AttributeName = "val")]
        public string Val { get; set; }
    }
    #endregion
}

namespace ApiAddresses.Ahunter
{
    public interface IAhunterResponse { }
    public interface IAhunterData { bool isData { get; } }

    [DataContract]
    public class AhunterData
    {
        [DataMember]
        public string role { get; set; }
        [DataMember]
        public string fias_object { get; set; }
        [DataMember]
        public string fias_object_level { get; set; }
        [DataMember]
        public string fias_region { get; set; }
        [DataMember]
        public string fias_city { get; set; }
        [DataMember]
        public string fias_place { get; set; }
        [DataMember]
        public string fias_code { get; set; }
        [DataMember]
        public string okato { get; set; }
        [DataMember]
        public string oktmo { get; set; }
        [DataMember]
        public string kladr { get; set; }
        [DataMember]
        public string fias_house { get; set; }
        [DataMember]
        public string fias_house_precise { get; set; }
        [DataMember]
        public string ifns_fl { get; set; }
        [DataMember]
        public string ifns_ul { get; set; }
        [DataMember]
        public string codes_sign { get; set; }
        [DataMember]
        public string abr_actual { get; set; }
        [DataMember]
        public string abr_detected { get; set; }
        [DataMember]
        public string geodata_mid_lat { get; set; }
        [DataMember]
        public string geodata_mid_lon { get; set; }
        [DataMember]
        public string geodata_min_lat { get; set; }
        [DataMember]
        public string geodata_min_lon { get; set; }
        [DataMember]
        public string geodata_max_lat { get; set; }
        [DataMember]
        public string geodata_max_lon { get; set; }
        [DataMember]
        public string adr_region { get; set; }
        [DataMember]
        public string adr_district { get; set; }
        [DataMember]
        public string adr_city { get; set; }
        [DataMember]
        public string adr_place { get; set; }
        [DataMember]
        public string adr_site { get; set; }
        [DataMember]
        public string adr_street { get; set; }
        [DataMember]
        public string adr_house { get; set; }
        [DataMember]
        public string adr_building { get; set; }
        [DataMember]
        public string adr_structure { get; set; }
        [DataMember]
        public string adr_flat { get; set; }
        [DataMember]
        public string adr_zip { get; set; }
        [DataMember]
        public string quality_precision { get; set; }
        [DataMember]
        public string quality_recall { get; set; }
        [DataMember]
        public string quality_canonicfields { get; set; }
        [DataMember]
        public string quality_detectedfields { get; set; }
        [DataMember]
        public string quality_verifiednumericfields { get; set; }
    }

    [DataContract]
    public class AhunterDataInput
    {
        [DataMember]
        public string Role { get; set; }
        [DataMember]
        public string VAL { get; set; }
    }

    public static class Ahunter
    {
        /// <summary>
        /// API-токен пользователя из личного кабинета
        /// </summary>
        public static string ApiUser = "xxx";
        
        /// <summary>
        /// Отправить в Api Ahunter адрес для связки
        /// </summary>
        /// <param name="UrlEncoding_Query"></param>
        /// <param name="isPack"></param>
        public static List<AhunterData> GetFias(List<AhunterDataInput> data, bool isPack, string role = "")
        {
            // Описание API:
            // https://www.ahunter.ru/site/doc/api/cleanse/address

            // Отладка
            //UrlEncoding_Query = HttpUtility.UrlEncode("Москва, 17-й Марьиной рощи, 13С5"); isPack = false;

            // Парсинг данных в строку запроса
            string UrlEncoding_Query = ParseDataToQuery(data);

            // Сбор запроса
            string ApiAction = "https://ahunter.ru/site/";
            string ApiInput = "input=xml"; // Формат, в котором передается пакет json|xml
            string ApiOutput = "output=xml|acover|ageo|acodes|adict|afiasall|aqual|apretty|status|ainabr|astations|utf8"; // Формат, в котором требуется вернуть результат обработки json|xml + Перечень выводимой информации
            string ApiQuery = "query=" + UrlEncoding_Query; // Строка, содержащая обрабатываемый почтовый адрес
            string ApiAddressLim = "addresslim=1"; // Лимит на число возвращаемых вариантов распознавания адреса, в случае, если адрес является многозначным

            string ApiMethod = (isPack) ? "cleanse/chunk" : "cleanse/address"; // Отправка пакета / одного адреса
            string Api = $"{ApiAction}{ApiMethod}?user={ApiUser};{ApiInput};{ApiOutput};{ApiAddressLim};{ApiQuery}";

            // Отправляем запрос
            string strResponse = SendRequestToApi(Api);

            List<AhunterData> AdrDataList = new List<AhunterData>();
            // Обработка ошибки от сервиса
            if (strResponse.Contains("<Errors>"))
                return null;
            else
            {
                // Разбираем XML
                if (isPack)
                {
                    ApiAddresses.Ahunter.ResultPack.ProcessChunkResult ApiResponse = ApiDeserialize<ApiAddresses.Ahunter.ResultPack.ProcessChunkResult>(strResponse);
                    foreach (ApiAddresses.Ahunter.ResultPack.Record record in ApiResponse.Record)
                    {
                        if (record.Item.Address == null)
                        {
                            continue;
                        }
                        AhunterData AdrData = ResponseParse(record);
                        AdrDataList.Add(AdrData);
                    }
                }
                else
                {
                    ApiAddresses.Ahunter.ResultOne.ProcessCheckResult ApiResponse = ApiDeserialize<ApiAddresses.Ahunter.ResultOne.ProcessCheckResult>(strResponse);                    
                    AhunterData AdrData = ResponseParse(ApiResponse, role);
                    AdrDataList.Add(AdrData);
                }
            }

            return AdrDataList;
        }

        /// <summary>
        /// Формирует строку для запроса из переданных данных
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static string ParseDataToQuery(List<AhunterDataInput> data)
        {
            string array = "<ProcessChunkRequest>";
            for (int i = 0; i < data.Count; i++)
            {
                array += $"<record id=\"{(i + 1).ToString()}\">";
                array += $"<item type=\"address\" role=\"{data[i].Role.Trim().Replace("\\p{Cntrl}", "").Replace(Environment.NewLine, " ")}\">";
                array += data[i].VAL.Trim().Replace("\\p{Cntrl}", "").Replace(Environment.NewLine, " ");
                array += "</item>";
                array += "</record>";
            }
            array += "</ProcessChunkRequest>";

            // Перекодируем в формат строки HTML
            string query = HttpUtility.UrlEncode(array);
            return query;
        }
        /// <summary>
        /// Отправить WEB запрос в Ahunter
        /// </summary>
        /// <param name="Api"></param>
        /// <returns></returns>
        private static string SendRequestToApi(string Api)
        {
            WebRequest request = WebRequest.Create(Api);
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);//, System.Text.Encoding.GetEncoding(1251));
            string strResponse = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();

            return strResponse;
        }
        /// <summary>
        /// Парсинг ответа от Ahunter
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strResponse"></param>
        /// <returns></returns>
        private static T ApiDeserialize<T>(string strResponse)
            where T : class, IAhunterData
        {
            T ApiResponse = null;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextReader ResponseReader = new StringReader(strResponse))
            {
                try
                {
                    ApiResponse = (T)serializer.Deserialize(ResponseReader);
                }
                catch (Exception ex)
                {
                    ApiResponse = null;
                }
            }

            if (ApiResponse == null)
            {
                return null;
            }
            if (ApiResponse.isData == false)
            {
                return null;
            }

            return ApiResponse;
        }

        /// <summary>
        /// Разбираем ответ от Api
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        private static AhunterData ResponseParse<T>(T obj, string role = "") 
            where T : class, IAhunterResponse
        {
            AhunterData res = new AhunterData();
            Type tObj = typeof(T);
            Type tPack = typeof(ApiAddresses.Ahunter.ResultPack.Record);
            Type tOne = typeof(ApiAddresses.Ahunter.ResultOne.ProcessCheckResult);

            try
            {
                ApiAddresses.Ahunter.Universal.Codes Codes = (tObj == tPack) ? (obj as ApiAddresses.Ahunter.ResultPack.Record).Item.Address.Codes : (obj as ApiAddresses.Ahunter.ResultOne.ProcessCheckResult).Address.Codes;
                ApiAddresses.Ahunter.Universal.GeoData Geodata = (tObj == tPack) ? (obj as ApiAddresses.Ahunter.ResultPack.Record).Item.Address.GeoData : (obj as ApiAddresses.Ahunter.ResultOne.ProcessCheckResult).Address.GeoData;
                ApiAddresses.Ahunter.Universal.Quality Quality = (tObj == tPack) ? (obj as ApiAddresses.Ahunter.ResultPack.Record).Item.Address.Quality : (obj as ApiAddresses.Ahunter.ResultOne.ProcessCheckResult).Address.Quality;

                // Быстрое приведение данных в нормальный вид
                foreach (ApiAddresses.Ahunter.Universal.Field item in ((tObj == tPack) ? (obj as ApiAddresses.Ahunter.ResultPack.Record).Item.Address.Field : (obj as ApiAddresses.Ahunter.ResultOne.ProcessCheckResult).Address.Field))
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

                // Может быть зашито что угодно, пример: "TW_ID:266492937;ID:39", использовать метод GetDataFromRole
                res.role = (tObj == tPack) ? (obj as ApiAddresses.Ahunter.ResultPack.Record).Item.Role : role;

                // Раскладываем по полям
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
        public static List<string[]> GetDataFromRole(string s)
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