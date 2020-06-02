using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание3
{
    class Program
    {
        /*С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.*/
        //Антипов Виктор

        static void Main(string[] args)
        {
            int num = 2;

            int sum = 0;
            
            while (num != 0)
            {
                if(num > 0)
                {
                    if (num % 2==1)
                    {
                        sum = sum + num;
                    }
                }
                Console.Write("Введите любое число: ");
                num = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Сумма положительных нечётных чисел = {sum}");

            Console.ReadKey();
        }
    }
}
