using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_009
{
    class Program
    {

        
        
        static void Main(string[] args)
        {

            Console.Write("Введите размер массива N = ");
            string dim = Console.ReadLine();
            int lng = Int32.Parse(dim);
            int[] array = new int[lng];
            int summ = 0;
            int aver = 0;
            int big = 0;
            int small = 0;


            Console.Write("нечетные элементы массива: ");
            for (int i = 0; i < lng; i++)
            {
                array[i] = 9+i-1;
                if (array[i] % 2 == 1)
                {
                    Console.Write(" {0},", array[i]);
                }
                summ = summ + array[i];

                if (summ >= array[i])
                {
                    big = array[i];
                }

                if (summ <= array[i])
                {
                    small = array[i];
                }
            }
            aver = summ / lng;
            Console.Write("\n");
            Console.WriteLine("наибольшее значение: {0}", big);
            Console.WriteLine("наименьшее значение: {0}", small);
            Console.WriteLine("среднее арифметическое: {0}",aver);
            Console.ReadKey();
        }
    }
}
