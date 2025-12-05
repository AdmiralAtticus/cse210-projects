public class StepsGoal : GoalBase
{
    public int DailyTarget {get; private set;}
    public int StepsToday {get; private set;}


    public StepsGoal(string name, string description, int points, int dailyTarget) : base(name, description, points)
    {
        DailyTarget = dailyTarget;
    }

    public void LogSteps(int steps)
    {
        StepsToday += steps;
    }

    public override int Complete()
    {
        if (StepsToday >= DailyTarget)
        {
            IsCompleted = true;
            return Points;
        }

        return 0;
    }
}