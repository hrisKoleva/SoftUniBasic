using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voleyball
{
    class VoleyballDays
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int daysHome = int.Parse(Console.ReadLine());

            int weekends = 48;
            double result;

            weekends = weekends - daysHome;
            var numberOfSaturdays = weekends * 3.0 / 4;
            var numberOfHolidays = holidays * 2.0 / 3;
            result = numberOfHolidays + numberOfSaturdays + daysHome;

            if (yearType.Equals("leap"))
            {
               
                result += 0.15 * result;
                Console.WriteLine(Math.Truncate(result));
                
            }
            else if(yearType.Equals("normal"))
            {
                Console.WriteLine(Math.Truncate(result));

            }
        }
    }
}
