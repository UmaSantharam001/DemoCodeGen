using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.BusinessServices.Interfaces
{
    public interface IPrintrequestService
    {
        PrintRequestresponse PrintRequestInsert_BL (Address1 body, string TenantIdentifier, string client_id, string client_secret, int channelid);

    }
}
