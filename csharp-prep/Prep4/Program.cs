using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
    
        int answer = -1;
        int finished = 0;

        while (answer != finished)
        {
        Console.Write("Enter number: ");
        answer = int.Parse(Console.ReadLine());

        numbers.Add(answer);
        
        }

    int sum = numbers.Sum();
    Console.WriteLine($"The sum is: {sum}");

    int size = numbers.Count;
    float average = ((float)sum)/(size-1);
    Console.WriteLine($"The average is: {average}");

    int largest = 0;
    int smallest = 1;
    foreach (int number in numbers)
    {
        if (number > largest)
        {
            largest = number;
        }
    }
    foreach (int number in numbers)
    {
        if (number >= 1 && number < smallest)
        {
            smallest = number;
        }
    }
    Console.WriteLine($"The smallest positive number is: {smallest}");
    Console.WriteLine($"The largest number is: {largest}");

    }
}