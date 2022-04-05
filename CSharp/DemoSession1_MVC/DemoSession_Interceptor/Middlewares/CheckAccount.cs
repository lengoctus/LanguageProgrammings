using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace DemoSession19_Interceptor.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CheckAccount
    {
        private readonly RequestDelegate _next;

        public CheckAccount(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            var session = httpContext.Session.GetString("username");

            if (session == null)
            {
                //  Chua co session
            }

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CheckAccountExtensions
    {
        public static IApplicationBuilder UseCheckAccount(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CheckAccount>();
        }
    }
}
