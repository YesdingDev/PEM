using System;
using System.Collections.Generic;
using System.Text;

namespace PEM.Service.Helpers.POCO
{
    public class StatusMessage
    {
        public string status { get; set; }
        public string message { get; set; }
        public dynamic data { get; set; }
        public string auth_token { get; set; }
    }

    public class Response<Result> where Result : class
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public Result Data { get; set; }
        public string Auth_token { get; set; }
    }
}
