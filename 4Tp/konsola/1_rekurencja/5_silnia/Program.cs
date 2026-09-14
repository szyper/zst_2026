using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_silnia
{
    internal class Program
    {
        // Funkcja oblicza silnię liczby
        // Przykład: 5! = 5 * 4 * 3 * 2 * 1 = 120
        static int CalculateFactorial(int number)
        {
            // 0! wynosi 1 -> jest to przypadek bazowy rekurencji
            if (number == 0) return 1;

            // mnożymy aktualną liczbę przez silnię liczby o 1 mniejszej
            return number * CalculateFactorial(number - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int number = int.Parse(Console.ReadLine());

            int result = CalculateFactorial(number);

            Console.WriteLine(number + "! = " + result);
        }
    }
}
