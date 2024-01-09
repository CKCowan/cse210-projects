using System;

// What is your first name? Scott
// What is your last name? Burton

// Your name is Burton, Scott Burton.
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.Write($"Your name is {lastName}, {firstName} {lastName}.");
    }
}