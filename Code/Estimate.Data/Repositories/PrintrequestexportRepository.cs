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
    public class PrintrequestexportRepository : IPrintrequestexportRepository
    {
        private readonly DataContext _dataContext;

        public PrintrequestexportRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public PrintRequestExportresponse PrintRequestExport_Data (string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<PrintRequestExportresponse>('dbo.PrintRequestExport', ChannelId);
            return null;
        }

    }
}
