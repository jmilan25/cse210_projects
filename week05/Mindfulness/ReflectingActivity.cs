public class ReflectingActivity : Activity
{
    List<string> _prompts = new List<string>();
    List<string> _question = new List<string>();
    Random random = new Random();
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect " +
            "\non times in your life when you have shown " +
            "\nstrength and resilience. This will help you " +
            "\nrecognize the power you have and how you can " +
            "\nuse it in other aspects of your life.";

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _question.Add("Why was this experience meaningful to you?");
        _question.Add("Have you ever done anything like this before?");
        _question.Add("How did you get started?");
        _question.Add("How did you feel when it was complete?");
        _question.Add("What made this time different than other times when you were not as successful?");
        _question.Add("What is your favorite thing about this experience?");
        _question.Add("What could you learn from this experience that applies to other situations?");
        _question.Add("What did you learn about yourself through this experience?");
        _question.Add("How can you keep this experience in mind in the future?");

        // _time = 50;

    }
    public void Run(int _time)
    {
        Console.Clear();
        Console.Write("Get Ready ");
        Activity activity = new Activity();
        activity.ShowSpinner(3);

        Console.WriteLine("\n\nConsider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions\nas they are related to this experience.");

        Console.Write("Now you may begin ");
        activity.ShowCountDown(5);

        Console.Clear();
        DisplayQuestions(_time);
        DisplayQuestions(_time);
        

    }
    public string GetRandomPrompt()
    {
        int x = random.Next(0,4); 
        return _prompts[x];
    }
    public string GetRandomQuestion()
    {
        int x = random.Next(0, 9);
        return _question[x];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"\n——— {GetRandomPrompt()} ———");
    }
    public void DisplayQuestions(int duration)
    {
        Activity activity = new Activity();
        Console.Write($"> {GetRandomQuestion()} ");
        activity.ShowSpinner(duration);
        Console.WriteLine();
    }
    
}