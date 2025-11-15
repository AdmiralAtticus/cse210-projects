using System;


class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favNumber = PromptUserNumber();

        PromptUserBirthYear(out int birthYear);

        int squaredNumber = SquareNumber(favNumber);
        
        DisplayResult(userName, squaredNumber, birthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
        Console.WriteLine();
    }

    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your fav number: ");
        return int.Parse(Console.ReadLine());
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }
    
    static void DisplayResult(string name, int squaredNumber, int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;


        Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
        Console.WriteLine($"You will turn {age} in {currentYear}.");
    }
}