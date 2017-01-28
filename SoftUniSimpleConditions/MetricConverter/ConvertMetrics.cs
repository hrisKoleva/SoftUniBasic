using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class ConvertMetrics
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, double> metrics = new Dictionary<string, double>();

            metrics.Add("mm", 1000);
            metrics.Add("cm", 100);
            metrics.Add("mi", 0.000621371192);
            metrics.Add("in", 39.3700787);
            metrics.Add("km", 0.001);
            metrics.Add("ft", 3.2808399);
            metrics.Add("yd", 1.0936133);

            double value = double.Parse(Console.ReadLine());
            string fromMetric = Console.ReadLine();
            string toMetric = Console.ReadLine();
            double result;

            result = value * metrics[toMetric]/metrics[fromMetric];

            Console.WriteLine(result + " " + toMetric);
        }
    }
}