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
    public static class Search
    {
        /// <summary>
        /// Поиск SGTIN / SSCC в базе МДЛП
        /// </summary>
        /// <param name="object_id"></param>
        /// <param name="mode">0 - Общий реестр МДЛП // 1 - Баланс Организации</param>
        /// <returns></returns>
        public static SearchObjectId SearchObjectId(string object_id, string mode)
        {
            SearchObjectId data = new SearchObjectId();

            try
            {
                data.object_id = object_id;
                data.err_code = 0;
                data.err_desc = "";
                //data.entries = new SerchObjectId.Entries[0];
                object_id = object_id.Trim();

                if (String.IsNullOrEmpty(mode))
                    mode = "0";

                if (object_id.Length == 27)
                {
                    try
                    {
                        ProfitMed.DataContract.SSFilter WebFilter = new ProfitMed.DataContract.SSFilter();
                        WebFilter.filter = new ProfitMed.DataContract.Sfilter();
                        WebFilter.filter.sgtins = new List<string>();
                        WebFilter.filter.sgtins.Add(object_id);

                        switch (mode)
                        {
                            // 1 - Баланс Организации
                            case "1":
                                ProfitMed.DataContract.SgtinByList resOrg = Sys.Global.WebMethod<ProfitMed.DataContract.SgtinByList>(149, WebFilter);
                                if (resOrg.failed == 1)
                                {
                                    data.err_code = resOrg.failed_entries[0].error_code;
                                    data.err_desc = resOrg.failed_entries[0].error_desc;
                                }
                                else
                                {
                                    data.sscc = $"{((string.IsNullOrEmpty(resOrg.entries[0].pack3_id)) ? "< РАЗАГРЕГИРОВАН >" : resOrg.entries[0].pack3_id)}";
                                    data.branch_id = resOrg.entries[0].sys_id;
                                    data.name = resOrg.entries[0].prod_name;
                                    data.status = resOrg.entries[0].status;
                                    data.status_date = resOrg.entries[0].status_date;
                                    data.owner = resOrg.entries[0].owner;
                                    data.gtin = resOrg.entries[0].gtin;
                                    data.batch = resOrg.entries[0].batch;
                                }
                                break;

                            // 0 - Общий реестр МДЛП
                            case "0":
                                ProfitMed.DataContract.PublicSgtinByList resPublic = Sys.Global.WebMethod<ProfitMed.DataContract.PublicSgtinByList>(150, WebFilter);
                                if (resPublic.failed == 1)
                                {
                                    data.err_code = resPublic.failed_entries[0].error_code;
                                    data.err_desc = resPublic.failed_entries[0].error_desc;
                                }
                                else
                                {
                                    string org_name = "";
                                    try
                                    {
                                        ProfitMed.DataContract.Filters<ProfitMed.DataContract.PartnersFilter> WebFilterBID = new ProfitMed.DataContract.Filters<ProfitMed.DataContract.PartnersFilter>
                                        {
                                            filter = new ProfitMed.DataContract.PartnersFilter { reg_entity_type = 1, branch_id = resPublic.entries[0].branch_id },
                                            start_from = 0,
                                            count = 10
                                        };
                                        List<ProfitMed.DataContract.FilteredRecords> resBID = Sys.Global.WebMethodFiltered<ProfitMed.DataContract.PartnersFilter, ProfitMed.DataContract.CountragentsList, ProfitMed.DataContract.FilteredRecords>(166, WebFilterBID);

                                        org_name = resBID[0].ORG_NAME;
                                    }
                                    catch (Exception ex) { org_name = ""; }

                                    data.sscc = $"{(string.IsNullOrEmpty(resPublic.entries[0].sscc) ? "< РАЗАГРЕГИРОВАН >" : resPublic.entries[0].sscc)}";
                                    data.status = resPublic.entries[0].status;
                                    data.branch_id = resPublic.entries[0].branch_id;
                                    data.name = resPublic.entries[0].prod_name;
                                    data.batch = resPublic.entries[0].batch;
                                    data.owner = org_name;
                                }
                                break;
                        }
                    }
                    catch (NullReferenceException nex)
                    {
                        data.err_code = -1;
                        data.err_desc = "Не удалось получить данные от сервера МДЛП.";
                    }
                    catch (Exception ex)
                    {
                        data.err_code = -1;
                        data.err_desc = ex.Message;
                    }
                }

                if (object_id.Length == 18)
                {
                    try
                    {
                        ProfitMed.DataContract.SSFilter WebFilter = new ProfitMed.DataContract.SSFilter();
                        WebFilter.filter = new ProfitMed.DataContract.Sfilter();
                        WebFilter.filter.sgtins = new List<string>();
                        WebFilter.filter.sgtins.Add(object_id);

                        ProfitMed.DataContract.Filters<ProfitMed.DataContract.SsccSgtinsFilter> filter = new ProfitMed.DataContract.Filters<ProfitMed.DataContract.SsccSgtinsFilter>();
                        filter.filter = new ProfitMed.DataContract.SsccSgtinsFilter();
                        filter.start_from = 0;
                        filter.count = 10;
                        ProfitMed.DataContract.SgtinsListFromSscc resSSCC = Sys.Global.WebMethod<ProfitMed.DataContract.SgtinsListFromSscc>(156, filter, object_id);
                        if (resSSCC.total > 0)
                        {
                            data.owner = resSSCC.entries[0].owner;
                            data.sscc_total = resSSCC.total;
                            data.status = resSSCC.entries[0].status;
                            data.status_date = resSSCC.entries[0].status_date;

                            /*List<SerchObjectId.Entries> detail = new List<SerchObjectId.Entries>();
                            foreach (ProfitMed.DataContract.Sgtin sgtin in resSSCC.entries)
                            {
                                SerchObjectId.Entries sdi = new SerchObjectId.Entries();
                                sdi.gtin = sgtin.gtin;
                                sdi.batch = sgtin.batch;

                                bool isExist = false;
                                foreach (SerchObjectId.Entries item in detail)
                                {
                                    if (item.gtin == sdi.gtin && item.batch == sdi.batch)
                                    {
                                        item.total++;
                                        isExist = true;
                                        break;
                                    }
                                }
                                if (!isExist)
                                    detail.Add(sdi);
                            }
                            data.entries = detail.ToArray();*/

                            try
                            {
                                ProfitMed.DataContract.SsccHierarchy s155 = Sys.Global.WebMethod<ProfitMed.DataContract.SsccHierarchy>(155, null, object_id);
                                foreach (var item in s155.up)
                                    data.sscc_hierarchy += (String.IsNullOrEmpty(data.sscc_hierarchy)) ? item.sscc : " / " + item.sscc;
                            }
                            catch { }
                        }
                        else
                        {
                            data.err_code = -1;
                            data.err_desc = "Ничего найти не удалось. Возможно коробка была ранее РАЗАГРЕГИРОВАНА или она нам НЕ ДОСТУПНА.";
                        }
                    }
                    catch (NullReferenceException nex)
                    {
                        data.err_code = -1;
                        data.err_desc = "Не удалось получить данные от сервера МДЛП.";
                    }
                    catch (Exception ex)
                    {
                        data.err_code = -1;
                        data.err_desc = ex.Message;
                    }
                }
            }
            catch (Exception ex)
            {
                data = null;
            }

            if (data != null)
            {
                string status_rus = "";
                if (!String.IsNullOrEmpty(data.status))
                {
                    try
                    {
                        status_rus = Sys.Global.dicStatus[data.status];
                    }
                    catch
                    {
                        status_rus = "";
                    }
                }
                data.status_rus = status_rus ?? "";
            }
            return data;
        }

        /// <summary>
        /// Поиск SGTIN в базе МДЛП по списку значений
        /// </summary>
        public static List<SearchObjectId> SearchObjectIdList(Stream streamdata)
        {
            List<SearchObjectId> res = new List<SearchObjectId>();
            try
            {
                StreamReader reader = new StreamReader(streamdata);
                string stringObjectIds = reader.ReadToEnd();
                reader.Close();
                reader.Dispose();

                if (String.IsNullOrEmpty(stringObjectIds))
                    throw new Exception("Отсутствуют данные");

                try
                {
                    MasterSgtin(stringObjectIds, ref res);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try
                {
                    MasterSscc(stringObjectIds, ref res);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return res;
        }
        private static void MasterSgtin(string stringObjectIds, ref List<SearchObjectId> res)
        {
            int limitFilter = 400;
            bool isNeedSleep = false;
            int sleepMs = 1000;
            string[] objectIds = stringObjectIds.Split(';');

            if (objectIds.Length == 0)
                throw new Exception("Отсутствуют данные");

            ProfitMed.DataContract.SSFilter WebFilterSgtin = new ProfitMed.DataContract.SSFilter();
            WebFilterSgtin.filter = new ProfitMed.DataContract.Sfilter();
            WebFilterSgtin.filter.sgtins = new List<string>();

            foreach (string line in objectIds)
            {
                string object_id = line.Replace("object_id", "")
                .Replace("sgtin", "")
                .Replace("'", "")
                .Replace(" ", "")
                .Replace(",", "")
                .Replace("<", "")
                .Replace(">", "")
                .Trim();

                if (String.IsNullOrEmpty(object_id) || object_id.Length != 27)
                    continue;
                WebFilterSgtin.filter.sgtins.Add(object_id);

                if (WebFilterSgtin.filter.sgtins.Count == limitFilter)
                {
                    if (isNeedSleep)
                        System.Threading.Thread.Sleep(sleepMs);

                    isNeedSleep = true;
                    GoSgtin(WebFilterSgtin, ref res);
                    WebFilterSgtin.filter.sgtins.Clear();
                }
            }

            if (WebFilterSgtin.filter.sgtins.Count > 0)
            {
                if (isNeedSleep)
                    System.Threading.Thread.Sleep(sleepMs);

                GoSgtin(WebFilterSgtin, ref res);
            }
        }
        private static void GoSgtin(ProfitMed.DataContract.SSFilter WebFilter, ref List<SearchObjectId> result)
        {
            if (WebFilter.filter.sgtins.Count == 0)
                return;

            try
            {
                var res = Sys.Global.WebMethod<ProfitMed.DataContract.PublicSgtinByList2>(150, WebFilter);

                if (res == null)
                {
                    throw new Exception("Не удалось получить данные от сервера МДЛП");
                }

                foreach (var item in res.entries)
                {
                    result.Add(new ResponseClasses.SearchObjectId
                    {
                        sscc = ((string.IsNullOrEmpty(item.sscc)) ? "" : item.sscc),
                        object_id = item.sgtin,
                        branch_id = item.branch_id,
                        status = item.status,
                        name = item.sell_name,
                        err_code = 0,
                        err_desc = "",
                        count = 0,
                    });
                }
                foreach (var item in res.failed_entries)
                {
                    result.Add(new ResponseClasses.SearchObjectId
                    {
                        sscc = "",
                        object_id = item,//item.sgtin, // ProfitMed.DataContract.PublicSgtinByList
                        branch_id = "",
                        status = "",
                        name = "",
                        err_code = 2,//item.error_code,
                        err_desc = "Нет данных от МДЛП",//item.error_desc,
                        count = 0,
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void MasterSscc(string stringObjectIds, ref List<SearchObjectId> res)
        {
            int limitFilter = 35;
            bool isNeedSleep = false;
            int sleepMs = 1000;
            string[] objectIds = stringObjectIds.Split(';');

            if (objectIds.Length == 0)
                throw new Exception("Отсутствуют данные");

            RestApi.DataClasses.SsccSearchFilter WebFilterSscc = new RestApi.DataClasses.SsccSearchFilter();
            WebFilterSscc.sscc = new List<string>();

            foreach (string line in objectIds)
            {
                string object_id = line.Replace("object_id", "")
                .Replace("sscc", "")
                .Replace("'", "")
                .Replace(" ", "")
                .Replace(",", "")
                .Replace("<", "")
                .Replace(">", "")
                .Trim();

                if (String.IsNullOrEmpty(object_id) || object_id.Length != 18)
                    continue;
                WebFilterSscc.sscc.Add(object_id);

                if (WebFilterSscc.sscc.Count == limitFilter)
                {
                    if (isNeedSleep)
                        System.Threading.Thread.Sleep(sleepMs);

                    isNeedSleep = true;
                    GoSscc(WebFilterSscc, ref res);
                    WebFilterSscc.sscc.Clear();
                }
            }

            if (WebFilterSscc.sscc.Count > 0)
            {
                if (isNeedSleep)
                    System.Threading.Thread.Sleep(sleepMs);

                GoSscc(WebFilterSscc, ref res);
            }
        }
        private static void GoSscc(RestApi.DataClasses.SsccSearchFilter WebFilter, ref List<SearchObjectId> result)
        {
            if (WebFilter.sscc.Count == 0)
                return;

            try
            {
                RestApi.DataClasses.SsccSearchResponse res = Sys.Global.WebMethod<RestApi.DataClasses.SsccSearchResponse>(181, WebFilter);

                if (res == null)
                {
                    throw new Exception("Не удалось получить данные от сервера МДЛП");
                }

                foreach (var item in res.entries)
                {
                    result.Add(new ResponseClasses.SearchObjectId
                    {
                        sscc = ((string.IsNullOrEmpty(item.parent_sscc)) ? "" : item.parent_sscc),
                        object_id = item.sscc,
                        branch_id = item.owner_id,
                        status = item.status,
                        name = "",
                        err_code = 0,
                        err_desc = "",
                        count = item.count,
                    });
                }
                foreach (var item in res.failed_entries)
                {
                    result.Add(new ResponseClasses.SearchObjectId
                    {
                        sscc = "",
                        object_id = item.sscc,
                        branch_id = "",
                        status = "",
                        name = "",
                        err_code = item.error_code,
                        err_desc = item.error_desc,
                        count = 0,
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static RestApi.ResponseClasses.ResMsg SearchGtinBySscc(string sscc)
        {
            RestApi.ResponseClasses.ResMsg res = new RestApi.ResponseClasses.ResMsg();
            res.res = -1;
            res.msg = "Ничего не найдено";

            bool isNeedTW = false;
            string gtin = "";
            try
            {
                DataTable dtMdlp = DAO.GtinBySsccFromMdlp(sscc);
                if (dtMdlp == null)
                    isNeedTW = true;
                else
                {
                    if (dtMdlp.Rows.Count == 0)
                        isNeedTW = true;
                    else
                    {
                        gtin = dtMdlp.Rows[0]["GTIN"].ToString();
                        if (string.IsNullOrEmpty(gtin))
                            isNeedTW = true;
                        else
                        {
                            if (gtin.Length != 14)
                                isNeedTW = true;
                            else
                            {
                                res.res = 1;
                                res.msg = gtin;
                                return res;
                            }
                        }
                    }
                }
            }
            catch (Exception exMdlp)
            {
                Console.WriteLine(exMdlp.Message);
                isNeedTW = true;
            }

            try
            {
                if (isNeedTW)
                {
                    DataTable dtTW = DAO.GtinBySsccFromTW(sscc);
                    if (dtTW == null)
                        throw new Exception("Не удалось получить данные от базы данных TW4");

                    if (dtTW.Rows.Count == 0)
                        throw new Exception("Ничего найти не удалось");

                    gtin = dtTW.Rows[0]["GTIN"].ToString();
                    if (string.IsNullOrEmpty(gtin))
                        throw new Exception("Ничего найти не удалось");

                    if (gtin.Length != 14)
                        throw new Exception($"Не верно заполнен GTIN ({gtin})");

                    res.res = 1;
                    res.msg = gtin;
                    return res;
                }
            }
            catch (Exception exTW)
            {
                res.res = -1;
                res.msg = exTW.Message;
                return res;
            }

            //TODO: Можно добавить запрос из Api МДЛП

            return res;
        }
    }
}
