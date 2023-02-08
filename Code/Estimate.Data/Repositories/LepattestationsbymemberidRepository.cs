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
    public class LepattestationsbymemberidRepository : ILepattestationsbymemberidRepository
    {
        private readonly DataContext _dataContext;

        public LepattestationsbymemberidRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public string GetLEPAttestationsByMemberID_Data (string memberId, string TenantIdentifier, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('dbo.LEPAttestationsGetByMemberID', memberId);
            return null;
        }

    }
}
