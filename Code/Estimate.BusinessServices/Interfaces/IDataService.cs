using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.BusinessServices.Interfaces
{
    public interface IDataService
    {
        IEnumerable<DataCodelookupresponse> CodeLookup_Get_BL (string Language, string TypeCode, string TenantIdentifier, string client_id, string client_secret, int channelid);

        IEnumerable<SEPReason> SEPReason_Get_BL (string TenantIdentifier, string client_id, string client_secret, int channelid);

    }
}
