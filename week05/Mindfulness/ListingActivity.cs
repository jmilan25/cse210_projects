public class ListingActivity : Activity
{
    private int _count;
    List<string> _prompts = new List<string>();
    Random random = new Random();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the " +
            "\ngood things in your life by having you list " +
            "\nas many things as you can in a certain area.";

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

    }

    public void Run(int duration)
    {
        Console.Clear();
        Console.Write("Get Ready ");
        Activity activity = new Activity();
        activity.ShowSpinner(3);

        Console.WriteLine("List as many responses you can to the following prompt: ");
        GetRandomPrompt();
        Console.Write("You may begin in ");
        activity.ShowCountDown(5);
        GetListFromUser(duration);


        
    }
    public void GetRandomPrompt()
    {
        int x = random.Next(0, 4);
        Console.WriteLine($"\n——— {_prompts[x]} ———");
    }
    
    public List<string> GetListFromUser(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        List<string> _input = new List<string>();

        string input = "hi";
        while (DateTime.Now < endTime)
        {
            Console.Write(">\n\t");
            input = Console.ReadLine();
            _input.Add(input);
            
        }
        return _input;
    }
}