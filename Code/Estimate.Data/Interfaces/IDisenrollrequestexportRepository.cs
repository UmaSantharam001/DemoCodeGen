using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface IDisenrollrequestexportRepository
    {
        DisenrollRequestExportresponse GetuserName_Data (string UserName, string client_id, string client_secret, int channelid);

    }
}
