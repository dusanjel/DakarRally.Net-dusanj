using DakarRally.Net_dusanj.Common.IoC;
using DakarRally.Net_dusanj.Domain.IoC;
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
            return services;
        }
    }
}
