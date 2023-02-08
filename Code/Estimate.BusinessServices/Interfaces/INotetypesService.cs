using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.BusinessServices.Interfaces
{
    public interface INotetypesService
    {
        string Notetypes_GET_BL (string TenantIdentifier, string client_id, string client_secret, int channelid);

    }
}
