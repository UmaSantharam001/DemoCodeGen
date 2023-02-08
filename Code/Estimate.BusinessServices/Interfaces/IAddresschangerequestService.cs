using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.BusinessServices.Interfaces
{
    public interface IAddresschangerequestService
    {
        Response_Boolean_ AddressChangeRequestUpdate_BL (AddressChangeRequestsresponse body, string TenantIdentifier, string client_id, string client_secret, int channelid);

        string AddressChangeRequestbyId_BL (double addressChangeID, string TenantIdentifier, string client_id, string client_secret, int channelid);

        string AddressChangeRequestMemberIDByID_GET_BL (int ID, string client_id, string client_secret, int channelid);

    }
}
