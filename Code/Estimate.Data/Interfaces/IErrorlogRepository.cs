using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface IErrorlogRepository
    {
        string PostAdminDisabledUsersInsert_Data (string body, string client_id, string client_secret, int channelid);

    }
}
