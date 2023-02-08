using System;
using System.Collections.Generic;
using Estimate.PlatformServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Estimate.PlatformServices.Controllers
{
    [Route("")]
    [ApiController]
    public class DataController : ControllerBase
    {

      public DataController() {}

      [HttpGet]
      [Route("/data/codelookup")]
      public ActionResult<IEnumerable<DataCodelookupresponse>> CodeLookup_Get ([FromQuery] string Language, [FromQuery] string TypeCode, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpGet]
      [Route("/data/codelookup/{language}/{typeCode}")]
      public ActionResult<object> CodeLookup_Get1 ([FromRoute] string language, [FromRoute] string typeCode, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpGet]
      [Route("/data/sep")]
      public ActionResult<IEnumerable<SEPReason>> SEPReason_Get ([FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpGet]
      [Route("/data/preenrollmenttype")]
      public ActionResult<IEnumerable<PreEnrollmentType>> PreEnrollmentType_GetAll ([FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

    }
}
