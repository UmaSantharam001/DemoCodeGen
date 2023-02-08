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
    public class SecretquestionRepository : ISecretquestionRepository
    {
        private readonly DataContext _dataContext;

        public SecretquestionRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public Secretquestionresponse SecretquestionByUserId_GET_Data (string UserId, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<Secretquestionresponse>('dbo.SecretQuestionsGet', userId);
            return null;
        }

    }
}
