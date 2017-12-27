using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Letsworkout.Api.Infrastructure;
using Letsworkout.Api.Infrastructure.Mapping;
using Letsworkout.Api.Infrastructure.Model;
using Letsworkout.Api.Infrastructure.Repository;
using Letsworkout.Api.Infrastructure.Repository.Implementation;
using Letsworkout.Api.Infrastructure.Services;
using Letsworkout.Api.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace Letsworkout.Api
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
            services.AddMvc();

            var connection = @"Server=localhost;Database=letsworkout;User Id=SA;Password=ERfdsx!1544758;";
            services.AddDbContext<LetsWorkoutContext>(options => options.UseSqlServer(connection));

            AutomapperSetup.Config();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            // Repositories
            services.AddTransient<IUserRepository, UserRepository>();

            // Services
            services.AddTransient<IUserService, UserService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseMvc();
        }
    }
}
