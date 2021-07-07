using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t4_005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите выслугу лет:");
            string vsl = Console.ReadLine();
            double x = Convert.ToByte(vsl);
            if (0 < x && x < 5)
            {
                Console.WriteLine("Ваша премия составляет 10%");
            }
            else if (5 <= x && x < 10)
            {
                Console.WriteLine("Ваша премия составляет 15%");
            }
            else if (10 <= x && x < 15)
            {
                Console.WriteLine("Ваша премия составляет 25%");
            }
            else if (15 <= x && x < 20)
            {
                Console.WriteLine("Ваша премия составляет 35%");
            }
            else if (20 <= x && x < 25)
            {
                Console.WriteLine("Ваша премия составляет 45%");
            }
            else if (x >= 25)
            {
                Console.WriteLine("Ваша премия составляет 50%");
            }
            else
            {
                Console.WriteLine("Вы ввели не правильное число");
            }
                

            Console.ReadKey();


        }
    }
}
