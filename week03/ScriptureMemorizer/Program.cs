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
        // int _random = verse.HideRandomWords(numberToHide);
        // int numberToHide;

        

        

        string _quit = "test";
        List<Word> _words = new List<Word>();

        while (_quit != "quit")
        {
            Console.Clear();

            string[] splitWords = _verse.Split(' ');
            string border = "|------------------------------------------------|";

            Console.WriteLine($"\n{border}");
            foreach (string s in splitWords)
            {
                if (s == ",")
                {
                    Console.Write($"\b,\n");

                }
                else
                {
                    if (s != "___")
                    {
                        Word Word = new Word(s);
                        s = "___";

                    }

                    else
                    {
                        Console.Write($"{s} ");
                        _words.Add(new Word(s));
                        
                    }

                }


            }
            Console.WriteLine($"\n{border}\n");




            // Console.WriteLine(_verse);
            Console.Write("Press enter to hide words or type \"quit\" to exit: ");
            
            // End(_verse);


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