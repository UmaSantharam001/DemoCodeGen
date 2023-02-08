using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using Estimate.BusinessEntities;
using Estimate.Data.Constants;
using Estimate.Data.Context;
using Estimate.Data.Interfaces;
using Estimate.Data.Repositories.Interfaces;

namespace Estimate.Data.Repositories
{
    public class AuditlogbynameidRepository : IAuditlogbynameidRepository
    {
        private readonly DataContext _dataContext;

        public AuditlogbynameidRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public string AuditLogByNameId_GET_Data (string NameId, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('dbo.AuditLogGetByNameID', NameID, ChannelID);
            return null;
        }

    }
}
