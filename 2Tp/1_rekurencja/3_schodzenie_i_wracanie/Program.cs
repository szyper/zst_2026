// schodzenie i wracanie
// napisz funkcję GoDownAndUp(int number), która pokaże oba etapy rekurencji

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_schodzenie_i_wracanie
{
    internal class Program
    {
        static void GoDownAndUp(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("Doszedłem do końca");
                return;
            }

            Console.WriteLine("Schodzę w dół: " + number);

            GoDownAndUp(number - 1);

            Console.WriteLine("Wracam w górę: " + number);
        }
        static void Main(string[] args)
        {
            GoDownAndUp(3);
            Console.WriteLine("Koniec");

        }
    }
}
