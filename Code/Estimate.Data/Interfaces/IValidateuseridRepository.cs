using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface IValidateuseridRepository
    {
        string Validateuserid_GET_Data (string userId, string nameId, string client_id, string client_secret, int channelid);

    }
}
