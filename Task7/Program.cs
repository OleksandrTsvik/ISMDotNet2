using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }

            Console.WriteLine($"\nSum = {sum}\n");
        }
    }
}
