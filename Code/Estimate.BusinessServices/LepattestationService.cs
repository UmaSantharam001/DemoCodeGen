using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;

namespace Estimate.BusinessServices
{
    public class LepattestationService : ILepattestationService
    {

        private BaseGateway _gateway;

        public LepattestationService(BaseGateway gateway)
        {
            _gateway = gateway;
        }

        public IEnumerable<LEPAttestationresponse1> LEPAttestationGetByID_BL(int ID, string TenantIdentifier, string client_id, string client_secret, int channelid)
        {
            return null;
        }

        public LepAttestationresponse LEPAttestationUpdate_BL(LEPAttestationresponse1 body, string TenantIdentifier, string client_id, string client_secret, int channelid)
        {
            return null;
        }

    }
}
