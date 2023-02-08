using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;

namespace Estimate.BusinessServices.Interfaces
{
    public interface IMemberService
    {
        Memberresponse Member_GET_BL (string client_id, string client_secret, int channelid);

        Memberresponse1 Member_POST_BL (Address1 body, string adminRequest, string client_id, string client_secret, int channelid);

        Memberresponse2 Member_PUT_BL (Memberresponse body, string client_id, string client_secret, int channelid);

        MemberPbpChangeresponse pbpChange_BL (MemberPbpChangeresponse body, string TenantIdentifier, string client_id, string client_secret, int channelid);

        IEnumerable<Letter> Member_GetMemberById_BL (string nameId, int channelid);

        MemberNotesresponse Member_GetnotesByNameId_BL (string nameId, string TenantIdentifier, string client_id, string client_secret, int channelid);

        MemberPaymentInsertpaymentlogresponse insertpaymentlog_BL (Address1 body, string TenantIdentifier, string client_id, string client_secret, int channelid);

        IEnumerable<MemberPaymentresponse> Member_ByNameId_BL (string nameId, string TenantIdentifier, string client_id, string client_secret, int channelid);

        MemberByNameIDresponse Member_ByNameId1_BL (string nameId, string TenantIdentifier, string client_id, string client_secret, int channelid);

        MemberNameIdresponse Member_GetnameId_BL (string nameId, string client_id, string client_secret, int channelid);

        Memberresponse MemberByNameId_GET_BL (string nameId, string client_id, string client_secret, int channelid);

        MemberBillingresponse MemberBillingByNameId_GET_BL (string nameId, string client_id, string client_secret, int channelid);

        object GetMember_GetMemberById_BL (string altMemberId, string TenantIdentifier, string client_id, string client_secret, int channelid);

        MemberPaymentLastvalidpaymentresponse lastvalidpayment_GetMemberById_BL (string altMemberId, string TenantIdentifier, string client_id, string client_secret, int channelid);

        string MemberPharmacy_POST_BL (string body, string client_id, string client_secret, int channelid);

        string MemberPharmacyByMemberPharmacyId_DELETE_BL (string memberPharmacyId, string client_id, string client_secret, int channelid);

        MemberBillingresponse1 MemberBillingByNameId_GET1_BL (string nameId, string client_id, string client_secret, int channelid);

        string MemberBillingVisitedByNameIdAndAltNameId_GET_BL (string nameId, string altNameId, string client_id, string client_secret, int channelid);

        string MemberPortaluser_POST_BL (string body, string client_id, string client_secret, int channelid);

        MemberPortaluserresponse1 MemberPortaluser_PUT_BL (Address1 body, string client_id, string client_secret, int channelid);

        string MemberValidateAbout_POST_BL (string body, string client_id, string client_secret, int channelid);

        string MemberAddresschange_POST_BL (string body, string client_id, string client_secret, int channelid);

        MemberAddressChangeMHKresponse Member_addressChangeMHK_BL (MemberAddressChangeMHKresponse body, string TenantIdentifier, string client_id, string client_secret, int channelid);

        string MemberDisenrollment_POST_BL (string body, string client_id, string client_secret, int channelid);

        string MemberMemberEnrollmentStatus_GET (string medicareNumber, string client_id, string client_secret, int channelid);

        string MemberMessages_POST_BL (string body, string client_id, string client_secret, int channelid);

        string Member_GetMemberMessages1_BL (Address1 body, string TenantIdentifier, string client_id, string client_secret, int channelid);

        string GetEOB_Get_BL (string MessageId, string TenantIdentifier, string client_id, string client_secret, int channelid);

        string MemberMessagesLookupsByMessageId_DELETE_BL (string MessageId, int channelid);

        string Member_GetMemberMessagesLookup_BL (Address1 body, string client_id, string client_secret, int channelid);

        string Member_GetMemberMessagesLookup1_BL (Address1 body, string client_id, string client_secret, int channelid);

        string Member_GetMemberMessagesLookup2_BL (Address1 body, string client_id, string client_secret, int channelid);

        string Member_GetMemberMessagesLookup3_BL (Address1 body, string client_id, string client_secret, int channelid);

        IEnumerable<MemberPortalDetailsresponse> GetportalDetails_BL (string nameId, string Role, int ChannelId, string client_id, string client_secret, int channelid);

        string MemberUpdateEmail_POST_BL (Address1 body, int ChannelId, string client_id, string client_secret, int channelid);

        string MemberPremiumByNameId_GET_BL (string nameId, string client_id, string client_secret, int channelid);

        MemberSetGoGreenSubscriptionresponse SetGoGreenSubscription_Post_BL (Address1 body, string TenantIdentifier, string client_id, string client_secret, int channelid);

        MemberGogreenstatusresponse gogreenstatus_Get_BL (string nameId, string TenantIdentifier, string client_id, string client_secret, int channelid);

        IEnumerable<EOBResponse> EOB_Get_BL (string altMemberId, string TenantIdentifier, string client_id, string client_secret, int channelid);

        EOBDocumentResponse EOB_GetDocument_BL (string downloadToken, string TenantIdentifier, string client_id, string client_secret, int channelid);

        EOBDocumentResponse EOB_GetDocumentByAltMemberIdMonthYear_BL (string monthYear, string altMemberId, string TenantIdentifier, string client_id, string client_secret, int channelid);

        MemberSSADeductRequestresponse SSADeductRequest_BL (Address1 body, string TenantIdentifier, string client_id, string client_secret, int channelid);

        MemberMergePhoneresponse MemberMergePhone_POST (Address1 body, string client_id, string client_secret, int channelid);

        MemberMergeEmailresponse MemberMergeEmail_POST_BL (Address1 body, string client_id, string client_secret, int channelid);

        MemberSearchresponse Member_Search (Address1 body, string TenantIdentifier, string client_id, string client_secret, int channelid);

    }
}
