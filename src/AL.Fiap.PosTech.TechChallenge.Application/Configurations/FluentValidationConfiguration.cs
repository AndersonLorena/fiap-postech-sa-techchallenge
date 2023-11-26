using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AL.Fiap.PosTech.TechChallenge.Application.Configurations
{
    public static class FluentValidationConfiguration
    {
        public static IServiceCollection AddCustomFluentValidationConfiguration(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();

            return services;
        }
    }
}