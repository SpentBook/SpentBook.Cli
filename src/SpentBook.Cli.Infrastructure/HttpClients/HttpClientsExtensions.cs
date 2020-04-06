using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Refit;
using SpentBook.Cli.Domain.Repository;
using SpentBook.Cli.Infrastructure.Configuration;
using SpentBook.Cli.Infrastructure.HttpClients;

namespace SpentBook.Cli.Infrastructure
{
    public static class HttpClientsExtensions
    {
        public static IServiceCollection ConfigureHttpClients(this IServiceCollection services)
        {
            // Add Refit apis
            services.AddTransient((s) =>
            {
                var settings = s.GetService<IOptions<AppSettings>>();
                return RestService.For<ITransactionApi>(settings.Value.SpentBookApi);
            });
            
            // Configure repositories
            services.AddTransient<ITransactionRepository, TransactionRepository>();

            return services;
        }
    }
}
