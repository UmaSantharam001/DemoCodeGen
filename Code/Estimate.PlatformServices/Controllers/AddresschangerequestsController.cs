using System;
using System.Collections.Generic;
using Estimate.PlatformServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Estimate.PlatformServices.Controllers
{
    [Route("")]
    [ApiController]
    public class AddresschangerequestsController : ControllerBase
    {

      public AddresschangerequestsController() {}

      [HttpGet]
      [Route("/AddressChangeRequests")]
      public ActionResult<AddressChangeRequestsresponse> AddressChangeRequest ([FromQuery] bool complete, [FromQuery] bool assigned, [FromQuery] string addresstype, [FromQuery] string requeststartdate, [FromQuery] string requestenddate, [FromQuery] bool pbpchange, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

    }
}
