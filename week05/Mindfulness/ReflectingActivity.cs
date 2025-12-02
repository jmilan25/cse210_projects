public class ReflectingActivity : Activity
{
    List<string> _prompts = new List<string>();
    List<string> _question = new List<string>();
    public ReflectingActivity(string name, string description, int duration)
        : base (name,description,duration)
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times ...";
        _duration = 50;

    }
    public void run()
    {

    }
    public string GetRandomPrompt()
    {
        return "";
    }
    public string GetRandomQuestion()
    {
        return "";
    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestions()
    {

    }
    
}