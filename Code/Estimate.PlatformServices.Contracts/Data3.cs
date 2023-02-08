using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class Data3
    {
        public string nameId  { get; set; }
        public IEnumerable<string> brokers  { get; set; }
        public IEnumerable<string> emailAddresses  { get; set; }
    }

}
