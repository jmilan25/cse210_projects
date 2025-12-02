using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Menu();
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
        // Console.WriteLine(text);
        // return text;
        
    }
    
    public static void Answer(string name)
    {

        string _description;
        // string name;

        if (name == "1")
        {
            _description = "This activity will help you relax by" +
            "\nwalking you through breathing in and out slowly." +
            "\nClear your mind and focus on your breathing";
            // _description = text;
            name = "Breathing Activity";
        }

        else if (name == "2")
        {
            _description = "This activity will help you reflect " +
            "\non times in your life when you have shown " +
            "\nstrength and resilience. This will help you " +
            "\nrecognize the power you have and how you can " +
            "\nuse it in other aspects of your life.";
            // _description = text;
            name = "Reflecting Activity";
        }

        else if (name == "3")
        {
            _description = "This activity will help you reflect on the " +
            "\ngood things in your life by having you list " +
            "\nas many things as you can in a certain area.";
            // _description = text;
            name = "Listing Activity";
        }
        else
        {
            Console.WriteLine("Please select an activity");
            Menu();
            return;
            
        }
        


        Activity activity = new Activity(name, _description, 3);
        activity.DisplayStartingMessage();
    }
}