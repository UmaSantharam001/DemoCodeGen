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
    public class SsadeductexportRepository : ISsadeductexportRepository
    {
        private readonly DataContext _dataContext;

        public SsadeductexportRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public SSADeductExportresponse userName_Data (string UserName, string TenantIdentifier, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<SSADeductExportresponse>('dbo.SSADeductExport', UserName);
            return null;
        }

    }
}
