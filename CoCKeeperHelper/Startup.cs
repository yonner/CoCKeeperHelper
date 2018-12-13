using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoCKeeperHelper.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CoCKeeperHelper
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // 1 instance of the service
            services.AddSingleton<IGreeter, Greeter>();
            // add transient (create when needed), add scoped (create within http scope)
            services.AddScoped<IActorPositionsData, InMemoryActorPositions>();
 //          services.AddScoped<IActorsData, InMemoryActorData>();
            services.AddSingleton<IActorsData, InMemoryActorData>();
            // register mvc service
            services.AddMvc();
        }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, 
            IGreeter greeter, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
               app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler();
            }

            //// use any default files if available
            //app.UseDefaultFiles();
            //// allows pages to be served
            app.UseStaticFiles();
            // does the same as above but with some extra stuff
            //app.UseFileServer();

            app.UseNodeModules(env.ContentRootPath);

            // use mvc
            //           app.UseMvcWithDefaultRoute(); // this automatically gives use the homecontroller
            app.UseMvc(ConfigureRoutes);


            // my own custom middleware which runs when request starts with /mym
            app.Use(next => {
                return async ctx =>
                {
                    logger.LogInformation("Request incoming");
                    if (ctx.Request.Path.StartsWithSegments("/mym"))
                    {
                        await ctx.Response.WriteAsync("!!hit!!");
                        logger.LogInformation("Request handled");
                    }
                    else
                    {
                        await next(ctx);
                        logger.LogInformation("Response outgoing");

                    }
                };
            });

            app.UseWelcomePage(new WelcomePageOptions
            {
                Path ="/wp"
            });

            app.Run(async (context) =>
            {
                var greeting = greeter.GetMessageOfTheDay();

                // mime type
                context.Response.ContentType = "text/plain";
                //await context.Response.WriteAsync($"{greeting}");
                await context.Response.WriteAsync($"Not Found");
            });
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            // /Home/Index
//            routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index}");
            routeBuilder.MapRoute("Default", "{controller=Chase}/{action=Index}");
        }
    }
}
