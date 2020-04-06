namespace SpentBook.Cli
{
    using System;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using SysCommand.ConsoleApp;
    using SpentBook.Cli.Infrastructure;
    using Refit;
    using SpentBook.Cli.Infrastructure.HttpClients;
    using SpentBook.Cli.Infrastructure.Configuration;
    using SpentBook.Cli.Infrastructure.UseCases;
    using SpentBook.Cli.Commands.Configuration;

    public class Program
    {
        public static int Main(string[] args)
        {
            return App.RunApplication(() =>
            {                
                var services = new ServiceCollection();
                var config = services.AddConfiguration();

                services.ConfigureAppSettings(config)
                        .ConfigureHttpClients()
                        .ConfigureUseCases()
                        .ConfigureEntities();

                var app = new App();
                app.Items.SetServiceProvider(services.BuildServiceProvider());
                return app;
            });
        }
    }

    // Classes inheriting from `Command` will be automatically found by the system
    // and its public properties and methods will be available for use.
    public class MyCommand : Command
    {
        // This signature "Main(...)" is reserved to process arguments fastly.
        public void Main(string myArgument, int? myArgument2 = null)
        {
            // this arg is obrigatory
            this.App.Console.Write(string.Format("myArgument='{0}'", myArgument));

            // verify if property was inputed by user.
            if (myArgument2 != null)
                this.App.Console.Write(string.Format("myArgument2='{0}'", myArgument2));
        }
    }
}