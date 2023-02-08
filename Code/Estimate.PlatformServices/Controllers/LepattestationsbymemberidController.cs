using System;
using System.Collections.Generic;
using Estimate.PlatformServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Estimate.PlatformServices.Controllers
{
    [Route("")]
    [ApiController]
    public class LepattestationsbymemberidController : ControllerBase
    {

      public LepattestationsbymemberidController() {}

      [HttpGet]
      [Route("/lepAttestationsByMemberId/{memberId}")]
      public ActionResult<string> GetLEPAttestationsByMemberID ([FromRoute] string memberId, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

    }
}
