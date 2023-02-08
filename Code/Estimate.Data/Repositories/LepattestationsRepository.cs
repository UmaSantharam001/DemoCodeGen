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
    public class LepattestationsRepository : ILepattestationsRepository
    {
        private readonly DataContext _dataContext;

        public LepattestationsRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public string LEPAttestationsGet_Data (bool complete, bool assigned, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('dbo.LEPAttestationsGet', complete, assigned);
            return null;
        }

    }
}
