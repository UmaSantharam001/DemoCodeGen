using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface ILastloginRepository
    {
        LastLoginresponse lastLogin_Data (string UserName, string client_id, string client_secret, int channelid);

    }
}
