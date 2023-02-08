using System;
using System.Collections.Generic;

namespace Estimate.BusinessEntities
{
    public class Error
    {
        public int statusCode  { get; set; }
        public string message  { get; set; }
        public string topic  { get; set; }
        public int severityLevel  { get; set; }
        public string severity  { get; set; }
    }
}
