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
    public class DisenrollmentreasonsRepository : IDisenrollmentreasonsRepository
    {
        private readonly DataContext _dataContext;

        public DisenrollmentreasonsRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public DisenrollmentReasonsresponse disenrollmentReasons_Data (string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<DisenrollmentReasonsresponse>('dbo.DisenrollmentReasonsGet', ChannelID);
            return null;
        }

    }
}
