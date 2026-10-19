using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_sortowanie_babelkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę elementów tablicy: ");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = ReadArray(size);

            // wyświetlenie tablicy przed sortowaniem
            Console.WriteLine("Tablica przed sortowaniem:");
            DisplayArray(numbers);

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];

                        numbers[j + 1] = temp;

                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }

            // wyświetlenie tablicy po sortowaniu
            Console.WriteLine("\nTablica po sortowaniu:");
            DisplayArray(numbers);
        }

        // metoda wyświetlająca tablicę
        static void DisplayArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }

        // metoda pobierająca wartości elementów tablicy
        static int[] ReadArray(int size)
        {
            int[] numbers = new int[size];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Podaj element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            return numbers;
        }
    }
}
