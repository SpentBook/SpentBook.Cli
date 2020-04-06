using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using SpentBook.Cli.Domain.Models;

namespace SpentBook.Cli.Commands.Configuration
{
    public static class EntititesExtensions
    {
        public static IServiceCollection ConfigureEntities(this IServiceCollection service)
        {
            // service.AddSingleton<List<ITypeConfiguration>>(s =>
            // {
            //     return new List<ITypeConfiguration>()
            //     {
            //         new TypeConfiguration<Transaction> 
            //         {
            //             Name = "transaction",
            //             NameShort = "trans",
            //             NamePlural = "transactions",
            //             TableConfig = new TransactionTableConfig()
            //         }
            //     };                
            // });

            // Table configutarion
            service.AddSingleton<ITableConfig<Transaction>>(s => new TransactionTableConfig());

            return service;
        }
}
}