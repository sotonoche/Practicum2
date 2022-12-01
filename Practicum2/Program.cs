using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            while (true)
            {
                try
                {

                    Console.Write("Введите значение x: ");
                    x = double.Parse(Console.ReadLine());
                    Console.Write("Введите значение y: ");
                    y = double.Parse(Console.ReadLine());
                    break;
                }
                catch 
                {
                    Console.WriteLine("Введите корректное значение!");
                }
            }

            if ((x * x + y * y > Math.Pow(3, 2)) && (x * x + y * y < Math.Pow(7, 2)))
            {
                Console.WriteLine("Да");
            }
            else if ((x * x + y * y == Math.Pow(3, 2)) || (x * x + y * y == Math.Pow(7, 2)))
            {
                Console.WriteLine("На границе");
            }
            else Console.WriteLine("Нет");

        }
    }
}
