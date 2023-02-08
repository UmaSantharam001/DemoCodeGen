using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.BusinessServices.Interfaces
{
    public interface IPrintrequestexportService
    {
        PrintRequestExportresponse PrintRequestExport_BL (string TenantIdentifier, string client_id, string client_secret, int channelid);

    }
}
