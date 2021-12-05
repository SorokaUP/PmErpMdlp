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
using RestApi.Additional;

namespace RestApi.Implementation
{
    public static class Counteragent
    {
        /// <summary>
        /// Получить информацию о контрагенте из МДЛП
        /// </summary>
        public static RestApi.ResponseClasses.ResMsg GetInfo(string inn)
        {
            var res = new RestApi.ResponseClasses.ResMsg();

            bool isCycle = string.IsNullOrEmpty(inn);
            int FixLimitApi = 15;
            int StartFromApi = 0;
            bool isNeedIteration = false;
            int SleepMs = 1000;
            int limitReCycle = 3;

            try
            {
                CountragentsList result = new CountragentsList();
                result.filtered_records = new List<FilteredRecords>();
                PartnersFilters WebFilter = new PartnersFilters
                {
                    filter = new PartnersFilter { reg_entity_type = 1 },
                    start_from = StartFromApi,
                    count = FixLimitApi
                };
                if (!string.IsNullOrEmpty(inn))
                    WebFilter.filter.inn = inn;

                do
                {
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
                            Thread.Sleep(SleepMs);
                        }
                    }
                    while (isNeedReCycle && iReCycle <= limitReCycle);

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
                    if (Sys.Global.DataProvider == null)
                        Sys.Global.DataProvider = new ProfitMed.Firebird.DataProvider();

                    result.session_id = Sys.Global.DataProvider.GetSessionID();
                    Sys.Global.DataProvider.SaveCountragentsList(result);
                    DAO.CounteragentParsing(result.session_id, false);
                }
                else
                {
                    if (isCycle)
                        throw new Exception($"Не удалось получить данные о контрагентах");
                    else
                        throw new Exception($"Не удалось получить данные о контрагенте по ИНН {inn}");
                }

                res.res = 1;
                res.msg = $"Информация о контрагенте с ИНН {inn} получена";
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
        /// Операции со списком доверенных контрагентов
        /// </summary>
        public static RestApi.ResponseClasses.ResMsg ToVerify(string inn, string mode)
        {
            const string modeAdd = "add";
            const string modeDel = "del";

            var res = new RestApi.ResponseClasses.ResMsg();

            if (!new string[] { modeAdd, modeDel }.Contains(mode))
            {
                res.res = -1;
                res.msg = "Не удалось определить режим работы";
                return res;
            }
            if (string.IsNullOrEmpty(inn))
            {
                res.res = -1;
                res.msg = "ИНН не передан";
                return res;
            }

            try
            {
                //------------------------------------------------------------------------------------
                // ШАГ 1. Получаем список выбранных контрагентов (их ИНН) и отправляем запрос в МДЛП

                // Отправляем запрос в МДЛП                    
                string responseApi = "";
                try
                {
                    TrustedPartnersArray WebData = new TrustedPartnersArray
                    {
                        trusted_partners = new string[] { inn }
                    };

                    int methodId = 0;
                    switch (mode)
                    {
                        case modeAdd:
                            methodId = 163;
                            break;

                        case modeDel:
                            methodId = 164;
                            break;
                    }

                    responseApi = Sys.Global.WebMethod<string>(methodId, WebData);
                }
                catch (Exception ex)
                {
                    res.res = -1;
                    res.msg = ex.Message;
                    return res;
                }

                //------------------------------------------------------------------------------------
                // ШАГ 2. Запрашиваем у МДЛП данные обо всех (или одном конкретном) доверенных контрагентах

                // 8.7.3 Метод фильтрации доверенных контрагентов
                ListTrustedPartners tplResponse = CounteragentsGetVerifyList(new TrustedPartnersFilter
                {
                    trusted_inn = inn
                });

                //------------------------------------------------------------------------------------
                // ШАГ 3. Сравниваем отправленные и полученные данные (ИНН)

                if (mode == modeAdd || mode == modeDel)
                {
                    int flag = (mode == modeAdd) ? 1 : 0;
                    bool isFind = false;
                    string sys_id = "";

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
                    if ((isFind && mode == modeAdd) || (!isFind && mode == modeDel))
                    {
                        if (!string.IsNullOrEmpty(inn))
                        {
                            // Пишем полученные sys_id по ИНН
                            DAO.ToVerify(inn, sys_id, flag);
                        }
                    }
                }


                //------------------------------------------------------------------------------------
                // Подведение итогов

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
        private static ListTrustedPartners CounteragentsGetVerifyList(TrustedPartnersFilter filter)
        {
            int iCycle = 0;
            int limitReCycle = 3;
            int total = 0;
            int SleepMs = 1000;
            ListTrustedPartners tplResponse = new ListTrustedPartners();
            tplResponse.entries = new List<TrustedPartners>();
            int FixLimitApi = 100;
            int StartFromApi = 0;
            bool isNeedIteration = false;

            // 8.7.3 Метод фильтрации доверенных контрагентов
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
                        temp = Sys.Global.WebMethod<ListTrustedPartners>(165, WebFilter);
                        if (total == 0)
                            total = temp.total;
                    }
                    catch
                    {
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
                        Thread.Sleep(SleepMs);
                    }
                }
                while (isNeedReCycle && iReCycle <= limitReCycle);

                #region Переливаем временные данные в общую кучу и определяем необходимость следующей итерации
                tplResponse.entries.AddRange(temp.entries);
                isNeedIteration = (total - tplResponse.entries.Count > 0);
                StartFromApi += FixLimitApi;

                // Пауза между вызовами методов
                if (isNeedIteration)
                    Thread.Sleep(SleepMs);
                #endregion
            }
            while (isNeedIteration && StartFromApi <= total);
            tplResponse.total = tplResponse.entries.Count;

            return tplResponse;
        }

        /// <summary>
        /// Получение ФИАС по адресу
        /// </summary>
        public static RestApi.ResponseClasses.ResMsg GetFias(string xec_id)
        {
            var res = new RestApi.ResponseClasses.ResMsg();

            try
            {
                int cntErrors = Ahunter.GetFiasAhunter(int.Parse(xec_id));
                if (cntErrors > 0)
                    throw new Exception("Не удалось получить данные из Ahunter");
                res.res = 1;
                res.msg = "Выполнено";
            }
            catch (Exception ex)
            {
                res.res = -1;
                res.msg = ex.Message;
            }

            return res;
        }
    }
}
