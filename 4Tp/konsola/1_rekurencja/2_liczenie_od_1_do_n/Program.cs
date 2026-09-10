using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_liczenie_od_1_do_n
{
    internal class Program
    {
        // Napisz program, który pobierze liczbę n i za pomocą rekurencjiwyświetli liczby od 1 do n
        static void CountUp(int number)
        {
            if (number == 0) return;

            CountUp (number - 1);

            Console.WriteLine(number);

        }
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int number = int.Parse(Console.ReadLine());

            CountUp(number);
        }
    }
}
