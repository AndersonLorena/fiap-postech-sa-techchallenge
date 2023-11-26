using AL.Fiap.PosTech.TechChallenge.Adapters.EntityFramework.DbContexts;
using AL.Fiap.PosTech.TechChallenge.Adapters.EntityFramework.Queries;
using AL.Fiap.PosTech.TechChallenge.Adapters.EntityFramework.Repositories;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.EntityFramework.Configurations
{
    public static class SqlServerPersistenceConfiguration
    {
        public static IServiceCollection AddCustomSqlServerPersistenceConfiguration(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TechChallengeDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    builder => builder.MigrationsAssembly(typeof(TechChallengeDbContext).Assembly.FullName)));

            services.AddScoped(typeof(IPersistenceRepository<>), typeof(PersistenceRepository<>));
            services.AddScoped(typeof(IQueryRepository<>), typeof(QueryRepository<>));

            return services;
        }
    }
}