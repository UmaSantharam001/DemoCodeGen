using System;
using System.Collections.Generic;

namespace Estimate.BusinessEntities
{
    public class SSADeductRequest
    {
        public string NameID  { get; set; }
        public string RequestDate  { get; set; }
        public string MedicareID  { get; set; }
        public string MemberID  { get; set; }
    }
}
