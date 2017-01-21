using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class SimpleDataTypes
    {
        static void Main(string[] args)
        {
            var a = 5;
            Console.WriteLine(a + a);
            Console.WriteLine(a.GetType());

            var b = '5';
            Console.WriteLine(b + b);
            Console.WriteLine(b.GetType());
            Console.WriteLine(Char.GetNumericValue(b));

            var c = "5";
            Console.WriteLine(c + c);
            Console.WriteLine(c.GetType());

        }
    }
}
