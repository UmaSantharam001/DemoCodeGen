using System;
using System.Collections.Generic;
using Estimate.PlatformServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Estimate.PlatformServices.Controllers
{
    [Route("")]
    [ApiController]
    public class CodelookupController : ControllerBase
    {

      public CodelookupController() {}

      [HttpGet]
      [Route("/CodeLookup/CallScript/{language}")]
      public ActionResult<CodeLookupCallScriptresponse> Language ([FromRoute] string language, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpGet]
      [Route("/CodeLookup/AdminDropDownList/{year}")]
      public ActionResult<CodeLookupAdminDropDownListresponse> Year ([FromRoute] int year, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

    }
}
