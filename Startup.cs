using DakarRally.Net_dusanj.Interfaces;
using DakarRally.Net_dusanj.Service.Interfaces;
using DakarRally.Net_dusanj.Service.IoC;
using DakarRally.Net_dusanj.Service.Services;
using Hangfire;
using Hangfire.Dashboard;
using Hangfire.MemoryStorage;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace DakarRally.Net_dusanj
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
            services.AddService();
            services.AddTransient<IVehicleRepositoryService, VehicleRepositoryService>();
            services.AddTransient<IRaceRepositoryService, RaceRepositoryService>();
            services.AddTransient<IScheduler, Scheduler>();

            services.AddHangfire(configuration => configuration
                    .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                    .UseSimpleAssemblyNameTypeSerializer()
                    .UseRecommendedSerializerSettings()
                    .UseMemoryStorage()
                );

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DakarRally.Net_dusanj", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IScheduler scheduler)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DakarRally.Net_dusanj v1"));
            }

            app.UseHangfireServer();

            app.UseHangfireDashboard("/hangfire", new DashboardOptions
            {
                IsReadOnlyFunc = (DashboardContext context) => true
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            scheduler.Schedule();
        }
    }
}
