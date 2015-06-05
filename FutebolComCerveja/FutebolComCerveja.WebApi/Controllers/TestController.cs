using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FutebolComCerveja.WebApi.Controllers
{
    [RoutePrefix("api/Test")]
    public class TestController : ApiController
    {
        [Route]
        public IHttpActionResult Get()
        {
            return Ok("Well Bixa");
        }
    }
}
