using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new("Samuel Bennett", "Multipication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignments writingAssignment = new("Mary Waters", "European History", "The Causes of World War II");
        writingAssignment.GetSummary();
        writingAssignment.GetWritingInformation();
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());



    }
}