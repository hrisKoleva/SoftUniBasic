using System;

namespace NovemberBFlowerShop
{
    class FlowerShop
    {
        static void Main(string[] args)
        {
            int magnolias = int.Parse(Console.ReadLine());
            int hyacinthes = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double priceMagnolias = magnolias * 3.25;
            double priceHyacithes = hyacinthes * 4.00;
            double priceRoses = roses * 3.50;
            double priceCactuses = cactuses * 8.00;

            double totalPrice = 0.95*(priceMagnolias + priceHyacithes + priceRoses + priceCactuses);

            double difference = giftPrice - totalPrice;
            

            if (difference<=0)
            {
                
                Console.WriteLine($"She is left with {Math.Floor(Math.Abs(difference))} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(Math.Abs(difference))} leva.");

            }
        }
    }
}