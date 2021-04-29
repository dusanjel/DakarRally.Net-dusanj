using DakarRally.Net_dusanj.Common.IoC;
using DakarRally.Net_dusanj.Domain.IoC;
using DakarRally.Net_dusanj.Service.AutoMapper.Profiles;
using DakarRally.Net_dusanj.Service.Interfaces;
using DakarRally.Net_dusanj.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DakarRally.Net_dusanj.Service.IoC
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            //services.AddTransient<IGetMeRepo, GetMe>();
            services.AddDomain();
            services.AddCommon();
            services.AddAutoMapper(typeof(VehicleProfile));
            return services;
        }
    }
}
