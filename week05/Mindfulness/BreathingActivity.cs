public class BreathingActivity : Activity
{
    
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by" +
            "\nwalking you through breathing in and out slowly." +
            "\nClear your mind and focus on your breathing";
        

    }
    public void Run(int seconds)
    {
        Console.Clear();
        Console.Write("Get Ready ");
        Activity activity = new Activity();
        activity.ShowSpinner(3);
        // Console.ReadLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("\n\nInhale ");
            activity.ShowCountDown(3);
            Console.Write("\nExhale ");
            activity.ShowCountDown(3);
        }


    }
    
}