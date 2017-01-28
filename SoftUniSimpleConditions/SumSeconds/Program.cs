using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            if ((firstTime < 1 && secondTime < 1 && thirdTime <1) || (firstTime > 50 && secondTime >50 && thirdTime >50))
            {
         
                return;
            }
            
            var sum = firstTime + secondTime + thirdTime;

            var minutes = sum / 60;
            var seconds = sum % 60;

            
            Console.WriteLine($"{minutes}:{seconds.ToString("00")}");



        }
    }
}
