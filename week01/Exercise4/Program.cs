using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number;
        int sum =0;


        do
        {
            Console.Write("Enter any number, 0 to stop: ");
            string input = Console.ReadLine();

            // Parse the input safely
            if (int.TryParse(input, out number))
            {
                if (number != 0)
                {
                numbers.Add(number);
                }
            }

            else
            {
                Console.WriteLine("Invalid input, please enter a valid number. ");
            }

        } while (number != 0);

        if (number.Count == 0)
            {
                Console.WriteLine("No numbers were entered.");
            }

            else 
            {
                Console.WriteLine("The sum of the numbers you entered is: ");
                foreach (int num in numbers)
            {
            Console.WriteLine(num);
            }

            }

    }
}