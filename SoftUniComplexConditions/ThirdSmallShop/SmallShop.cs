using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondSmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

           if(city.Equals("Sofia"))
            {
                if(product.Equals("coffee"))
                {
                    Console.WriteLine(amount * 0.50);
                }
                else if(product.Equals("water"))
                {
                    Console.WriteLine(amount * 0.80);
                }
                else if(product.Equals("beer"))
                {
                    Console.WriteLine(amount * 1.20);
                }
                else if(product.Equals("sweets"))
                {
                    Console.WriteLine(amount * 1.45);
                }
                else if (product.Equals("peanuts"))
                {
                    Console.WriteLine(amount * 1.60);
                }
            }
            else if(city.Equals("Plovdiv"))
            {
                if (product.Equals("coffee"))
                {
                    Console.WriteLine(amount * 0.40);
                }
                else if (product.Equals("water"))
                {
                    Console.WriteLine(amount * 0.70);
                }
                else if (product.Equals("beer"))
                {
                    Console.WriteLine(amount * 1.15);
                }
                else if (product.Equals("sweets"))
                {
                    Console.WriteLine(amount * 1.30);
                }
                else if (product.Equals("peanuts"))
                {
                    Console.WriteLine(amount * 1.50);
                }
            }
            else if (city.Equals("Varna"))
            {
                if (product.Equals("coffee"))
                {
                    Console.WriteLine(amount * 0.45);
                }
                else if (product.Equals("water"))
                {
                    Console.WriteLine(amount * 0.70);
                }
                else if (product.Equals("beer"))
                {
                    Console.WriteLine(amount * 1.10);
                }
                else if (product.Equals("sweets"))
                {
                    Console.WriteLine(amount * 1.35);
                }
                else if (product.Equals("peanuts"))
                {
                    Console.WriteLine(amount * 1.55);
                }
            }
        }
    }
}
