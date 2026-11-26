namespace _12_wlasciwosci;

public class Student
{
    // pola
    private string firstName = "";
    private string lastName = "";
    private int age;
    private double averageGrade;
    
    // właściwości
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public double AverageGrade
    {
        get { return averageGrade; }
        set { averageGrade = value; }
    }

} 
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

        student.FirstName = "Janusz";
        student.LastName = "Kowalski";
        student.Age = 20;
        student.AverageGrade = 4.5;
        
        Console.WriteLine("Imię: {$student.AverageGrade}");
        
    }
}