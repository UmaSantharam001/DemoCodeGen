using System;
using System.Collections.Generic;
using Estimate.PlatformServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Estimate.PlatformServices.Controllers
{
    [Route("")]
    [ApiController]
    public class LepattestationController : ControllerBase
    {

      public LepattestationController() {}

      [HttpGet]
      [Route("/LEPAttestation/{ID}")]
      public ActionResult<IEnumerable<LEPAttestationresponse1>> LEPAttestationGetByID ([FromRoute] int ID, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpPost]
      [Route("/LEPAttestation")]
      public ActionResult<LepAttestationresponse> LEPAttestationUpdate ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

    }
}
