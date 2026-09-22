using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_NWD
{
    internal class Program
    {
        // NWD => funkcja obliczająca największy wspólny dzielnik dwóch liczb
        static int CalculateGcd(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0) return firstNumber;

            return CalculateGcd(secondNumber
                , firstNumber % secondNumber);
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj pierwszą liczbę: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int result = CalculateGcd(firstNumber, secondNumber);

            Console.WriteLine("NWD wynosi: " + result);
        }
    }
}
