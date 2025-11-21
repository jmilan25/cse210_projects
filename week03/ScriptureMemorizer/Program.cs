using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Clear();
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        string scriptureVerse = "For God so loved the world , " +
                        "that he gave his only begotten Son , " +
                        "that whosoever believeth in him should not perish , " +
                        "but have everlasting life.";
        Reference reference = new Reference("John", 3, 16);
        string _reference = reference.GetDisplayText();
        Scripture verse = new Scripture(_reference, scriptureVerse);
        string border = "|------------------------------------------------|";

        // List<int> numbers = new List<int>();
        // int sum = 0;
        // List<Word> _words = new List<Word>();


        string _quit = "test";

        while (_quit != "quit")
        {
            Console.Clear(); // to clear previous itterations


            // Console.WriteLine(_verse);
            Console.WriteLine($"{border}"); 

            string _verse = verse.GetDisplayText();

            Console.WriteLine($"\n{border}\n");


            Console.Write("Press enter to hide words or type \"quit\" to exit: ");
            _quit = Console.ReadLine(); // exit DO NOT DELETE
            if (_quit == "")
            {
                verse.IncreaseChance();
            }
        

        }
        Console.Clear();
        

        

    }

    

}























// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello World! This is the Sandbox Project.");
//     }
// }