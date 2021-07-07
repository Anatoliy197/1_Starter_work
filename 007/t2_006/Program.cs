using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_006
{
    class Program
    {
        static int add(int arg1, int arg2)
        {
            return (arg1 + arg2);
        }
        static int sub(int arg1, int arg2)
        {
            return (arg1 - arg2);
        }
        static int mul(int arg1, int arg2)
        {
            return (arg1 * arg2);
        }
        static int div(int arg1, int arg2)
        {
            return (arg1 / arg2);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите 1-e число: ");

            string operand1 = Console.ReadLine();
            int arg1 = Int32.Parse(operand1);

            Console.Write("Введите знак: ");
            string sign = Console.ReadLine();

            Console.Write("Введите 2-e число: ");

            string operand2 = Console.ReadLine();
            int arg2 = Int32.Parse(operand2);

            if (sign == "+")
            {
                int res = add(arg1, arg2);
                Console.WriteLine("{0} + {1} = {2}", arg1, arg2, res);
            }

            else if (sign == "-")
            {
                int res = sub(arg1, arg2);
                Console.WriteLine("{0} - {1} = {2}", arg1, arg2, res);
            }

            else if (sign == "*")
            {
                int res = mul(arg1, arg2);
                Console.WriteLine("{0} * {1} = {2}", arg1, arg2, res);
            }

            else if (sign == "/")
            {
                if (arg2 == 0)
                {
                    Console.WriteLine("На ноль делить нельзя");
                }
                else
                {
                    int res = div(arg1, arg2);
                    Console.WriteLine("{0} / {1} = {2}", arg1, arg2, res);
                }

            }
            Console.ReadKey();
        }
    }
}
