using System.ServiceModel;
using System.Collections.Generic;
using System.ServiceModel.Web;
using RestApi.ResponseClasses;
using System.IO;

namespace RestApi
{
    [ServiceContract]
    public interface ISearch
    {
        
        #region Поиск
        [OperationContract]
        [WebInvoke(Method = "GET",
             ResponseFormat = WebMessageFormat.Xml,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "Search/ObjectId/object_id={object_id}&mode={mode}")]
        [return: MessageParameter(Name = "data")]
        SearchObjectId SearchObjectId(string object_id, string mode);

        [OperationContract]
        [WebInvoke(Method = "POST",
             ResponseFormat = WebMessageFormat.Xml,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "Search/ObjectIdList")]
        [return: MessageParameter(Name = "data")]
        List<SearchObjectId> SearchObjectIdList(Stream streamdata);

        [OperationContract]
        [WebInvoke(Method = "GET",
             ResponseFormat = WebMessageFormat.Xml,
             BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "Search/GtinBySscc/{sscc}")]
        [return: MessageParameter(Name = "data")]
        ResMsg SearchGtinBySscc(string sscc);
        #endregion
    }
}