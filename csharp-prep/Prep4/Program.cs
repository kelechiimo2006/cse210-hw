using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int _number;

        do
        {
            Console.Write("Enter a number: ");
            _number = int.Parse(Console.ReadLine());
            if (_number != 0)
            {
            numbers.Add(_number);
            }
        }  while(_number != 0);
        int _sumNumbers = numbers.Sum();
        double _averageNumbers = numbers.Average();
        int _maxNumber = numbers.Max();
        Console.WriteLine($"The sum is: {_sumNumbers}");
        Console.WriteLine($"The average is: {_averageNumbers}");
        Console.WriteLine($"The largest number is: {_maxNumber}");
    }
}