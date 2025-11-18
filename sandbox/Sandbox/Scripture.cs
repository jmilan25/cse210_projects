using System;

public class Scripture
{

    List<string> _words = new List<string>();



    public static void reference()
    {
        Reference r1 = new Reference("john", 3, 16);
        Console.WriteLine(r1.GetDisplayText());

        
        
    }
        



    // foreach (string word in text)
    // {
    //     _words.Add(word);
    // }
}