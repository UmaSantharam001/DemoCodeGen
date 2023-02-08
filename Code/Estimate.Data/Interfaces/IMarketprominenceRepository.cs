using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface IMarketprominenceRepository
    {
        string MarketProminence_GET_Data (string pbp, int year, string client_id, string client_secret, int channelid);

    }
}
