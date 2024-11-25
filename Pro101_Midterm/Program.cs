using System.Runtime.CompilerServices;

namespace Pro101_Midterm;

class Program
{
    static void Main(string[] args)
    {
        Student Mohammed = new()
        {
            Name = "Mohammed",
            Age = 28,
            Grade = "Exceptional"
        };
        Student Ahmed = new()
        {
            Name = "Ahmed",
            Age = 22,
            Grade = "Excellent"
        };
        Student Ali = new()
        {
            Name = "Ali",
            Age = 25,
            Grade = "Good"
        };

        Mohammed.DisplayInfo();
        Ahmed.DisplayInfo();
        Ali.DisplayInfo();
    }
}

class Student
{
    public required string Name;
    public required int Age;
    public required string Grade;

    public void DisplayInfo(){
        Console.WriteLine($"Name: {this.Name}, Age: {this.Age}, Grade: {this.Grade}");
    }
}