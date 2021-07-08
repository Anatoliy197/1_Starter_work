using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t2_003
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double r = 3;

            double s = pi * r * r;
            Console.WriteLine("Площадь круга равна {0}", s);

            Console.ReadKey();

        }
    }
}
