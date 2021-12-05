using System.IO;
using System.Collections.Generic;
using RestApi.ResponseClasses;
using RestApi.Implementation;

namespace RestApi
{
    public class Service : IService
    {
        #region Документы
        /// <summary>
        /// Получить метаданные
        /// </summary>
        public ResMsg GetMetadata(string idoc_id)
            => Doc.GetMetadata(idoc_id);

        /// <summary>
        /// Получить XML тело документа
        /// </summary>
        public ResMsg GetBody(string idoc_id)
            => Doc.GetBody(idoc_id);

        /// <summary>
        /// Получить Квитанцию
        /// </summary>
        public ResMsg GetTicket(string idoc_id)
            => Doc.GetTicket(idoc_id);

        /// <summary>
        /// Отправить документ
        /// </summary>
        public ResMsg Send(string idoc_id)
            => Doc.Send(idoc_id);

        /// <summary>
        /// Обработать тело документа
        /// </summary>
        public ResMsg ProcessBody(string doc_id)
            => Doc.ProcessBody(doc_id);

        /// <summary>
        /// Обработать коробки
        /// </summary>
        public ResMsg ProcessSscc(string doc_id)
            => Doc.ProcessSscc(doc_id);
        #endregion
        #region Поиск
        /// <summary>
        /// Поиск SGTIN / SSCC в базе МДЛП
        /// </summary>
        /// <param name="object_id"></param>
        /// <param name="mode">0 - Общий реестр МДЛП // 1 - Баланс Организации</param>
        /// <returns></returns>
        public SearchObjectId SearchObjectId(string object_id, string mode)
            => Search.SearchObjectId(object_id, mode);

        /// <summary>
        /// Поиск SGTIN в базе МДЛП по списку значений
        /// </summary>
        public List<SearchObjectId> SearchObjectIdList(Stream streamdata)
            => Search.SearchObjectIdList(streamdata);

        /// <summary>
        /// Получить GTIN по SSCC
        /// </summary>
        public ResMsg SearchGtinBySscc(string sscc)
            => Search.SearchGtinBySscc(sscc);
        #endregion
        #region Контрагенты
        /// <summary>
        /// Получить информацию о контрагенте из МДЛП
        /// </summary>
        public ResMsg GetInfo(string inn)
            => Counteragent.GetInfo(inn);

        /// <summary>
        /// Операции со списком доверенных контрагентов
        /// </summary>
        public ResMsg ToVerify(string inn, string mode)
            => Counteragent.ToVerify(inn, mode);

        /// <summary>
        /// Получение ФИАС по адресу
        /// </summary>
        public ResMsg GetFias(string xec_id)
            => Counteragent.GetFias(xec_id);
        #endregion
        #region КИЗ
        public ResMsg KizGetInfoByList(string doc_id, Stream streamdata)
            => Kiz.KizGetInfoByList(doc_id, streamdata);
        #endregion
    }
}