using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());

            double sum_factorials = 0, factorial = 1;

            for(int i = 1; i <= n; i++)
            {
                factorial = 1;
                for (int j = 1; j <= i; j++)
                {
                    factorial *= j;
                }
                sum_factorials += factorial;
            }

            Console.WriteLine($"\nThe sum of factorials = {sum_factorials}\n");
        }
    }
}
