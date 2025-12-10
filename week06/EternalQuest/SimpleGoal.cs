public class SimpleGoal : Goal
{
    private bool _isCOmplete;
    // private string _name;
    // private string _description;
    // private string _points;
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;

    }
    public override void RecordEvent()
    {


    }
    public override bool IsComplete()
    {
        return false;
        // return true;
    }
    public override string GetStringRepresentation()
    {
        return $"SG//{_shortName}//{_description}//{_points}//{_isCOmplete}";
    }

}