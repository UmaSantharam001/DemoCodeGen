using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface ILepattestationsRepository
    {
        string LEPAttestationsGet_Data (bool complete, bool assigned, string client_id, string client_secret, int channelid);

    }
}
