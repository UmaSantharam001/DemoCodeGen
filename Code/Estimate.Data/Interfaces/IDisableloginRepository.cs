using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface IDisableloginRepository
    {
        DisableLoginresponse AdminDisabledUsersInsert_Data (DisableLoginrequest body, string client_id, string client_secret, int channelid);

    }
}
