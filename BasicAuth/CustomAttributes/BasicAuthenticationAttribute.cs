using Core.Interfaces;
using Infrastructure;
using System;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
//using System.Web.Mvc.Filters;

namespace BasicAuth
{
    public class BasicAuthenticationAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {

                string authToken = actionContext.Request.Headers.Authorization.Parameter;
                string decodedToken = Encoding.UTF8.GetString(Convert.FromBase64String(authToken));
                string username = decodedToken.Split(':')[0];
                string password = decodedToken.Split(':')[1];
                ILogin login = new LoginRepo();
                if (login.AuthenticateUser(username,password))
                {
                    var identity = new GenericIdentity(username);
                    var principle = new GenericPrincipal(identity, null);
                    Thread.CurrentPrincipal = principle;
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
            }
        }
    }
}