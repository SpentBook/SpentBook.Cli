using System.Diagnostics;
using System.IO;
using SysCommand.ConsoleApp;
using SysCommand.Mapping;
using System;

namespace SpentBook.Cli.Commands
{
    public class CategoryCommand : Command
    {
        public IServiceProvider ServiceProvider => this.App.Items.GetServiceProvider();

        public enum EntityNames
        {
            Category,
            Categories,
            Cat,
        }

        [Action(Name="get")]
        public string Get(
            EntityNames type,
            [Argument(ShortName = 'n', LongName = "name")] string objectNameOrId = null,
            [Argument(ShortName = 'o', LongName = "output")] string outputFormat = null
        )
        {
            // var types = ServiceProvider.GetService<List<ITypeConfiguration>>();
            // var type = types.FirstOrDefault(f => objectType.In(f.Name, f.NamePlural, f.NameShort));

            // var transactionGetUseCase = ServiceProvider.GetService<ITransactionGetUseCase>();
            // var list = transactionGetUseCase.Get().Take(1);
            // return this.ViewFormatted(list, outputFormat);
            return "Category";
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