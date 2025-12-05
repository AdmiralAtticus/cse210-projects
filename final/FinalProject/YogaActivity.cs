public class YogaActivity : ActivityBase
{
    public YogaActivity(int minutes) : base("Yoga", minutes) {}

    public override int CalculateCalories()
    {
        return Minutes * 4;
    }
}