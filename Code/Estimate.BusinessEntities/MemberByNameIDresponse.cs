using System;
using System.Collections.Generic;

namespace Estimate.BusinessEntities
{
    public class MemberByNameIDresponse
    {
        public string nameId  { get; set; }
        public IEnumerable<string> brokers  { get; set; }
        public IEnumerable<string> emailAddresses  { get; set; }
    }
}
