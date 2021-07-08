using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t1_003
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;

            int res1 = x += y - x++ * z;

            x = 10;
            y = 12;
            z = 3;

            int res2 = z = --x - y * 5;

            x = 10;
            y = 12;
            z = 3;

            int res3 = y /= x + 5 % z; //????

            x = 10;
            y = 12;
            z = 3;

            int res4 = z = x++ + y * 5;

            x = 10;
            y = 12;
            z = 3;

            int res5 = x = y - x++ * z;

            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            Console.WriteLine(res4);
            Console.WriteLine(res5);


            Console.ReadKey();
        }
    }
}
