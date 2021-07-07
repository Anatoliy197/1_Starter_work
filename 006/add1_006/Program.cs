using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add1_006
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 5; x++)
            {
                for(int y = 0; y < 2; y++)
                {
                    Console.WriteLine("@");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
