using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            for (int left = -n; left <= n; left++)
            {
                for (int right = -n; right <= n; right++)
                {
                    for (int top = -n; top <= n; top++)
                    {
                        for (int bottom = -n; bottom <= n; bottom++)
                        {
                            int area = (right - left) * (top - bottom);

                            if (area >= m)
                            {
                                Console.WriteLine($"({left}, {top}) ({right}, {bottom}) -> {area}");
                            }
                        }

                    }
                }
            }

        }
    }
}
