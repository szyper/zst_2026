using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_algorytm_Euklidesa
{
    internal class Program
    {
        static int CalculateGcd(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }

            return CalculateGcd(b, a % b);
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj pierwszą liczbę:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę:");
            int secondNumber = int.Parse(Console.ReadLine());

            int result = CalculateGcd(firstNumber, secondNumber);

            Console.WriteLine("NWD = " + result);
        }
    }
}
