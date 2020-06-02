using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание4
{
    /*Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
      На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
      Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
      программа пропускает его дальше или не пропускает.
      С помощью цикла do while ограничить ввод пароля тремя попытками.*/
    //Антипов Виктор

    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string password;
            int i = 1;

            do
            {
                Console.Write("Логин: ");
                login = Console.ReadLine();

                Console.Write("Пароль: ");
                password = Console.ReadLine();

                if (login == "root" && password == "GeekBrains")
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
