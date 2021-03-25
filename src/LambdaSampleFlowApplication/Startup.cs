﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Repos;

namespace LambdaSampleFlowApplication
{
    public class Startup
    {
        private readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public static IConfiguration Configuration { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ISampleRepository, StubSampleRepository>();
            services.AddScoped<ISecurityDepRepository, StubSecurityDepRepository>();
            services.AddScoped<ISourceDepRepository, StubSourceDepRepository>();
            services.AddControllers();
            services.AddCors(c => 
                            {
                                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
                            });

            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(options => options.AllowAnyOrigin());
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers()
                         .RequireCors(MyAllowSpecificOrigins);
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Welcome to running ASP.NET Core on AWS Lambda");
                });
            });
            
        }
    }
}
