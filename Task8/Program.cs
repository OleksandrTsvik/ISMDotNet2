using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());

            double power = 1;

            for (int i = 1; i <= n; i++)
                power *= a;

            Console.WriteLine($"\na^n = {power}\n");
        }
    }
}
