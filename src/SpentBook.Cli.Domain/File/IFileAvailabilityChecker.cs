namespace SpentBook.Cli.Domain.File
{
    public interface IFileAvailabilityChecker
    {
        void CheckForAvailableFilesAndMoveToWorking(string extension);
    }
}
