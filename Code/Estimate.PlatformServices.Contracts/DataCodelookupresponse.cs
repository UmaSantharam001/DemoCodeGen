using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class DataCodelookupresponse
    {
        public string LookupTypeCode  { get; set; }
        public string Code  { get; set; }
        public string Description  { get; set; }
        public string LanguageType  { get; set; }
        public int DefaultOrder  { get; set; }
    }

}
