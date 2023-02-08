using System;
using System.Collections.Generic;
using Estimate.PlatformServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Estimate.PlatformServices.Controllers
{
    [Route("")]
    [ApiController]
    public class LepattestationsController : ControllerBase
    {

      public LepattestationsController() {}

      [HttpGet]
      [Route("/lepAttestations")]
      public ActionResult<LepAttestationsresponse> LEPAttestationsGet ([FromQuery] bool complete, [FromQuery] bool assigned, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

    }
}
