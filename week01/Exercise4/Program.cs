using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> numbers = new List<string>();
        string input;

        // int largeNumber = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do {
            Console.Write("Enter Number: ");
            input = Console.ReadLine();

            // Validate if input is numeric
            if (int.TryParse(input, out int number))
            {
                if (number != 0)
                {
                    numbers.Add(input);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        } while (input !=  "0");

        int sum = 0;
        foreach (string number in numbers)
        {
            sum += int.Parse(number);
        }
        Console.WriteLine($"The sum is: {sum}");

        // Get the average
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Get the largest number
        int largestNumber = 0;
        foreach (string number in numbers)
        {
            if (int.Parse(number) > largestNumber)
            {
                largestNumber = int.Parse(number);
            }
        }
        Console.WriteLine($"The largest number is: {largestNumber}");

        // get the smallest positive number
        int smallestPositiveNumber = int.MaxValue;
        foreach (string number in numbers)
        {
            if (int.Parse(number) > 0 && int.Parse(number) < smallestPositiveNumber)
            {
                smallestPositiveNumber = int.Parse(number);
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");

        // Write the sorted list
        Console.WriteLine("The sorted list is:");
        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(numbers[i]);
        }
    }
    
}