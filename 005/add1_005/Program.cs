using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add1_005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            string num = Console.ReadLine();
            int x = Convert.ToInt32(num);
            int res = x & (x - 1);
            
            if (res == 0)
                Console.WriteLine("введенное число является результатом степени 2");
            else
                Console.WriteLine("не является результатом степени 2");
            Console.ReadKey();
        }
    }
}
