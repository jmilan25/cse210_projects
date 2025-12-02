public class ListingActivity : Activity
{
    private int _count;
    List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description, int duration, int count)
        : base (name,description,duration)
    {
        _count = count;
    }

    public void run()
    {
        
    }
    public void GetRandomPrompt()
    {

    }
    
    // public List<string> GetListFromUser()
    // {
        
    //     return "";
    // }
}