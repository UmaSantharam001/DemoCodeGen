using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.BusinessServices.Interfaces
{
    public interface ICodelookupService
    {
        CodeLookupCallScriptresponse Language_BL (string language, string TenantIdentifier, string client_id, string client_secret, int channelid);

        CodeLookupAdminDropDownListresponse Year_BL (int year, string TenantIdentifier, string client_id, string client_secret, int channelid);

    }
}
