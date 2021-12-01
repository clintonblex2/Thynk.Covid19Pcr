using Hangfire;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Thynk.Covid19Pcr.API.Extensions;
using Thynk.Covid19Pcr.Application.Filters;

namespace Thynk.Covid19Pcr.API
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

            services.AddApplicationLayer();
            services.AddContextInfrastructure(Configuration);
            services.AddPersistenceContexts();
            services.AddRepositories();
            services.AddSharedInfrastructure(Configuration);
            services.AddEssentials(Configuration);
            services.AddCrossOriginResource();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Thynk.Covid19Pcr.API v1"));
            }

            app.ConfigureSwagger(Configuration);

            app.UseMiddleware<ExceptionMiddleware>();

            app.UseHangfireDashboard("/hangfire", new DashboardOptions
            {
                Authorization = new[]
            {
                new HangfireDashboardAuthorizationFilter()
            }
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("ApiCorsPolicy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
