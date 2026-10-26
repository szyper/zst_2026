using System.Text.Json;
using System.Text.Json.Nodes;

namespace _2_serializacja_ex
{
    internal class Program
    {
        class Student
        {
            public string name { get; set; }
            public string surname { get; set; }
            public int age { get; set; }
            public string className { get; set;  }

            public int studentID { get; set; }
            public double AverageGrade { get; set; }
            public bool isValid { get; set; }
        }
        static void Main(string[] args)
        {
            Console.Write("\n=== Elektroniczna legitymacja ===\n");

            Console.Write("Podaj imie: ");
            string name = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            string surname = Console.ReadLine();

            Console.Write("Podaj wiek: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Podaj klasę: ");
            string className = Console.ReadLine();

            Console.Write("Podaj średnią ocen: ");
            double.TryParse(Console.ReadLine(), out double AverageGrade);

            bool isValid = age < 20;

            Random random = new Random();
            int studendID = random.Next(1000, 10000);

            Student student = new Student
            {
                name = name,
                surname = surname,
                age = age,
                className = className,
                studentID = studendID,
                AverageGrade = AverageGrade,
            };

            Console.Write("\n=== DANE LEGITYMACJI ===\n");
            Console.Write($"Imię: {student.name}\n");
            Console.Write($"Nazwisko: {student.surname}\n");
            Console.Write($"Wiek: {student.age} \n");
            Console.Write($"Klasa: {student.className} \n");
            Console.Write($"Numer legitymacji: {student.studentID} \n");
            Console.Write($"Średnia ocen: {student.AverageGrade}  \n");
            Console.Write($"Ważna: {student.isValid}  \n");

            Console.Write("\n === Serializacja json ===\n");

            string json = JsonSerializer.Serialize( student, new JsonSerializerOptions { WriteIndented = true} );

            Console.WriteLine(json);

            Student student2 = JsonSerializer.Deserialize<Student>(json);
            Student student3 = student;

            Console.WriteLine("\n==== DESERIALIZACJA ====\n");
            Console.Write($"Imię: {student2.name}\n");
            Console.Write($"Nazwisko: {student2.surname}\n");
            Console.Write($"Numer legitymacji: {student.studentID}\n");
            Console.Write($"Klasa: {student2.className}\n");

            Console.WriteLine($"Czy to ten sam obiekt? {ReferenceEquals(student,student3)}");
            Console.WriteLine($"Czy to ten sam obiekt? {ReferenceEquals(student,student2)}");

        }
    }
}
