using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager goal = new GoalManager();

        goal.Start();

    }

    // public static void Goal()
    // {
    //     Console.WriteLine("Types of Goals:");
    //     Console.WriteLine("(1) Simple Goal");
    //     Console.WriteLine("(2) Eternal Goal");
    //     Console.WriteLine("(3) Checklist Goal");
    //     Console.Write("What kind of Goal would you like to create? ");
    //     string entry = Console.ReadLine();

    //     if (entry == "1")
    //     {
    //         Console.WriteLine("Simple Goal");   
    //     }
    //     else if (entry == "2")
    //     {
    //         Console.WriteLine("Eternal Goal");   
    //     }
    //     else if (entry == "3")
    //     {
    //         Console.WriteLine("Checklist Goal");   
    //     }

    // }
}