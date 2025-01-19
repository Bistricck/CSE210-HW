using System;

class Program
{
    static void Main(string[] args)
    {
        //Display a welcome message to the user
        DisplayWelcomeMessage();

        //prompt user for their name. Use a string
        string userName = PromptUserName();
        //Prompt user for their favorite number. Use Int 
        int userNumber = PromptUserNumber();

        //Calculate the square of the users favorite number
        int squareNumber = SquaredNumber(userNumber);
        //Display the result combining the username and their favorite number
        DisplayResult(userName, squareNumber);
    }

    //Method to display a welcome message.
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    //Method to prompt username.
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    //Method to prompt user number.
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    //Method to square the user's favorite number.
    static int SquaredNumber(int number)
    {
        int square = number * number; //Calculate the square
        return square; //return the square number
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
