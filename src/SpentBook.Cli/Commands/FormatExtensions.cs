using System;

namespace SpentBook.Cli.Commands
{
    public static class FormatExtensions
    {
        public static string ToShortString(this Guid guid)
        {
            var split = guid.ToString().Split('-');
            return split[0];
        }

        public static string ToShortDate(this DateTime date)
        {
            return date.ToString("dd/MM/yyyy");
        }

        public static string ToCurrency(this decimal value)
        {
            return string.Format("{0:C2}", value);
        }
    }
}