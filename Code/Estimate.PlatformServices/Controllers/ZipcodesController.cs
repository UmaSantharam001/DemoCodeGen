using System;
using System.Collections.Generic;
using Estimate.PlatformServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Estimate.PlatformServices.Controllers
{
    [Route("")]
    [ApiController]
    public class ZipcodesController : ControllerBase
    {

      public ZipcodesController() {}

      [HttpGet]
      [Route("/ZipCodes/Search")]
      public ActionResult<IEnumerable<ZipCode>> ZipCode_Search ([FromQuery] string zipCode, [FromQuery] string state, [FromQuery] int take, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpGet]
      [Route("/ZipCodes/Validate")]
      public ActionResult<bool> GetZipCode_Validate ([FromQuery] string zipCode, [FromQuery] string state, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

    }
}
