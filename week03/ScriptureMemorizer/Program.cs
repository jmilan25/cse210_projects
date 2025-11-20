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
                                
        string[] splitWords = scriptureVerse.Split(' ');

        // Word word = new Word(scriptureVerse);
        string border = "|------------------------------------------------|";
        List<Word> words = new List<Word>();

        Console.WriteLine($"\n{border}");
        foreach (string s in splitWords)
        {
            if (s == ",")
            {
                Console.Write($"\b,\n");

            }
            else
            {
                if (s == "___")  //is hidden
                {
                    Word hidden = new Word(s);
                    Console.Write($"{hidden.IsHidden} ");
                }
                else
                {
                    Console.Write($"{s} ");
                    words.Add(new Word(s));
                    
                }

            }


        }
        Console.WriteLine($"\n{border}\n");
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