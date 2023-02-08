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
    public class LastloginRepository : ILastloginRepository
    {
        private readonly DataContext _dataContext;

        public LastloginRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public LastLoginresponse lastLogin_Data (string UserName, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<LastLoginresponse>('dbo.AdminLoginGet', UserName);
            return null;
        }

    }
}
