using System;
using System.Reflection;

namespace SpentBook.Cli.Commands.Configuration
{
    public class TableColumn<T>
    {
        public string Name { get; set; }
        public PropertyInfo Property { get; set; }
        public Func<T, string> ValueFormatter { get; set; }
        public bool OnlyInWide { get; set; }
    }
}