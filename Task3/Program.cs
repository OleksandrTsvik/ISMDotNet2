using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Input a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Input b: ");
            double b = double.Parse(Console.ReadLine());

            double y1 = 2.4 * Math.Abs((x * x + b) / a);
            double y2 = (a - b) * Math.Pow(Math.Sin(a - b), 2);
            double y3 = Math.Pow(10, -2) * (x - b);

            Console.WriteLine($"y = {y1 + y2 + y3}");

        }
    }
}
