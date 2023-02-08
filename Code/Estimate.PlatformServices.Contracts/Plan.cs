using System;
using System.Collections.Generic;

namespace Estimate.PlatformServices.Contracts
{
    public class Plan
    {
        public int PlanId  { get; set; }
        public string PlanName  { get; set; }
        public int PlanYear  { get; set; }
        public string Pbp  { get; set; }
        public string PbpDescription  { get; set; }
        public bool IsEGWP  { get; set; }
        public string GroupId  { get; set; }
        public string State  { get; set; }
        public string StateName  { get; set; }
        public double Lis25  { get; set; }
        public double Lis50  { get; set; }
        public double Lis75  { get; set; }
        public double Lis100  { get; set; }
        public double Deductible  { get; set; }
        public string DeductibleDescription  { get; set; }
        public double Premium  { get; set; }
        public bool Deminimis  { get; set; }
        public bool SkipDeductable  { get; set; }
    }

}
