using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double y = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            for (double i = x; x < y; x++)
            {
                //Ниже представлен алгоритм проверки числа на нечетность
                if ((x % 2) != 0)
                {
                    //Запись нечетного числа в стандартный выходной поток
                    Console.WriteLine("{0} ", x);
                }
                //Суммирование всех чисел расположенных между числами x и y.
                result += x;
            }

            Console.WriteLine("Сумма чисел равна {0}", result);

            // Delay.
            Console.ReadKey();
        }

    }
}
