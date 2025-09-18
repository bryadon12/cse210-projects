using System;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade;
        Console.WriteLine("Please enter a grade (0-100)");
        int grade = int.Parse(Console.ReadLine());
        if (grade < 60)
        {
            letterGrade = "F";
        }
        else if (grade < 70)
        {
            letterGrade = "D";
        }
        else if (grade < 80)
        {
            letterGrade = "C";
        }
        else if (grade < 90)
        {
            letterGrade = "B";
        }
        else
        {
            letterGrade = "A";
        }
        Console.WriteLine(letterGrade);
    }
}