using System.Collections.Generic;
using SpentBook.Cli.Commands.Configuration;
using SpentBook.Cli.Domain.Models;

namespace SpentBook.Cli.Commands
{
    public class CategoryTableConfig : ITableConfig<Transaction>
    {
        public IEnumerable<TableColumn<Transaction>> GetTableColumns()
        {
            yield return new TableColumn<Transaction>
            {
                Property = typeof(Transaction).GetProperty(nameof(Transaction.Id)),
                ValueFormatter = (t) => t.Id.ToString(),
            };

            yield return new TableColumn<Transaction>
            {
                Property = typeof(Transaction).GetProperty(nameof(Transaction.Date)),
                ValueFormatter = (t) => t.Date.ToString()
            };

            yield return new TableColumn<Transaction>
            {
                Property = typeof(Transaction).GetProperty(nameof(Transaction.BankId)),
                ValueFormatter = (t) => t.BankId
            };

            yield return new TableColumn<Transaction>
            {
                Property = typeof(Transaction).GetProperty(nameof(Transaction.AccountAgency)),
                ValueFormatter = (t) => t.AccountAgency,
                OnlyInWide = true
            };

            yield return new TableColumn<Transaction>
            {
                Property = typeof(Transaction).GetProperty(nameof(Transaction.AccountId)),
                ValueFormatter = (t) => t.AccountId,
                OnlyInWide = true
            };

            yield return new TableColumn<Transaction>
            {
                Property = typeof(Transaction).GetProperty(nameof(Transaction.Name)),
                ValueFormatter = (t) => t.Name
            };           

            yield return new TableColumn<Transaction>
            {
                Property = typeof(Transaction).GetProperty(nameof(Transaction.Value)),
                ValueFormatter = (t) => t.Value.ToString()
            };

            yield return new TableColumn<Transaction>
            {
                Property = typeof(Transaction).GetProperty(nameof(Transaction.Category)),
                ValueFormatter = (t) => t.Category,
                OnlyInWide = true
            };

            yield return new TableColumn<Transaction>
            {
                Property = typeof(Transaction).GetProperty(nameof(Transaction.SubCategory)),
                ValueFormatter = (t) => t.SubCategory,
                OnlyInWide = true
            };
        }
    }
}