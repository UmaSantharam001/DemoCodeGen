using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.BusinessServices.Interfaces
{
    public interface ILepattestationsService
    {
        LepAttestationsresponse LEPAttestationsGet_BL (bool complete, bool assigned, string TenantIdentifier, string client_id, string client_secret, int channelid);

    }
}
