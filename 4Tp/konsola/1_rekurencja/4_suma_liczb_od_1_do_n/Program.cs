using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _3_suma_liczb_od_1_do_n
{
    internal class Program
    {
        // Napisz funkcję rekurencyjną, która obliczy sumę wszystkich liczb od 1 do n

        static int CalculateSum(int number)
        {
            if (number == 0) return 0;

            return number + CalculateSum(number - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę: ");
            int number = int.Parse(Console.ReadLine());

            int result = CalculateSum(number);

            Console.WriteLine("Suma liczb od 1 do " + number + " wynosi: " + result);
        }
    }
}
