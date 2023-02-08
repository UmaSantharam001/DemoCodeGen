using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;

namespace Estimate.BusinessServices
{
    public class AddresschangerequestService : IAddresschangerequestService
    {

      private BaseGateway _gateway;

      public AddresschangerequestService(BaseGateway gateway) {
            _gateway = gateway;
        }

      public Response_Boolean_ AddressChangeRequestUpdate_BL (AddressChangeRequestsresponse body, string TenantIdentifier, string client_id, string client_secret, int channelid)
      {
        //  
        return null;
      }

      public string AddressChangeRequestbyId_BL (double addressChangeID, string TenantIdentifier, string client_id, string client_secret, int channelid)
      {
        //  
        return null;
      }

      public string AddressChangeRequestMemberIDByID_GET_BL (int ID, string client_id, string client_secret, int channelid)
      {
        //  
        return null;
      }

    }
}
