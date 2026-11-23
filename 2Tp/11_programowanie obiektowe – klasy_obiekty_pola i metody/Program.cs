namespace _11_programowanie_obiektowe___klasy_obiekty_pola_i_metody
{
    internal class Program
    {
        public class Person
        {
            // pole instancyjne
            // public string Name = "";
            // string? oznacza, że pole Name może mieć wartość null, czyli na początku może nie byćustawione
            public string? Name;
        }
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Franek";

            Person p2 = new Person();
            p2.Name = p1.Name;

            if (p1.Name is null)
            {
                Console.WriteLine("Imię nie zostało utworzone");
            } else
            {
                Console.WriteLine(p1.Name);
            }

            Console.WriteLine();
            Console.WriteLine(p2.Name);

            Console.WriteLine();
            p2.Name = "Tomasz";
            Console.WriteLine(p1.Name);
            Console.WriteLine(p2.Name);
        }
    }
}
