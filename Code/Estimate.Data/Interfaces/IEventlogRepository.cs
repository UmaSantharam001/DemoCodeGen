using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface IEventlogRepository
    {
        Eventlogresponse EventLog_Data (Eventlogresponse body, string client_id, string client_secret, int channelid);

    }
}
