using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_silnia
{
    internal class Program
    {
    // napisz program obliczający za pomocą rekurencji silnię liczby
    // Silnia odpowiada na pytanie: na ile sposobów można ustawić n różnych elementów w kolejności
    // n! = n * (n - 1)! =>    5! = 5 * (5 - 1)! = 5 * 24 = 120 
    // ustawianie osób w kolejności
    // hasła i kody

        static int CalculateFactorial(int number)
        {
            // przypadek bazowy
            //Silnia zera wynosi 1
            if (number == 0) return 1;

            // maksymalnie 16! => 2 004 189 184
            return number * CalculateFactorial(number - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int number = int.Parse(Console.ReadLine());

            int result = CalculateFactorial(number);

            Console.WriteLine("Silnia liczby " + number + " wynosi: " + result);
        }
    }
}
