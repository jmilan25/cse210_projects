using System;

public class Scripture
{

    private Reference _reference;
    private string _text;

    // List<string> _words = new List<string>();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;

    }
    public void HideRandomWords(int numberToHide)
    {
        
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