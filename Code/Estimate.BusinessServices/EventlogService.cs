using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;

namespace Estimate.BusinessServices
{
    public class EventlogService : IEventlogService
    {

        private BaseGateway _gateway;

        public EventlogService(BaseGateway gateway)
        {
            _gateway = gateway;
        }

        public Eventlogresponse EventLog_BL (Eventlogresponse body, string client_id, string client_secret, int channelid)
      {
        //  
        return null;
      }

    }
}
