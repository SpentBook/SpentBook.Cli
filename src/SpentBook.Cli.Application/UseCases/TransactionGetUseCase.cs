using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SpentBook.Cli.Domain.File;
using SpentBook.Cli.Domain.Models;
using SpentBook.Cli.Domain.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace SpentBook.Cli.Application.UseCases
{
    public class TransactionGetUseCase : ITransactionGetUseCase
    {
        private readonly ITransactionRepository repository;

        // private readonly ILogger<TransactionGetUseCase> logger;

        public TransactionGetUseCase(
            // ILogger<TransactionGetUseCase> logger,
            ITransactionRepository repository
        )
        {
            // this.logger = logger;
            this.repository = repository;
        }

        public IEnumerable<Transaction> Get()
        {
            return repository.GetTransactions();
        }

        // /// <summary>
        // /// Logs error for monitoring
        // /// </summary>
        // /// <param name="path">Path of the file</param>
        // /// <param name="details">Instance of <see cref="ImportDetails" /></param>
        // /// <param name="exception">Instance of <see cref="Exception"/></param>
        // private void LogError(FileInfo fileInfo, ImportDetails details, Exception exception)
        // {
        //     details.Status = nameof(ImportDetailsStatus.Error);
        //     details.Message = $"Fail to import file from '{fileInfo.Name}' - Message: {exception.Message} >> StackStrace: {exception.StackTrace}";
        //     details.FinishTime = DateTime.Now;
        //     logger.LogInformation($"Finishing import file '{fileInfo.Name}'");
        //     logger.LogError(JsonConvert.SerializeObject(details));
        // }

        // /// <summary>
        // /// Logs information for monitoring
        // /// </summary>
        // /// <param name="path">Name of the file.</param>
        // /// <param name="details">Instance of <see cref="ImportDetails" /></param>
        // private void LogSuccess(FileInfo fileInfo, ImportDetails details)
        // {
        //     details.Status = nameof(ImportDetailsStatus.Success);
        //     details.Message = $"Finishing OFX file '{fileInfo.Name}' processing with success";
        //     details.FinishTime = DateTime.Now;
        //     logger.LogInformation($"Finishing import file '{fileInfo.Name}'");
        //     logger.LogInformation(JsonConvert.SerializeObject(details));
        // }
    }
}
