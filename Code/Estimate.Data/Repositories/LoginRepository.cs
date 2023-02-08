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
    public class LoginRepository : ILoginRepository
    {
        private readonly DataContext _dataContext;

        public LoginRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public Loginresponse AdminLoginInsert_Data (Loginrequest body, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<Loginresponse>('dbo.AdminLoginInsert', UserName, IPAddress, Success, return);
            return null;
        }

    }
}
