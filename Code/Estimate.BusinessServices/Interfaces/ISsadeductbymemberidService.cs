using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.BusinessServices.Interfaces
{
    public interface ISsadeductbymemberidService
    {
        SSADeductByMemberIDresponse MemberID (string memberId, string TenantIdentifier, string client_id, string client_secret, int channelid);

    }
}
