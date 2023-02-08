using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;

namespace Estimate.BusinessServices
{
    public class LepattestationsbymemberidService : ILepattestationsbymemberidService
    {

      private BaseGateway _gateway;

      public LepattestationsbymemberidService(BaseGateway gateway) {
            _gateway = gateway;
        }

      public string GetLEPAttestationsByMemberID_BL (string memberId, string TenantIdentifier, string client_id, string client_secret, int channelid)
      {
        //  
        return null;
      }

    }
}
