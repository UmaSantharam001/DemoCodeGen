using System;
using System.Collections.Generic;
using Estimate.PlatformServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Estimate.PlatformServices.Controllers
{
    [Route("")]
    [ApiController]
    public class PrintrequesttypesController : ControllerBase
    {

      public PrintrequesttypesController() {}

      [HttpGet]
      [Route("/PrintRequestTypes/{Who}")]
      public ActionResult<PrintRequestTypesresponse> PrintRequestTypesWho ([FromRoute] string Who, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

    }
}
