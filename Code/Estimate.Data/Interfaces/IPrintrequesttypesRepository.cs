using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface IPrintrequesttypesRepository
    {
        PrintRequestTypesresponse PrintRequestTypesWho_Data (string Who, string client_id, string client_secret, int channelid);

    }
}
