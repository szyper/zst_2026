using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2_przetwarzanie_tekstu_generator_loginow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // poprawne wyświetlanie polskich znaków
            Console.OutputEncoding = Encoding.UTF8;

            DisplayHeader();

            // pobieramy imię i nazwisko. Puste dane nie zostaną zaakceptowane
            string firstName = GetNonEmptyText("Podaj imię: ");
            string lastName = GetNonEmptyText("Podaj nazwisko: ");

            // pobieramy liczbę loginów z zakresu od 1 do 20
            int loginCount = GetNumber("Ile loginów wygenerować (1-20): ", 1, 20);

            // zmienna format przechowuje wybrany przez użytkwonika wariant loginu
            int format = GetNumber("Wybierz format: 1) imie.nazwisko 2) inicjal.nazwisko 3)nazwisko.imie: ", 1, 3);

            try
            {
                // tworzymy listę loginów i wyświetla ją w konsoli
                List<string> logins = GenerateLoginList(firstName, lastName, loginCount, format);

                DisplayLogins(logins);
            }
            catch (ArgumentException error)
            {
                // wyświetla komunikat, jeśli podane dane nie zawierają liter ani cyfr
                Console.WriteLine($"Błąd danych: {error.Message}");
            }
            Console.WriteLine("Naciśnij Enter, aby zakończyć");
            Console.ReadLine();
        }

        // wyświetla tytuł programu
        private static void DisplayHeader()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("        GENERATOR LOGINÓW");
            Console.WriteLine("========================================");
        }

        // pobiera niepusty teskt. Jeśli użytkownik nic nie wpisze, pyta ponownie
        private static string GetNonEmptyText(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    // usuwamy spacje z początku i końca tekstu
                    return input.Trim();
                }
                Console.WriteLine("Pole nie może być puste");
            }
        }

        // pobiera liczbę całkowitą z podanego zakresu
        private static int GetNumber(string prompt, int minimum, int maximum)
        {
            while(true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();

                // sprawdzamy, czy wpisano liczbę i czy mieści się w dozwolonym zakresie
                if (int.TryParse(input, out int number) && number >= minimum && number <= maximum)
                {
                    return number;
                }
                Console.WriteLine($"Wpisz liczbę od {minimum} do {maximum}");
            }
        }

        // Generuje listę loginów na podstawie czterech parametrów.
        private static List<string> GenerateLoginList(
            string firstName,
            string lastName,
            int loginCount,
            int format)
        {
            List<string> logins = new List<string>();

            // Usuwa spacje z początku i końca oraz zamienia litery na małe.
            firstName = firstName.Trim().ToLower();
            lastName = lastName.Trim().ToLower();

            for (int i = 0; i < loginCount; i++)
            {
                string login = "";

                // Tworzy login w wybranym formacie.
                if (format == 1)
                {
                    login = firstName + "." + lastName;
                }
                else if (format == 2)
                {
                    login = firstName[0] + "." + lastName;
                }
                else if (format == 3)
                {
                    login = lastName + "." + firstName;
                }

                // Do kolejnych propozycji dopisuje numer.
                if (i > 0)
                {
                    login = login + (i + 1);
                }

                logins.Add(login);
            }

            return logins;
        }

        // Wyświetla loginy znajdujące się na liście.
        private static void DisplayLogins(List<string> logins)
        {
            Console.WriteLine();
            Console.WriteLine("Wygenerowane loginy:");

            for (int i = 0; i < logins.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + logins[i]);
            }
        }


    }
}
