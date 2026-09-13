using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter numbers (type '0' to finish):");
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine("The sum of the numbers is: " + sum);

        double average = (double)sum / numbers.Count;
        Console.WriteLine("The average of the numbers is: " + average);

        numbers.Sort();
        Console.WriteLine("The largest number is: " + numbers[numbers.Count - 1]);

        if (numbers.Any(n => n > 0))
        {
            Console.WriteLine("The smallest positive number is: " + numbers.First(n => n > 0));
        }

        numbers.Sort();
        Console.WriteLine("The sorted list of numbers is:");
        foreach (int num in numbers)
        {
            Console.WriteLine($"{num}");
        }
    }

}