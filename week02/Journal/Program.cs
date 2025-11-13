using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        prompt();

    }

    static void prompt()
    {
        Console.WriteLine("Please select the following choices");

        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Exit");

        Console.WriteLine("6. again");

        Console.Write("What would you like to do? ");
        string user_response = Console.ReadLine();


        // prompt again if user enters 6
        if (user_response == "6")
        {
            prompt();
        }
        // if user wants to add an entry 
        else if (user_response == "1")
        {
            Editor.WriteEntry();
        }
        // Display journal
        else if (user_response == "2")
        {
            Editor.DisplayEntry();
        }


        // test this if variable works 
        // Console.WriteLine(user_response);
        
    }
}