using DakarRally.Net_dusanj.Common.IoC;
using DakarRally.Net_dusanj.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DakarRally.Net_dusanj.Domain.IoC
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            //services.AddTransient<IGetMeRepo, GetMe>();
            services.AddCommon();

            var connection = @"Server=(localdb)\mssqllocaldb;Database=DakarRally;Integrated Security=True";

            services.AddDbContext<DakarRallyDBContext>
                (options => options.UseSqlServer(connection));

            return services;
        }
    }
}
