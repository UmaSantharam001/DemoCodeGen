using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class Error3
    {
        public string statusCode  { get; set; }
        public string message  { get; set; }
        public string topic  { get; set; }
        public int severityLevel  { get; set; }
        public string severity  { get; set; }
    }

}
