using SysCommand.ConsoleApp;
using SysCommand.Mapping;
using System;
using Microsoft.Extensions.DependencyInjection;
using SpentBook.Cli.Application.UseCases;
using System.Linq;

namespace SpentBook.Cli.Commands
{
    public class TransactionCommand : Command
    {
        public IServiceProvider ServiceProvider => this.App.Items.GetServiceProvider();

        public enum EntityNames
        {
            Transaction,
            Transactions,
            Trans,
        }

        [Action(Name="get")]
        public string Get(
            EntityNames type,
            [Argument(ShortName = 'n', LongName = "name")] string objectNameOrId = null,
            [Argument(ShortName = 'o', LongName = "output")] string outputFormat = null
        )
        {
            var transactionGetUseCase = ServiceProvider.GetService<ITransactionGetUseCase>();
            var list = transactionGetUseCase.Get().Take(10);
            return this.ViewFormatted(list, outputFormat);
        }

        // public string Create(
        //     [Argument(ShortName = 'f', LongName = "filename")] string filename
        // )
        // {
        //     var content = File.ReadAllText(filename);
        //     return content;
        // }

        // public string Edit(
        //     [Argument(ShortName = 'o', LongName = "object")] string objectType,
        //     [Argument(ShortName = 'n', LongName = "name")] string objectNameOrId
        // )
        // {
        //     return $"{objectType} {objectNameOrId}";
        // }

        // public string Edit(
        //     [Argument(ShortName = 'f', LongName = "filename")] string filename
        // )
        // {
        //     Process.Start("vim", filename).WaitForExit();
        //     var content = File.ReadAllText(filename);
        //     return content;
        // }
    }
}