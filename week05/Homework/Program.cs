using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        MathAssignment math = new MathAssignment("Robert Rodriguez", "fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment write = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(write.GetSummary());
        Console.WriteLine(write.GetWritingInformation());


    }

}