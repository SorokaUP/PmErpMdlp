using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using ProfitMed.DataContract;
using Newtonsoft.Json;
using ProfitMedServiceClient;

namespace Sys
{
    public static class Global
    {
        public const string USER_ID = "53e4e9ac-4eeb-4bd5-98d4-eadce4a348c9";

        public static ProfitMedClient Api = null;
        public static ProfitMed.Firebird.DataProvider DataProvider = null;
        public static T WebMethod<T>(int MethodId, object Body, params string[] QueryParam)
        {
            try
            {
                //if (Api == null)
                    Api = new ProfitMedClient();
                if (DataProvider == null)
                    DataProvider = new ProfitMed.Firebird.DataProvider();

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
                        RequestBody = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(Body));
                    else
                        RequestBody = Encoding.UTF8.GetBytes(Body.ToString());
                }

                byte[] ApiRes = Api.RequestManager(MethodId, Sys.Global.USER_ID, RequestBody, QueryParam);
                string ApiResString = Encoding.UTF8.GetString(ApiRes);
                if (typeof(T) == typeof(string) || ResponseType != "application/json")
                    return (T)Convert.ChangeType(ApiResString, typeof(T));
                try
                {
                    return JsonConvert.DeserializeObject<T>(ApiResString);
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

        public static object WebMethod(int MethodId, object Body, params string[] QueryParam)
         => WebMethod<object>(MethodId, Body, QueryParam);

        /// <summary>
        /// Получение данных по фильтру
        /// </summary>
        /// <typeparam name="TF">Тип фильтра Filters</typeparam>
        /// <typeparam name="TR">Тип возвращаемого объекта с сервера</typeparam>
        /// <typeparam name="TR">Тип возвращаемого значения</typeparam>
        /// <param name="MethodId">ID метода из таблицы TBL_WEBMETHODS</param>
        /// <param name="WebFilter">Передаваемый фильтр</param>
        /// <returns></returns>
        public static List<TE> WebMethodFiltered<TF, TR, TE>(int MethodId, Filters<TF> WebFilter)
            where TF : class, IWebFilter
            where TR : class, IWebMethodResponse<TE>
            where TE : class
        {
            List<TE> res = new List<TE>();

            int StartFromApi = WebFilter.start_from;
            int ResponseCountTotal = 0;
            int ResponseTotal = 0;
            bool isNeedIteration = false;
            int PackNum = 0;
            int PackCount = 0;
            int ReCycle = 0;
            int ReCycleLimit = 5;
            int ReCycleTimeOut = 500;
            int RequestTimeOut = 500;
            try
            {
                RequestTimeOut = (int)ProfitMed.Firebird.DAO.GetWebMethods(MethodId).Rows[0]["REQUEST_TIMEOUT"];
            }
            catch
            {
                RequestTimeOut = 500;
            }

            do
            {
                PackNum++;
                ReCycle = 0;
                // В случае, когда требуется повторить цикл
                LinkReCycle:
                WebFilter.start_from = StartFromApi;

                TR temp = default(TR);
                try
                {
                    // Получаем данные из пакета                    
                    bool is_first = true;
                    TBeg:
                    System.Threading.Thread.Sleep(500);
                    temp = Sys.Global.WebMethod<TR>(MethodId, WebFilter);
                    if (temp == null)
                    {
                        if (is_first)
                        {
                            is_first = false;
                            System.Threading.Thread.Sleep(1500);
                            goto TBeg;
                        }
                        throw new NullReferenceException();
                    }

                    if (temp is ProfitMed.DataContract.SgtinByList)
                    {
                        foreach (TE item in temp.ResponseEntries)
                        {
                            ProfitMed.DataContract.Sgtin sgtin = item as ProfitMed.DataContract.Sgtin;
                            ProfitMed.Firebird.DAO.Balance431_INS(sgtin.pack3_id, sgtin.sgtin, sgtin.status);
                        }
                    }

                    // Переливаем временные данные в общую кучу (Entries нам к сожалению не извествен)
                    foreach (TE item in temp.ResponseEntries)
                        res.Add(item);
                    ResponseCountTotal += temp.ResponseCount;
                    ResponseTotal = (ResponseTotal == 0) ? temp.ResponseTotal : ResponseTotal;
                    if (ResponseTotal > 0)
                        PackCount = ResponseTotal / WebFilter.count;
                }
                catch (NullReferenceException nex)
                {
                    if (ReCycle < ReCycleLimit)
                    {
                        // Отправляем цикл на повторную обработку
                        ReCycle++;
                        System.Threading.Thread.Sleep(ReCycleTimeOut);
                        goto LinkReCycle;
                    }
                    else
                    {
                        Console.WriteLine($"ОШИБКА: WebMethodFiltered(MethodId : {MethodId}, WebFilter : {WebFilter}) - Значение не получено ({nex.Message})");
                        // В случае, когда цикл был повторен фиксированное количество раз, а Total так и не вернулся
                        // Значит проблема в методе (не был вызван ни разу)
                        if (ResponseTotal <= 0)
                            break;
                        // Наращиваем результат (якобы мы их получили)
                        ResponseCountTotal += WebFilter.count;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ОШИБКА: WebMethodFiltered(MethodId : {MethodId}, WebFilter : {WebFilter}) - {ex.Message}");
                    break;
                }

                // Необходимость следующей итерации (всего по фильтру в API - всего перелитых в кучу)
                isNeedIteration = (ResponseTotal - ResponseCountTotal > 0);
                if (isNeedIteration)
                {
                    // Наращиваем индексы поиска
                    StartFromApi += WebFilter.count;
                    // Пауза между вызовами методов
                    System.Threading.Thread.Sleep(RequestTimeOut);
                }
            }
            while (isNeedIteration);

            return res;
        }

        public static Dictionary<string, string> dicStatus = new Dictionary<string, string>
        {
            { "in_circulacion", "В обороте" },
            { "in_realization", "Отгружен" },
            { "transfer_to_agent", "Отгружен по агентскому договору" },
            { "change_owner_state_gov", "Ожидает подтверждения получения новым владельцем" },
            { "waiting_confirmation", "Ожидает подтверждения" },
            { "in_arbitration", "В арбитраже" },
            { "moved_for_disposal", "Передан на уничтожение" },
            { "disposed", "Уничтожен" },
            { "out_of_circulation", "Выведен из оборота" },
            { "experiment_outbound", "Выведен из оборота (накопленный в рамках эксперимента)" },
            { "in_sale", "Продан в розницу" },
            { "in_partial_sale", "Частично продан в розницу" },
            { "in_discount_prescription_sale", "Отпущен по льготному рецепту" },
            { "in_partial_discount_prescription_sale", "Частично отпущен по льготному рецепту" },
            { "in_medical_use", "Выдан для медицинского применения" },
            { "in_partial_medical_use", "Частично выдан для медицинского применения" },
            { "moved_to_unregistered", "Отгружен на незарегистрированное место деятельности" },
            { "moved_to_eeu", "Отгружен в ЕАЭС" },
            { "marked", "Ожидает выпуска" },
            { "lp_sampled", "Отобран образец" },
            { "transfered_to_owner", "Ожидает подтверждения получения собственником" },
            { "shipped", "Отгружен в РФ" },
            { "arrived", "Ввезен на территорию РФ" },
            { "declared", "Задекларирован" },
            { "in_circulation", "В обороте" },
            { "paused_circulation", "Оборот приостановлен" },
            { "relabeled", "Перемаркирован" },
            { "reexported", "Реэкспорт" },
            { "released_contract", "Ожидает передачи собственнику" },
            { "released_foreign", "для типа эмиссии 3?—?Ожидает отгрузки в РФ || для типа эмиссии 4?—?Маркирован в ЗТК" },
            { "expired", "Срок годности истек" },
            { "change_owner", "Ожидает подтверждения смены собственника" },
            { "confirm_return_paused", "Ожидает подтверждения возврата приостановленных лекарственных препаратов" },
            { "moved_to_warehouse", "Принят на склад из ЗТК" },
            { "emission", "Эмитирован" },
            { "ofd_retail_error", "Продан в розницу с использованием ККТ с ошибкой" },
            { "ofd_discount_prescription_error", "Отпущен по льготному рецепту с использованием ККТ с ошибкой" },
            { "transferred_for_release", "Ожидает подтверждения получения собственником до ввода в оборот" },
            { "waiting_for_release", "Ожидает ввода в оборот собственником" },
            { "emitted", "Эмитирован" },
            { "marked_not_paid", "Ожидает выпуска, не оплачен" },
            { "released_foreign_not_paid", "для типа эмиссии 3?—?Ожидает отгрузки в РФ, не оплачен || для типа эмиссии 4?—?Маркирован в ЗТК, не оплачен" },
            { "expired_not_paid", "Истек срок ожидания оплаты" },
            { "emitted_paid", "Эмитирован, готов к использованию" },
            { "discount_prescription_error", "Отпущен по льготному рецепту с использованием РВ с ошибкой" },
            { "med_care_error", "Выдан для медицинского применения с использованием РВ с ошибкой" },
            { "declared_warehouse", "Принят на склад из ЗТК" },
            { "transferred_to_customs", "Передан для маркировки в ЗТК" },
            { "transferred_to_importer", "Ожидает подтверждения импортером" },
            { "transfer_to_production", "Ожидает подтверждения возврата" },
            { "waiting_change_property", "Ожидает подтверждения корректировки" },
            { "eliminated", "Не использован" }
        };
    }
}
