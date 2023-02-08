using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.BusinessServices.Interfaces
{
    public interface ILastloginService
    {
        LastLoginresponse Username_BL (string UserName, string TenantIdentifier, string client_id, string client_secret, int channelid);

    }
}
