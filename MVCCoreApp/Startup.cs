using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MVCCoreApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            
            app.UseMvc(routes =>
            {
                // Đặt route cho area
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                routes.MapRoute(
                  name: "default",
                template: "{controller=Home}/{action=Index}/{id:int?}");

                // phân biệt route dự trên tham số trên thanh url
                routes.MapRoute(
                    "Default1",
                    "post/{id:regex(^\\d{{4}}$)}",
                    new { controller = "Post", action = "PostById" });

                routes.MapRoute(
                    "Default2",
                    "post/{id:alpha:minlength(6)}",
                    new { controller = "Post", action = "PostByName" });
            });

            
            //app.UseMvcWithDefaultRoute();

            // Rewrite url
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute("secure1", "secure", new 
            //    {
            //        Controller = "Admin", Action = "Index"
            //    });
            //    routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            //});
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });



        }
    }
}
