using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace fincheckup.StartupConfigurations;

public class CustomResponseHeaderMiddleware(RequestDelegate next)
{
    public async Task Invoke(HttpContext context)
    {
        //To add Headers AFTER everything you need to do this
        context.Response.OnStarting(state =>
        {
            var httpContext = (HttpContext)state;
            httpContext.Response.Headers.Add("Strict-Transport-Security", "max-age=31536000");
            httpContext.Response.Headers.Add("X-Content-Type-Options", "nosniff");
            httpContext.Response.Headers.Add("X-Xss-Protection", "1; mode=block");
            httpContext.Response.Headers.Add("X-Frame-Options", "SAMEORIGIN");
            //... and so on
            return Task.CompletedTask;
        }, context);

        await next(context);
    }
}  // Type or member is obsolete