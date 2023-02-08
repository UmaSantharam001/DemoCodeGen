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
    public class GreeneobportalgetbynameidRepository : IGreeneobportalgetbynameidRepository
    {
        private readonly DataContext _dataContext;

        public GreeneobportalgetbynameidRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public string GreenEobPortalGetByNameId_GET_Data (string nameId, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('dbo.GreenEobPortalGetByNameId', NameId, channelId);
            return null;
        }

    }
}
