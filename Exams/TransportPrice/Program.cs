using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            double taxi;
            double bus;
            double train;


            if (time.Equals("day"))
            {
                if (distance >= 20)
                {
                    if (distance >= 100)
                    {
                        taxi = 0.70 + 0.79 * distance;
                        bus = 0.09 * distance;
                        train = 0.06 * distance;

                        if (taxi < bus && bus < train)
                        {
                            Console.WriteLine(taxi);
                        }
                        else if (bus < taxi && bus<train)
                        {
                            Console.WriteLine(bus);
                        }
                        else if (train < bus)
                        {
                            Console.WriteLine(train);
                        }

                    }
                    else
                    {
                        taxi = 0.70 + 0.79 * distance;
                        bus = 0.09 * distance;
                        if (taxi < bus)
                        {
                            Console.WriteLine(taxi);

                        }
                        else
                        {
                            Console.WriteLine(bus);

                        }
                    }
                }
                else
                {
                    taxi = 0.70 + 0.79 * distance;
                    Console.WriteLine(taxi);
                }
            }

            else if (time.Equals("night"))
            {
                if (distance >= 20)
                {
                    if (distance >= 100)
                    {
                        taxi = 0.70 + 0.90 * distance;
                        bus = 0.09 * distance;
                        train = 0.06 * distance;

                        if (taxi < bus && bus < train)
                        {
                            Console.WriteLine(taxi);
                        }
                        else if (bus < taxi && bus <train)
                        {
                            Console.WriteLine(bus);
                        }
                        else if (train < bus)
                        {
                            Console.WriteLine(train);
                        }

                    }
                    else
                    {
                        taxi = 0.70 + 0.90 * distance;
                        bus = 0.09 * distance;
                        if (taxi < bus)
                        {
                            Console.WriteLine(taxi);

                        }
                        else
                        {
                            Console.WriteLine(bus);

                        }
                    }
                }
                else
                {
                    taxi = 0.70 + 0.90 * distance;
                    Console.WriteLine(taxi);
                }
            }
        }
    }
}
 