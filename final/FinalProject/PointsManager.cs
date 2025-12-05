using System.Runtime.InteropServices;

public class PointsManager
{
    public int TotalPoints {get; private set;}

    public void ProcessGoals(List<GoalBase> goals)
    {
        foreach (var goal in goals)
                TotalPoints += goal.Complete();
    }
}