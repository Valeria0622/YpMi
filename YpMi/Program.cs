﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YpMi
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Консольный калькулятор");
            Console.WriteLine(' ');

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"Выберите арифметическое действие:
            - Умножение (введите 1)
            - Деление (введите 2)
            - Сложение (введите 3)
            - Вычитание (введите 4)
            - Возведение числа в степень (введите 5)");

            Console.ForegroundColor = ConsoleColor.Red;
            string q = Console.ReadLine();

            double a, b;

            Console.WriteLine(' ');
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите первое значение");
            Console.ForegroundColor = ConsoleColor.Red;

            a = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите второе значение");
            Console.ForegroundColor = ConsoleColor.Red;

            b = double.Parse(Console.ReadLine());
            Console.WriteLine(' ');

            if (q == "3")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Результат сложения = {0}", a + b);
            }
        }
    }
}
