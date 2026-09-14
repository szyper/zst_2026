using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_potegowanie
{
    internal class Program
    {
        // napisz funkcję rekurencyjną, która obliczy potęgę
        static int CalculatePower(int number, int exponent)
        {
            if (exponent == 0) return 1;

            return number * CalculatePower(number, exponent - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Pobieramy podstawę: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Pobieramy wykładnik: ");
            int exponent = int.Parse(Console.ReadLine());

            int result = CalculatePower(number, exponent);

            Console.WriteLine(number + "^" + exponent + " = " + result);
        }
    }
}
