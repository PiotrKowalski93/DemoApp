using DemoWebAPI.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace DemoWebAPI.Controllers
{
    [Route("api/signalr")]
    public class RideController : ApiControllerWithHub<RideHub>
    {
    }
}
