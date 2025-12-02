using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Activity spinner = new Activity();
        // spinner.ShowSpinner(20);
        // spinner.ShowCountDown(10);
        Menu();
        // ReflectingActivity reflecting = new ReflectingActivity();
        // reflecting.DisplayStartingMessage();


    }

    public static void Menu()
    {
        Console.WriteLine("\nHi! What activity would you like to do? " +
                        "\n(1) Breathing Activity" +
                        "\n(2) Reflecting Activity" +
                        "\n(3) Listing Activity" +
                        "\n(4) Quit\n");
        string text = Console.ReadLine();
        Answer(text);
        // Console.WriteLine("How long would you like to do this activity? (seconds) ");
        // string _number = Console.ReadLine();
        // int _time = Int32.Parse(_number);

        // Timer(text, _time);


        
    }

    public static void Answer(string name)
    {
        // int _seconds;


        if (name == "1")
        {
            BreathingActivity breathing = new BreathingActivity();
            breathing.DisplayStartingMessage();

            Console.WriteLine("How long would you like to do this activity? (seconds) ");
            string _time = Console.ReadLine();
            int _duration = Int32.Parse(_time);

            // breathing.ShowCountDown(_seconds);

            breathing.Run(_duration);
            breathing.DisplayEndingMessage();
            Menu();

        }

        else if (name == "2")
        {
            ReflectingActivity reflecting = new ReflectingActivity();
            reflecting.DisplayStartingMessage();

            Console.WriteLine("How long would you like to do this activity? (seconds) ");
            string _time = Console.ReadLine();
            int _duration = Int32.Parse(_time);
            // reflecting.ShowCountDown(_seconds);

            reflecting.Run(_duration);
            reflecting.DisplayEndingMessage();
            Menu();

        }

        else if (name == "3")
        {
            ListingActivity listing = new ListingActivity();
            listing.DisplayStartingMessage();

            Console.WriteLine("How long would you like to do this activity? (seconds) ");
            string _time = Console.ReadLine();
            int _duration = Int32.Parse(_time);
            // listing.ShowCountDown(_seconds);

            listing.Run(_duration);
            listing.DisplayEndingMessage();
            Menu();

        }

        else if (name == "4")
        {
            Activity activity = new Activity();
            activity.DisplayEndingMessage();
        }
        else
        {
            Console.WriteLine("Please select an activity");
            Menu();
            return;

        }
    }
    
}