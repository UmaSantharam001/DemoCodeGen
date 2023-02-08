using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;

namespace Estimate.BusinessServices
{
    public class AuditlogbynameidService : IAuditlogbynameidService
    {

        private BaseGateway _gateway;

        public AuditlogbynameidService(BaseGateway gateway)
        {
            _gateway = gateway;
        }

        public string AuditLogByNameId_GET_BL (string NameId, string client_id, string client_secret, int channelid)
      {
        //  
        return null;
      }

    }
}
