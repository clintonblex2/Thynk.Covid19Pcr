using System;
using System.Linq;
using System.Text;

namespace Thynk.Covid19Pcr.Domain.Helpers
{
    public static class Utils
    {
        public static bool IsDateValid(object value, int minAge)
        {
            DateTime date;
            if (DateTime.TryParse(value.ToString(), out date))
            {
                return date.AddYears(minAge) <= DateTime.Now;
            }

            return false;
        }

        public static bool IsNull(string txt)
        {
            if (string.IsNullOrEmpty(txt) || string.IsNullOrWhiteSpace(txt) || txt.Length == 0)
            {
                return true;
            }
            return false;
        }

        public static string FormatException(Exception e)
        {
            if (e == null)
            {
                return null;
            }

            var ex = e;
            var sb = new StringBuilder();

            while (ex != null)
            {
                sb.AppendLine($"Exception: {ex.Message} \nStackTrace: {ex.StackTrace} {Environment.NewLine}");
                ex = ex.InnerException;
            }

            sb.AppendLine("======================================");

            return sb.ToString();
        }

        public static string RandomString(int length)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
