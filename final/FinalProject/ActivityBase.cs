public abstract class ActivityBase
{
    public string Name {get; protected set;}
    public string Minutes {get; protected set;}


    public ActivityBase(string name, int minutes)
    {
        Name = name;
        Minutes = minutes;
    }


    public abstract int CalculateCalories();
}