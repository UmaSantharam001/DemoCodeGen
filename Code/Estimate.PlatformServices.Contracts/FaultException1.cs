using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class FaultException1
    {
        public bool Success  { get; set; }
        public IEnumerable<string> Exceptions  { get; set; }
        public IEnumerable<string> Errors  { get; set; }
        public IEnumerable<string> Warnings  { get; set; }
        public IEnumerable<string> Messages  { get; set; }
    }

}
