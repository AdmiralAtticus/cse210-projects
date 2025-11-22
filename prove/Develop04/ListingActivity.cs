public class ListingActivity : BaseActivity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "What spiritual moments have you felt recently?",
        "Who are your heroes?"
    };

    private Random _rand = new Random();

    public ListingActivity() : base("Listing Activity", "This activity helps you focus on the good in your life.")
    {}


    protected override void RunActivity()
    {
        Console.WriteLine("\nPrompt:");
        Console.WriteLine(_prompts[_rand.Next(_prompts.Count)]);

        Console.WriteLine("\nBeginning in...");
        Countdown(5);

        int count = 0;
        int endTime = Environment.TickCount + (_duration * 1000);

        while (Environment.TickCount < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"/nYou listed {count} items.");
    }
}