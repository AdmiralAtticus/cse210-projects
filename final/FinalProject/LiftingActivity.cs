public class LiftingActivity : ActivityBase
{
    public LiftingActivity(int minutes) : base("Weight Lifting", minutes) {}


    public override int CalculateCalories()
    {
        return Minutes * 6;
    }
}