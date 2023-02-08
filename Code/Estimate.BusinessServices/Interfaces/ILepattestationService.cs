using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.BusinessServices.Interfaces
{
    public interface ILepattestationService
    {
        IEnumerable<LEPAttestationresponse1> LEPAttestationGetByID_BL (int ID, string TenantIdentifier, string client_id, string client_secret, int channelid);

        LepAttestationresponse LEPAttestationUpdate_BL (LEPAttestationresponse1 body, string TenantIdentifier, string client_id, string client_secret, int channelid);

    }
}
