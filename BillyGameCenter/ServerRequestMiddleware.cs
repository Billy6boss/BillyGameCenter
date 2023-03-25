namespace BillyGameCenter
{
    public class ServerRequestMiddleware
    {
        /// <summary>
        /// RequestDelegate
        /// </summary>
        private readonly RequestDelegate _next;

        /// <summary>
        /// Initialization 
        /// </summary>
        /// <param name="next"></param>
        public ServerRequestMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        /// <summary>
        /// Invoke
        /// </summary>
        /// <param name="httpContext"></param>
        public async Task Invoke(HttpContext httpContext)
        {
            await httpContext.Response.WriteAsync($"Request：{httpContext.Request} \n");
            await _next(httpContext);
            await httpContext.Response.WriteAsync($"Response：{httpContext.Response} \n");
        }
    }
}