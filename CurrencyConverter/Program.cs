using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {//It does not work correct!!!!!!!! I know - just commiting to have the idea
            Dictionary<string, double> currencies = new Dictionary<string, double>();
            currencies.Add("BGN", 1.0);
            currencies.Add("USD", 1.79549);
            currencies.Add("EUR", 1.95583);
            currencies.Add("GBP", 2.53405);

            double value = double.Parse(Console.ReadLine());
            string fromCurrency = Console.ReadLine();
            string toCurrency = Console.ReadLine();

            double result = 1;

            if(currencies.ContainsKey(fromCurrency) && currencies.ContainsKey(toCurrency))
            {
                var fromRate = currencies[fromCurrency];
                var toRate = currencies[toCurrency];

                result = value * fromRate;
                Console.WriteLine(result + currencies[toCurrency]);
            }

            Console.ReadLine();




        }
    }
}
