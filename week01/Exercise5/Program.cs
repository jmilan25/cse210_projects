using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        Console.WriteLine("Welcome to the program!");
        string name = PromptUserName();
        int number = PromptUserNumber();
        int snumber = SquareNumber(number);
        DisplayResult(name, snumber);

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string number = Console.ReadLine();
            int y = int.Parse(number);
            return y;
        }

        static int SquareNumber(int number)
        {
            int sum = number * number;
            return sum;
        }

        static void DisplayResult(string name, int sum)
        {

            Console.WriteLine($"{name}, the square of your number is {sum}");
        }











        // static void DisplayResult(string PromptUserName, int PromptUserNumber, int SquareNumber)
        // static void DisplayResult()
        // {




        // }

        // DisplayResult();

    }
}