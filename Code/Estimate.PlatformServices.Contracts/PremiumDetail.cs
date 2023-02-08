using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class PremiumDetail
    {
        public string effectiveDate  { get; set; }
        public double premiumAmount  { get; set; }
        public double memberExpected  { get; set; }
        public string lepAmount  { get; set; }
        public int lisExpected  { get; set; }
        public int spapExpected  { get; set; }
        public int ssaExpected  { get; set; }
    }

}
