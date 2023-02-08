using System;
using System.Collections.Generic;
using Estimate.PlatformServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Estimate.PlatformServices.Controllers
{
    [Route("")]
    [ApiController]
    public class SsadeductexportController : ControllerBase
    {

      public SsadeductexportController() {}

      [HttpGet]
      [Route("/SSADeductExport/{UserName}")]
      public ActionResult<SSADeductExportresponse> UserName ([FromRoute] string UserName, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

    }
}
