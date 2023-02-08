using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class Enrollment
    {
        public string applicationDate  { get; set; }
        public string electionType  { get; set; }
        public string state  { get; set; }
        public string type  { get; set; }
        public string medicareId  { get; set; }
        public string plan  { get; set; }
        public string sepReason  { get; set; }
        public string language  { get; set; }
        public string partAStartDate  { get; set; }
        public string partBStartDate  { get; set; }
        public string partDStartDate  { get; set; }
        public object otherCoverage  { get; set; }
        public string memberId  { get; set; }
        public string groupNumber  { get; set; }
        public string rxBin  { get; set; }
        public string rxPcn  { get; set; }
        public string pbp  { get; set; }
    }

}
