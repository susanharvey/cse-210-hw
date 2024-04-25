using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
       
        // Display User Instructions
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter Number: ");
            string response = Console.ReadLine();
            number = int.Parse(response);

            if (number != 0)
            {
                numbers.Add(number);
            }

        }
        int sum = 0;
        foreach(int digit in numbers)
        {
            sum += digit;
        }
        Console.WriteLine($"The sum is {sum}");
        
        float average;
        average =  (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        int maxNum = numbers[0];
        foreach (int i in numbers)
        {
            if (i > maxNum)
            {
                maxNum = i;
            }
        }
        
        Console.WriteLine($"The max is: {maxNum}");

        
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int digit in numbers)
        {
            Console.WriteLine(digit);
        }

    }
} 