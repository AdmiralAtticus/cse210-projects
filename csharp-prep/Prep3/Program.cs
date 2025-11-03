using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Console.Write($"Enter magic number: ");
        int magicNumber = int.Parse(Console.ReadLine());

        Console.Write($"Enter guess: ");
        int guess = int.Parse(Console.ReadLine());

        if (guess < magicNumber)
        {
            Console.WriteLine("Too low, guess again.");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Too high, guess again.");
        }

        else
        {
            Console.WriteLine("You nailed it, nice!");
        }
    
    }



        
}