public class RunningActivity : ActivityBase
{
    public RunningActivity(int minutes) : base("Running", minutes) {}


    public override int CalculateCalories()
    {
        return Minutes * 10;
    }
}