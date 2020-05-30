using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание5
{
    /*а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
      б) *Сделать задание, только вывод организовать в центре экрана.
      в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string firstName = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            string lastName = Console.ReadLine();

            Console.Write("Введите город проживания: ");
            string city = Console.ReadLine();

            /*string output = String.Format("{1} {2} живёт в городе {3}", firstName, lastName, city);
            Console.WriteLine(output);*/

            Console.WriteLine($"{firstName} {lastName} живёт в городе {city}");

            Console.ReadKey();
        }
    }
}
