using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ConsoleToWebAPI
{
    public class CustomMiddleware1 : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            // 2
            await context.Response.WriteAsync("Hello from New File 1 \n");

            await next(context);
            // 6
            await context.Response.WriteAsync("Hello from New File 2 \n");
        }
    }
}