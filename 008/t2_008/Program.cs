using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2_008
{
    class Program
    {
        static void Credit(ref int summ_pl)
        {
            if (summ_pl == 700)
                Console.WriteLine("Ваш долг погашен");
            else if (summ_pl < 700)
                Console.WriteLine("Ваш долг составляет {0} гривен", 700 - summ_pl);
                Console.WriteLine("Сумма переплаты составляет {0} гривен", summ_pl - 100);
        }
        static void Main()
        {
            Console.Write("Введите сумму платежа: ");
            string operand1 = Console.ReadLine();
            int summ_pl = Int32.Parse(operand1);
            Credit(ref summ_pl);
            Console.ReadKey();
        }
    }
}
