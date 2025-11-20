using System;

public class Scripture
{

    private Reference _reference;
    private string _text;

    List<string> _words = new List<string>();



    // public static void reference()
    // {
    //     Reference r1 = new Reference("John", 3, 16);
    //     Console.Write($"\n{r1.GetDisplayText()} ");
    //     Console.WriteLine("For God so loved the world, \nthat he gave his only begotten Son, \nthat whosoever believeth in him should not perish, \nbut have everlasting life.\n");


    // }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;

    }
    public void HideRandomWords(int numberToHide)
    {
        
    }
    // public string GetDisplayText()
    // {

    // }
    // public bool isCompletelyHidden()
    // {
        
    // }
        



    // foreach (string word in text)
    // {
    //     _words.Add(word);
    // }
}