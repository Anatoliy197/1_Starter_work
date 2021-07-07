using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace t3_007
{
    class Program
    {
        static double Usd_Rur(double summ, double course_U)
        {
            return (summ * course_U);
        }
        static double Rur_Usd(double summ, double course_U)
        {
            return (summ / course_U);
        }
        static double Eur_Rur(double summ, double course_E)
        {
            return (summ * course_E);
        }
        static double Rur_Eur(double summ, double course_E)
        {
            return (summ / course_E);
        }
        static void Main()
        {
            Console.WriteLine("Валютные пары: 1 = Доллары на рубли, 2 = Рубли на доллары, 3 = Евро на рубли, 4 = Рубли на Евро");
            Console.Write("Пожалуйста, сделайте свой выбор: ");

            string exchange = Console.ReadLine();

            Console.Write("Введите сумму: ");
            string operand1 = Console.ReadLine();
            double summ = Double.Parse(operand1);
            double course_U = 65.45;
            double course_E = 72.01;

            switch (exchange)
            {
                case "1":
                    Console.WriteLine("Отдаете {0} долларов, получаете {1} рублей", summ, Usd_Rur(summ, course_U));
                    break;
                case "2":
                    Console.WriteLine("Отдаете {0} рублей, получаете {1} долларов", summ, Rur_Usd(summ, course_U));
                    break;
                case "3":
                    Console.WriteLine("Отдаете {0} евро, получаете {1} рублей", summ, Eur_Rur(summ, course_E));
                    break;
                case "4":
                    Console.WriteLine("Отдаете {0} евро, получаете {1} рублей", summ, Rur_Eur(summ, course_E));
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Пожалуста выберите 1, 2, 3 или 4.");
                    break;
            }
            Console.ReadKey();


        }

    }
}