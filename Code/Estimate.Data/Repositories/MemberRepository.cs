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
    public class MemberRepository : IMemberRepository
    {
        private readonly DataContext _dataContext;

        public MemberRepository(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public MemberSSADeductRequestresponse SSADeductRequest_Data (MemberSSADeductRequestresponse body, string TenantIdentifier, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<MemberSSADeductRequestresponse>('dbo.MemberInsertSSADeduct', SSADeductId, NameId, ChannelId, MemberID, MedicareNumber, FirstName, LastName, CreatedBy);
            return null;
        }

        public MemberPaymentInsertpaymentlogresponse insertpaymentlog_Data (MemberPaymentInsertpaymentlogresponse body, string TenantIdentifier, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<MemberPaymentInsertpaymentlogresponse>('dbo.PaymentLogInsert', MemberId, CreatedDate, TransactionId, Status, Origin);
            return null;
        }

        public IEnumerable<MemberPaymentLastvalidpaymentresponse> lastvalidpayment_GetMemberById_Data (string altMemberId, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<IEnumerable<MemberPaymentLastvalidpaymentresponse>>('select * from dbo.PaymentLog where MemberId=:altMemberId');
            return null;
        }

        public MemberPortaluserresponse portaluser_Data (MemberPortaluserresponse body, string client_id, string client_secret, int channelid)
        {
            return null;
        }

        public MemberPortaluserresponse portaluser1_Data (MemberPortaluserresponse body, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<MemberPortaluserresponse>('select  UserId  from dbo.PortalUsers where UserId = ::userId');
            // _dataContext.Query<MemberPortaluserresponse>('dbo.PortalUserUpdate', UserId, UserName, EMail, WritingCode, RoleId, NameId, ChannelID, PatientId, Password, SecretImage, ResetGUID, ResetTs, LoginAttempt, HasAcceptedEula, Phone, PreferedContactMethod, ReturnId);
            return null;
        }

        public MemberPortalusersresponse portaluser2_Data (MemberPortalusersresponse body, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<MemberPortalusersresponse>('select UserId  from dbo.PortalUsers where UserId = ::userId');
            // _dataContext.Query<MemberPortalusersresponse>('dbo.PortalUserUpdate', UserId, UserName, EMail, WritingCode, RoleId, NameId, ChannelID, PatientId, Password, SecretImage, ResetGUID, ResetTs, LoginAttempt, HasAcceptedEula, Phone, PreferedContactMethod, ReturnId);
            return null;
        }

        public Memberresponse GetMemberDetailsByNameId_Data (string NameId, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<Memberresponse>('dbo.MemberNavBillingGet', nameId, channelId);
            return null;
        }

        public IEnumerable<MemberMessagesresponse> Member_GetMemberMessages_Data (MemberMessagesresponse body, string client_id, string client_secret, int channelid)
        {
            return null;
        }

        public string GetMember_GetMemberMessages_Data (int ApplicationId, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('dbo.MemberMessagesGetAll', ApplicationId);
            return null;
        }

        public IEnumerable<MemberPortalDetailsresponse> GetportalDetails_Data (string nameId, string Role, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<IEnumerable<MemberPortalDetailsresponse>>('dbo.PortalDetailsByNameIdGet', NameId, Role, ChannelId);
            return null;
        }

        public string MemberUpdateEmail_POST_Data (string body, string client_id, string client_secret, int channelid)
        {
            // _dataContext.Query<string>('dbo.PortalUserUpdate', UserId, UserName, EMail, WritingCode, RoleId, NameId, ChannelId, PatientId, Password, SecretImage, ResetGUID, ResetTs, LoginAttempt, HasAcceptedEula, Phone, PreferedContactMethod, ReturnId);
            return null;
        }

    }
}
