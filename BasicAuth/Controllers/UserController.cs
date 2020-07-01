using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace BasicAuth.Controllers
{
    public class UserController : ApiController
    {
        [BasicAuthentication]
        public IHttpActionResult Get()
        {
            return Ok();
        }
    }
}
