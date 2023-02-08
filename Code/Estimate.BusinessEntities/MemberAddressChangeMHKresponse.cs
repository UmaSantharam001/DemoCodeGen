using System;
using System.Collections.Generic;

namespace Estimate.BusinessEntities
{
    public class MemberAddressChangeMHKresponse
    {
        public int MpStatusCode  { get; set; }
        public IEnumerable<string> errors  { get; set; }
    }
}
