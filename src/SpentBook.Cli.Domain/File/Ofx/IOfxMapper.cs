using SpentBook.Cli.Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace SpentBook.Cli.Domain.File
{
    public interface IOfxMapper
    {
        IEnumerable<Transaction> Map(FileInfo fileInfo, Guid idImport);
    }
}
