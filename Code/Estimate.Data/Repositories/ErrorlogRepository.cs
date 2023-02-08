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
    public class ErrorlogRepository : IErrorlogRepository
    {
        private readonly DataContext _dataContext;

        public ErrorlogRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public string PostAdminDisabledUsersInsert_Data (string body, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('dbo.MuleApiErrorLogInsert', Message, MuleApp, ErrorType, OriginalPayload, Timestamp);
            return null;
        }

    }
}
