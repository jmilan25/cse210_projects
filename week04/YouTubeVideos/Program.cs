using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        // Video v1 = new Video("test title", "jun", 3);
        // Console.WriteLine(v1.Display());

        // Console.WriteLine();
        // Video1();
        // Console.WriteLine();

        Video("How to Code Faster in C# (Beginner Tips)", "Bro Code", 12,
        "PixelNova", "This video deserves way more views!",
        "SunnyByte", "I didn't expect that ending",
        "TechTornado", "Very clear explanation, thanks!");
        Console.WriteLine();

        Video("The Most Relaxing Study Music Playlist", "Ikigai", 45,
        "MidnightMango", "Impressive editing",
        "ChocoRaptor", "Replay button is broken because of me",
        "WaveRunner42", "Please make a part 2!");
        Console.WriteLine();

        Video("I Tried Learning Animation in 7 Days", "gigi", 34,
        "LunaSketch", "Came here from the recommended",
        "StormyKite", "I learned more here than in school",
        "RavenCircuit", "Please make a part 2!");
        Console.WriteLine();

    }

    // static void Video1()
    // {
    //     Video v1 = new Video();
    //     v1._title = "Test Video";
    //     v1._author = "Jun";
    //     v1._length = 3;

    //     Comment comment1 = new Comment();
    //     comment1._name = "arvi";
    //     comment1._comment = "hi";
    //     Comment comment2 = new Comment();
    //     comment2._name = "milan";
    //     comment2._comment = "test";

    //     v1._comment.Add(comment1);
    //     v1._comment.Add(comment2);

    //     v1.Display();
    // }
    static void Video(string title, string name, int length, string commentNameA,string commentA, string commentNameB, string commentB, string commentNameC, string commentC)
    {
        string border = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
        Video v1 = new Video();
        v1._title = title;
        v1._author = name;
        v1._length = length;

        Comment comment1 = new Comment();
        comment1._name = commentNameA;
        comment1._comment = commentA;
        Comment comment2 = new Comment();
        comment2._name = commentNameB;
        comment2._comment = commentB;
        Comment comment3 = new Comment();
        comment3._name = commentNameC;
        comment3._comment = commentC;

        v1._comment.Add(comment1);
        v1._comment.Add(comment2);
        v1._comment.Add(comment3);

        Console.WriteLine(border);
        v1.Display();
        Console.WriteLine(border);
    }
}