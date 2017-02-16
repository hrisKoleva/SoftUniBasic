using System;

namespace DeveloperDailyProfitInBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDaysInMonth = int.Parse(Console.ReadLine());
            double dailySalary = double.Parse(Console.ReadLine());
            double dollarsToBGN = double.Parse(Console.ReadLine());

            double monthlySalary = workingDaysInMonth * dailySalary;
            double yearSalary = monthlySalary * 12;

            double withBonus = yearSalary + 2.5 * monthlySalary;
            double afterTaxes = 0.75 *withBonus;

            double totalInLeva = afterTaxes * dollarsToBGN;
            double dailyProfitInBGN = totalInLeva / 365;

            Console.WriteLine("{0:0.00}", dailyProfitInBGN);
        }
    }
}