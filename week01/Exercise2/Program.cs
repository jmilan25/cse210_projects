using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("grade: ");
        string input = Console.ReadLine();
        
        int x = int.Parse(input);

        if (x >= 90)
        {
            Console.WriteLine("You got an A");
        }
        else if (x >= 80)
        {
            Console.WriteLine("You got a B");
        }
        else if (x >= 70)
        {
            Console.WriteLine("You got a C");
        }
        else if (x >= 60)
        {
            Console.WriteLine("You got a D");
        }
        else
        {
            Console.WriteLine("You got an F");
        }

        if (x >= 70)
        {
            Console.Write("YOU PASSED!");
        }

        else
        {
            Console.Write("you failed... I'm sorry");
        }
    }
}