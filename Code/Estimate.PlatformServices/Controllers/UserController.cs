using System;
using System.Collections.Generic;
using Estimate.PlatformServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Estimate.PlatformServices.Controllers
{
    [Route("")]
    [ApiController]
    public class UserController : ControllerBase
    {

      public UserController() {}

      [HttpPut]
      [Route("/user")]
      public ActionResult<object> PortalUser_Put ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpPost]
      [Route("/user")]
      public ActionResult<object> PortalUser_Post ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpGet]
      [Route("/user/getuser")]
      public ActionResult<PortalUser> PortalUser_GetUserInfo ([FromQuery] string userName, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpGet]
      [Route("/user/get")]
      public ActionResult<PortalUser> PortalUser_GetUser ([FromQuery] long userId, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpGet]
      [Route("/user/{UserName}")]
      public ActionResult<PortalUser> PortalUser_GetUserInfo1 ([FromRoute] string UserName, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpPost]
      [Route("/user/login")]
      public ActionResult<UserLoginresponse> PortalUser_PortalUserLogin ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpPost]
      [Route("/user/ResetPassword")]
      public ActionResult<object> PortalUser_ResetPassword ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpPost]
      [Route("/user/SendPasswordResetMail")]
      public ActionResult<string> PortalUser_SendPasswordResetMail ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        //  
        return Ok();
      }

      [HttpPost]
      [Route("/user/PortalUserForgetUserName")]
      public ActionResult<object> PortalUser_PortalUserForgotUserName ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpPost]
      [Route("/user/Temp")]
      public ActionResult<object> PortalUser_PostTemp ([FromBody] Address body, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpGet]
      [Route("/user/Validate")]
      public ActionResult<bool> ZipCode_Validate ([FromQuery] string zipCode, [FromQuery] string state, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpGet]
      [Route("/user/ValidateDob")]
      public ActionResult<object> PortalUser_ValidateDob ([FromQuery] string userName, [FromQuery] DateTime dob, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

      [HttpGet]
      [Route("/user/{UserName}/{DOB}")]
      public ActionResult<object> PortalUser_ValidateDob1 ([FromRoute] string UserName, [FromRoute] DateTime DOB, [FromHeader] string TenantIdentifier, [FromHeader] string client_id, [FromHeader] string client_secret, [FromHeader] int channelid)
      {
        return Ok();
      }

    }
}
