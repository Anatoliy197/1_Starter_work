using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t4_009
{
    class Program
    {
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

        }

        static int[] Enlargement (int[] array)
        {
            int[] largeArray = new int[array.Length+1];
            for (int i = 0; i < largeArray.Length; i++)
            {
                largeArray[i] = i * 2;
            }

            return largeArray;
        }
        static int[] Add_argument(int[] array, int value)
        {
            int[] addArray = new int[array.Length+1];
            for (int i = 0; i < addArray.Length; i++)
            {
                if (i == 0)
                {
                    addArray[i] = value;
                }
                else
                {
                    addArray[i] = i * 2 - 2; 
                }
                addArray[0] = value;
            }

            return addArray;
        }
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 2;
            }

            PrintArray(array);
            Console.Write("\n");

            array = Enlargement(array);

            PrintArray(array);
            Console.Write("\n");

            int value = 99;
            array = Add_argument(array,value);

            PrintArray(array);

            Console.ReadKey();
        }
    }
}
