using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface IDisenrollmentreasonsRepository
    {
        DisenrollmentReasonsresponse disenrollmentReasons_Data (string client_id, string client_secret, int channelid);

    }
}
