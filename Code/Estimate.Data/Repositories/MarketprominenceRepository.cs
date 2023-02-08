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
    public class MarketprominenceRepository : IMarketprominenceRepository
    {
        private readonly DataContext _dataContext;

        public MarketprominenceRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public string MarketProminence_GET_Data (string pbp, int year, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('dbo.PackageIdGetbyPBPYear', PBP, PlanYear, ChannelID);
            return null;
        }

    }
}
