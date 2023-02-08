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
    public class DisableloginRepository : IDisableloginRepository
    {
        private readonly DataContext _dataContext;

        public DisableloginRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public DisableLoginresponse AdminDisabledUsersInsert_Data (DisableLoginrequest body, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<DisableLoginresponse>('dbo.AdminDisabledUsersInsert', UserName);
            return null;
        }

    }
}
