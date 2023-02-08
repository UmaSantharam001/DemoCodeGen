using System;
using System.Collections.Generic;

namespace Estimate.BusinessEntities
{
    public class PlanDetail
    {
        public string PharmacyCostType  { get; set; }
        public int DrugTier  { get; set; }
        public string DrugTierCaption  { get; set; }
        public string DaysSupply  { get; set; }
        public double CostAmount  { get; set; }
        public double CostPercentage  { get; set; }
        public double MinAmount  { get; set; }
        public double MaxAmount  { get; set; }
        public bool Is31DaySupply  { get; set; }
        public string DrugCategory  { get; set; }
        public string SubCategory  { get; set; }
    }
}
