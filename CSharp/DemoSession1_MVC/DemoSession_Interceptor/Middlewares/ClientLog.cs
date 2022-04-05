using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace DemoSession19_Interceptor.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ClientLog
    {
        private readonly RequestDelegate _next;

        public ClientLog(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            var IP_address = httpContext.Connection.RemoteIpAddress.ToString();

            var url = httpContext.Request.Path;

            //  Lay Info browser
            var browserInfo = httpContext.Request.Headers["User-Agent"].ToString();

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ClientLogExtensions
    {
        public static IApplicationBuilder UseClientLog(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ClientLog>();
        }
    }
}
