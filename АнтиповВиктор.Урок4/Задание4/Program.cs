using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание4
{
    /*Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
     * Создайте структуру Account, содержащую Login и Password.*/
    //Антипов

    struct Account
    {
        string[] fileArray;
        string login;
        string password;
        public Account(string start)
        {
            fileArray = File.ReadAllLines("C:\\Users\\Юрий Фалин\\source\\repos\\АнтиповВиктор.Урок4\\Задание4\\ВходныеДанные.txt");
            login = fileArray[0];
            password = fileArray[1];
        }

        public string trueLogin() 
        {
            return login;
        }

        public string truePassword()
        {
            return password;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account("Данные аккаунта");

            string login;
            string password;
            int i = 1;

            do
            {
                Console.Write("Логин: ");
                login = Console.ReadLine();

                Console.Write("Пароль: ");
                password = Console.ReadLine();

                if (login == acc.trueLogin() && password == acc.truePassword())
                {
                    Console.WriteLine("Добро пожаловать!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Неверный логин или пароль. Повторите попытку.\nОсталось {3 - i} попыток");
                    i++;
                }
            }
            while (i < 4);

            if (i == 4)
            {
                Console.WriteLine("Количество попыток входа превысило лимит. Повторите попытку позже.");
            }

            Console.ReadKey();
        }
    }
}
