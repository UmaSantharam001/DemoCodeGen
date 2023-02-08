using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.BusinessServices.Interfaces
{
    public interface IPrintrequesttypesService
    {
        PrintRequestTypesresponse PrintRequestTypesWho_BL (string Who, string TenantIdentifier, string client_id, string client_secret, int channelid);

    }
}
