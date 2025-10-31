using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int x = randomGenerator.Next(1, 100);

        int y = -1;
        
        while (x != y)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            y = int.Parse(guess);

            if (y > x)
            {
                Console.WriteLine("lower");
            }
            else if (y < x)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
            

    }
}