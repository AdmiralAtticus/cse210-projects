using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        string firstName;
        string lastName;

        Console.Write("Please enter your first name: ");
        firstName = Console.ReadLine();

        Console.WriteLine("Please enter your last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your full name is {firstName} {lastName}");    

        int x = 10;

        if (!(x == 11 || x == 12 && x == 13 ||!= 23))
            Console.WriteLine("X is 10");

        else if (x == 435)
        {
            Console.WriteLine('Hey Joe');
        }
        else
        {
            
        }
            Console.WriteLine("X is whatever");
    }
}