using System;
using System.Collections.Generic;
using Estimate.PlatformServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Estimate.PlatformServices.Controllers
{
    [Route("")]
    [ApiController]
    public class DisableloginController : ControllerBase
    {

      public DisableloginController() {}

      [HttpPost]
      [Route("/disableLogin")]
      public ActionResult<DisableLoginresponse> AdminDisabledUsersInsert ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

    }
}
