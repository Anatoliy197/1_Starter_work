using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t4_007
{
    class Program
    {
        static string Check_plus(double x)
        {
            if (x > 0)
            {
                return "Вы ввели положительное число";
            }
            else if (x < 0)
            {
                return "Вы ввели отрицательное число";
            }

            return "Вы ввели ноль";
        }
        static string Check_simple(int x)
        {
            if(x < 1)
            {
                return "Вы ввели сложное число";
            }

            for (int y = 2; y < x; y++)
            {
                if(x % y != 0)
                {
                    continue;
                }
                else
                {
                    return "Вы ввели сложное число";
                }
            }

            return "Вы ввели простое число";
        }
        static string Check_dividers(int x)
        {
            if (x % 2 == 0 && x % 3 == 0 && x % 5 == 0 && x % 6 == 0 && x % 9 == 0)
            {
                return "Число делится на 2,3,5,6,9 без остатка";
            }
            else
            {
                return "Число не делится на 2,3,5,6,9 без остатка";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");

            string number = Console.ReadLine();
            int x = Int32.Parse(number);

            Console.WriteLine(Check_plus(x));
            Console.WriteLine(Check_simple(x));
            Console.WriteLine(Check_dividers(x));

            Console.ReadKey();
        }
    }
}
