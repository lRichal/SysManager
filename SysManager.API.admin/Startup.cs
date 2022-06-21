using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysManager.API.admin
{
    public class Startup
    {
        public void BeforeConfigureServices(IServiceCollection services)
        {

        }

        public void ConfigureServices(IServiceCollection services)
        {
            BeforeConfigureServices(services);

            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMvc();
        }
    }
}
