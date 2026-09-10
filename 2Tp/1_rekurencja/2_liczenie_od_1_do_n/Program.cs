// Napisz program, który pobierze liczbę n i za pomocą rekurencji wyświetli liczby od 1 do n

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_liczenie_od_1_do_n
{
    internal class Program
    {
        static void CountUp(int number)
        {
            if (number == 0) return;

            CountUp(number - 1);

            Console.WriteLine(number);


        }

        // Instrukcja przed wywołaniem rekurencyjnym wykonuje się podczas "schodzenia", a instrukcja po wywołaniu rekurencyjnym wykonuje się podczas "wracania"

        // Dlatego w zadaniu 1 -> 5, 4, 3, 2, 1, 0 a w zadaniu 2 -> 1, 2, 3, 4, 5, mimo, że w obu przypadkach mamy number - 1
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int number = int.Parse(Console.ReadLine());

            CountUp(number);

        }

        /*
         * 
         * STOS *
         CountUp(0) <- ostatnia dodana wykonuje return;
         CountUp(1)
         CountUp(2)
         CountUp(3)
         CountUp(4)
         CountUp(5) <- pierwsza

         LIFO (Last In, First Out) -> ostatnie wywołanie, które weszło na stos, jako pierwsze z niego wychodzi
        */
       
    }
}
