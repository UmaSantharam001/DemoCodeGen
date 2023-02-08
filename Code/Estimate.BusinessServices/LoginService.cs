using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;

namespace Estimate.BusinessServices
{
    public class LoginService : ILoginService
    {

      private BaseGateway _gateway;

      public LoginService(BaseGateway gateway) {
            _gateway = gateway;
        }

      public Loginresponse AdminLoginInsert_BL (Address1 body, string TenantIdentifier, string client_id, string client_secret, int channelid)
      {
        //  
        return null;
      }

    }
}
