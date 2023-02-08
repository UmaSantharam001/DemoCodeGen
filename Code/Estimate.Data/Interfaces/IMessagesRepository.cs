using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface IMessagesRepository
    {
        string GetMemberMessages_Data (Messagesresponse body, string client_id, string client_secret, int channelid);

        Messagesresponse UpsertMemberMessages_Data (Messagesresponse body, string client_id, string client_secret, int channelid);

        string MessagesByMessageId_GET_Data (string MessageId, string client_id, string client_secret, int channelid);

        string MessagesLookupsByMessageId_DELETE_Data (string MessageId, int channelid);

        string Member_GetMemberMessagesLookup_Data (string client_id, string client_secret, int channelid);

        string Member_GetMemberMessagesLookup1_Data (string client_id, string client_secret, int channelid);

        string Member_GetMemberMessagesLookup2_Data (string client_id, string client_secret, int channelid);

        string Member_GetMemberMessagesLookup3_Data (string client_id, string client_secret, int channelid);

    }
}
