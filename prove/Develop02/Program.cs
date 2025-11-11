using System;

class Program
{
    static void Main(string[] args)
    {
        Menu journalMenu = new Menu();
        Journal journal = new Journal();
        JournalEntry promptGen = new JournalEntry();

        bool done = false;

        do
        {
           int userSelection = journalMenu.ProcessMenu();



            switch (userSelection)
            {
                case 1:
                    string randomPrompt = promptGen.GetRandomPrompt();
                    JournalEntry newEntry = new JournalEntry();
                    newEntry.CreateJournalEntry(randomPrompt);
                    journal.AddEntry(newEntry);
                    Console.WriteLine("\nEntry added\n");
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    // Save to a file
                    Console.Write("\nEnter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.WriteToFile(saveFile);
                    break;
                case 4:
                    // Read from a file
                    Console.Write("\nEnter filename to read from: ");
                    string loadFile = Console.ReadLine();
                    journal.ReadFromFile(loadFile);
                    break;
                case 5:
                    done = true;
                    break;

                default:
                    Console.WriteLine("\nInvalid option. Select one (1-5)");
                    break;
            }
        } while (!done);
    }
}