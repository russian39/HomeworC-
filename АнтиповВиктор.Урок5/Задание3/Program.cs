using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание3
{
    /*Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
      Например:
      badc являются перестановкой abcd.*/
    //Антипов
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");
            string line1 = Console.ReadLine();
            char[] symline1 = line1.ToCharArray();

            Console.Write("Введите вторую строку: ");
            string line2 = Console.ReadLine();
            char[] symline2 = line2.ToCharArray();

            int coincidence = 0;
            bool result = true;
            if (symline1.Length == symline2.Length)
            {
                for (int i = 0; i < symline1.Length; i++)
                {
                    for (int j = 0; j < symline2.Length; j++)
                    {
                        if (symline1[i] == symline2[j])
                        {
                            coincidence++;
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Вторая строка не является перестоновкой первой, т.к. их длины разные");
                result = false;
            }
            
            if (coincidence == symline2.Length)
            {
                Console.WriteLine("Вторая строка является перестоновкой первой");
            }
            else if (result == false)
            {

            }
            else
            {
                Console.WriteLine("Вторая сторка не является перестоновкой первой");
            }

            Console.ReadKey();
        }
    }
}
