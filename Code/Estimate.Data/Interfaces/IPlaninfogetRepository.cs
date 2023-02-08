using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface IPlaninfogetRepository
    {
        PlanInfoGetresponse PlanInfoGet_GET_Data (string packageId, int year, string groupId, string client_id, string client_secret, int channelid);

    }
}
