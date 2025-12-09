public class ChecklistGoal : Goal
{
    private int _ammountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, string points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return true;
    }
    public string GetDetailsString()
    {
        return "";
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}