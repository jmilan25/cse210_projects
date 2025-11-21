public class Word
{
    private string _text;
    private string _update;
    private bool _isHidden;



    public Word(string text)
    {
        _text = text;
        _update = text;
        _isHidden = false;

        // foreach (string word in text);
        // {
            
        // }

    }

    public void Hide()
    {
        if (!_isHidden)
        {
            _update = "___";
            _isHidden = true;
        }
    }
    public void Show()
    {
        if (_isHidden)
        {
            _update = _text;
            _isHidden = false;
        }
        // _text = text;
        // // Console.Write(text);
        // _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplay()
    {
        return _update;
    }
}