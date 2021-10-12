using Kafka.MassTransit.Application.UseCases.PostMessage;
using Microsoft.Extensions.DependencyInjection;

namespace Kafka.MassTransit.Application.Commons.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IPostMessageUseCase, PostMessageUseCase>();
            return services;
        }
    }
}