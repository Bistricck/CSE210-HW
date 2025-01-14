using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grading percentage? ");
        string ValueFromUser = Console.ReadLine();

        int x = int.Parse(ValueFromUser);

        string letter = "";

        if (x >= 90)
        {
            letter = "A";
        }

        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "D";
        }
        else if (x <= 59)
        {
            letter = "F";
        }

        Console.WriteLine ($"Your letter grade is: {letter}");

        if (x >= 70)
        {
            Console.WriteLine("Congratulations, you have passed the class! ");
        }

        else
        {
            Console.WriteLine("I am sorry, you did not pass the class. Try again!");
        }
    }
}