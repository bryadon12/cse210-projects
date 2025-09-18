using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter your favorite number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the year you were born");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine($"Your number squared is {number * number}");
        Console.WriteLine($"You turn {2025 - year} this year");
    }
}