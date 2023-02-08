using System;
using System.Collections.Generic;

namespace Estimate.BusinessEntities
{
    public class PlanYearStage
    {
        public int Stage  { get; set; }
        public string StageDescription  { get; set; }
        public double StageLimit  { get; set; }
        public string StageGenericDescription  { get; set; }
        public string StageBrandDescription  { get; set; }
    }
}
