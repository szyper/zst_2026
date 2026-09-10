using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_w_dol_i_w_gore
{
    internal class Program
    {
        // funkcja pokazuje dwa etapy działania rekurencji: schodzenie w dół oraz wracanie w górę

        static void GoDownAndUp(int number)
        {
            if (number == 0) 
            {
                Console.WriteLine("Koniec zadania");
                return;
            }

            // ta instrukcja wykonuje się PRZED wywołaniem rekurencyjnym. Dlatego wykonuje się podczas schodzenia w dół
            Console.WriteLine("Schodzę w dół: " + number);

            // wywołujemy funkcję z mniejszą wartością. Każde kolejne wywołanie schodzi o 1 niżej
            GoDownAndUp(number - 1);

            //  ta instrukcja znajduje się PO wywołaniu rekurencyjnym. Wykona się dopiero, wtedy gdy rekurencja zacznie wracać
            Console.WriteLine("Wracam w górę: " + number);

        }
        static void Main(string[] args)
        {
            GoDownAndUp(5);
        }
    }
}
