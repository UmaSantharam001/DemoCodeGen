using System;
using System.Collections.Generic;
using Estimate.PlatformServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Estimate.PlatformServices.Controllers
{
    [Route("")]
    [ApiController]
    public class PrintrequestController : ControllerBase
    {

      public PrintrequestController() {}

      [HttpPost]
      [Route("/PrintRequest")]
      public ActionResult<PrintRequestresponse> PrintRequestInsert ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

    }
}
