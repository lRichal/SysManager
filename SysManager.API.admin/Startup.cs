using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SysManager.Application.Data.MySql;
using SysManager.Application.Data.MySql.Repositories;
using SysManager.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysManager.API.admin
{
    public class Startup
    {
        public IConfiguration Configuration
        {
            get; set;
        }
        public void BeforeConfigureServices(IServiceCollection services)
        {

        }

        public void ConfigureServices(IServiceCollection services)
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            BeforeConfigureServices(services);
            services.AddApiVersioning();
            services.AddScoped<UserService>();
            services.AddScoped<UserRepository>();
            services.AddScoped<MySqlContext>();
            services.Configure<AppConnectionSettings>(option => Configuration.GetSection("ConnectionStrings").Bind(option));

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
