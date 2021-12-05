using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ProfitMed.DataContract;
using PMMarkingUI.Forms;
using PMMarkingUI.Classes;
using PMMarkingUI.Delegats;
using Newtonsoft.Json;
using ProfitMedServiceClient;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraBars;
using DevExpress.XtraVerticalGrid.Rows;

namespace Sys
{
    public static class Global
    {
        /// <summary>
        /// ID пользователя в TBL_USERS
        /// </summary>
        public static int UID { get; set; }
        /// <summary>
        /// ID пользователя в TBL_USERS_TW
        /// </summary>
        public static int TW_UID { get; set; }
        /// <summary>
        /// ID организации пользователя TBL_OUR_ORG_INFO
        /// </summary>
        public static int ID_OUR { get; set; }
        /// <summary>
        /// GUID пользователя по МДЛП
        /// </summary>
        public static string USER_ID { get; set; }
        /// <summary>
        /// Login пользователя по МДЛП
        /// </summary>
        public static string USER_LOGIN { get; set; }
        /// <summary>
        /// TBL_OUR_ORG_INFO
        /// </summary>
        public static string SYS_OBJ_ID { get; set; }
        /// <summary>
        /// Дата и время получения токена доступа к МДЛП
        /// </summary>
        public static DateTime TOKEN_DATE { get; set; }
        /// <summary>
        /// Время жизни токена в минутах
        /// </summary>
        public static int TOKEN_LIFE_TIME { get; set; }

        public static string VERSION = "1.35";
        public static DelegateVoid dTokenChange;

        public const string AdminPassword = "xxx";
        public const string RootPassword = "xxx";

        public static System.IO.Ports.SerialPort Scaner { get; set; }
        public static bool ScanerOpen()
        {
            if (Scaner == null)
                ScanerSet();
            /*if (!Scaner.IsOpen)
            {
                try
                {
                    Scaner.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }*/
            return Scaner.IsOpen;
        }
        public static void ScanerSet()
        {
            if (Scaner == null)
                Scaner = new System.IO.Ports.SerialPort();
            Scaner.ReadTimeout = 500;
            frmTextBox frm = new frmTextBox("Укажите номер COM порта", "Введите номер (без приписки СОМ)");
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Scaner.PortName = "COM" + frm.Data;
            }
        }
        public static void SetSettingsAndOpen(this System.IO.Ports.SerialPort sp, bool ForceSet = false)
        {
            bool isFirst = true;            
            if (Scaner == null || ForceSet)
                ScanerSet();

            AOpen:
            sp.ReadTimeout = Scaner.ReadTimeout;
            sp.PortName = Scaner.PortName;
            try
            {
                if (!sp.IsOpen)
                    sp.Open();
            }
            catch (System.InvalidOperationException iex)
            {
                if (isFirst)
                {
                    isFirst = false;
                    if (MessageBox.Show("Не удалось подключиться к порту, хотите сменить настройки COM порта?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ScanerSet();
                        goto AOpen;
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.IndexOf("не существует") > 0)
                {
                    if (MessageBox.Show(ex.Message + " Хотите сменить настройки COM порта?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ScanerSet();
                        goto AOpen;
                    }
                }
                Console.WriteLine(ex.Message);
            }
        }

        #region LookUpEdit.Ref
        public static void Ref(this LookUpEdit sender, ButtonPressedEventArgs e, DataTable data, string FieldValue, string FieldName)
        {
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
                sender.GetRef(data, FieldValue, FieldName);
            if (e.Button.Kind == ButtonPredefines.Delete)
                sender.ClearRef();
        }

        private static void GetRef(this LookUpEdit sender, DataTable data, string FieldValue, string FieldName)
        {
            string caption = "Выбор значения";
            //try { caption = ((sender.Parent) as GroupBox).Text; } catch { caption = ""; }

            frmRef frm = new frmRef(caption, data, FieldValue, FieldName);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK || dr == DialogResult.Retry)
            {
                DataTable res = new DataTable();
                res.Columns.Add(FieldValue, typeof(object));
                res.Columns.Add(FieldName, typeof(string));
                DataRow row = res.NewRow();
                row[FieldValue] = frm.Value;
                row[FieldName] = frm.ValueName;
                res.Rows.Add(row);

                sender.Properties.DataSource = res;
                sender.Properties.DisplayMember = FieldName;
                sender.Properties.ValueMember = FieldValue;

                sender.EditValue = frm.Value;
                sender.RefreshEditValue();
            }
        }

        private static void ClearRef(this RepositoryItemLookUpEdit sender)
        {
            if (MessageBox.Show("Очистить поле?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sender.DataSource = new DataTable();
            }
        }
        #endregion

        #region LookUpEdit.Ref
        public static void Ref(this EditorRow sender, ButtonPressedEventArgs e, DataTable data, string FieldValue, string FieldName)
        {
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
                sender.GetRef(data, FieldValue, FieldName);
            if (e.Button.Kind == ButtonPredefines.Delete)
                sender.ClearRef();
        }

        private static void GetRef(this EditorRow sender, DataTable data, string FieldValue, string FieldName)
        {
            string caption = "Выбор значения";

            frmRef frm = new frmRef(caption, data, FieldValue, FieldName);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK || dr == DialogResult.Retry)
            {
                DataTable res = new DataTable();
                res.Columns.Add(FieldValue, typeof(object));
                res.Columns.Add(FieldName, typeof(string));
                DataRow row = res.NewRow();
                row[FieldValue] = frm.Value;
                row[FieldName] = frm.ValueName;
                res.Rows.Add(row);

                (sender.Properties.RowEdit as RepositoryItemLookUpEdit).DataSource = res;
                (sender.Properties.RowEdit as RepositoryItemLookUpEdit).DisplayMember = FieldName;
                (sender.Properties.RowEdit as RepositoryItemLookUpEdit).ValueMember = FieldValue;
                sender.Properties.Value = frm.Value;
            }
        }

        private static void ClearRef(this EditorRow sender)
        {
            if (MessageBox.Show("Очистить поле?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                (sender.Properties.RowEdit as RepositoryItemLookUpEdit).DataSource = new DataTable();
                sender.Properties.Value = null;
            }
        }
        #endregion

        #region ButtonEdit.Ref
        public static void Ref(this ButtonEdit sender, ButtonPressedEventArgs e, DataTable data, string FieldValue, string FieldName)
        {
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
                sender.GetRef(data, FieldValue, FieldName);
            if (e.Button.Kind == ButtonPredefines.Delete)
                sender.ClearRef();
        }

        private static void GetRef(this ButtonEdit sender, DataTable data, string FieldValue, string FieldName)
        {
            string caption = "";
            try { caption = ((sender.Parent) as GroupBox).Text; } catch { caption = ""; }

            frmRef frm = new frmRef(caption, data, FieldValue, FieldName);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK || dr == DialogResult.Retry)
            {
                sender.Tag = frm.Value;
                sender.Text = frm.ValueName;
            }
        }

        private static void ClearRef(this ButtonEdit sender)
        {
            if (MessageBox.Show("Очистить поле?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sender.Tag = null;
                sender.Text = "";
            }
        }

        public static RefRes GetRef(DataTable data, string Caption, string FieldValue, string FieldName)
        {
            RefRes res = new RefRes();
            string caption = (string.IsNullOrEmpty(Caption)) ? "Выберите значение" : Caption;

            frmRef frm = new frmRef(caption, data, FieldValue, FieldName, true);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK || dr == DialogResult.Retry)
            {
                res.Value = frm.Value;
                res.Name = frm.ValueName;
            }
            res.DResult = dr;

            return res;
        }
        #endregion

        #region BarEditItem.Ref
        public static void Ref(this BarEditItem sender, ButtonPressedEventArgs e, DataTable data, string FieldValue, string FieldName)
        {
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
                sender.GetRef(data, FieldValue, FieldName);
            if (e.Button.Kind == ButtonPredefines.Delete || e.Button.Kind == ButtonPredefines.Close)
                sender.ClearRef();
        }

        private static void GetRef(this BarEditItem sender, DataTable data, string FieldValue, string FieldName)
        {
            frmRef frm = new frmRef("", data, FieldValue, FieldName);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK || dr == DialogResult.Retry)
            {
                sender.Tag = frm.Value;
                sender.EditValue = frm.ValueName;
            }
        }

        private static void ClearRef(this BarEditItem sender)
        {
            if (MessageBox.Show("Очистить поле?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sender.Tag = null;
                sender.EditValue = "";
            }
        }
        #endregion

        /// <summary>
        /// Обновить информацию о TOKEN пользователя из базы данных по tbl_USERS
        /// </summary>
        /// </summary>
        public static void RefreshToken()
        {
            try
            {
                Dictionary<string, object> data = ProfitMed.Firebird.DAO.GetTokenDateByUid(Sys.Global.UID);
                DateTime newTOKEN = Convert.ToDateTime(data["TOKEN_DATE"]);
                Sys.Global.TOKEN_LIFE_TIME = Convert.ToInt32(data["TOKEN_LIFE_TIME"]);
                bool isChange = Sys.Global.TOKEN_DATE != newTOKEN;
                Sys.Global.TOKEN_DATE = newTOKEN;
                dTokenChange();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка обновления токена: {ex.Message}");
            }
        }

        public static ProfitMedClient Api = new ProfitMedClient();
        public static ProfitMed.Firebird.DataProvider DataProvider = new ProfitMed.Firebird.DataProvider();
        public static T WebMethod<T>(int MethodId, object Body, params string[] QueryParam)
        {
            try
            {
                if (Api == null)
                    Api = new ProfitMedClient();

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
                    System.Threading.Thread.Sleep(4000);
                    temp = Sys.Global.WebMethod<TR>(MethodId, WebFilter);
                    if (temp == null)
                    {
                        Console.WriteLine($"[{DateTime.Now}] № {PackNum} Пусто");
                        if (is_first)
                        {
                            is_first = false;
                            System.Threading.Thread.Sleep(1500);
                            goto TBeg;
                        }
                        throw new NullReferenceException();
                    }
                    else
                    {
                        Console.WriteLine($"[{DateTime.Now}] № {PackNum} Успешно");
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

        public static string WebRequestHttp(string strRequest)
        {
            WebRequest request = WebRequest.Create(strRequest);
            request.Credentials = CredentialCache.DefaultCredentials;
            string strResponse = null;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream dataStream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(dataStream))//, System.Text.Encoding.GetEncoding(1251));
                    {
                        strResponse = reader.ReadToEnd();
                        reader.Close();
                    }
                    dataStream.Close();
                }
                response.Close();
            }

            return strResponse;
        }








        public static string WebMethod000()
        {
            try
            {
                int MethodId = 139;
                string Body = "";
                Body = "{\"filter\":{\"houseguid\": \"e197a891-291d-4d2b-95a4-9f42a8210cfb\"}, \"start_from\": 0, \"count\": 100}";
                //Body = "{\"filter\":{\"houseguid\": \"b99e6a5e-8505-4c41-8e86-edb2b2dc35d7\"}, \"start_from\": 0, \"count\": 100}"; // г Москва, проезд 17-й Марьиной Рощи, Дом 13, Строение 5

                if (Api == null)
                    Api = new ProfitMedClient();

                byte[] RequestBody = Encoding.UTF8.GetBytes(Body.ToString());
                byte[] ApiRes = Api.RequestManager(MethodId, Sys.Global.USER_ID, RequestBody, null);
                string ApiResString = Encoding.UTF8.GetString(ApiRes);
                return ApiResString;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Console.WriteLine("Ошибка! " + ex.Message);
                return null;
            }
        }
    }
}
