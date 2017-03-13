using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_LetterCombinations
{
    class LetterCombinations
    {
        static void Main(string[] args)
        {
            char firstLetter = Convert.ToChar(Console.ReadLine());
            char secondLetter = Convert.ToChar(Console.ReadLine());
            char thirdLetter = Convert.ToChar(Console.ReadLine());
            int count = 0;
     
            for (char i = firstLetter; i <= thirdLetter; i++)
            {
                if (i != thirdLetter)
                {
                    for (char j = firstLetter; j <= thirdLetter; j++)
                    {
                        if (j != thirdLetter)
                        {
                            for (char m = firstLetter; m <= thirdLetter; m++)
                            {
                                if (m != thirdLetter)
                                {
                                    count++;
                                    string output = i.ToString() + j.ToString() + m.ToString();
                                    Console.Write(output + " ");
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
