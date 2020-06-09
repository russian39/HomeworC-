using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание1
{
    /* С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
     * Требуется подсчитать сумму всех нечётных положительных чисел.
     * Сами числа и сумму вывести на экран, используя tryParse.*/

    class Program
    {
        static void Main(string[] args)
        {
            int num = number();
            int sum = 0;
            while(num != 0)
            {
                if (num > 0)
                {
                    if (num % 2==1)
                    {
                        sum = sum + num;
                    }
                }
                num = number();
            }
            Console.WriteLine($"Сумма положительных нечётных чисел = {sum}");

            Console.ReadKey();

        }

        static int number()
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
    }
}
