using System;
using System.Collections.Generic;
using Estimate.PlatformServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Estimate.PlatformServices.Controllers
{
    [Route("")]
    [ApiController]
    public class AddresschangerequestController : ControllerBase
    {

      public AddresschangerequestController() {}

      [HttpPost]
      [Route("/AddressChangeRequest")]
      public ActionResult<Response_Boolean_> AddressChangeRequestUpdate ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpGet]
      [Route("/AddressChangeRequest/{addressChangeID}")]
      public ActionResult<string> AddressChangeRequestbyId ([FromRoute] double addressChangeID, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpGet]
      [Route("/AddressChangeRequest/MemberID/{ID}")]
      public ActionResult<string> AddressChangeRequestMemberIDByID_GET ([FromRoute] int ID, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

    }
}
