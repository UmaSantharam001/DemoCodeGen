using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;

namespace Estimate.BusinessServices
{
    public class PrintrequesttypesService : IPrintrequesttypesService
    {

      private BaseGateway _gateway;

      public PrintrequesttypesService(BaseGateway gateway) {
            _gateway = gateway;
        }

      public PrintRequestTypesresponse PrintRequestTypesWho_BL (string Who, string TenantIdentifier, string client_id, string client_secret, int channelid)
      {
        //  
        return null;
      }

    }
}
