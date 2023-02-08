using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class MemberBillingresponse
    {
        public int MpStatusCode  { get; set; }
        public IEnumerable<string> errors  { get; set; }
    }

}
