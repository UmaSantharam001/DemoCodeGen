using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface IPrintrequestRepository
    {
        PrintRequestresponse PrintRequestInsert_Data (PrintRequestresponse body, string client_id, string client_secret, int channelid);

    }
}
