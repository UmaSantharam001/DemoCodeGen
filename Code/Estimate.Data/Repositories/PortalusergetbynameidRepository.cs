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
    public class PortalusergetbynameidRepository : IPortalusergetbynameidRepository
    {
        private readonly DataContext _dataContext;

        public PortalusergetbynameidRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public PortalUserGetByNameIdresponse PortalUserGetByNameIdByNameId_GET_Data (string NameId, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<PortalUserGetByNameIdresponse>('dbo.PortalUserGetByNameId', NameId, ChannelID);
            return null;
        }

    }
}
