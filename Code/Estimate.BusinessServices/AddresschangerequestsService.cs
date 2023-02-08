using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;

namespace Estimate.BusinessServices
{
    public class AddresschangerequestsService : IAddresschangerequestsService
    {

      private BaseGateway _gateway;

      public AddresschangerequestsService(BaseGateway gateway) {
            _gateway = gateway;
        }

      public AddressChangeRequestsresponse AddressChangeRequest_BL (bool complete, bool assigned, string addresstype, string requeststartdate, string requestenddate, bool pbpchange, string TenantIdentifier, string client_id, string client_secret, int channelid)
      {
        //  
        return null;
      }

    }
}
