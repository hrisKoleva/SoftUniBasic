using System;
using System.Globalization;

namespace ThousandDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(), string.Format("dd-MM-yyyy"), CultureInfo.InvariantCulture);

            DateTime result = date.AddDays(999);

            Console.WriteLine(result.ToString("dd-MM-yyyy"));

        }
    }
}
