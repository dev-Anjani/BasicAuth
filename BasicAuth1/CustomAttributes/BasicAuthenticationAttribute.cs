using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace BasicAuth.CustomAttributes
{
    public class BasicAuthenticationAttribute : IAuthorizationFilter
    {
        public BasicAuthenticationAttribute()
        {

        }

        public void OnAuthorization(AuthorizationContext filterContext)
        {

        }
    }
}