using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t_003
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "\nмоя строка 1";
            string b = "\tмоя строка 2";
            string c = "\aмоя строка 3";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
