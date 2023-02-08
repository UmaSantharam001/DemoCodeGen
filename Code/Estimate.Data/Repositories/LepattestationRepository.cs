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
    public class LepattestationRepository : ILepattestationRepository
    {
        private readonly DataContext _dataContext;

        public LepattestationRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public string LEPAttestationGetByID_Data (string ID, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('dbo.LEPAttestationGetByID', attestationID);
            return null;
        }

        public string LEPAttestationUpdate_Data (string body, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('dbo.LEPAttestationUpdate', AttestationID, AssignedTo, CompletionDate, CompletedBy);
            return null;
        }

    }
}
