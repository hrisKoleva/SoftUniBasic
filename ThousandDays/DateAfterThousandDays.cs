using System;
using System.Globalization;

namespace ThousandDays
{
    class DateAfterThousandDays
    {
        static void Main(string[] args)
        {
            string inputDate = Console.ReadLine();
            string format = "dd-MM-yyyy";

            // DateTime date = DateTime.ParseExact(Console.ReadLine(), string.Format("dd-MM-yyyy"), CultureInfo.InvariantCulture);
            DateTime date = DateTime.ParseExact(inputDate, format, CultureInfo.InvariantCulture);

            DateTime result = date.AddDays(999);

            Console.WriteLine(result.ToString(format));

        }
    }
}
