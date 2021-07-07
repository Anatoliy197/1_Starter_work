using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add1_009
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] array = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

                for (int i = 9; i >= 0; i--)
                {
                    Console.WriteLine(array[i]);
                }

                Console.ReadKey();
            }
        }
    }
}
