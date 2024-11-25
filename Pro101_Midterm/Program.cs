using System;
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

        Array Array1 = new();
        Console.Write("Enter a number to square: ");
        int input = Convert.ToInt32(Console.ReadLine());
        Squared(input);

        NumState numState1 = new();
        DayPrinter day = new();
        Player player = new();

    }
    static void Squared(int input){
        Squared num = new(input);
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

class Array
{
        public int[] numbers = [1,2,3,4,5];
        public Array(){
            Console.WriteLine("Array Elements:");
            foreach (int num in this.numbers){
                Console.WriteLine(num);
            }
            Console.WriteLine($"Array sum = {this.numbers.Sum()}");
        }
}

class Squared
{
    private int num;

    public Squared(int num)
    {
        this.num = num;
        Console.WriteLine($"Your number squared = {this.num*this.num}");
    }
}

class NumState
{
    private int input;
    public NumState(){
        Console.WriteLine("Enter a number to check its state :\"(");
        this.input = Convert.ToInt32(Console.ReadLine());
        if(input < 0){
            Console.WriteLine("Your Number is NEGATIVE!!, Positivity is important in life :)");
        }
        else if(input >0){
            Console.WriteLine("Your Number is POSITIVE!!, Being more critical is a good trait to have :D");
        }
        else{
            Console.WriteLine("Your number is ZERO!! I guess it is okay to take it easy in life sometimes ;)");
        }
    }
}

class DayPrinter
{
    enum Days{Monday, Tuesday, Wedensday, Thursday, Friday, Saturday, Sunday};
    public DayPrinter(){
        Console.WriteLine("Enter a Number between 1 and 7 (Inclusive): ");
        int input = Convert.ToInt32(Console.ReadLine());
        switch (input){
            case 1:
                Console.WriteLine(Days.Monday);
                break;
            case 2:
                Console.WriteLine(Days.Tuesday);
                break;
            case 3:
                Console.WriteLine(Days.Wedensday);
                break;
            case 4:
                Console.WriteLine(Days.Thursday);
                break;
            case 5:
                Console.WriteLine(Days.Friday);
                break;
            case 6:
                Console.WriteLine(Days.Saturday);
                break;
            case 7:
                Console.WriteLine(Days.Sunday);
                break;
            default:
                Console.WriteLine("WRONG INPUT!!");
                break;
        }
    }
}

class Player
{
    private string name;
    private int age;
    private double wage;
    public Player(){
        Console.WriteLine("Please enter your name:");
        name = Console.ReadLine();
        Console.WriteLine("Please enter your age:");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter your wage:");
        wage = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Hi, my name is {this.name}. I am {this.age} years old and earn ${this.wage} per hour.");
    }
}