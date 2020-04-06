using SpentBook.Cli.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpentBook.Cli.Domain.Repository
{
    public interface ITransactionRepository
    {
        IEnumerable<Transaction> GetTransactions();
    }
}