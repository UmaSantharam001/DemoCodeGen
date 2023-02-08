using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;

namespace Estimate.BusinessServices
{
    public class SsadeductbymemberidService : ISsadeductbymemberidService
    {

      private BaseGateway _gateway;

      public SsadeductbymemberidService(BaseGateway gateway) {
            _gateway = gateway;
        }

      public SSADeductByMemberIDresponse MemberID (string memberId, string TenantIdentifier, string client_id, string client_secret, int channelid)
      {
        //  
        return null;
      }

    }
}
