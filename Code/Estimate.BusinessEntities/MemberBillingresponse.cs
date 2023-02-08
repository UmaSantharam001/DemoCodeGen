using System;
using System.Collections.Generic;

namespace Estimate.BusinessEntities
{
    public class MemberBillingresponse
    {
        public int MpStatusCode  { get; set; }
        public IEnumerable<string> errors  { get; set; }
    }
}
