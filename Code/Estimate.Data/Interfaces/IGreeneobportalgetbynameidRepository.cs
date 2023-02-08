using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface IGreeneobportalgetbynameidRepository
    {
        string GreenEobPortalGetByNameId_GET_Data (string nameId, string client_id, string client_secret, int channelid);

    }
}
