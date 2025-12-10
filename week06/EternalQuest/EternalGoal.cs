public class EternalGoal : Goal
{
    // private string _name;
    // private string _description;
    // private string _points;
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        _shortName = name;
    }
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetStringRepresentation()
    {
        return $"EG//{_shortName}//{_description}//{_points}";
    }
}