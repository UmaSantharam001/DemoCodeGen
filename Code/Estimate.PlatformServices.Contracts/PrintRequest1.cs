using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class PrintRequest1
    {
        public string documentType  { get; set; }
        public string planType  { get; set; }
        public string memberID  { get; set; }
        public string medicareID  { get; set; }
        public string prefix  { get; set; }
        public string firstName  { get; set; }
        public string middleInitial  { get; set; }
        public string lastName  { get; set; }
        public string address1  { get; set; }
        public string address2  { get; set; }
        public string city  { get; set; }
        public string state  { get; set; }
        public string zipCode  { get; set; }
        public string phone  { get; set; }
        public string language  { get; set; }
        public string groupID  { get; set; }
        public string PBP  { get; set; }
    }

}
