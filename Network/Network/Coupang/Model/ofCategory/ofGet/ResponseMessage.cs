using System;
using System.Collections.Generic;
using System.Text;

namespace Coupang.Model.ofCategory.ofGet
{
    public class ResponseMessage
    {
        public int code { get; set; }
        public string message { get; set; }
        public data data { get; set; }
    }

    public class data
    {
        public string displayCategoryCode { get; set; }
        public string name{ get; set; }
        public string status {get; set;}
        public string chile {get; set;}
    }
}
