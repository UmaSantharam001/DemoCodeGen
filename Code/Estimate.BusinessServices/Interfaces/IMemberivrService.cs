using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.BusinessServices.Interfaces
{
    public interface IMemberivrService
    {
        string MemberIvr_GetBalance_BL (Memberresponse body, string TenantIdentifier, string client_id, string client_secret, int channelid);

    }
}
