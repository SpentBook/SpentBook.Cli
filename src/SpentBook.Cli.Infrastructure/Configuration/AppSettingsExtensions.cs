using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SpentBook.Cli.Infrastructure.Configuration;

namespace SpentBook.Cli.Infrastructure
{
    public static class AppSettingsExtensions
    {
        public static IServiceCollection ConfigureAppSettings(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<AppSettings>(options => configuration.GetSection("AppSettings").Bind(options));
            return services;
        }
    }
}
