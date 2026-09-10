using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_suma_liczb_od_1_do_n
{
    internal class Program
    {
        static int CalculateSum(int number)
        {
            if (number == 0) return 0;

            // Console.WriteLine(number);
            return number + CalculateSum(number - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int number = int.Parse(Console.ReadLine());

            int result = CalculateSum(number);

            Console.WriteLine("Suma = " + result);

            // Podczas schodzenia funkcje nie liczą jeszcze wyniku - każda zostawia sobie działanie do wykonania. dopiero gdy funkcja niżej zwróci wynik, funkcja wyżej może dokończyć swoje dodawanie
        }
    }
}
