using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenerHarvestProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            double vegetableAmount = double.Parse(Console.ReadLine());
            double fruitAmount = double.Parse(Console.ReadLine());
            double rate = 1.94;
            double total;
            double totalEuro;

            //validation 4 numbers >= 0.00 and <= 1000.00
            
            double vegetableProfit = vegetablePrice * vegetableAmount;
            double fruitProfit = fruitPrice * fruitAmount;
            total = vegetableProfit + fruitProfit;
            totalEuro = total / rate;

            Console.WriteLine(totalEuro);

        }
    }
}
