using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface ISecretquestionRepository
    {
        Secretquestionresponse SecretquestionByUserId_GET_Data (string UserId, string client_id, string client_secret, int channelid);

    }
}
