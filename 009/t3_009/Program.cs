using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3_009
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

        static void MyReverse (params int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.Write("\n");
        }

        static int[] SubArray (int[] array, int index, int count)
        {
            int[] tempArray = new int[count];
            int k = 0;

            for (int i = 0; i < tempArray.Length; i++)
            {
                if (array.Length > index)
                {
                    tempArray[k] = array[index];
                }
                else
                {
                    tempArray[k] = 1;
                }

                index++;
                k++;
            }
            return tempArray;
        }

        static void Main(string[] args)
        {
            int[] array = new int[10];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            MyReverse(array);

            int index = 4;
            int count = 10;
            array = SubArray(array, index, count);

            PrintArray(array);

            Console.ReadKey();
        }
    }
}
