using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RestApi.DataClasses
{
    [DataContract]
    [JsonObject]
    public class SsccSearchFilter
    {
        [DataMember]
        [JsonProperty]
        public List<string> sscc;
    }

    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class SsccSearchResponse
    {
        [DataMember]
        [JsonProperty]
        public int total;
        [DataMember]
        [JsonProperty]
        public int failed;
        [DataMember]
        [JsonProperty]
        public List<SsccShortInfo> entries;
        [DataMember]
        [JsonProperty]
        public List<FailedInfo> failed_entries;
    }

    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class SsccShortInfo
    {
        [DataMember]
        [JsonProperty]
        public string sscc;
        [DataMember]
        [JsonProperty]
        public string owner_id;
        [DataMember]
        [JsonProperty]
        public string status_date;
        [DataMember]
        [JsonProperty]
        public string last_tracing_op_date;
        [DataMember]
        [JsonProperty]
        public string status;
        [DataMember]
        [JsonProperty]
        public int count;
        [DataMember]
        [JsonProperty]
        public string parent_sscc;
    }

    [DataContract]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class FailedInfo
    {
        [DataMember]
        [JsonProperty]
        public string sscc;
        [DataMember]
        [JsonProperty]
        public int error_code;
        [DataMember]
        [JsonProperty]
        public string error_desc;
    }
}
