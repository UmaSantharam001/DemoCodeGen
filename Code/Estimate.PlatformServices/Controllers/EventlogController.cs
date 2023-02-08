using System;
using System.Collections.Generic;
using Estimate.PlatformServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Estimate.PlatformServices.Controllers
{
    [Route("")]
    [ApiController]
    public class EventlogController : ControllerBase
    {

      public EventlogController() {}

      [HttpPost]
      [Route("/eventlog")]
      public ActionResult<Eventlogresponse> EventLog ([FromBody] Address body, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

    }
}
