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
    public class MemberpharmacygetbyidRepository : IMemberpharmacygetbyidRepository
    {
        private readonly DataContext _dataContext;

        public MemberpharmacygetbyidRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public MemberPharmacyGetByIDresponse MemberPharmacyGetByID_GET_Data (string nameId, double planId, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<MemberPharmacyGetByIDresponse>('dbo.MemberPharmacyGetById', NameId, PlanId, ChannelId);
            return null;
        }

    }
}
