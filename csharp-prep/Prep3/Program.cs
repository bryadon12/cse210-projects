using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the magic number! (1-100)");
        int magicNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Guess the Magic Number!");
        int guess = int.Parse(Console.ReadLine());
        if (guess == magicNumber)
        {
            Console.WriteLine("You Guessed It!!!");
        }
        else if (guess < magicNumber)
        {
            Console.WriteLine("Too Small!");
        }
        else
        {
            Console.WriteLine("Too Big");
        }
    }
}