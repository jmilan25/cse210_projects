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
        Reference r = new Reference("John", 3, 16);

        // string _reference = new Reference("John", 3, 16).GetDisplayText();
        Scripture s = new Scripture(r, scriptureVerse).GetDisplayText();
        Console.WriteLine(s);
        // Console.WriteLine(new Scripture(_reference,scriptureVerse).GetDisplayText());
        // Console.WriteLine(new Scripture(r, scriptureVerse).GetDisplayText());
        
        
        

    }
    static void End()
    {
        Console.Write("Press enter to hide words or type \"quit\" to exit");
        string _quit = Console.ReadLine();
        if (_quit != "quit")
        {
            // repeat
        }

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