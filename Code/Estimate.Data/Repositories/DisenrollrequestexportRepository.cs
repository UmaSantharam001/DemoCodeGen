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
    public class DisenrollrequestexportRepository : IDisenrollrequestexportRepository
    {
        private readonly DataContext _dataContext;

        public DisenrollrequestexportRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public DisenrollRequestExportresponse GetuserName_Data (string UserName, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<DisenrollRequestExportresponse>('dbo.DisenrollmentRequestPortalExport', UserName, ChannelID);
            return null;
        }

    }
}
