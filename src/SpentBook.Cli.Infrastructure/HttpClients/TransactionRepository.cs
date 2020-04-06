using SpentBook.Cli.Domain.Models;
using System.Collections.Generic;
using SpentBook.Cli.Domain.Repository;

namespace SpentBook.Cli.Infrastructure.HttpClients
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly ITransactionApi transactionApi;

        public TransactionRepository(ITransactionApi transactionApi)
        {
            this.transactionApi = transactionApi;
        }

        public IEnumerable<Transaction> GetTransactions()
        {            
            return transactionApi.GetTransactions().Result;
        }
    }
}