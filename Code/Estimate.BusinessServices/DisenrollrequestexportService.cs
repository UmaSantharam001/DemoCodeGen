using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;

namespace Estimate.BusinessServices
{
    public class DisenrollrequestexportService : IDisenrollrequestexportService
    {

      private BaseGateway _gateway;

      public DisenrollrequestexportService(BaseGateway gateway) {
            _gateway = gateway;
        }

      public DisenrollRequestExportresponse userName_BL (string UserName, string TenantIdentifier, string client_id, string client_secret, int channelid)
      {
        //  
        return null;
      }

    }
}
