using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum2_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("Цикл for");
            Console.WriteLine("-----------------------------------------");
            for(; i < 11; i++)
            {
                Console.WriteLine($"{i} lb. equals {i * 453} gram");
            }
            Console.WriteLine();

            i = 1;
            Console.WriteLine("Цикл while");
            Console.WriteLine("-----------------------------------------");
            while(i < 11)
            {
                Console.WriteLine($"{i} lb. equals {i * 453} gram");
                i++;
            }
            Console.WriteLine();

            i = 1;
            Console.WriteLine("Цикл do...while");
            Console.WriteLine("-----------------------------------------");
            do
            {
                Console.WriteLine($"{i} lb. equals {i * 453} gram");
                i++;
            }
            while(i < 11);
        }
    }
}
