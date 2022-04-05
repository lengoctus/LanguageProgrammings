using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace DemoSession19_Interceptor.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class DateLog
    {
        private readonly RequestDelegate _next;

        public DateLog(RequestDelegate next)
        {
            _next = next;
        }

        /// <summary>
        /// Sau return se tra ve controller hoac middleware 
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public Task Invoke(HttpContext httpContext)
        {
            var date_time = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class DateLogExtensions
    {
        public static IApplicationBuilder UseDateLog(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<DateLog>();
        }
    }
}
