using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        int sum = 0;
        do
        {
            Console.WriteLine("Enter Nmber: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        } while (number != 0);
        foreach (int value in numbers)
        {
            sum += value;
        }
        Console.WriteLine($"The sum is {sum}");
    }
}