using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание1
{
    /*Написать метод, возвращающий минимальное из трёх чисел.*/
    //Антипов Виктор

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int min = 0;

            if (a<b && a<c)
            {
                if (b>c)
                {
                    min = c;
                }
                else
                {
                    min = b;
                }
            }
            else
            {
                min = a;
            }

            Console.WriteLine($"Минимальное число: {min}");

            Console.ReadKey();
        }
    }
}
