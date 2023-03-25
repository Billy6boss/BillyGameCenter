using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BillyGameCenter
{
    public class HeaderActionFilter : Attribute,IActionFilter
    {
        public string RedirectController { get; set; }

        public string RedirectAction { get; set; }
        
        public HeaderActionFilter()
        {
            
        }
        
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Debug.WriteLine("OnActionExecuting");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.HttpContext.Request.Headers.Keys.Contains("x-mobile"))
            {
                context.Result = new RedirectToActionResult(RedirectAction, RedirectController,null);
            }
        }
    }
}