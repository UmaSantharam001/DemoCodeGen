using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;

namespace Estimate.BusinessServices
{
    public class LepattestationsService : ILepattestationsService
    {

      private BaseGateway _gateway;

      public LepattestationsService(BaseGateway gateway) {
            _gateway = gateway;
        }

      public LepAttestationsresponse LEPAttestationsGet_BL (bool complete, bool assigned, string TenantIdentifier, string client_id, string client_secret, int channelid)
      {
        //  
        return null;
      }

    }
}
