public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_name}!\n");
        Console.WriteLine(_description);
        Console.WriteLine();
        
    }
    public void DisplayEndingMessage()
    {

    }
    public void ShowSpinner(int seconds)
    {

    }
    public void ShowCountDown(int seconds)
    {
        
    }
}