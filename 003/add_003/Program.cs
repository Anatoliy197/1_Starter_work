using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace add_003
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 28, y = 9;

            Console.WriteLine("{0}+{1}={2}", x, y, x + y);
            Console.WriteLine("{0}-{1}={2}", x, y, x - y);
            Console.WriteLine("{0}*{1}={2}", x, y, x * y);
            Console.WriteLine("{0}/{1}={2}", x, y, x / y);

            Console.ReadKey();
        }
    }
}
