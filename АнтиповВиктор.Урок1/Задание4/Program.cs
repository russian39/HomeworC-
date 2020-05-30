using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание4
{
    /*Написать программу обмена значениями двух переменных:
    а) с использованием третьей переменной;
	б) *без использования третьей переменной.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 переменные");
            
            Console.Write("переменная а: ");
            var a = Console.ReadLine();
            
            Console.Write("переменная в: ");
            var b = Console.ReadLine();

            var c = a;
            a = b;
            b = c;

            Console.WriteLine("Результат обмена: ");
            Console.WriteLine($"переменная а = {a};");
            Console.WriteLine($"переменная в = {b};");

            Console.ReadKey();
        }
    }
}
