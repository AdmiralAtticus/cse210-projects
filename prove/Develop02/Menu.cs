class Menu
{
    public string[] _menuStrings =
    {
        "Welcome to the Count",
        "You can create, display, save, and read journal entries",
        "1 - Create Entry",
        "2 - Display Journal",
        "3 - Save to File",
        "4 - Read from File",
        "5 - Quit"
    };

    public void ProcessMenu()
    {
        foreach(string menuItem in _menuStrings)
        {
            Console.WriteLine(menuItem);
        }
    }
}