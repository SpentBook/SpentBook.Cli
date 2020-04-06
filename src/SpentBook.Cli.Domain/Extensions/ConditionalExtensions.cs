namespace SpentBook.Cli.Domain.Extensions
{
    public static class ConditionalExtensions
    {
        public static bool In<T>(this T obj, params T[] comparations)
        {
            foreach(var c in comparations)
                if (!obj.Equals(c))
                    return false;

            return comparations.Length == 0 ? false : true;
        }
    }
}