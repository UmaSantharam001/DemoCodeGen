using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class LastLoginresponse
    {
        public string username  { get; set; }
        public string ipAddress  { get; set; }
        public bool success  { get; set; }
        public string loginDate  { get; set; }
    }

}
