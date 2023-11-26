using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AL.Fiap.PosTech.TechChallenge.Application.Configurations
{
    public static class AutoMapperConfiguration
    {
        public static IServiceCollection AddCustomAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}