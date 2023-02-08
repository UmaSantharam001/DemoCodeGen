using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.Data.Repositories.Interfaces
{
    public interface IMemberRepository
    {
        MemberSSADeductRequestresponse SSADeductRequest_Data (MemberSSADeductRequestresponse body, string TenantIdentifier, string client_id, string client_secret, int channelid);

        MemberPaymentInsertpaymentlogresponse insertpaymentlog_Data (MemberPaymentInsertpaymentlogresponse body, string TenantIdentifier, string client_id, string client_secret, int channelid);

        IEnumerable<MemberPaymentLastvalidpaymentresponse> lastvalidpayment_GetMemberById_Data (string altMemberId, string client_id, string client_secret, int channelid);

        MemberPortaluserresponse portaluser_Data (MemberPortaluserresponse body, string client_id, string client_secret, int channelid);

        MemberPortaluserresponse portaluser1_Data (MemberPortaluserresponse body, string client_id, string client_secret, int channelid);

        MemberPortalusersresponse portaluser2_Data (MemberPortalusersresponse body, string client_id, string client_secret, int channelid);

        Memberresponse GetMemberDetailsByNameId_Data (string NameId, string client_id, string client_secret, int channelid);

        IEnumerable<MemberMessagesresponse> Member_GetMemberMessages_Data (MemberMessagesresponse body, string client_id, string client_secret, int channelid);

        string GetMember_GetMemberMessages_Data (int ApplicationId, string client_id, string client_secret, int channelid);

        IEnumerable<MemberPortalDetailsresponse> GetportalDetails_Data (string nameId, string Role, string client_id, string client_secret, int channelid);

        string MemberUpdateEmail_POST_Data (string body, string client_id, string client_secret, int channelid);

    }
}
