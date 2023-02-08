using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.BusinessServices.Interfaces
{
    public interface IAddresschangerequestsService
    {
        AddressChangeRequestsresponse AddressChangeRequest_BL (bool complete, bool assigned, string addresstype, string requeststartdate, string requestenddate, bool pbpchange, string TenantIdentifier, string client_id, string client_secret, int channelid);

    }
}
