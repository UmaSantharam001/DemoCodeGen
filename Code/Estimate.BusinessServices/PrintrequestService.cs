using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;

namespace Estimate.BusinessServices
{
    public class PrintrequestService : IPrintrequestService
    {

      private BaseGateway _gateway;

      public PrintrequestService(BaseGateway gateway) {
            _gateway = gateway;
        }

      public PrintRequestresponse PrintRequestInsert_BL (Address1 body, string TenantIdentifier, string client_id, string client_secret, int channelid)
      {
        //  
        return null;
      }

    }
}
