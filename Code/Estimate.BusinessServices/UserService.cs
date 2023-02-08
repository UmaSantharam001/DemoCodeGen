using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;

namespace Estimate.BusinessServices
{
    public class UserService : IUserService
    {

      private BaseGateway _gateway;

      public UserService(BaseGateway gateway) {
            _gateway = gateway;
        }

      public string PortalUser_SendPasswordResetMail_BL (Address1 body, string TenantIdentifier, string client_id, string client_secret, int channelid)
      {
        // gateway.Get("http://apieic.envisionrx.internalapi/api/user/SendPasswordResetMail"); 
        return null;
      }

    }
}
