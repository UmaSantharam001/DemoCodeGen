using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;

namespace Estimate.BusinessServices
{
    public class DisableloginService : IDisableloginService
    {

        private BaseGateway _gateway;

        public DisableloginService(BaseGateway gateway)
        {
            _gateway = gateway;
        }

        public DisableLoginresponse AdminDisabledUsersInsert_BL (Address1 body, string TenantIdentifier, string client_id, string client_secret, int channelid)
      {
        //  
        return null;
      }

    }
}
