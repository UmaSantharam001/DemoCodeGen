using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface ISsadeductexportRepository
    {
        SSADeductExportresponse userName_Data (string UserName, string TenantIdentifier, string client_id, string client_secret, int channelid);

    }
}
