using System;
using System.Diagnostics.Contracts;

class Program
{
    static void testValues(int x, float y, double z)
    {
        Console.WriteLine($"Values are {x}, {y}, {z}");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        // string firstName;
        // string lastName;

        // Console.Write("Please enter your first name: ");
        // firstName = Console.ReadLine();

        // Console.WriteLine("Please enter your last name: ");
        // lastName = Console.ReadLine();

        // Console.WriteLine($"Your full name is {firstName} {lastName}");    

        // int x = 10;

        // if (!(x == 11 || x == 12 && x == 13 || x != 23))
        //     Console.WriteLine("X is 10");

        // else if (x == 435)
        // {
        //     Console.WriteLine("Hey Joe");
        // }
        // else
        {
        }
        // Console.WriteLine(Math.Pow(2, 64));
        // int x = 10;
        // Console.WriteLine($"{x}, {++x}, {x++}, {x}");


        // for (int i = 13.34; i <= 100.323; i += .777)
        // {
        //     Console.WriteLine($"The value of i is: {i:F2}.");
        // }


        // // While/Do..While Loops

        // bool done = false;

        // while (!done)
        // {
        //     Console.Write("Input age: ");
        //     int age = int.Parse(Console.ReadLine());
        //     if (age >= 0 && age <= 125)
        //     {
        //         done = true;
        //         Console.WriteLine($"Super age: {age}.");
        //     }
        // }


        // do
        // {
        //     Console.Write("Input age: ");
        //     int age = int.Parse(Console.ReadLine());
        //     if (age >= 0 && age <= 125)
        //     {
        //         done = true;
        //         Console.WriteLine($"Super age: {age}.");
        //     }
        // } while (!done);


        // Lists

        List<int> numbers = new List<int>();
        numbers.Add(10);
        numbers.Add(33);
        numbers.Add(-33);

        foreach(int n in numbers)
        {
            Console.WriteLine($"Numbers are : {n}");
        }


    }
}