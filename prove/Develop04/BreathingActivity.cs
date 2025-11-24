public class BreathingActivity : BaseActivity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through slow, intentional breathing.")
    { }

    protected override void RunActivity()
    {
        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.Write("\nBreathe in...");
            Countdown(4);
            elapsed += 4;

            if (elapsed >= _duration) break;

            Console.Write("\nBreathe out...");
            Countdown(4);
            elapsed += 4;
        }
    }
}