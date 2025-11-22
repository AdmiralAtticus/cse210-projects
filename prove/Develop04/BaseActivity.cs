public abstract class BaseActivity
{
    private string _name;
    private string _description;
    protected int _duration;


    protected BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"'{_name}'\n");
        Console.WriteLine(_description);
        Console.Write("\nDuration (sec): ");

        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nStarting soon...");
        PauseWithSpinner(3);

        RunActivity();
        End();
    }


    protected abstract void RunActivity();

    private void End()
    {
        Console.WriteLine("\nWrapping up your session...");
        PauseWithSpinner(3);
        Console.WriteLine($"You completed the {_name} activity for {_duration} seconds.");
        PauseWithSpinner(3);
    }

    protected void PauseWithSpinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };

        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(frames[i % 4]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}