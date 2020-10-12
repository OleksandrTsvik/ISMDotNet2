using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Input b: ");
            int b = int.Parse(Console.ReadLine());

            int product = 1;

            for (; a <= b; a++)
                product *= a;

            Console.WriteLine($"\nProduct = {product}\n");
        }
    }
}
