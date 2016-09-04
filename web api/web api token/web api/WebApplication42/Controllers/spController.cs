using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication42.Controllers
{
    [Authorize]
    public class spController : ApiController
    {
        [HttpGet]
        public IHttpActionResult TestAuthorize()
        {
            return Ok("saurabh pratap singh");
        }
    }
}
