//=================================================
// Copyright (c) Coalition of Good-Hearted Engineers 
// Free To Use Comfort and Pease
//==================================================

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Rummage.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration) =>
            Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var apiInfo = new OpenApiInfo
            {
                Title = "Rummage.Api",
                Version = "v1"
            };

            services.AddControllers();

            services.AddSwaggerGen(operations =>
            {
                operations.SwaggerDoc(
                    name:"v1",
                   info: apiInfo);
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment enveriment)
        {
            if (enveriment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();

                app.UseSwaggerUI(operations =>
                {
                    operations.SwaggerEndpoint(
                        url: "/swagger/v1/swagger.json",
                        name: "Rummage.Api v1");
                });
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
                endpoints.MapControllers());

        }
    }
}
