using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class ResponseDetails
    {
        public string ProcessPaymentReponse  { get; set; }
        public bool SsaDeductRequested  { get; set; }
        public bool IsBrokerCompliant  { get; set; }
        public string PaymentException  { get; set; }
    }

}
