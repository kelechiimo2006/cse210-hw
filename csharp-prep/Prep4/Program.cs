using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number;

        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
            numbers.Add(number);
            }
        }  while(number != 0);
        int sumNumbers = numbers.Sum();
        double averageNumbers = numbers.Average();
        int maxNumber = numbers.Max();
        Console.WriteLine($"The sum is: {sumNumbers}");
        Console.WriteLine($"The average is: {averageNumbers}");
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}