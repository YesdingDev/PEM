using System;
using System.Collections.Generic;
using System.Text;

namespace PEM.Service.Helpers.POCO
{
    public class APIsettings
    {
        public string WebApiBaseUrl { get; set; }
        public string Initializer { get; set; }
        public string BearerToken { get; set; }
        public string PageNumDefault { get; set; }
        public string PageSizeDefault { get; set; }
    }
}
