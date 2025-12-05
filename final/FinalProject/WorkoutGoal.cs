public class WorkoutGoal : GoalBase
{
    public int RequiredMinutes {get; private set;}
    public int MinutesLogged {get; private set;}


    public WorkoutGoal(string name, string desc, int points, int requiredMinutes) : base(name, desc, points)
    {
        RequiredMinutes = requiredMinutes;
    }

    public void LogWorkout(int minutes)
    {
        MinutesLogged += minutes;
    }

    public override int Complete()
    {
        if (MinutesLogged >= RequiredMinutes)
        {
            IsCompleted = true;
            return Points;
        }

        return 0;
    }
    
}