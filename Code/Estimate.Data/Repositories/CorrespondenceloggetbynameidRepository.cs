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
    public class CorrespondenceloggetbynameidRepository : ICorrespondenceloggetbynameidRepository
    {
        private readonly DataContext _dataContext;

        public CorrespondenceloggetbynameidRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public IEnumerable<Letter> CorrespondenceLogGetByNameIdByNameId_GET_Data (string NameId, string client_id, string client_secret, int channelid)
        {   
            var queryParam = new DynamicParameters();
            queryParam.Add("toDoId", NameId);
            var data = _dataContext.CreateConnection().Query<Letter>("dbo.CorrespondenceLogGetByNameID", queryParam, commandType: System.Data.CommandType.StoredProcedure);
            return data;
        }

    }
}
