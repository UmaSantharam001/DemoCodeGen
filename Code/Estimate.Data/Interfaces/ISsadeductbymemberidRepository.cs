using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface ISsadeductbymemberidRepository
    {
        string MemberID_Data (string memberId, string TenantIdentifier, string client_id, string client_secret, int channelid);

    }
}
