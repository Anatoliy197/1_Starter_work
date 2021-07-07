using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t4_006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество клиентов N = ");
            long numberCust = Convert.ToInt32(Console.ReadLine());
            long quantityRout = 1;
            do
            {
               quantityRout *= numberCust--;
            }
            while (numberCust > 0);

            Console.WriteLine("Количество возможных маршуртов :{0}", quantityRout);

            Console.ReadKey();
        }
    }
}
