using System;
using System.Collections.Generic;
using Estimate.PlatformServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Estimate.PlatformServices.Controllers
{
    [Route("")]
    [ApiController]
    public class PlanController : ControllerBase
    {

      public PlanController() {}

      [HttpGet]
      [Route("/plan/search")]
      public ActionResult<IEnumerable<Plan>> Plan_Get ([FromQuery] int planYear, [FromQuery] int planId, [FromQuery] string state, [FromQuery] string pbp, [FromQuery] int daysSupply, [FromQuery] int drugTier, [FromQuery] string pharmacyCostType, [FromRoute] string language, [FromQuery] string groupId, [FromQuery] bool isEGWP, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

    }
}
