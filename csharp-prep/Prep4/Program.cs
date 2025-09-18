using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        do
        {
            Console.WriteLine("Enter Nmber: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        } while (number != 0);
        Console.WriteLine("Hello Prep4 World!");
    }
}