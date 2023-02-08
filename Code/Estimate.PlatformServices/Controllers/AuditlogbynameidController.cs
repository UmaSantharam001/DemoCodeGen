using System;
using System.Collections.Generic;
using Estimate.PlatformServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Estimate.PlatformServices.Controllers
{
    [Route("")]
    [ApiController]
    public class AuditlogbynameidController : ControllerBase
    {

      public AuditlogbynameidController() {}

      [HttpGet]
      [Route("/auditLogByNameId")]
      public ActionResult<string> AuditLogByNameId_GET ([FromQuery] string NameId, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

    }
}
