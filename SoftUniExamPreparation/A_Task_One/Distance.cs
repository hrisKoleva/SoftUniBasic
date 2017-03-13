using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1 = int.Parse(Console.ReadLine());
            double t1 = int.Parse(Console.ReadLine());
            double t2 = int.Parse(Console.ReadLine());
            double t3 = int.Parse(Console.ReadLine());

            t1 = t1/60;
            t2 = t2/60;
            t3 = t3/60;

            double d1 = v1 * t1;
            double v2 = v1 * 1.1;
            double v3 = v2 * 0.95; ;

            double distance = d1 + t2 * v2 + t3 * v3;

            Console.WriteLine("{0:0.00}",distance);
        }
    }
}
