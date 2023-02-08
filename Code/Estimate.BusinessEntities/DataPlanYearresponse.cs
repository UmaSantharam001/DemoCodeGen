using System;
using System.Collections.Generic;

namespace Estimate.BusinessEntities
{
    public class DataPlanYearresponse
    {
        public int PlanId  { get; set; }
        public string Description  { get; set; }
        public bool Enabled  { get; set; }
        public int PlanYearId  { get; set; }
        public int Year  { get; set; }
        public int PbpId  { get; set; }
        public string PbpCode  { get; set; }
        public string PbpDescription  { get; set; }
        public string GroupId  { get; set; }
        public string StateCode  { get; set; }
        public string StateName  { get; set; }
        public double LIS25  { get; set; }
        public double LIS50  { get; set; }
        public double LIS75  { get; set; }
        public double LIS100  { get; set; }
        public int Deductible  { get; set; }
        public double Premium  { get; set; }
        public bool Deminimis  { get; set; }
        public string FormularyId  { get; set; }
        public string PricingGroupId  { get; set; }
        public bool IsBrokerPbp  { get; set; }
        public bool IsEGWP  { get; set; }
        public string TimeZone  { get; set; }
        public bool DayLightSavings  { get; set; }
        public bool SkipDeductable  { get; set; }
        public bool EGWPDirectBill  { get; set; }
    }
}
