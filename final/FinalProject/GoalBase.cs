using System.Dynamic;

public abstract class GoalBase
{
    public string Name {get; protected set;}
    public string Description {get; protected set;}
    public int Points {get; protected set;}
    public bool IsCompleted {get; protected set;}


    public GoalBase(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public abstract int Complete();
}