public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetSummary()
    {
        string text = $"{_studentName} - {_topic}";
        return text;
    }
}