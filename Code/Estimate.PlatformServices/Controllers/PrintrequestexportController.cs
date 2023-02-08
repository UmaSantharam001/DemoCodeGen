using System;
using System.Collections.Generic;
using Estimate.PlatformServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Estimate.PlatformServices.Controllers
{
    [Route("")]
    [ApiController]
    public class PrintrequestexportController : ControllerBase
    {

      public PrintrequestexportController() {}

      [HttpGet]
      [Route("/PrintRequestExport")]
      public ActionResult<PrintRequestExportresponse> PrintRequestExport ([FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

    }
}
