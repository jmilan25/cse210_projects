public class ChecklistGoal : Goal
{
    private int _ammountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        // _ammountCompleted = false;
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
        if (_ammountCompleted == _target)
        {
            return $"[X] {_shortName} ({_description}) —— Currently completed: {_ammountCompleted}/{_target}";
        }
        return $"[ ] {_shortName} ({_description}) —— Currently completed: {_ammountCompleted}/{_target}";
        
    }
    public override string GetStringRepresentation()
    {
        return $"CG//{_shortName}//{_description}//{_points}//{_ammountCompleted}//{_target}//{_bonus}";
    }
}