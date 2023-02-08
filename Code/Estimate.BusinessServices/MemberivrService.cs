using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;

namespace Estimate.BusinessServices
{
    public class MemberivrService : IMemberivrService
    {

      private BaseGateway _gateway;

      public MemberivrService(BaseGateway gateway) {
            _gateway = gateway;
        }

      public string MemberIvr_GetBalance_BL (Memberresponse body, string TenantIdentifier, string client_id, string client_secret, int channelid)
      {
        return null;
      }

    }
}
