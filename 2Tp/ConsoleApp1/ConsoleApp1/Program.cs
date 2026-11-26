using System.Globalization;

namespace ConsoleApp1;

class Program
{
    public delegate void NotificationHandler(string message);
    
    public class User
    {
        public string Name { get; set; }
        public int Priority { get; set; } // Priorytet użytkownika (1 - wysoki, 2 - średni, 3 - niski).
    }
    
    public interface INotifier
    {
        void Notify(string message);
    }

    public class EmailNotifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Email wysłany: {message}");
        }
    }

    public class SMSNotifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine($"SMS wysłany: {message}");
        }
    }

    public class PushNotifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Powiadomienie Push wysłane: {message}");
        }
    }

    public class NotificationManager
    {
        public NotificationHandler Notify;
        
        private Dictionary<string, User> users = new Dictionary<string, User>();

        private List<INotifier> notifiers = new List<INotifier>();

        public void AddUser(string name, int priority)
        {
            if (!users.ContainsKey(name))
            {
                users[name] = new User { Name = name, Priority = priority };
                Console.WriteLine($"Dodano użytkownika: {name} z priorytetem {priority}");
            }
            else
            {
                Console.WriteLine($"Użytkownik {name} już istnieje");
            }
        }

        public void RemoveUser(string name)
        {
            if (users.Remove(name))
            {
                Console.WriteLine($"Usunięto użytkownika : {name}");
            }
            else
            {
                Console.WriteLine($"Użytkownik {name} nie istnieje");
            }
        }

        public User GetUserByName(string name)
        {
            if (users.TryGetValue(name, out User user))
            {
                return user;
            }

            return null;
        }

        public void ListUsers()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("Brak użytkowników");
                return;
            }

            Console.WriteLine("Lista użytkowników:");
            int index = 1;

            foreach (var user in users)
            {
                Console.WriteLine($"{index}. {user.Value.Name} (priorytet: {user.Value.Priority})");
                index++;
            }
        }

        public void SendNotification(string message, int priority)
        {
            if (notifiers.Count == 0)
            {
                Console.WriteLine("Brak dostępnych metod powiadomień");
                return;
            }
            
            var filteredUsers = new List<User>(users.Values).FindAll(u => u.Priority <= priority);

            if (filteredUsers.Count == 0)
            {
                Console.WriteLine($"Brak użytkowników z priorytetem równym lub wyższym niż {priority}");
                return;
            }

            Console.WriteLine($"Wiadomość: \"{message}\"");

            foreach (var notifier in notifiers)
            {
                notifier.Notify(message);
            }

            Console.WriteLine("Powiadomienie zostało wysłane do:");
            foreach (var user in filteredUsers)
            {
                Console.WriteLine($"- {user.Name} (priorytet: {user.Priority})");
            }
        }

        public void AddNotifier(INotifier notifier)
        {
            if (!notifiers.Contains(notifier))
            {
                notifiers.Add(notifier);
                Console.WriteLine("Metoda powiadomienia została dodana");
            }
            else
            {
                Console.WriteLine("Ta metoda powiadomienia już istnieje");
            }
        }

        public void RemoveNotifier(INotifier notifier)
        {
            if (notifiers.Remove(notifier))
            {
                Console.WriteLine("Metoda powiadomienia została usunięta");
            }
            else
            {
                Console.WriteLine("Nie znaleziono tej metody powiadomienia");
            }
        }

        public void ListNotifiers()
        {
            if (notifiers.Count == 0)
            {
                Console.WriteLine("Brak dostępnych metod powiadamiana");
                return;
            }

            Console.WriteLine("Dostępne metody powiadamiania");
            foreach (var notifier in notifiers)
            {
                Console.WriteLine(notifier.GetType().Name);
            }
        }
    }
    
    static void Main(string[] args)
    {
        var notificationManager = new NotificationManager();
        
        var emailNotifier = new EmailNotifier();
        var smsNotifier = new SMSNotifier();
        var pushNotifier = new PushNotifier();

        while (true)
        {
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Dodaj użytkownika");
            Console.WriteLine("2. Usuń użytkownika");
            Console.WriteLine("3. Wyślij powiadomienie do użytkownika");
            Console.WriteLine("4. Wyświetl użytkowników");
            Console.WriteLine("5. Dodaj metodę powiadomień");
            Console.WriteLine("6. Usuń metode powiadomień");
            Console.WriteLine("7. Wyśietl metody powiadomień");
            Console.WriteLine("8. Wyjdź");
            Console.WriteLine("Wybierz opcję: ");
            
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                Console.Write("Podaj nazwisko użytkownika: ");
                string name  = Console.ReadLine();
                Console.WriteLine("Podaj priorytet użytkownika (1 - wysoki, 2 - średni, 3 - niski: )");
                int priority = int.Parse(Console.ReadLine());
                notificationManager.AddUser(name, priority);
                break;
                
                
            }
        }
    }
}