using System.IO.IsolatedStorage;

public class WeightGoal : GoalBase
{
    public double TargetWeight {get; private set;}
    public double CurrentWeight {get; private set;}


    public WeightGoal(string name, string description, int points, double targetWeight) : base(name, description, points)
    {
        TargetWeight = targetWeight;
        CurrentWeight = double.MaxValue;
    }

    public void LogWeight(double weight)
    {
        CurrentWeight = weight;
    }

    public override int Complete()
    {
        if(CurrentWeight <= TargetWeight)
        {
            IsCompleted = true;
            return Points;
        }

        return 0;
    }
}