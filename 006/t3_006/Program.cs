using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3_006
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1_Прямоугольник
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Write("\n");

            // 2_Прямоугольный треугольник
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Write("\n");

            // 3_Равносторонний треугольник
            int rg = 3;
            int lf = 2;

            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    if (x <= rg && x > lf)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
                rg++;
                lf--;
            }
            Console.Write("\n");

            // 4_Ромб
            rg = 3;
            lf = 2;

            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    if (x <= rg && x > lf)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
                rg++;
                lf--;
            }
            rg = 5;
            lf = 0;

            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    if (x <= rg && x > lf)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
                rg--;
                lf++;
            }
            Console.ReadKey();
        }
    }
}
