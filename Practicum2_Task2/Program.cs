using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum2_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k;

            while(true)
            {
                try
                {
                    Console.Write("Введите номер карты: ");
                    k = int.Parse(Console.ReadLine());
                    if (k < 6 || k > 14) throw new Exception("Достоинство карты должно находиться в диапазоне от 6 до 14!");
                    break;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Ошибка: Введены некорректные значения!");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
            switch (k)
            {
                case 6:
                    Console.WriteLine("Шестерка");
                    break;
                case 7:
                    Console.WriteLine("Семерка");
                    break;
                case 8:
                    Console.WriteLine("Восьмерка");
                    break;
                case 9:
                    Console.WriteLine("Девятка");
                    break;
                case 10:
                    Console.WriteLine("Десятка");
                    break;
                case 11:
                    Console.WriteLine("Валет");
                    break;
                case 12:
                    Console.WriteLine("Дама");
                    break;
                case 13:
                    Console.WriteLine("Король");
                    break;
                case 14:
                    Console.WriteLine("Туз");
                    break;
            }
        }
    }
}
