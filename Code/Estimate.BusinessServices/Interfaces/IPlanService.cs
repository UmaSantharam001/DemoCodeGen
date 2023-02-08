using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.BusinessServices.Interfaces
{
    public interface IPlanService
    {
        IEnumerable<Plan> Plan_Get_BL (int planYear, int planId, string state, string pbp, int daysSupply, int drugTier, string pharmacyCostType, string language, string groupId, bool isEGWP, string TenantIdentifier, string client_id, string client_secret, int channelid);

    }
}
