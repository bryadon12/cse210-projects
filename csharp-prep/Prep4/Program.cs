using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        int sum = 0;
        int large;
        do
        {
            Console.WriteLine("Enter Nmber: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        } while (number != 0);
        large = number;
        foreach (int value in numbers)
        {
            sum += value;
            if (value > large)
            {
                large = value;
            }
        }
        int average = sum / (numbers.Count()-1);
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {large}");
    }
}