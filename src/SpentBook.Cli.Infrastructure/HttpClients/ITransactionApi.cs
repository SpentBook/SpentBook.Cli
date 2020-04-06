using System.Threading.Tasks;
using SpentBook.Cli.Domain.Models;
using Refit;
using System.Collections.Generic;

namespace SpentBook.Cli.Infrastructure.HttpClients
{
    public interface ITransactionApi
    {
        [Get("/transaction")]
        Task<IEnumerable<Transaction>> GetTransactions();
    }
}