using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            string num = Console.ReadLine();
            int x = Convert.ToInt32(num);
            
            if (x % 2 == 0)
                Console.WriteLine("вы ввели четное число");
            else
                Console.WriteLine("не четное число");
            Console.ReadKey();


        }
    }
}
