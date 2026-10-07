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
            int[] numbers = { 2, -3, 44, -5, 8 };

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

        static void DisplayArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
