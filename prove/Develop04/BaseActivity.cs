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
        
    }


}