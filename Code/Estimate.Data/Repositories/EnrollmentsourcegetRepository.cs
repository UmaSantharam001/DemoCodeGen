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
    public class EnrollmentsourcegetRepository : IEnrollmentsourcegetRepository
    {
        private readonly DataContext _dataContext;

        public EnrollmentsourcegetRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public IEnumerable<EnrollmentSourceGetresponse> EnrollmentSourceGet_GET_Data (string id, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<IEnumerable<EnrollmentSourceGetresponse>>('dbo.EnrollmentSourceGet', id, ChannelID);
            return null;
        }

    }
}
