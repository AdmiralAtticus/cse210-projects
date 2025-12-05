public class UserProfile
{
    public string Name {get; private set;}
    public double Weight {get; private set;}
    public List<GoalBase> Goals {get; private set;}


    public UserProfile(string name, double weight)
    {
        Name = name;
        Weight = weight;
        Goals = new List<GoalBase>();
    }
    

    public void AddGoal(GoalBase goal)
    {
        Goals.Add(goal);
    }
}