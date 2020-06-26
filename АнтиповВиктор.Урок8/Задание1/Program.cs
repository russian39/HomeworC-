﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Задание1
{
    class Program
    {
        static PropertyInfo GetPropertyInfo(object obj, string str)
        {
            return obj.GetType().GetProperty(str);
        }

        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            //dateTime.DayOfWeek
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").CanRead);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").CanWrite);
            Console.WriteLine(GetPropertyInfo(dateTime, "DayOfWeek").GetValue(dateTime, null));
            Console.ReadKey();
        }
    }
}
