using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SpentBook.Cli.Infrastructure.Configuration
{
    public class AppSettings
    {
        public string DataBaseName { get; set; }
        public string MigrationAssemblyMySql { get; set; }
        public string MigrationAssemblySqlServer { get; set; }
        public string SpentBookApi { get;  set; }
    }
}
