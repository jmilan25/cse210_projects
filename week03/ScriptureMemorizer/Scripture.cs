using System;

public class Scripture
{
    private string _reference;
    private string _verse;
    private int _number;

    public Scripture(string reference, string verse)
    {
        _reference = reference;
        _verse = verse;
    }

    public int HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new Random();
        int x = randomGenerator.Next(1, numberToHide);
        Console.WriteLine(x);

        _number = numberToHide;
        return _number;
    }

    public string GetDisplayText()
    {
        return $"{_reference} - {_verse}";
    }
}
