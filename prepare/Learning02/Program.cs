using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "microsoft";
        job1._jobTitle = "Software Engineer";
        job1._yearStart = 2015;
        job1._yearEnd = 2022;

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Software Engineer";
        job2._yearStart = 2010;
        job2._yearEnd = 2015;

        Console.WriteLine(job1._company);
        Console.WriteLine(job2._company);
    }
}