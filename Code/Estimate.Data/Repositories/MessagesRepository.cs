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
    public class MessagesRepository : IMessagesRepository
    {
        private readonly DataContext _dataContext;

        public MessagesRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public string GetMemberMessages_Data (Messagesresponse body, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('dbo.MemberMessagesGet', PlanType, State, ZipCode, EICNumber, ChannelID, ApplicationId);
            return null;
        }

        public Messagesresponse UpsertMemberMessages_Data (Messagesresponse body, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<Messagesresponse>('dbo.MemberMessagesInsert', MessageID, Title, Content, Link, LinkText, LanguageType, Image, DefaultOrder, StartDate, EndDate, UserName, ApplicationId);
            return null;
        }

        public string MessagesByMessageId_GET_Data (string MessageId, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('dbo.MemberMessagesGetByID', MessageId, ChannelID);
            return null;
        }

        public string MessagesLookupsByMessageId_DELETE_Data (string MessageId, int channelid)
        {
            // _dataContext.Query<string>('dbo.MemberMessagesGet', PlanType, State, ZipCode, EICNumber, channelID, ApplicationId);
            return null;
        }

        public string Member_GetMemberMessagesLookup_Data (string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('select * from MemberMessages where MemberMessageId = :MessageID');
            // _dataContext.Query<string>('//Please refer to logic in mulesoft for calling stored procedure', );
            return null;
        }

        public string Member_GetMemberMessagesLookup1_Data (string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('dbo.MemberMessagesLookupIns_Plan', Lookup, MessageID, PlanType, ChannelID);
            return null;
        }

        public string Member_GetMemberMessagesLookup2_Data (string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('select * from MemberMessages where MemberMessageId = :MessageID');
            // _dataContext.Query<string>('//Please refer to logic in mulesoft for calling stored procedure', );
            return null;
        }

        public string Member_GetMemberMessagesLookup3_Data (string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('select * from MemberMessages where MemberMessageId = :MessageID');
            // _dataContext.Query<string>('//Please refer to logic in mulesoft for calling stored procedure', );
            return null;
        }

    }
}
