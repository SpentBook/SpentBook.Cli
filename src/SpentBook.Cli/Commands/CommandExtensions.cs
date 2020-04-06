using System.Collections.Generic;
using Newtonsoft.Json;
using SpentBook.Cli.Commands.Configuration;
using SysCommand.ConsoleApp;
using Microsoft.Extensions.DependencyInjection;

namespace SpentBook.Cli.Commands
{
    public static class CommandExtensions
    {
        public static string ViewFormatted<T>(this Command command, T value, string output)
        {
            if (output == "json")
                return Newtonsoft.Json.JsonConvert.SerializeObject(value, Formatting.Indented);

            return ToTable(command, new List<T>() { value }, output);
        }

        public static string ViewFormatted<T>(this Command command, IEnumerable<T> value, string output)
        {
            if (output == "json")
                return Newtonsoft.Json.JsonConvert.SerializeObject(value, Formatting.Indented);
            
            return ToTable(command, value, output);
        }

        private static string ToTable<T>(Command command, IEnumerable<T> value, string output)
        {
            TableView tableView;
            
            var tableConfig = command.App.Items.GetServiceProvider().GetService<ITableConfig<T>>();
            if (tableConfig == null)
                tableView = TableView.ToTableView(value);
            else
                tableView = TableView.ToTableView(value, tableConfig, output == "wide");

            tableView.AddLineSeparator = false;
            tableView.ColumnSeparator = null;
            
            return tableView.Build().ToString();
        }
    }
}