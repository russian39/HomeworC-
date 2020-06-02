using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание5
{
    class Program
    {
        static void Main(string[] args)
        {
            double I = IMT();

            switch (I)
            {
                case <= 16 : Console.WriteLine("Выраженный дефицит массы тела. Вам требуется набрать вес."); break;
                case > 16 && <= 18.5: Console.WriteLine("Недостаточная масса тела. Вам требуется набрать вес."); break;
            }
        }

        static double IMT()
        {
            Console.Write("Введите ваш рост в сантиметрах: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ваш вес в килограммах: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double h = height / 100;

            double I = weight / (h * h);
            Console.WriteLine($"ИМТ = {I:F2}");

            return I;
        }
    }
}
