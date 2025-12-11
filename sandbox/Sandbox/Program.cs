using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Sandbox Project.");
        Start();


    }
    static void Start()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine("Please select the following choices");

        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("What would you like to do? ");
        string userResponse = Console.ReadLine();
        PromptGenerator prompt = new PromptGenerator();
        Journal journal = new Journal();
        Entry entry = new Entry();


        // prompt again if user enters 6
        if (userResponse == "1")
        {
            entry._date = dateText;
            entry._promptText = prompt.GetRandomPrompt();
            Console.WriteLine(entry._promptText);
            string _userEntry = Console.ReadLine();
            entry._entryText = _userEntry;
            journal.AddEntry(entry);
            Start();
            
        }
        else if (userResponse == "2")
        {
            journal.DisplayAll();
            Start();
        }

    }
    
}