using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface ICorrespondenceloggetbynameidRepository
    {
        IEnumerable<Letter> CorrespondenceLogGetByNameIdByNameId_GET_Data (string NameId, string client_id, string client_secret, int channelid);

    }
}
