namespace _10__Operacje_na_listach_i_slownikach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Elementy o tym samym indeksie w każdej liście opisują tego samego studenta
            List<int> indexNumbers = [1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008];
            List<string> firstNames = ["Anna", "Jan", "Maria", "Piotr", "Zofia", "Adam", "Ewa", "Tomasz"];
            List<string> lastNames = ["Kowalska", "Nowak", "Wiśniewska", "Zieliński", "Wójcik", "Kamiński", "Lewandowska", "Dąbrowski"];
            List<string> majors = ["Informatyka", "Informatyka", "Matematyka", "Informatyka", "Zarządzanie", "Matematyka", "Informatyka", "Zarządzanie"];
            List<int> studyYears = [2, 1, 3, 2, 1, 2, 3, 2];
            List<double> avarageGrades = [4.5, 3.5, 5.0, 2.0, 4.0, 3.0, 4.8, 3.8];

            // Słownik łączy numer indeksu z pozycją studenta na listach
            Dictionary<int, int> studentPositions = new();
            for (int i = 0; i < indexNumbers.Count; i++)
            {
                studentPositions[indexNumbers[i]] = i;
            }

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\n=== Baza studentów ===");
                Console.WriteLine("1. Wyświetl wszystkich studentów");
                Console.WriteLine("2. Wyszukaj studenta po numerze indeksu");
                Console.WriteLine("3. Wyszukaj po nazwisku");
                Console.WriteLine("4. Filtruj według kierunku");
                Console.WriteLine("5. Filtruj według minimalnej średniej");
                Console.WriteLine("6. Zlicz studentów na kierunkach");
                Console.WriteLine("7. Oblicz średnią ocen na kierunkach");
                Console.WriteLine("8. Dodaj studenta");
                Console.WriteLine("9. Usuń studenta");
                Console.WriteLine("0. Zakończ");
                Console.Write("Wybierz opcję: ");

                string option = Console.ReadLine() ?? "";

                switch(option)
                {
                    case "1":
                        ShowStudents(Enumerable.Range(0, indexNumbers.Count));
                        break;
                    case "2":
                        FindStudentByIndex();
                        break;
                    case "3":
                        FindStudentByLastName();
                        break;
                    case "4":
                        FilterStudentByMajor();
                        break;
                    case "5":
                        FindStudentByGrade();
                        break;
                    case "6":
                        CountStudentsByMajor();
                        break;
                    case "7":
                        CalculateAverageByMajor();
                        break;
                    case "8":
                        AddStudent();
                        break;
                    case "9":
                        RemoveStudent();
                        break;
                    case "0":
                        isRunning = false;
                        Console.WriteLine("Koniec programu");
                        break;
                    default:
                        Console.WriteLine("Nie ma takiej opcji");
                        break;
                }
            }
              void ShowStudents(IEnumerable<int> positions)
              {
                Console.WriteLine("\nIndeks | Imię i nazwisko        | Kierunek      | Rok | Średnia");
                Console.WriteLine("_______+________________________+_______________+_____+________");
                foreach (int i in positions)
                {
                    Console.WriteLine($"{indexNumbers[i],6} | {(firstNames[i] + " " +lastNames[i]),-22} | " + $"{majors[i], -13} | {studyYears[i],3} | {avarageGrades[i],6:F2}");
                }
              }

        }

        private static void RemoveStudent()
        {
            throw new NotImplementedException();
        }

        private static void AddStudent()
        {
            throw new NotImplementedException();
        }

        private static void CalculateAverageByMajor()
        {
            throw new NotImplementedException();
        }

        private static void CountStudentsByMajor()
        {
            throw new NotImplementedException();
        }

        private static void FindStudentByGrade()
        {
            throw new NotImplementedException();
        }

        private static void FilterStudentByMajor()
        {
            throw new NotImplementedException();
        }

        private static void FindStudentByLastName()
        {
            throw new NotImplementedException();
        }

        private static void FindStudentByIndex()
        {
            throw new NotImplementedException();
        }

        
    }
}
