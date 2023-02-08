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
    public class ValidateuseridRepository : IValidateuseridRepository
    {
        private readonly DataContext _dataContext;

        public ValidateuseridRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public string Validateuserid_GET_Data (string userId, string nameId, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('dbo.PortalUserVerifyUserName', UserName, NameId, ChannelId);
            // _dataContext.Query<string>('dbo.PortalUserInsertTempUser', UserName, RoleId, WritingCode, NameId, Email, ChannelId);
            return null;
        }

    }
}
