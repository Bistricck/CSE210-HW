using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a list to store the numbers entered by the user.
        List<int> numbers = new List<int>();

        int number;
        int sum = 0;

        
        do
        {
            //Prompt the user to enter a number.
            Console.Write("Enter any number. When you are finished enter 0 to stop the program: ");
            string input = Console.ReadLine();

            // Parse the input safely
            if (int.TryParse(input, out number))
            {
                //Add the number to the list and update the sum if its not 0.
                if (number != 0)
                {
                numbers.Add(number);
                sum += number;
                }
            }

            else
            {
                //inform the user that the input must be valid
                Console.WriteLine("Invalid input, please enter a valid number. ");
            }

        } while (number != 0);

        if (numbers.Count == 0)
            {
                //inform the user that no numbers were entered
                Console.WriteLine("No numbers were entered.");
            }
            else 
            {
                //Display the numbers entered by the user.
            Console.WriteLine("The numbers you have entered are: ");
            foreach (int num in numbers)
            {
            Console.WriteLine(num);
            }
            //Display the sum of the numbers entered by the user.
            Console.WriteLine($"The sum of the numbers you entered is {sum}. ");
            

            //calculate and display the average of the numbers.
            double average = (double)sum / numbers.Count;
            
            {
                Console.WriteLine($"The average is {average}");
            }

            //Find the largest number.
            int max = numbers [0];

            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            
            }
            {
                //Display to 
                Console.WriteLine($"The largest number is {max}.");
            }


            }

    }
}