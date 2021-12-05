using System.ServiceModel;
using System.Collections.Generic;
using System.ServiceModel.Web;
using RestApi.ResponseClasses;
using System.IO;

namespace RestApi
{
    [ServiceContract]
    public interface IDoc
    {
        #region Документ
        [OperationContract]
        [WebInvoke(Method = "GET",
             ResponseFormat = WebMessageFormat.Xml,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "Doc/GetMetadata/{doc_id}")]
        [return: MessageParameter(Name = "data")]
        ResMsg GetMetadata(string doc_id);

        [OperationContract]
        [WebInvoke(Method = "GET",
             ResponseFormat = WebMessageFormat.Xml,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "Doc/GetBody/{doc_id}")]
        [return: MessageParameter(Name = "data")]
        ResMsg GetBody(string doc_id);

        [OperationContract]
        [WebInvoke(Method = "GET",
             ResponseFormat = WebMessageFormat.Xml,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "Doc/GetTicket/{doc_id}")]
        [return: MessageParameter(Name = "data")]
        ResMsg GetTicket(string doc_id);

        [OperationContract]
        [WebInvoke(Method = "GET",
             ResponseFormat = WebMessageFormat.Xml,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "Doc/Send/{doc_id}")]
        [return: MessageParameter(Name = "data")]
        ResMsg Send(string doc_id);

        [OperationContract]
        [WebInvoke(Method = "GET",
             ResponseFormat = WebMessageFormat.Xml,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "Doc/ProcessBody/{doc_id}")]
        [return: MessageParameter(Name = "data")]
        ResMsg ProcessBody(string doc_id);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Xml,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "Doc/ProcessSscc/{doc_id}")]
        [return: MessageParameter(Name = "data")]
        ResMsg ProcessSscc(string doc_id);
        #endregion
    }
}