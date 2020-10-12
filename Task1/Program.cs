using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());

            float S, P;
            S = a * b;
            P = 2 * (a + b);

            Console.WriteLine($"S = {S}, P = {P}");
        }
    }
}
