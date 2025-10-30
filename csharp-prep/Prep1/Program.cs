using System;

class Program
{
    static void Main(string[] args)
    {
        //This is my C# Prep 1 Code
        Console.WriteLine("Hello Sandbox World!");
        string firstName;
        string lastName;

        Console.Write("Please enter your first name: ");
        firstName = Console.ReadLine();

        Console.WriteLine("Please enter your last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your full name is {firstName} {lastName}");    
    }
}