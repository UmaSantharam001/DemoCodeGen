using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.BusinessServices.Interfaces
{
    public interface IEventlogService
    {
        Eventlogresponse EventLog_BL (Eventlogresponse body, string client_id, string client_secret, int channelid);

    }
}
