using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;

namespace Estimate.BusinessServices
{
    public class CodelookupService : ICodelookupService
    {

      private BaseGateway _gateway;

      public CodelookupService(BaseGateway gateway) {
            _gateway = gateway;
        }

      public CodeLookupCallScriptresponse Language_BL (string language, string TenantIdentifier, string client_id, string client_secret, int channelid)
      {
        //  
        return null;
      }

      public CodeLookupAdminDropDownListresponse Year_BL (int year, string TenantIdentifier, string client_id, string client_secret, int channelid)
      {
        //  
        return null;
      }

    }
}
