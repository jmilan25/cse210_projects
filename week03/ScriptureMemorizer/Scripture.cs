using System;

public class Scripture
{
    private string _reference;
    private string _verse;
    private int _number;
    private int _chance = 0;
    // private int _roll;
    // private int _sum;
    
    // private int _random;
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
        // int x = 20;
        Console.Write($"{_reference} ");


        string[] splitWords = _verse.Split(' ');
        foreach (string s in splitWords)
        {

            if (s == ",")
            {
                Console.Write($"\b,\n");

            }
            else
            {

                Random randomGenerator = new Random();
                int _roll = randomGenerator.Next(1, 101);

                if (_roll <= _chance)
                {

                    Console.Write($"___ ");
                    _words.Add(new Word("___"));
                    // HideRandomWords(20);
                }
                else
                {
                    Console.Write($"{s} ");
                    // return s;
                    _words.Add(new Word(s));
                    // _sum += _roll;



                }


            }


        }


        return $"{_reference} - {_verse}";
    }
        public void IncreaseChance()
    {
        _chance += 10;
        if (_chance > 100)
            _chance = 100;
    }

    // public string GetDisplayText()
    // {
    //     return $"{_reference} - {_verse}";
    // }
}
