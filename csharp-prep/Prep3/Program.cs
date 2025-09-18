using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the magic number! (1-100)");
        int magicNumber = int.Parse(Console.ReadLine());
        int guess;
        do
        {
            Console.WriteLine("Guess the Magic Number!");
            guess = int.Parse(Console.ReadLine());
            if (guess < magicNumber)
            {
                Console.WriteLine("Too Small!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Too Big");
            }
        } while (guess != magicNumber);
    }
}