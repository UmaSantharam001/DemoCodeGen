using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class MemberPaymentLastvalidpaymentresponse
    {
        public int Id  { get; set; }
        public int MemberId  { get; set; }
        public string CreatedDate  { get; set; }
        public string TransactionId  { get; set; }
        public bool Approved  { get; set; }
        public string Origin  { get; set; }
    }

}
