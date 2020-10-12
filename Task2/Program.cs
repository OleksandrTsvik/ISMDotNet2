using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input m: ");
            double m = double.Parse(Console.ReadLine());

            Console.Write("Input n: ");
            double n = double.Parse(Console.ReadLine());

            double z1, z2;
            z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + m * n + Math.Pow(m, 2) - m);
            z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

            Console.WriteLine($"z1 = {z1}, z2 = {z2}");

        }
    }
}
