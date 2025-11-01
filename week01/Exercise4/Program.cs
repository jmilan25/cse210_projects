using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int y = -1;
        int sum = 0;

        while (y != 0)
        {

            Console.Write("Enter a number (0 to quit): ");   
            string x = Console.ReadLine();
            y = int.Parse(x);
            numbers.Add(y);
        }

        foreach (int number in numbers)
        {

            sum += number;
            
            //Console.WriteLine($" test {number}");


        }
        Console.WriteLine($"The sum is: {sum}");


    }
}