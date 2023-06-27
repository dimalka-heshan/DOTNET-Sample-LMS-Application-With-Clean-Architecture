using Microsoft.Extensions.DependencyInjection;
using FluentValidation;

namespace LMS.Application
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = typeof(DependancyInjection).Assembly;

            services.AddMediatR(configuration => configuration.RegisterServicesFromAssemblies(assembly));

            services.AddValidatorsFromAssembly(assembly);

            return services;
        }
    }
}
