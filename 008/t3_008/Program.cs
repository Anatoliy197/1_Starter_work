using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3_008
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 3;
            int factorial = 1;

            Console.Write("Факториал числа: {0}! = ", counter);

            do
            {
                // Сначала умножение, потом декремент. 
                factorial *= counter--;

                // Данная строка эквивалентна:

                //factorial = factorial * counter;
                //counter = counter - 1;
            }
            while (counter > 0);

            Console.WriteLine("{0}", factorial);
            Console.ReadKey();
        }
    }
}
