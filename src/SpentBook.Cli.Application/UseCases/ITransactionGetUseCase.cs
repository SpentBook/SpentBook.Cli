using System.Collections.Generic;
using System.Threading.Tasks;
using SpentBook.Cli.Domain.Models;

namespace SpentBook.Cli.Application.UseCases
{
    public interface ITransactionGetUseCase
    {
        IEnumerable<Transaction> Get();
    }
}