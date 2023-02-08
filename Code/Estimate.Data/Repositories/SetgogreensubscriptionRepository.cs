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
    public class SetgogreensubscriptionRepository : ISetgogreensubscriptionRepository
    {
        private readonly DataContext _dataContext;

        public SetgogreensubscriptionRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public SetGoGreenSubscriptionresponse SetGoGreenSubscription_Data (SetGoGreenSubscriptionresponse body, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<SetGoGreenSubscriptionresponse>('dbo.GreenEobPortalInsert', ChannelId, NameId, ReasonCode);
            return null;
        }

    }
}
