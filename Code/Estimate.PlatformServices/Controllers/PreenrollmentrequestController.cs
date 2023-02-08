using System;
using System.Collections.Generic;
using Estimate.PlatformServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Estimate.PlatformServices.Controllers
{
    [Route("")]
    [ApiController]
    public class PreenrollmentrequestController : ControllerBase
    {

      public PreenrollmentrequestController() {}

      [HttpPost]
      [Route("/PreEnrollmentRequest")]
      public ActionResult<Response_PreEnrollment_> PreEnrollment_Post ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

    }
}
