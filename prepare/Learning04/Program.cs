using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment assignment = new Assignment();
        // Console.WriteLine(assignment.GetSummary());
        // assignment.SetName("Braydon");
        // assignment.SetTopic("Inheratence");

        Assignment assignment = new Assignment("Braydon", "Inheratence");

        Console.WriteLine(assignment.GetSummary());

        // MathAssignment mathAssignment = new MathAssignment();
        // Console.WriteLine(mathAssignment.GetHomeworkList());

        // mathAssignment.SetTextbookSelection("Calculus");
        // mathAssignment.SetProblems("1-12");
        // mathAssignment.SetName("Braydon");
        // mathAssignment.SetTopic("Integration");

        MathAssignment mathAssignment = new MathAssignment("Braydon", "Calculus", "CalcBook", "1-11");

        Console.WriteLine(mathAssignment.GetHomeworkList());

        // WritingAssignment writingAssignment = new WritingAssignment();
        // Console.WriteLine(writingAssignment.GetWritingInformation());

        // writingAssignment.SetTitle("Desk Chairs : Do we need them?");
        // writingAssignment.SetName("Braydon");
        // writingAssignment.SetTopic("Essay");

        WritingAssignment writingAssignment = new WritingAssignment("Braydon", "Essay", "Hamburgers...Yummy!");

        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}