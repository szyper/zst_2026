using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_odwrocenie_tekstu
{
    internal class Program
    {
        // funkcja rekurencyjnie odwraca tekst
        static string ReverseText(string text)
        {
            if (text.Length <= 1) return text;

            // pobieramy pierwszy znak
            char firstCharacter = text[0];

            // odwracamy rekurencyjnie pozostałą część tekstu
            string rest = ReverseText(text.Substring(1));

            // dodajemy pierwszy znak na końcu
            return rest + firstCharacter;

        }
        static void Main(string[] args)
        {
            Console.Write("Podaj tekst:");
            string text = Console.ReadLine();

            string result = ReverseText(text);

            Console.WriteLine("Odwrócony tekst: " + result);
        }
    }
}
