using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание1
{
    /*Создать программу, которая будет проверять корректность ввода логина.
     *Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
     *при этом цифра не может быть первой:
    а) без использования регулярных выражений;
    б) **с использованием регулярных выражений.*/
    //Антипов
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();
            char[] symLog = login.ToCharArray();
            bool right = true;
            if (symLog.Length > 1 && symLog.Length < 11)
            {
                for (int i = 0; i < symLog.Length; i++)
                {
                    //Console.WriteLine(symLog[i]);
                    if (i == 0)
                    {
                         if(Char.IsNumber(symLog[i]) == true)
                         {
                            right = false;
                         }
                    }
                    //char.GetUnicodeCategory
                }
            }
            //Console.WriteLine(right);
            Console.ReadKey();
        }
    }
}
