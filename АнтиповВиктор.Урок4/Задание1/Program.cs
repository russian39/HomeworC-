using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание1
{
    /*Дан целочисленный массив из 20 элементов.
     * Элементы массива могут принимать целые значения от –10000 до 10000 включительно. Заполнить случайными числами.
     * Написать программу, позволяющую найти и вывести количество пар элементов массива,
     * в которых только одно число делится на 3.
     * В данной задаче под парой подразумевается два подряд идущих элемента массива.
     * Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.*/
    //Антипов

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rnd = new Random();
            int couples = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10000, 10000);
                Console.WriteLine(array[i]);
                if (array[i]%3==0)
                {
                    couples++;
                }
            }
            couples = couples / 2;
            Console.WriteLine(couples);
            Console.ReadKey();
        }
    }
}
