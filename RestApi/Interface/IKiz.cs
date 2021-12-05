using System.ServiceModel;
using System.ServiceModel.Web;
using RestApi.ResponseClasses;
using System.IO;

namespace RestApi
{
    [ServiceContract]
    public interface IKiz
    {
        #region КИЗ
        [OperationContract]
        [WebInvoke(Method = "POST",
             ResponseFormat = WebMessageFormat.Xml,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "Kiz/GetInfo/{doc_id}")]
        [return: MessageParameter(Name = "data")]
        ResMsg KizGetInfoByList(string doc_id, Stream streamdata);
        #endregion
    }
}