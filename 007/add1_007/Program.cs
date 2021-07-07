
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add1_007
{
    class Program
    {
        static int calculate(int summand1, int summand2, int summand3)
        {
            return (summand1 + summand2 + summand3)/3;
        }
        static void Main(string[] args)
        {
            int summand1 = 7, summand2 = 3, summand3 = 8;

            int average = calculate(summand1, summand2, summand3);

            Console.WriteLine("среднее арифметическое {0},{1},{2} равно {3}", summand1, summand2, summand3, average);

            Console.ReadKey();
        }
    }
}
