using System;

namespace NinethVowelsSum
{
    class VowelsSum
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int sumOfVowels = 0;

            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a': sumOfVowels += 1;
                          break;
                    case 'e': sumOfVowels += 2;
                        break;
                    case 'i':
                        sumOfVowels += 3;
                        break;
                    case 'o':
                        sumOfVowels += 4;
                        break;
                    case 'u':
                        sumOfVowels += 5;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(sumOfVowels);
        }
    }
}
