using System;

namespace CExamTask
{
    class CarToGo
    {

        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string carClass = "";
            string carType = "";
            double price = 1;

            if(budget<=100)
            {
                carClass = "Economy class";

                if(season.Equals("Summer"))
                {
                    carType = "Cabrio";
                    price = 0.35 * budget; 
                }
                else if(season.Equals("Winter"))
                {
                    carType = "Jeep";
                    price = 0.65 * budget;
                }
            }
            else if(budget>100 && budget<=500)
            {
                carClass = "Compact class";
                if (season.Equals("Summer"))
                {
                    carType = "Cabrio";
                    price = 0.45 * budget;
                }
                else if (season.Equals("Winter"))
                {
                    carType = "Jeep";
                    price = 0.80 * budget;
                }

            }
            else if(budget>500)
            {
                carClass = "Luxury class";
                carType = "Jeep";
                price = 0.90 * budget;

            }

            Console.WriteLine($"{carClass}");
            Console.WriteLine($"{carType} - {price.ToString("0.00")}");

        }
    }
}