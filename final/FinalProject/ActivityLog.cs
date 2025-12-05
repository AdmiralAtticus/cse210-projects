public class ActivityLog
{
    private List<ActivityBase> _activities = new List<ActivityBase>();


    public void AddActivity(ActivityBase activity)
    {
        _activities.Add(activity);
    }


    public int GetTotalCalories()
    {
        int total = 0;
        foreach (var a in _activities)
                total += a.CalculateCalories();

                return total;
    }
}