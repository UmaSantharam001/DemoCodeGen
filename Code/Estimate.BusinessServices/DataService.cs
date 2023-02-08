using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;

namespace Estimate.BusinessServices
{
    public class DataService : IDataService
    {

      private BaseGateway _gateway;

      public DataService(BaseGateway gateway) {
            _gateway = gateway;
        }

      public IEnumerable<DataCodelookupresponse> CodeLookup_Get_BL (string Language, string TypeCode, string TenantIdentifier, string client_id, string client_secret, int channelid)
      {
        // gateway.Get("http://apieic.envisionrx.internalapi/api/data/codelookup"); 
        return null;
      }

      public IEnumerable<SEPReason> SEPReason_Get_BL (string TenantIdentifier, string client_id, string client_secret, int channelid)
      {
        //  
        return null;
      }

    }
}
