using System;
/*
Write a program that determines the letter grade for a course according to the following scale:
A >= 90
B >= 80
C >= 70
D >= 60
F < 60

1. Ask the user for their grade percentage, then write a series of if-elif-else statements to print out the appropriate letter grade. (At this point, you'll have a separate print statement for each grade letter in the appropriate block.)

2. Assume that you must have at least a 70 to pass the class. After determining the letter grade and printing it out. Add a separate if statement to determine if the user passed the course, and if so display a message to congratulate them. If not, display a different message to encourage them for next time.

3. Change your code from the first part, so that instead of printing the letter grade in the body of each if, elif, or else block, instead create a new variable called letter and then in each block, set this variable to the appropriate value. Finally, after the whole series of if-elif-else statements, have a single print statement that prints the letter grade once.
*/
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        string letter = "";
        if (grade >= 90)
            {
                // Console.WriteLine("Your grade is an A!");
                letter = "A";
            }
        else if (grade >= 80)
            {
                // Console.WriteLine("Your grade is a B!");
                letter = "B";
            }
        else if (grade >= 70)
            {
                // Console.WriteLine("Your grade is a C.");
                letter = "C";
            }
        else if (grade >= 60)
            {
                // Console.WriteLine("Your grade is a D.");
                letter = "D";
            }
        else if (grade < 60)
            {
                // Console.WriteLine("Your grade is a F.");
                letter = "F";
            }
        
        Console.WriteLine($"Your grade is a {letter}.");


        if (grade >= 70)
            {
                Console.Write("Congratulations, you passed!");
            }
        else
            {
                Console.Write("I'm sorry, but you failed. Better luck next time!");
            }
    }
}