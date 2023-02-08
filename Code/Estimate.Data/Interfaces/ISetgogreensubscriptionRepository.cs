using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface ISetgogreensubscriptionRepository
    {
        SetGoGreenSubscriptionresponse SetGoGreenSubscription_Data (SetGoGreenSubscriptionresponse body, string client_id, string client_secret, int channelid);

    }
}
