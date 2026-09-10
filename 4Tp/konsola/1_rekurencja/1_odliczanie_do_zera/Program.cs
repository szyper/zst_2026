using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_odliczanie_do_zera
{
    internal class Program
    {
        // funkcja wyświetla liczby od podanej wartości do zera

        static void CountDown(int number)
        {
            // przypadek bazowy, gdy liczba jest mniejsza od zera, kończymy działanie funkncji
            if (number < 0) return;

            // wyświetlamy aktualną wartość liczby
            Console.WriteLine(number);

            // wywołujemy funkcję ponownie, zmniejszając liczbę o 1
            CountDown(number - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int number = int.Parse(Console.ReadLine());
            
            // wywołujemy funkcję rekurencyjną
            CountDown(number);
        }
    }
}
