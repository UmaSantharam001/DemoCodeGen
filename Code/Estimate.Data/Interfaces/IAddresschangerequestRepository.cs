using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface IAddresschangerequestRepository
    {
        string AddressChangeRequestMemberIDByID_GET_Data (string ID, string client_id, string client_secret, int channelid);

    }
}
