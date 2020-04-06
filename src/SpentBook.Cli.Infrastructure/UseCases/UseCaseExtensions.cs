using Microsoft.Extensions.DependencyInjection;
using SpentBook.Cli.Application.UseCases;

namespace SpentBook.Cli.Infrastructure.UseCases
{
    public static class UseCaseExtensions
    {
        public static IServiceCollection ConfigureUseCases(this IServiceCollection services)
        {
            services.AddTransient<ITransactionGetUseCase, TransactionGetUseCase>();
            return services;
        }
    }
}
