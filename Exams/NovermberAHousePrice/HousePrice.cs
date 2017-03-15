using System;

namespace NovermberAHousePrice
{
    class HousePrice
    {
        static void Main(string[] args)
        {
            double firstRoomArea = double.Parse(Console.ReadLine());
            double kitchenArea = double.Parse(Console.ReadLine());
            double pricePerSquareMeter = double.Parse(Console.ReadLine());

            double bathRoomArea = 0.5 * firstRoomArea;

            double secondRoomArea = 1.1 * firstRoomArea;

            double thirdRoomArea = 1.1 * secondRoomArea;

            double houseArea = 1.05 * (firstRoomArea + secondRoomArea + thirdRoomArea + kitchenArea + bathRoomArea);

            double price = 1;

            price = houseArea * pricePerSquareMeter;
            Console.WriteLine(price.ToString("0.00"));
        }
    }
}