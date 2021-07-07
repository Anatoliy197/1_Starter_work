using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3_005
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10, z = 15;
            Console.WriteLine("1-е уравнение равно: {0}", x += y >> x++ * z);
            x = 5;
            y = 10; 
            z = 15;
            Console.WriteLine("2-е уравнение равно: {0}", z = ++x & y * 5);
            x = 5;
            y = 10;
            z = 15;
            Console.WriteLine("3-е уравнение равно: {0}", y /= x + 5 | z);
            x = 5;
            y = 10;
            z = 15;
            Console.WriteLine("4-е уравнение равно: {0}", z = x++ & y * 5);
            x = 5;
            y = 10;
            z = 15;
            Console.WriteLine("5-е уравнение равно: {0}", x = y << x++ ^ z);
            Console.ReadKey();
        }
    }
}
