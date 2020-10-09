using System.Net.Mime;
using AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PremexCaseManagementApi.DataAccess;
using PremexCaseManagementApi.Mappers;

namespace PremexCaseManagementApi
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
            services
                .AddControllers()
                //.AddXmlDataContractSerializerFormatters()
                .AddXmlSerializerFormatters()
                .AddFluentValidation(fv => 
                    fv.RegisterValidatorsFromAssemblyContaining(typeof(Startup)));
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<ICaseManagementDataAccess, CaseManagementDataAccess>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseExceptionHandler(error =>
            {
                error.Run(async context =>
                {
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    context.Response.ContentType = MediaTypeNames.Text.Plain;
                    await context.Response.WriteAsync("An unhandled Exception occurred.");
                });
            });
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
