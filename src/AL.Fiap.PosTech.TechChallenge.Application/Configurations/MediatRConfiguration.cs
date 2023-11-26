using AL.Fiap.PosTech.TechChallenge.Application.Middlewares;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AL.Fiap.PosTech.TechChallenge.Application.Configurations
{
    public static class MediatRConfiguration
    {
        public static IServiceCollection AddCustomMediatRConfiguration(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(PerformancePipeline<,>));
            });

            return services;
        }
    }
}