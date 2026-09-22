using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_palindrom
{
    internal class Program
    {
        static bool IsPalindrome(string text, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex) return true;

            if (text[leftIndex] != text[rightIndex]) return false;

            return IsPalindrome(text, leftIndex + 1 , rightIndex - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj tekst: ");
            string text = Console.ReadLine();

            bool result = IsPalindrome(text, 0, text.Length - 1);

            if (result)
                Console.WriteLine("Tekst jest palindromem");
            else Console.WriteLine("Tekst nie jest palindromem" );
        }
    }
}
