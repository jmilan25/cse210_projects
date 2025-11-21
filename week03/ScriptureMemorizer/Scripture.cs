using System;

public class Scripture
{
    private string _reference;
    private string _verse;
    private int _number;
    List<Word> _words = new List<Word>();

    public Scripture(string reference, string verse)
    {
        _reference = reference;
        _verse = verse;
    }

    public int HideRandomWords(int numberToHide)
    {
        _number = numberToHide;
        return _number;

    }

    public string GetDisplayText()
    {

        string[] splitWords = _verse.Split(' ');
        string border = "|------------------------------------------------|";

        Console.WriteLine($"{border}");
        foreach (string s in splitWords)
        {
        
            if (s == ",")
            {
                Console.Write($"\b,\n");

            }
            else
            {
                Random randomGenerator = new Random();
                int x = randomGenerator.Next(1, 101);
                if (_number > HideRandomWords(x))
                {
                    x = _number;
                }


                Console.Write($"{s} ");
                _words.Add(new Word(s));

            }


        }
        Console.WriteLine($"\n{border}\n");



        return $"{_reference} - {_verse}";
    }

    // public string GetDisplayText()
    // {
    //     return $"{_reference} - {_verse}";
    // }
}
