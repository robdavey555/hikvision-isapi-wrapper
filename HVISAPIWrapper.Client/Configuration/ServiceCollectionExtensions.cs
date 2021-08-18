using HVISAPIWrapper.Client.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HVISAPIWrapper.Client.Configuration
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IVideoSettingsService, VideoSettingsService>();


            return services;

        }
    }
}
