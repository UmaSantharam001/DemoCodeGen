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
    public class CodelookupRepository : ICodelookupRepository
    {
        private readonly DataContext _dataContext;

        public CodelookupRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public CodeLookupCallScriptresponse Language_Data (string language, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<CodeLookupCallScriptresponse>('dbo.CallScriptGet', language, ChannelID);
            return null;
        }

        public CodeLookupAdminDropDownListresponse Year_Data (int Year, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<CodeLookupAdminDropDownListresponse>('dbo.AdminDropDownListGet', Year, ChannelID);
            return null;
        }

    }
}
