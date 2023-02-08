using System;
using System.Collections.Generic;
using Estimate.PlatformServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Estimate.PlatformServices.Controllers
{
    [Route("")]
    [ApiController]
    public class LastloginController : ControllerBase
    {

      public LastloginController() {}

      [HttpGet]
      [Route("/lastLogin/{UserName}")]
      public ActionResult<LastLoginresponse> Username ([FromRoute] string UserName, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

    }
}
