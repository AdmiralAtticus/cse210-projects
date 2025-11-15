using System;

class Program
{
    static void Main(string[] args)
    {
       Reference reference = new Reference("Proverbs", 3, 27, 28);
       Scripture scripture = new Scripture(reference, "Withhold not good from them to whom it is due, When it is in the power of thine hand to do it. Say not unto thy neighbour, Go, and come again, And to morrow I will give; when thou hast it by thee.");

       while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to continue or type 'quit' to end.");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;

            if (scripture.IsCompletelyHidden())
            break;

            scripture.HideRandomWords(3);
        }
    }
}