using System;
using System.Collections.Generic;
using System.Text;
using Estimate.BusinessEntities;
using Estimate.BusinessServices.Interfaces;
using Estimate.ServiceGateway;
using Estimate.Data.Repositories.Interfaces;

namespace Estimate.BusinessServices
{
    public class MemberService : IMemberService
    {

      private BaseGateway _gateway;
        private ICorrespondenceloggetbynameidRepository _correspondenceloggetbynameidRepository;

      public MemberService(BaseGateway gateway, ICorrespondenceloggetbynameidRepository correspondenceloggetbynameidRepository) {
            _gateway = gateway;
            _correspondenceloggetbynameidRepository = correspondenceloggetbynameidRepository;
        }

        public Memberresponse Member_GET_BL(string client_id, string client_secret, int channelid){
          return null;
        }

        public Memberresponse1 Member_POST_BL(Address1 body, string adminRequest, string client_id, string client_secret, int channelid){
          return null;
        }

        public Memberresponse2 Member_PUT_BL(Memberresponse body, string client_id, string client_secret, int channelid){
          return null;
        }

        public MemberPbpChangeresponse pbpChange_BL(MemberPbpChangeresponse body, string TenantIdentifier, string client_id, string client_secret, int channelid){
		    // gateway.Get("https://envisionprodws.mpwebapp.com/app/pbp"); 
        // gateway.Get("https://envisionprodws.mpwebapp.com/members/{nameId}/summary"); 
        // gateway.Get("https://envisionprodws.mpwebapp.com/members/{nameId}/merge_contact"); 
          return null;
        }

        public IEnumerable<Letter> Member_GetMemberById_BL(string nameId, int channelid){
          var data = _gateway.GetData<ApiResponse, ApiResponse>($"https://mockapirg.azurewebsites.net/members/1");
          var letterId = data.data.letters[0].toDoId;
          var result = _correspondenceloggetbynameidRepository.CorrespondenceLogGetByNameIdByNameId_GET_Data(nameId, "", "", 0);
          return result;
        }

        public MemberNotesresponse Member_GetnotesByNameId_BL(string nameId, string TenantIdentifier, string client_id, string client_secret, int channelid){
          return null;
        }

        public MemberPaymentInsertpaymentlogresponse insertpaymentlog_BL(Address1 body, string TenantIdentifier, string client_id, string client_secret, int channelid){
          return null;
        }

        public IEnumerable<MemberPaymentresponse> Member_ByNameId_BL(string nameId, string TenantIdentifier, string client_id, string client_secret, int channelid){
          return null;
        }

        public MemberByNameIDresponse Member_ByNameId1_BL(string nameId, string TenantIdentifier, string client_id, string client_secret, int channelid){
          return null;
        }

        public MemberNameIdresponse Member_GetnameId_BL(string nameId, string client_id, string client_secret, int channelid){
          return null;
        }

        public Memberresponse MemberByNameId_GET_BL(string nameId, string client_id, string client_secret, int channelid){
          return null;
        }

        public MemberBillingresponse MemberBillingByNameId_GET_BL(string nameId, string client_id, string client_secret, int channelid){
          return null;
        }

        public object GetMember_GetMemberById_BL(string altMemberId, string TenantIdentifier, string client_id, string client_secret, int channelid){
          return null;
        }

        public MemberPaymentLastvalidpaymentresponse lastvalidpayment_GetMemberById_BL(string altMemberId, string TenantIdentifier, string client_id, string client_secret, int channelid){
          return null;
        }

        public string MemberPharmacy_POST_BL(string body, string client_id, string client_secret, int channelid){
          return null;
        }

        public string MemberPharmacyByMemberPharmacyId_DELETE_BL(string memberPharmacyId, string client_id, string client_secret, int channelid){
          return null;
        }

        public MemberBillingresponse1 MemberBillingByNameId_GET1_BL(string nameId, string client_id, string client_secret, int channelid){
          return null;
        }

        public string MemberBillingVisitedByNameIdAndAltNameId_GET_BL(string nameId, string altNameId, string client_id, string client_secret, int channelid){
          return null;
        }

        public string MemberPortaluser_POST_BL(string body, string client_id, string client_secret, int channelid){
          return null;
        }

        public MemberPortaluserresponse1 MemberPortaluser_PUT_BL(Address1 body, string client_id, string client_secret, int channelid){
          return null;
        }

        public string MemberValidateAbout_POST_BL(string body, string client_id, string client_secret, int channelid){
          return null;
        }

        public string MemberAddresschange_POST_BL(string body, string client_id, string client_secret, int channelid){
          return null;
        }

        public MemberAddressChangeMHKresponse Member_addressChangeMHK_BL(MemberAddressChangeMHKresponse body, string TenantIdentifier, string client_id, string client_secret, int channelid){
          return null;
        }

        public string MemberDisenrollment_POST_BL(string body, string client_id, string client_secret, int channelid){
          return null;
        }

        public string MemberMemberEnrollmentStatus_GET(string medicareNumber, string client_id, string client_secret, int channelid){
          return null;
        }

        public string MemberMessages_POST_BL(string body, string client_id, string client_secret, int channelid){
          return null;
        }

        public string Member_GetMemberMessages1_BL(Address1 body, string TenantIdentifier, string client_id, string client_secret, int channelid){
          return null;
        }

        public string GetEOB_Get_BL(string MessageId, string TenantIdentifier, string client_id, string client_secret, int channelid){
          return null;
        }

        public string MemberMessagesLookupsByMessageId_DELETE_BL(string MessageId, int channelid){
          return null;
        }

        public string Member_GetMemberMessagesLookup_BL(Address1 body, string client_id, string client_secret, int channelid){
          return null;
        }

        public string Member_GetMemberMessagesLookup1_BL(Address1 body, string client_id, string client_secret, int channelid){
          return null;
        }

        public string Member_GetMemberMessagesLookup2_BL(Address1 body, string client_id, string client_secret, int channelid){
          return null;
        }

        public string Member_GetMemberMessagesLookup3_BL(Address1 body, string client_id, string client_secret, int channelid){
          return null;
        }

        public IEnumerable<MemberPortalDetailsresponse> GetportalDetails_BL(string nameId, string Role, int ChannelId, string client_id, string client_secret, int channelid){
          return null;
        }

        public string MemberUpdateEmail_POST_BL(Address1 body, int ChannelId, string client_id, string client_secret, int channelid){
          return null;
        }

        public string MemberPremiumByNameId_GET_BL(string nameId, string client_id, string client_secret, int channelid){
          return null;
        }

        public MemberSetGoGreenSubscriptionresponse SetGoGreenSubscription_Post_BL(Address1 body, string TenantIdentifier, string client_id, string client_secret, int channelid){
          return null;
        }

        public MemberGogreenstatusresponse gogreenstatus_Get_BL(string nameId, string TenantIdentifier, string client_id, string client_secret, int channelid){
          return null;
        }

        public IEnumerable<EOBResponse> EOB_Get_BL(string altMemberId, string TenantIdentifier, string client_id, string client_secret, int channelid){
          return null;
        }

        public EOBDocumentResponse EOB_GetDocument_BL(string downloadToken, string TenantIdentifier, string client_id, string client_secret, int channelid){
          return null;
        }

        public EOBDocumentResponse EOB_GetDocumentByAltMemberIdMonthYear_BL(string monthYear, string altMemberId, string TenantIdentifier, string client_id, string client_secret, int channelid){
          return null;
        }

        public MemberSSADeductRequestresponse SSADeductRequest_BL(Address1 body, string TenantIdentifier, string client_id, string client_secret, int channelid){
          return null;
        }

        public MemberMergePhoneresponse MemberMergePhone_POST(Address1 body, string client_id, string client_secret, int channelid){
          return null;
        }

        public MemberMergeEmailresponse MemberMergeEmail_POST_BL(Address1 body, string client_id, string client_secret, int channelid){
          return null;
        }

        public MemberSearchresponse Member_Search(Address1 body, string TenantIdentifier, string client_id, string client_secret, int channelid){
          return null;
        }


    }
}
