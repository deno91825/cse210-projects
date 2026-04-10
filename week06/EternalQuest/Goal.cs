public  class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public  void RecordEvent();
    public bool IsComplete();
    public  string GetDetailsString();
    public  string GetStringRepresentation();

    public int GetPoints()
    {
        return _points;
    }
}