using System;
using System.Collections.Generic;

namespace CurrencyConverter
{
    class ConvertCurrencies
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> currencies = new Dictionary<string, double>();
            currencies.Add("BGN", 1.0);
            currencies.Add("USD", 1.79549);
            currencies.Add("EUR", 1.95583);
            currencies.Add("GBP", 2.53405);

            double value = double.Parse(Console.ReadLine());
            string fromCurrency = Console.ReadLine();
            string toCurrency = Console.ReadLine();
            double valueInBGN;
            double result;

            valueInBGN = value * currencies[fromCurrency];
            result = valueInBGN / currencies[toCurrency];
                        
            Console.WriteLine(Math.Round(result,2) + " " + toCurrency);
        }
    }
}
