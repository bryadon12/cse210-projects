using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
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
        Console.WriteLine("You Guessed It!!!");
    }
}