public class ReflectionActivity : BaseActivity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different?",
        "What did you learn from this experience?",
        "How can you apply this lesson in the future?"
    };

    private Random _rand = new Random();

    public ReflectionActivity() : base("Reflection Activity", "This activity helps you reflect on your own strength and resilience.")
    {}

    
    protected override void RunActivity()
    {
        Console.WriteLine("\nPrompt: ");
        Console.WriteLine(_prompts[_rand.Next(_prompts.Count)]);

        int elapsed = 0;

        while (elapsed < _duration)
        {
            string q = _questions[_rand.Next(_questions.Count)];
            Console.WriteLine($"\n {q}");
            PauseWithSpinner(5);
            elapsed += 5;
        }
    }
}