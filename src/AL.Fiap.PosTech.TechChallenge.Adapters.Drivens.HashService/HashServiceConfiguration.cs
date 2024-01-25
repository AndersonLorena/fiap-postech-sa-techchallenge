using AL.Fiap.PosTech.TechChallenge.Ports.Interfaces.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.Drivens.HashService
{
    public static class HashServiceConfiguration
    {
        public static IServiceCollection AddCustomHashServiceConfiguration(
            this IServiceCollection services)
        {
            services.AddScoped(typeof(IPasswordHasher<>), typeof(PasswordHasher<>));
            services.AddScoped(typeof(IHashService<>), typeof(HashService<>));
            return services;
        }
    }
}