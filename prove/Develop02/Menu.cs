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

        /* Process Menu will display menu to the user, read and evaluate input, and return the input. No paramaters received in this method. */

    public int ProcessMenu()
    {
        int userSelection = 0;
        do
        {
            foreach (string menuItem in _menuStrings)
            {
                Console.WriteLine(menuItem);
            }
            userSelection = int.Parse(Console.ReadLine());
        } while (userSelection < 1 || userSelection > 5);
        return userSelection;
    }
}