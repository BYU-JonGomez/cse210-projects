using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int number = int.Parse(gradePercentage);
        string minus = "-";
        string plus = "+";

        if (number >= 90 && number <= 100)
        {
            string letter = "A";
            if (number >= 90 && number < 93)
            {
                Console.WriteLine($"Your grade is {letter}{minus}.");
            }
            // else if (number >= 97 && number < 100)
            // {
            //     Console.WriteLine($"Your grade is {letter}{plus}.");
            // }
            else
            {
                Console.WriteLine($"Your grade is {letter}.");
            }
        }
        else if (number >= 80 && number < 90)
        {
            string letter = "B";
            if (number >= 80 && number < 83)
            {
                Console.WriteLine($"Your grade is {letter}{minus}.");
            }
            else if (number >= 87 && number < 90)
            {
                Console.WriteLine($"Your grade is {letter}{plus}.");
            }
            else
            {
                Console.WriteLine($"Your grade is {letter}.");
            }
        }
        else if (number >= 70 && number < 80)
        {
            string letter = "C";
            if (number >= 70 && number < 73)
            {
                Console.WriteLine($"Your grade is {letter}{minus}.");
            }
            else if (number >= 77 && number < 80)
            {
                Console.WriteLine($"Your grade is {letter}{plus}.");
            }
            else
            {
                Console.WriteLine($"Your grade is {letter}.");
            }
        }
        else if (number >= 60 && number < 70)
        {
            string letter = "D";
            if (number >= 60 && number < 63)
            {
                Console.WriteLine($"Your grade is {letter}{minus}.");
            }
            else if (number >= 67 && number < 70)
            {
                Console.WriteLine($"Your grade is {letter}{plus}.");
            }
            else
            {
                Console.WriteLine($"Your grade is {letter}.");
            }
        }
        else
        {
            string letter = "F";
            Console.WriteLine($"Your grade is {letter}.");
        }

        if (number >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class.");
        }
    }
}