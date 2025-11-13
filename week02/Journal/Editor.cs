using System;
using System.IO;

public class Editor
{
    private static string filename = "notes.txt";
    public static void WriteEntry()
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            Console.WriteLine("Please write your journal entry:");
            string entry = Console.ReadLine();
            outputFile.WriteLine($"{dateText} {entry}");

            
        }




        // File.AppendAllText(filename + Environment.NewLine);

    }

    public static void DisplayEntry()
    {
        if (File.Exists(filename))
        {
            Console.WriteLine("\n--- Your Journal Entries ---");
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("----------------------------\n");
        }
        else
        {
            Console.WriteLine("\nYour journal is empty. Select '1. Write' to add an entry.\n");
        }
    }



    // string[] lines = System.IO.File.ReadAllLines(filename);

}
















// static void reader()

// {
// }
// static void edit()
// {
// }
// static void date()
// {
    // DateTime theCurrentTime = DateTime.Now;
    // string dateText = theCurrentTime.ToShortDateString();
// }