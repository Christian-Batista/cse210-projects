using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade!");
        string input = Console.ReadLine();
        double grade = double.Parse(input);

        string letter = "";

        // Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >=80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else {
            letter = "F";
        }

        // Determine the sign
        string sign = "";
        double lastDigit = grade % 10;

        if (letter != "F")
        {
            if (lastDigit >= 0.7)
            {
                sign = "+";
            }
            else if (lastDigit < 0.3)
            {
                sign = "-";
            }
        }


        Console.WriteLine($"Your grade is {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed!");
        }

    }
}