using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Input a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Input b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Input c: ");
            double c = double.Parse(Console.ReadLine());

            double D, x1, x2;
            D = b * b - 4 * a * c;

            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"\nD = {D}\nx1 = {x1}, x2 = {x2}");
            }
            else if (D == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine($"\nD = {D}\nx = {x1}");
            }
            else
                Console.WriteLine("\nD < 0\nРозв'язків немає.");
                
        }
    }
}
