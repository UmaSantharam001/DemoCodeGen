using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;

namespace Estimate.BusinessServices
{
    public class PrintrequestexportService : IPrintrequestexportService
    {

      private BaseGateway _gateway;

      public PrintrequestexportService(BaseGateway gateway) {
            _gateway = gateway;
        }

      public PrintRequestExportresponse PrintRequestExport_BL (string TenantIdentifier, string client_id, string client_secret, int channelid)
      {
        //  
        return null;
      }

    }
}
