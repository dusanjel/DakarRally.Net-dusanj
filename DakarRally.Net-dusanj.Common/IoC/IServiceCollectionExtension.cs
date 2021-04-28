using Microsoft.Extensions.DependencyInjection;

namespace DakarRally.Net_dusanj.Common.IoC
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddCommon(this IServiceCollection services)
        {
            //services.AddTransient<IConcrete, Concrete>();
            return services;
        }
    }
}
