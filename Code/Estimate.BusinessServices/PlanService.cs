using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;

namespace Estimate.BusinessServices
{
    public class PlanService : IPlanService
    {

      private BaseGateway _gateway;

      public PlanService(BaseGateway gateway) {
            _gateway = gateway;
        }

      public IEnumerable<Plan> Plan_Get_BL (int planYear, int planId, string state, string pbp, int daysSupply, int drugTier, string pharmacyCostType, string language, string groupId, bool isEGWP, string TenantIdentifier, string client_id, string client_secret, int channelid)
      {
        // gateway.Get("http://apieic.envisionrx.internalapi/api/plan/search"); 
        return null;
      }

    }
}
