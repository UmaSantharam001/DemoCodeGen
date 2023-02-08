using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.BusinessServices.Interfaces
{
    public interface IAuditlogbynameidService
    {
        string AuditLogByNameId_GET_BL (string NameId, string client_id, string client_secret, int channelid);

    }
}
