using System;
using System.Collections.Generic;
using Estimate.PlatformServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Estimate.PlatformServices.Controllers
{
    [Route("")]
    [ApiController]
    public class SsadeductbymemberidController : ControllerBase
    {

      public SsadeductbymemberidController() {}

      [HttpGet]
      [Route("/SSADeductByMemberID/{memberId}")]
      public ActionResult<SSADeductByMemberIDresponse> MemberID ([FromRoute] string memberId, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

    }
}
