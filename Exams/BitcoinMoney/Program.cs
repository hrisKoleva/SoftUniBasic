using System;

namespace BitcoinMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double chineseYuans = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double bitcoinsInBGN = bitcoins * 1168;
            double chienseYuansInBGN = chineseYuans * 1.76 * 0.15;


            double euroForBitcoins = (bitcoinsInBGN + chienseYuansInBGN) / 1.95;
            double euroForBitcoinsWithCommission = euroForBitcoins - commission * euroForBitcoins/100;

            Console.WriteLine(euroForBitcoinsWithCommission);
        }
    }
}