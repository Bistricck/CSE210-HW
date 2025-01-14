using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for the magic number
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        // ask for the guess
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        if (guess > magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guess < magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed the magic number!");
        }
    }    
}