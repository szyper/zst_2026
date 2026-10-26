using System.Text.Json;
namespace _2_serializacja
{
    internal class Program
    {
        class Student
        {
            public string name { get; set; }
            public int age { get; set; }
            public string className { get; set; }
        }
        static void Main(string[] args)
        {
            Student student = new Student
            {
                name = "Janusz",
                age = 20,
                className = "4Tp"
            };

            string json = JsonSerializer.Serialize(student);

            Console.WriteLine(json);

        }
    }
}
