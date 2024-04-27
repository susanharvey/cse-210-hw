using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Create new list called numbers.
        List<int> numbers = new List<int>();
       
        // Display User Instructions
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;
        
        /*do while loop and if statement to get user numbers for list,
        add them to the numbers list numbers until user enters 0*/
        do
        {
            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        // Foreach loop to add together all the digits in the numbers list.
        int sum = 0;
        foreach(int digit in numbers)
        {
            sum += digit;
        }

        // Display the sum
        Console.WriteLine($"The sum is {sum}");
        
        //Find the average of the numbers in the list.
        float average;
        average =  (float)sum / numbers.Count;

        //Display the numbers list average.
        Console.WriteLine($"The average is: {average}");

       //Sort the numbers list from low to high.
        numbers.Sort();

        //Find the largest number in the list.
        int maxNum = numbers.Last();

        //Display the largest number.
        Console.WriteLine($"The largest number is: {maxNum}");
        
        // Foreach loop to display the sorted list.
        Console.WriteLine("The sorted list is:");
        foreach (int digit in numbers)
        {
            Console.WriteLine(digit);
        }

    }
} 