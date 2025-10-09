using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment assignment = new Assignment();
        // Console.WriteLine(assignment.GetSummary());
        // assignment.SetName("Braydon");
        // assignment.SetTopic("Inheratence");
        // Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment();
        Console.WriteLine(mathAssignment.GetHomeworkList());

        mathAssignment.SetTextbookSelection("Calculus");
        mathAssignment.SetProblems("1-12");
        mathAssignment.SetName("Braydon");
        mathAssignment.SetTopic("Integration");

        Console.WriteLine(mathAssignment.GetHomeworkList());

    }
}