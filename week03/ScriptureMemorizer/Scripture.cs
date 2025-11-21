using System;

public class Scripture
{

    private Reference _reference;
    private string _text;
    // private string scriptureVerse = "For God so loved the world , " +
    //                     "that he gave his only begotten Son , " +
    //                     "that whosoever believeth in him should not perish , " +
    //                     "but have everlasting life.";

    List<Word> _words = new List<Word>();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;

    }
    public void HideRandomWords(int numberToHide)
    {
        // // string[] splitWords = scriptureVerse.Split(' ');
        // string border = "|------------------------------------------------|";

        // Console.WriteLine($"\n{border}");
        // foreach (string s in splitWords)
        // {
        //     if (s == ",")
        //     {
        //         Console.Write($"\b,\n");

        //     }
        //     else
        //     {

        //         Console.Write($"{s} ");
        //         _words.Add(new Word(s));

        //     }


        // }
        // Console.WriteLine($"\n{border}\n");
    }
    public string GetDisplayText()
    {
        
        string text = $"{_reference} {_text}";
        return text;
    }
    public bool IsCompletelyHidden()
    {
        bool text = true;
        return text;
    }
    

}