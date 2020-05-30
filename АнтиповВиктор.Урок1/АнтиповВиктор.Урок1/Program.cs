using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание1
{
    /*Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
      В результате вся информация выводится в одну строчку:
        а) используя  склеивание;
	    б) используя форматированный вывод;
	    в) используя вывод со знаком $.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Заполните пожалуйста анкету.");
            
            Console.Write("Введите ваше имя: ");
            string firstName = Console.ReadLine();

            Console.Write("Введите вашу фамилию: ");
            string lastName = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ваш рост в сантиметрах: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ваш вес в килограммах: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Вывод методом склеивания:");
            TaskA(firstName, lastName, age, height, weight);

            /*Console.WriteLine("Форматированный вывод:");
            TaskB(firstName, lastName, age, height, weight);*/

            Console.WriteLine("Вывод со знаком $:");
            TaskC(firstName, lastName, age, height, weight);

            Console.ReadKey();
        }

        static void TaskA(string firstName, string lastName, int age, int height, double weight)
        {
            Console.WriteLine(firstName + " " + lastName + "; возраст " + age + "; " + height + " см, " + weight + " кг.");
        }

        static void TaskB()
        {

        }

        static void TaskC(string firstName, string lastName, int age, int height, double weight)
        {
            Console.WriteLine($"{firstName} {lastName}; возраст {age}; {height}");
        }
    }
}
