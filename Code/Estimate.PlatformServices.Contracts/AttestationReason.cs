using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class AttestationReason
    {
        public string ReasonName  { get; set; }
        public string StateID  { get; set; }
        public string DateTo  { get; set; }
        public int LEPReasonID  { get; set; }
        public string DateFrom  { get; set; }
    }

}
