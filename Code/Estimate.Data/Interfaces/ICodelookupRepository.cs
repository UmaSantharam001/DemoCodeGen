using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface ICodelookupRepository
    {
        CodeLookupCallScriptresponse Language_Data (string language, string client_id, string client_secret, int channelid);

        CodeLookupAdminDropDownListresponse Year_Data (int Year, string client_id, string client_secret, int channelid);

    }
}
