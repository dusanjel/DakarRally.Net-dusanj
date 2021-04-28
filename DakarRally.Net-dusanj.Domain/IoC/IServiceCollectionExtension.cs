using DakarRally.Net_dusanj.Common.IoC;
using DakarRally.Net_dusanj.Domain.Entity;
using DakarRally.Net_dusanj.Domain.Interfaces;
using DakarRally.Net_dusanj.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DakarRally.Net_dusanj.Domain.IoC
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            //services.AddTransient<IGetMeRepo, GetMe>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient<DakarRallyDBContext, DakarRallyDBContext>();

            services.AddCommon();

            var connection = @"Server=(localdb)\mssqllocaldb;Database=DakarRally;Integrated Security=True";

            services.AddDbContext<DakarRallyDBContext>
                (options => options.UseSqlServer(connection, b => b.MigrationsAssembly("DakarRally.Net-dusanj")));

            return services;
        }
    }
}
