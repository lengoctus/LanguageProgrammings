using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DemoSession26_MultiLoginPage.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DemoSession26_MultiLoginPage
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<Db25Context>(options => options.UseLazyLoadingProxies().UseSqlServer(Configuration.GetConnectionString("ConnectStr")));

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = "Schema_Customer";
            })
             .AddCookie("Schema_Admin", options =>
             {
                 options.LoginPath = "/Admin";
                 options.LogoutPath = "/Admin/Account/LogOut";
                 options.AccessDeniedPath = "/Admin/Account/AccessDenied";
             })
             .AddCookie("Schema_Customer", options =>
             {
                 options.LoginPath = "/Customer";
                 options.LogoutPath = "/Customer/Account/LogOut";
                 options.AccessDeniedPath = "/Customer/Account/AccessDenied";
             })
             .AddCookie("Vendor_Schema", options =>
             {
                 options.LoginPath = "/Vendor";
                 options.LogoutPath = "/Vendor/Account/LogOut";
                 options.AccessDeniedPath = "/Vendor/Account/AccessDenied";
             });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
                    
            app.UseRouting();

            app.Use(async (context, next) =>
            {
                var principal = new ClaimsPrincipal();

                var result1 = await context.AuthenticateAsync("Schema_Admin");
                if (result1?.Principal != null)
                {
                    // Lay thong tin acc save vao Claim
                    principal.AddIdentities(result1.Principal.Identities);

                }

                var result2 = await context.AuthenticateAsync("Schema_Customer");
                if (result2?.Principal != null)
                {
                    // Lay thong tin acc save vao Claim
                    principal.AddIdentities(result2.Principal.Identities);

                }

                var result3 = await context.AuthenticateAsync("Vendor_Schema");
                if (result3?.Principal != null)
                {
                    // Lay thong tin acc save vao Claim
                    principal.AddIdentities(result3.Principal.Identities);

                }

                context.User = principal;
                await next();
            });

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                //Area Admin
                endpoints.MapAreaControllerRoute(
                    name: "Admins",
                    areaName: "Admin",
                     pattern: "Admin/{controller=Account}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                 name: "Admins",
                 areaName: "Admin",
                  pattern: "Admin/{controller=Employee}/{action=Index}/{id?}");


                //Areas Customer

                endpoints.MapAreaControllerRoute(
                    name: "Customer",
                    areaName: "Customer",
                     pattern: "Customer/{controller=Account}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                    name: "Customer",
                    areaName: "Customer",
                     pattern: "Customer/{controller=Invoice}/{action=Index}/{id?}");

                //Areas Vendor
                endpoints.MapAreaControllerRoute(
                    name: "Vendor",
                    areaName: "Vendor",
                     pattern: "Vendor/{controller=Account}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                   name: "Vendor",
                   areaName: "Vendor",
                    pattern: "Vendor/{controller=Product}/{action=Index}/{id?}");
            });
        }
    }
}
