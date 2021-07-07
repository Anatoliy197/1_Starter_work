using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add1_008
{
    class Program
    {
        static void Calculate(ref int a, ref int b, ref int c)
        {
            a /= 5;
            b /= 5;
            c /= 5;
        }
        static void Main()
        {

            int a = 100, b = 500, c = 750;

            Calculate(ref a, ref b, ref c);
            Console.WriteLine("1-е значение равно {0}, 2-е значение равно {1}, 3-е значение равно {2}", a,b,c);
            Console.ReadKey();

        }
    }
}
