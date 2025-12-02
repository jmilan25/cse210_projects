public class Activity
{
    protected string _name ="";
    protected string _description;
    protected int _duration;
    // _duration = duration

    public Activity()
    {

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
        if (_name == "")
        {
            Console.WriteLine("Bye!");

        }

        else
        {
            Console.Write($"\nThank you for using {_name} ");
            ShowSpinner(5);
            Console.Clear();
        }

    }
    public void ShowSpinner(int seconds)
    {
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("—");
        spinner.Add("\\");
        while (DateTime.Now < endTime)
        {
            foreach (string frame in spinner)
            {
                Console.Write(frame);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
            
        }

    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            if (i >= 100)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b\b\b   \b\b\b");

            }
            if (i >= 10)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b\b  \b\b");

            }
            else
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");   
            }

        }
        // Console.Write("\b ");
        
    }
}