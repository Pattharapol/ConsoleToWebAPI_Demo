using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleToWebAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<CustomMiddleware1>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Hello from RUN()");
            //});

            //app.Use(async (context, next) =>
            //{
            //    // 1
            //    await context.Response.WriteAsync("Hello from Use1 1 \n");

            //    await next(); // goto middleware
            //    // 7
            //    await context.Response.WriteAsync("Hello from Use1 2 \n");
            //});

            //// 2
            //app.UseMiddleware<CustomMiddleware1>();

            //app.Map("/tik", CustomCode);

            //app.Use(async (context, next) =>
            //{
            //    // 3
            //    await context.Response.WriteAsync("Hello from Use2 1 \n");

            //    await next();
            //    // 5
            //    await context.Response.WriteAsync("Hello from Use2 2 \n");
            //});

            //app.Run(async context =>
            //{
            //    // 4
            //    await context.Response.WriteAsync("Request Completed... \n");
            //});

            //app.Run(async context =>
            //{
            //    // 3
            //    await context.Response.WriteAsync("Hello from RUN() \n");
            //});

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello from New Web API app...");
            //    });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello from New Web API app...");
            //    });

            //    endpoints.MapGet("/test", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello from New Web API app.../test");
            //    });
            //});
        }

        private void CustomCode(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
           {
               await context.Response.WriteAsync("Hello From TIKK...\n");
           });
        }
    }
}