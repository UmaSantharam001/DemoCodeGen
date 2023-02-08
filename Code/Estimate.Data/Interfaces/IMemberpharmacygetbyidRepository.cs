using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface IMemberpharmacygetbyidRepository
    {
        MemberPharmacyGetByIDresponse MemberPharmacyGetByID_GET_Data (string nameId, double planId, string client_id, string client_secret, int channelid);

    }
}
