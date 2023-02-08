using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface ILepattestationRepository
    {
        string LEPAttestationGetByID_Data (string ID, string client_id, string client_secret, int channelid);

        string LEPAttestationUpdate_Data (string body, string client_id, string client_secret, int channelid);

    }
}
