using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number;
        int sum = 0;

        
        do
        {
            Console.Write("Enter any number. When you are finished enter 0 to stop the program: ");
            string input = Console.ReadLine();

            // Parse the input safely
            if (int.TryParse(input, out number))
            {
                if (number != 0)
                {
                numbers.Add(number);
                sum += number;
                }
            }

            else
            {
                Console.WriteLine("Invalid input, please enter a valid number. ");
            }

        } while (number != 0);

        if (numbers.Count == 0)
            {
                Console.WriteLine("No numbers were entered.");
            }
            else 
            {
            Console.WriteLine("The numbers you have entered are: ");
            foreach (int num in numbers)
            {
            Console.WriteLine(num);
            }
            
            Console.WriteLine($"The sum of the numbers you entered is {sum}. ");
            
            double average = (double)sum / numbers.Count;
            {
                Console.WriteLine($"The average is {average}");
            }

            int max = numbers [0];

            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            
            }
            {
                Console.WriteLine($"The largest number is {max}.");
            }


            }

    }
}