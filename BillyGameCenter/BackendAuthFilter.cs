using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BillyGameCenter
{
    public class BackendAuthFilter : Attribute,IAuthorizationFilter
    {
        private readonly IConfiguration _configuration;
        
        public BackendAuthFilter(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public void OnAuthorization(AuthorizationFilterContext context)
        {

            if (_configuration.GetValue<string>("Backend:Auth:UserName") == "Bdmin")
            {
                context.Result = new ViewResult() { ViewName = "403Page" };
            }
        }
    }
}