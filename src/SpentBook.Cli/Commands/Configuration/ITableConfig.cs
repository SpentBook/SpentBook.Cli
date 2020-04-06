using System.Collections.Generic;

namespace SpentBook.Cli.Commands.Configuration
{
    public interface ITableConfig<T>
    {
        IEnumerable<TableColumn<T>> GetTableColumns();
    }
}