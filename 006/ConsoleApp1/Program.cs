using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3_Ромб

            int rg = 5;
            int lf = 0;

            for (int y = 0; y < 3; y++)
            { 
                for (int x = 0; x < 7; x++)
                {
                    if (x <= rg && x > lf)
                        Console.Write("*");
                    else
                        Console.Write("2");
                }
                Console.Write("\n");
                rg--;
                lf++;
            }
            Console.ReadKey();

                        
            /*for (int y = 0; y < 7; y++)
            {
                if (y <= 4 && y > 1)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.Write("\n");

            for (int y = 0; y < 7; y++)
            {
                if (y<=5 && y>0)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.Write("\n");

            for (int y = 0; y < 7; y++)
            {
                if (y <= 7)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.Write("\n");






            Console.ReadKey();
            */

        }
    }
}
