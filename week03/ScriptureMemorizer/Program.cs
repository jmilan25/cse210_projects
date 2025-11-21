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

        // Console.WriteLine(new Scripture(_reference, scriptureVerse).GetDisplayText());
        Scripture verse = new Scripture(_reference, scriptureVerse);
        string _verse = verse.GetDisplayText();

        string _quit = "test";

        while (_quit != "quit")
        {
            Console.Clear();
            Console.WriteLine(_verse);
            // End(_verse);
            Console.Write("Press enter to hide words or type \"quit\" to exit: ");


            _quit = Console.ReadLine(); // exit DO NOT DELETE
        }
        

        
        
        

    }
    // static void End(string text)
    // {
    //     Console.WriteLine(text);
    //     // Console.Write("Press enter to hide words or type \"quit\" to exit: ");
    //     // string _quit = Console.ReadLine();
        
        

    // }
    

}























// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello World! This is the Sandbox Project.");
//     }
// }