using System;

namespace EighthTradeCommissions
{
    class TradeCommission
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            bool isInFirstRange = sales >= 0 & sales <= 500;
            bool isInSecondRange = sales > 500 && sales <= 1000;
            bool isInThirdRange = sales > 1000 && sales <= 10000;
            bool isInForthRange = sales > 10000;

            switch (city)
            {
                case "Sofia":
                    {
                        if (isInFirstRange)
                        {
                            Console.WriteLine("{0:f2}", sales * 0.05);
                        }
                        else if (isInSecondRange)
                        {
                            Console.WriteLine("{0:f2}", sales * 0.07);

                        }
                        else if (isInThirdRange)
                        {
                            Console.WriteLine("{0:f2}", sales * 0.08);

                        }
                        else if (isInForthRange)
                        {
                            Console.WriteLine("{0:f2}", sales * 0.12);

                        }
                    }
                    break;
                case "Varna":
                    {
                        if (isInFirstRange)
                        {
                            Console.WriteLine("{0:f2}", sales * 0.045);
                        }
                        else if (isInSecondRange)
                        {
                            Console.WriteLine("{0:f2}", sales * 0.075);

                        }
                        else if (isInThirdRange)
                        {
                            Console.WriteLine("{0:f2}", sales * 0.1);

                        }
                        else if (isInForthRange)
                        {
                            Console.WriteLine("{0:f2}", sales * 0.13);

                        }
                        else
                        {
                            Console.WriteLine("error");
                        }

                    }
                    break;
                case "Plovdiv":
                    {
                        if (isInFirstRange)
                        {
                            Console.WriteLine("{0:f2}", sales * 0.055);
                        }
                        else if (isInSecondRange)
                        {
                            Console.WriteLine("{0:f2}", sales * 0.08);

                        }
                        else if (isInThirdRange)
                        {
                            Console.WriteLine("{0:f2}", sales * 0.12);

                        }
                        else if (isInForthRange)
                        {
                            Console.WriteLine("{0:f2}", sales * 0.145);

                        }
                        else
                        {
                            Console.WriteLine("error");
                        }

                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
