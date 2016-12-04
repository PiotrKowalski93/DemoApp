using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using DemoDataModel.Models;
using DemoWebAPI.Services;

namespace DemoWebAPI.Controllers
{
    [Route("api/login")]
    public class LoginController : ApiController
    {
        private IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IHttpActionResult TestMethod()
        {
            return Ok();
        }

        [HttpPost]
        public HttpResponseMessage AuthorizeUser([FromBody] UserToAuthorize user)
        {
            HttpResponseMessage response;
            bool isAuthorized = _userService.CheckIfUserIsAuthorized(user);

            if(isAuthorized)
            {
                response = Request.CreateResponse(HttpStatusCode.OK, "value");
                response.Content = new StringContent("Authorized", Encoding.Unicode);
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.Forbidden, "value");
                response.Content = new StringContent("Not Authorized", Encoding.Unicode);
            }

            return response;      
        }
    }
}
