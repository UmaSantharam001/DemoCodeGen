using System;
using System.Collections.Generic;

namespace Estimate.BusinessEntities
{
    public class Transaction
    {
        public string billee  { get; set; }
        public string invoiceNumber  { get; set; }
        public string paymentType  { get; set; }
        public string createDate  { get; set; }
        public string periodStart  { get; set; }
        public string paymentMethod  { get; set; }
        public string note  { get; set; }
        public double totalAmount  { get; set; }
    }
}
