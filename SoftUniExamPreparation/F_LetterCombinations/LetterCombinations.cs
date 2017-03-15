using System;

namespace F_LetterCombinations
{
    class LetterCombinations
    {
        static void Main(string[] args)
        {
            char firstLetter = Convert.ToChar(Console.ReadLine());
            char lastLetter = Convert.ToChar(Console.ReadLine());

            char skipLetter = Convert.ToChar(Console.ReadLine());

            int count = 0;
            string output = "";

            for (char i = firstLetter; i <= lastLetter; i++)
            {
                if (i != skipLetter)
                {
                    for (char j = firstLetter; j <= lastLetter; j++)
                    {
                        if (j != skipLetter)
                        {
                            for (char m = firstLetter; m <= lastLetter; m++)
                            {
                                if (m != skipLetter)
                                {
                                    count++;
                                    output = i.ToString() + j.ToString() + m.ToString();
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
