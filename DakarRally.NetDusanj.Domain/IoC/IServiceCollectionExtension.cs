using DakarRally.NetDusanj.Common.IoC;
using DakarRally.NetDusanj.Domain.Entity;
using DakarRally.NetDusanj.Domain.Interfaces;
using DakarRally.NetDusanj.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DakarRally.NetDusanj.Domain.IoC
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
                (options => options.UseSqlServer(connection, b => b.MigrationsAssembly("DakarRally.NetDusanj")));

            return services;
        }
    }
}
