using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface IEnrollmentsourcegetRepository
    {
        IEnumerable<EnrollmentSourceGetresponse> EnrollmentSourceGet_GET_Data (string id, string client_id, string client_secret, int channelid);

    }
}
