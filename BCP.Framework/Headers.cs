using System;
using System.Linq;

namespace BCP.Framework
{
    public class Headers
    {
        public static string GetCorrelationId(string nameApp)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 12).Select(s => s[random.Next(s.Length)]).ToArray()) + "_" + nameApp;
        }
    }
}
