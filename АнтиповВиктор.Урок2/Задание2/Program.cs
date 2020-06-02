using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2
{
    /*Написать метод подсчета количества цифр числа.*/
    //Антипов Виктор

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int length = number.ToString().Length;
            Console.WriteLine($"Длинна числа = {length}");
            Console.ReadKey();
        }
    }
}
