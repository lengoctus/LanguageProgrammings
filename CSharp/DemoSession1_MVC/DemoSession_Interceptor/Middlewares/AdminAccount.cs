using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace DemoSession19_Interceptor.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class AdminAccount
    {
        private readonly RequestDelegate _next;

        public AdminAccount(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            var url = httpContext.Request.Path;

            if (url.HasValue && url.ToString().StartsWith("/admin"))
            {
                if (httpContext.Session.GetString("admin") == null)
                {
                    httpContext.Response.Redirect("Admin/LoginAdmin/Index");
                }
            }

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class AdminAccountExtensions
    {
        public static IApplicationBuilder UseAdminAccount(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AdminAccount>();
        }
    }
}
