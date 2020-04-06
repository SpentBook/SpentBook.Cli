using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SpentBook.Cli.Infrastructure.Configuration;

namespace SpentBook.Cli.Infrastructure
{
    public static class ConfigurationExtensions
    {
        public static IConfiguration AddConfiguration(this IServiceCollection services)
        {
            var environmentName = Environment.GetEnvironmentVariable("ENVIRONMENT");
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{environmentName}.json", true)
                .AddEnvironmentVariables();

            var config = builder.Build();
            services.AddTransient<IConfiguration>((s) => config);

            return config;
        }
    }
}
