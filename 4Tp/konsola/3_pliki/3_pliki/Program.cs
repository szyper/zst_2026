namespace _3_pliki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\xampp\\htdocs\\git\\zst_2026\\4Tp\\konsola\\3_pliki\\3_pliki\\file.txt";
            StreamWriter sw;

            if (!File.Exists(path))
            {
                Console.WriteLine("Brak pliku");
                sw = File.CreateText(path);
            }
            else
            {
                Console.WriteLine("Plik istnieje");
                //sw = new StreamWriter(path); // nadpisuje
                sw = new StreamWriter(path, true); // dopisanie
            }

            Console.Write("Podaj tekst: ");
            string? text = Console.ReadLine();
            sw.WriteLine(text);
            sw.Close();

            StreamReader sr = File.OpenText(path);
            string? line = "";
            int? count = 1;

            Console.WriteLine("\n\nZawartość pliku:");
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(count++ + " linia: " + line);
            }

            sr.Close();

        }
    }
}
