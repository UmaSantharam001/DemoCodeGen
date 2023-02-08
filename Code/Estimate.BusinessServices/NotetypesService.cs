using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;

namespace Estimate.BusinessServices
{
    public class NotetypesService : INotetypesService
    {

      private BaseGateway _gateway;

      public NotetypesService(BaseGateway gateway) {
            _gateway = gateway;
        }

      public string Notetypes_GET_BL (string TenantIdentifier, string client_id, string client_secret, int channelid)
      {
        //  
        return null;
      }

    }
}
