using System;
using System.Collections.Generic;
using Estimate.PlatformServices.Contracts;
using Microsoft.AspNetCore.Mvc;
using Estimate.BusinessServices.Interfaces;

namespace Estimate.PlatformServices.Controllers
{
    [Route("")]
    [ApiController]
    public class MemberController : ControllerBase
    {
      private IMemberService _memberService;
      public MemberController(IMemberService memberService) {
            _memberService = memberService;
        }

      [HttpGet]
      [Route("/member")]
      public ActionResult<object> Member_GetMemberById ([FromRoute] string memberId, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpPut]
      [Route("/member")]
      public ActionResult<Response_Boolean_> Member_Put ([FromBody] Member body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpPost]
      [Route("/member")]
      public ActionResult<Memberresponse> Member_Post ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpPost]
      [Route("/member/SetGoGreenSubscription")]
      public ActionResult<MemberSetGoGreenSubscriptionresponse> SetGoGreenSubscription_Post ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpGet]
      [Route("/member/gogreenstatus/{nameId}")]
      public ActionResult<MemberGogreenstatusresponse> gogreenstatus_Get ([FromRoute] string nameId, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpGet]
      [Route("/member/eob/{altmemberid}")]
      public ActionResult<IEnumerable<EOBResponse>> EOB_Get ([FromRoute] string altmemberid, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpGet]
      [Route("/member/eob/document")]
      public ActionResult<EOBDocumentResponse> EOB_GetDocument ([FromQuery] string downloadToken, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpGet]
      [Route("/member/eob/document/{altMemberId}/{monthYear}")]
      public ActionResult<EOBDocumentResponse> EOB_GetDocumentByAltMemberIdMonthYear ([FromRoute] string monthYear, [FromRoute] string altMemberId, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpPost]
      [Route("/member/SSADeductRequest")]
      public ActionResult<MemberSSADeductRequestresponse> SSADeductRequest ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpGet]
      [Route("/member/nameId/{nameId}")]
      public ActionResult<MemberNameIdresponse> GetMember_GetMemberById ([FromRoute] string nameId, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpGet]
      [Route("/member/letters/{nameId}")]
      public ActionResult<IEnumerable<Letter>> Member_GetMemberById1 ([FromRoute] string nameId, [FromHeader] int channelid)
      {
            // MemberLettersresponse resp = memberService.Member_GetMemberById_BL(nameId, channelid); 
        var resp = _memberService.Member_GetMemberById_BL(nameId, channelid);
        return Ok(resp);
      }

      [HttpGet]
      [Route("/member/Notes/{nameId}")]
      public ActionResult<MemberNotesresponse> Member_GetnotesByNameId ([FromRoute] string nameId, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        // gateway.Get("https://envisionprodws.mpwebapp.com/members/{nameId}/notes"); 
        return Ok();
      }

      [HttpPost]
      [Route("/member/MergePhone")]
      public ActionResult<MemberMergePhoneresponse> MemberMergePhone_POST ([FromBody] Address body, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpPost]
      [Route("/member/MergeEmail")]
      public ActionResult<MemberMergeEmailresponse> MemberMergeEmail_POST ([FromBody] Address body, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpPost]
      [Route("/member/notes")]
      public ActionResult<MemberNotesresponse1> MemberNotes_POST ([FromBody] Address body, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        // gateway.Get("https://envisionprodws.mpwebapp.com/member/{nameId}/notes"); 
        return Ok();
      }

      [HttpPost]
      [Route("/member/search")]
      public ActionResult<MemberSearchresponse> Member_Search ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpGet]
      [Route("/member/billing/{nameId}")]
      public ActionResult<MemberBillingresponse> Member_nameId ([FromRoute] string nameId, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpGet]
      [Route("/member/{nameId}")]
      public ActionResult<Memberresponse1> nameId ([FromRoute] string nameId, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpPost]
      [Route("/member/payment/insertpaymentlog")]
      public ActionResult<string> insertpaymentlog ([FromBody] Address body, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpGet]
      [Route("/member/payment/lastvalidpayment/{altMemberId}")]
      public ActionResult<MemberPaymentLastvalidpaymentresponse> lastvalidpayment_GetMemberById ([FromRoute] string altMemberId, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        // gateway.Get("http://apieic.envisionrx.internal/api/member/payment/lastvalidpayment/{altMemberId}"); 
        return Ok();
      }

      [HttpGet]
      [Route("/member/ByAltMemberId/{altMemberId}")]
      public ActionResult<object> GetMember_GetMemberById1 ([FromRoute] string altMemberId, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpPost]
      [Route("/member/pharmacy")]
      public ActionResult<object> Member_SaveMemberPharmacy ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpDelete]
      [Route("/member/pharmacy/{memberPharmacyId}")]
      public ActionResult<object> Member_DeleteMemberPharmacy ([FromRoute] int memberPharmacyId, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpGet]
      [Route("/member/pharmacy/visited/{altMemberId}")]
      public ActionResult<IEnumerable<Pharmacy>> Member_GetVisitedPharmaciesLastNDays ([FromRoute] string altMemberId, [FromQuery] int lastNDays, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpPost]
      [Route("/member/portaluser")]
      public ActionResult<MemberPortaluserresponse> Member_Post1 ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpPut]
      [Route("/member/portaluser")]
      public ActionResult<MemberPortaluserresponse1> MemberPortaluser_PUT ([FromBody] Address body, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpPost]
      [Route("/member/validate/about")]
      public ActionResult<object> Member_ValidateMember ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpPost]
      [Route("/member/addresschange")]
      public ActionResult<MemberAddresschangeresponse> Member_UpdateAddress ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpPost]
      [Route("/member/addressChangeMHK")]
      public ActionResult<MemberAddressChangeMHKresponse> Member_addressChangeMHK ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpPost]
      [Route("/member/disenrollment")]
      public ActionResult<Response_Boolean_> Member_Disenroll ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpGet]
      [Route("/member/MemberEnrollmentStatus/{medicareNumber}")]
      public ActionResult<string> Member_GetMemberPlanStatus ([FromRoute] string medicareNumber, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpGet]
      [Route("/member/Premium/{memberId}")]
      public ActionResult<MemberPremiumDetailsResponse> Member_GetMemberPremiumDetails ([FromRoute] string memberId, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpPost]
      [Route("/member/Messages")]
      public ActionResult<IEnumerable<MemberMessage>> Member_GetMemberMessages ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpPut]
      [Route("/member/Messages")]
      public ActionResult<string> Member_GetMemberMessages1 ([FromBody] MemberMessage body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpGet]
      [Route("/member/Messages")]
      public ActionResult<IEnumerable<MemberMessagesresponse>> GetMember_GetMemberMessages ([FromQuery] int ApplicationId, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpGet]
      [Route("/member/Messages/{MessageId}")]
      public ActionResult<string> GetEOB_Get ([FromRoute] string MessageId, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpDelete]
      [Route("/member/Messages/Lookups/{MessageId}")]
      public ActionResult<string> MemberMessagesLookupsByMessageId_DELETE ([FromRoute] string MessageId, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpPost]
      [Route("/member/Messages/LookupByMemberID")]
      public ActionResult<string> Member_GetMemberMessagesLookup ([FromBody] Address body, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpPost]
      [Route("/member/Messages/LookupByPlan")]
      public ActionResult<string> Member_GetMemberMessagesLookup1 ([FromBody] Address body, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpPost]
      [Route("/member/Messages/LookupByState")]
      public ActionResult<string> Member_GetMemberMessagesLookup2 ([FromBody] Address body, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpPost]
      [Route("/member/Messages/LookupByZipCodes")]
      public ActionResult<string> Member_GetMemberMessagesLookup3 ([FromBody] Address body, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpPost]
      [Route("/member/pbpChange")]
      public ActionResult<MemberPbpChangeresponse> pbpChange ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpGet]
      [Route("/member/portalDetails")]
      public ActionResult<IEnumerable<MemberPortalDetailsresponse>> GetportalDetails ([FromRoute] string nameId, [FromQuery] string Role, [FromHeader] int ChannelId, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpPost]
      [Route("/member/updateEmail")]
      public ActionResult<string> MemberUpdateEmail_POST ([FromBody] Address body, [FromHeader] int ChannelId, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

    }
}
