using System;
using System.Collections.Generic;

namespace Estimate.BusinessEntities
{
    public class EOBResponse
    {
        public string AltMemberId  { get; set; }
        public string RunDate  { get; set; }
        public string DownloadToken  { get; set; }
        public string Error  { get; set; }
    }
}
