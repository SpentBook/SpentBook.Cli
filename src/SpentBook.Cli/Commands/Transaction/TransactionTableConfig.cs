using System.Collections.Generic;
using SpentBook.Cli.Commands.Configuration;
using SpentBook.Cli.Domain.Models;

namespace SpentBook.Cli.Commands
{
    public class TransactionTableConfig : ITableConfig<Transaction>
    {
        public IEnumerable<TableColumn<Transaction>> GetTableColumns()
        {
            yield return new TableColumn<Transaction>
            {
                Name = "Id",
                Property = typeof(Transaction).GetProperty(nameof(Transaction.Id)),
                ValueFormatter = (t) => t.Id.ToShortString(),
            };

            yield return new TableColumn<Transaction>
            {
                Name = "Data",
                Property = typeof(Transaction).GetProperty(nameof(Transaction.Date)),
                ValueFormatter = (t) => t.Date.ToShortDate()
            };

            yield return new TableColumn<Transaction>
            {
                Name = "Banco",
                Property = typeof(Transaction).GetProperty(nameof(Transaction.BankId)),
                ValueFormatter = (t) => t.BankId
            };

            yield return new TableColumn<Transaction>
            {
                Name = "Agência",
                Property = typeof(Transaction).GetProperty(nameof(Transaction.AccountAgency)),
                ValueFormatter = (t) => t.AccountAgency,
                OnlyInWide = true
            };

            yield return new TableColumn<Transaction>
            {
                Name = "Conta",
                Property = typeof(Transaction).GetProperty(nameof(Transaction.AccountId)),
                ValueFormatter = (t) => t.AccountId,
                OnlyInWide = true
            };

            yield return new TableColumn<Transaction>
            {
                Name = "Compra",
                Property = typeof(Transaction).GetProperty(nameof(Transaction.Name)),
                ValueFormatter = (t) => t.Name
            };           

            yield return new TableColumn<Transaction>
            {
                Name = "Valor",
                Property = typeof(Transaction).GetProperty(nameof(Transaction.Value)),
                ValueFormatter = (t) => t.Value.ToCurrency()
            };

            yield return new TableColumn<Transaction>
            {
                Name = "Categoria",
                Property = typeof(Transaction).GetProperty(nameof(Transaction.Category)),
                ValueFormatter = (t) => t.Category + (t.SubCategory == null ? "" : $"/{t.SubCategory}"),
            };
        }
    }
}