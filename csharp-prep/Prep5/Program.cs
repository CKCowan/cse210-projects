using System;

/*
For this assignment, write a C# program that has several simple functions:

DisplayWelcome - Displays the message, "Welcome to the Program!"
PromptUserName - Asks for and returns the user's name (as a string)
PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
DisplayResult - Accepts the user's name and the squared number and displays them.
Your Main function should then call each of these functions saving the return values and passing data to them as necessary.
*/
class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int numberSquared = SquareNumber(userNumber);
        string message = DisplayResult(userName, numberSquared);
        Console.Write(message);

        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName(){
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber(){
            Console.Write("What is your favorite number? ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number){
            int sqNumber = number * number;
            return sqNumber;
        }

        static string DisplayResult(string name, int sqNumber){
            string string_sqNumber = sqNumber.ToString();
            string message = $"{name}, the square of your number is {string_sqNumber}";
            return message;
        }
    }
}