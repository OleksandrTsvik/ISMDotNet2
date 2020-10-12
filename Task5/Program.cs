using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Enter the day of the week: ");
            byte day = byte.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Понеділок\n");
                    break;
                case 2:
                    Console.WriteLine("Вівторок\n");
                    break;
                case 3:
                    Console.WriteLine("Середа\n");
                    break;
                case 4:
                    Console.WriteLine("Четвер\n");
                    break;
                case 5:
                    Console.WriteLine("П’ятниця\n");
                    break;
                case 6:
                    Console.WriteLine("Субота\n");
                    break;
                case 7:
                    Console.WriteLine("Неділя\n");
                    break;
                default:
                    Console.WriteLine("Помилка.\n");
                    break;
            }

        }
    }
}
