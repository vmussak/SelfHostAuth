using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace TesteAuth
{
    public class Authentication : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var x = actionContext.Request.Headers.Authorization;
            if (x == null || !Validation.IsAuthenticated(x.ToString()))
                actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
        }
        // pre-processing
    }

}
