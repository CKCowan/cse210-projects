using System;
/*
1. Start by asking the user for the magic number. (In future steps, we will change this to have the computer generate a random number, but to get started, we'll just let the user decide what it is.)
Ask the user for a guess.
Using an if statement, determine if the user needs to guess higher or lower next time, or tell them if they guessed it.

2. Add a loop that keeps looping as long as the guess does not match the magic number.
At this point, the user should be able to keep playing until they get the correct answer.

3. Instead of having the user supply the magic number, generate a random number from 1 to 100.
Play the game and make sure it works!
*/
class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1,11);

        int guess;

        // Console.Write("What is the magic number? ");
        // magic = int.Parse(Console.ReadLine());

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magic < guess)
                {
                    Console.WriteLine("Lower");
                }
            else if (magic > guess)
                {
                    Console.WriteLine("Higher");
                }
        } 
        while (magic != guess);
        
        Console.Write("You guessed it!");
    }
}