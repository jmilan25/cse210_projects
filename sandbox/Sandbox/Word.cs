public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        if (_isHidden is true)
        {
            Show(text);
        }
        else
        {
            _isHidden = false;
            
        }

    }

    public void Hide(string text)
    {
        // Console.Clear();
        text = "___";
        _isHidden = true;
    }
    public void Show(string text)
    {
        Console.Write(text);
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden = true;
    }

    public string GetDisplay()
    {
        return _text;
    }
}