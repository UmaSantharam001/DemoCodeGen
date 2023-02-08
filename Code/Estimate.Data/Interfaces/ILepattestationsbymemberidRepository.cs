using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface ILepattestationsbymemberidRepository
    {
        string GetLEPAttestationsByMemberID_Data (string memberId, string TenantIdentifier, string client_id, string client_secret, int channelid);

    }
}
