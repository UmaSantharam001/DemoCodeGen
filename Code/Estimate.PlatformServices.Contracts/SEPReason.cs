using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class SEPReason
    {
        public int SEPReasonID  { get; set; }
        public string Code  { get; set; }
        public string Reason  { get; set; }
        public bool ActiveFlag  { get; set; }
        public bool MoreInfo  { get; set; }
    }

}
