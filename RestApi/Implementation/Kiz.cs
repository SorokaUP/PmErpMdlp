using System;
using System.Threading;
using System.IO;
using System.Collections.Generic;
using ProfitMed.DataContract;

namespace RestApi.Implementation
{
    public static class Kiz
    {
        public static RestApi.ResponseClasses.ResMsg KizGetInfoByList(string idoc_id, Stream streamdata)
        {
            RestApi.ResponseClasses.ResMsg res = new RestApi.ResponseClasses.ResMsg();
            bool isRes = false;
            string msg = "";
            try
            {
                int doc_id = Int32.Parse(idoc_id);

                StreamReader reader = new StreamReader(streamdata);
                string stringObjectIds = reader.ReadToEnd();
                reader.Close();
                reader.Dispose();

                if (String.IsNullOrEmpty(stringObjectIds))
                    throw new Exception("Отсутствуют данные для запроса");

                string[] object_ids = stringObjectIds.Split(';');
                if (object_ids.Length == 0)
                    throw new Exception("Отсутствуют данные для запроса");

                int PackLim = 500;
                int PackNum = 0;
                bool isNeedCycle = object_ids.Length > PackLim;
                SSFilter sgtin_filter = new SSFilter();
                sgtin_filter.filter = new Sfilter();

                do
                {
                    // Расчет отбора данных для цикла
                    int factLim = object_ids.Length - PackLim * PackNum;
                    int forTo = (factLim > PackLim) ? (PackLim * (PackNum + 1)) : object_ids.Length;
                    List<string> SGTINs_pack = new List<string>();

                    for (int i = PackNum * PackLim; i < forTo; i++)
                        SGTINs_pack.Add(object_ids[i]);
                    if (SGTINs_pack.Count > 0)
                    {
                        sgtin_filter.filter.sgtins = SGTINs_pack;
                        SgtinByList resWeb = Sys.Global.WebMethod<SgtinByList>(149, sgtin_filter);
                        Sys.Global.DataProvider.SaveSgtins(resWeb.entries, 0, doc_id);

                        isRes = true;
                    }

                    // Расчет необходимости следующего цикла
                    PackNum++;
                    isNeedCycle = object_ids.Length - PackLim * PackNum > 0;
                    if (isNeedCycle)
                        Thread.Sleep(1000);
                }
                while (isNeedCycle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                msg = ex.Message;
                isRes = false;
            }

            res.res = isRes ? 1 : -1;
            res.msg = isRes ? "Выполнено" : $"Ошибка: {msg}";
            return res;
        }
    }
}
