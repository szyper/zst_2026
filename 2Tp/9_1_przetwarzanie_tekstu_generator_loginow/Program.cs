using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_przetwarzanie_tekstu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // generator_loginu
            Console.Write("Podaj imię:");
            string firstName = Console.ReadLine();

            Console.Write("Podaj nazwisko:");
            string lastname = Console.ReadLine();

            // usunięcie zbędnych spacji
            firstName = firstName.Trim();
            lastname = lastname.Trim();

            // sprawdzenie długości danych
            if (firstName.Length >= 3 && lastname.Length >= 3)
            {
                // pobranie 3 pierwszych liter
                string firstPart = firstName.Substring(0, 3);
                string lastPart = lastname.Substring(0, 3);

                // połączenie i zmiana na małe litery
                string login = (firstPart + lastPart).ToLower();

                Console.WriteLine($"Wygenerowany login: {login}");

            } else
            {
                Console.WriteLine("Imię i nazwisko musi mieć co najmniej 3 znaki");
            }
        }
    }
}
