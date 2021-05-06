using DakarRally.NetDusanj.Common.IoC;
using DakarRally.NetDusanj.Domain.IoC;
using DakarRally.NetDusanj.Service.AutoMapper.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace DakarRally.NetDusanj.Service.IoC
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
