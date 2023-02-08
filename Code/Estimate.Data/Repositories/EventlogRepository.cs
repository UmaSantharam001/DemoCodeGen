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
    public class EventlogRepository : IEventlogRepository
    {
        private readonly DataContext _dataContext;

        public EventlogRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public Eventlogresponse EventLog_Data (Eventlogresponse body, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<Eventlogresponse>('dbo.EventLogInsert', EventTypeId, ApplicationId, NameId, ChannelId, CreatedBy, CreatedDate, OldValue, NewValue);
            return null;
        }

    }
}
