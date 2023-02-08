using System;
using System.Collections.Generic;

namespace Estimate.BusinessEntities
{
    public class MemberPaymentresponse
    {
        public string NameId  { get; set; }
        public string PaymentMethodCode  { get; set; }
        public string PaymentType  { get; set; }
        public string BillingId  { get; set; }
        public bool StopRequestPending  { get; set; }
    }
}
