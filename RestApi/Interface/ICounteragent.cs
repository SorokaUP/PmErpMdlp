using System.ServiceModel;
using System.Collections.Generic;
using System.ServiceModel.Web;
using RestApi.ResponseClasses;
using System.IO;

namespace RestApi
{
    [ServiceContract]
    public interface ICounteragent
    {
        #region Контрагенты
        [OperationContract]
        [WebInvoke(Method = "GET",
             ResponseFormat = WebMessageFormat.Xml,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "Counteragent/GetInfo/inn={inn}")]
        [return: MessageParameter(Name = "data")]
        ResMsg GetInfo(string inn);

        [OperationContract]
        [WebInvoke(Method = "GET",
             ResponseFormat = WebMessageFormat.Xml,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "Counteragent/ToVerify/inn={inn}&mode={mode}")]
        [return: MessageParameter(Name = "data")]
        ResMsg ToVerify(string inn, string mode);

        [OperationContract]
        [WebInvoke(Method = "GET",
             ResponseFormat = WebMessageFormat.Xml,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "Counteragent/GetFias/xec_id={xec_id}")]
        [return: MessageParameter(Name = "data")]
        ResMsg GetFias(string xec_id);
        #endregion
    }
}