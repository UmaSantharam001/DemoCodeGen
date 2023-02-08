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
    public class PlaninfogetRepository : IPlaninfogetRepository
    {
        private readonly DataContext _dataContext;

        public PlaninfogetRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public PlanInfoGetresponse PlanInfoGet_GET_Data (string packageId, int year, string groupId, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<PlanInfoGetresponse>('dbo.PlanInfoGet', packageId, groupId, year, channelId);
            return null;
        }

    }
}
