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
    public class PrintrequesttypesRepository : IPrintrequesttypesRepository
    {
        private readonly DataContext _dataContext;

        public PrintrequesttypesRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public PrintRequestTypesresponse PrintRequestTypesWho_Data (string Who, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<PrintRequestTypesresponse>('dbo.PrintRequestTypesGet', Who, ChannelID);
            return null;
        }

    }
}
