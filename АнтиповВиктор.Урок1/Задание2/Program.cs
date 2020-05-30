using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2
{
    /*Ввести вес и рост человека.
      Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
      где m — масса тела в килограммах, h — рост в метрах.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваш рост в сантиметрах: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ваш вес в килограммах: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double h = height / 100;

            double I = weight / (h * h);
            Console.WriteLine($"ИМТ = {I:F2}");

            Console.ReadKey();
        }
    }
}
