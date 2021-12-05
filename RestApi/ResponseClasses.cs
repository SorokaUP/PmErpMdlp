using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApi.ResponseClasses
{
    public class SearchObjectId
    {
        public string object_id { get; set; }
        //SGTIN
        public string name { get; set; }
        public string batch { get; set; }
        public string gtin { get; set; }
        public string sscc { get; set; }
        public string branch_id { get; set; }
        public string status { get; set; }
        public string status_rus { get; set; }
        public DateTime status_date { get; set; }
        public string owner { get; set; }
        public int sscc_total { get; set; }
        public string sscc_hierarchy { get; set; }

        public int err_code { get; set; }
        public string err_desc { get; set; }

        //SSCC
        public int count { get; set; }
        public string parent_sscc { get; set; }
    }

    public class ResMsg
    {
        public int res { set; get; }
        public string msg { set; get; }
    }
}
