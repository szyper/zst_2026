// napisać program, który pobierze od użytkownika liczbę całkowitą, a następnie za pomocą funkcji rekurencyjnej wyświetli wszystkie liczby od podanej do zera

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_odliczanie_do_zera
{
    internal class Program
    {
        static void CountDown(int number)
        {
            // przypadek bazowy (warunek zakończenia)
            if (number < 0) return;

            // wyświetlenie aktualnej wartości liczby
            Console.WriteLine(number);

            // wywołujemy funkcję ponownie zmniejszając liczbę o 1
            CountDown(number - 1);
        }
        static void Main(string[] args)
        {
            // pobieramy liczbę od użytkownika
            Console.Write("Podaj liczbę: ");

            int number = int.Parse(Console.ReadLine());

            // wywołujemy funkcję rekurencyjną
            CountDown(number);

            // przy odpowiednio dużej głębokości rekurencji zabraknie miejsca na stosie ok. 14250
        }
    }
}
